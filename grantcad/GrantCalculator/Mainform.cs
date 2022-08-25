using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrantCalculator
{
    public partial class Mainform : Form
    {
        public enum Drawtools
        {
            _select, _rectangle, _circle, _polygon

        }
        Drawtools toolis;
        readonly string RECTSHAPE = "REC";
        readonly string POLSHAPE = "POL";
        readonly string CIRSHAPE = "CIR";
        bool _mouseDown = false;
        PointF sPt, ePt;
        Pen curPen;

        // Store the selected shape.
        private Shape selectedShape;
        // Keep track of when drag or resize mode is enabled.
        private bool isDragging = false;
        private bool isResizing = false;
        private bool isMovingpoint = false;
        private Shape.HitSpot resizingMode;

        // Store the location where the user clicked on the control.
        private float clickOffsetX, clickOffsetY;
        Color myColor, ourColor;
        Shape drawShape = null;
        public float lineThick = .01F;
        RectangleF myRect, myCirc;
        List<PointF> myPolygons;
        private bool reqStraightLine;
        RectanglePlotter plotRect;
        private ShapesCollection shapes = new ShapesCollection();
        float abovedepth = 1;
        public Mainform()
        {
            InitializeComponent();

            MakeBackgroundGrid();
            CreateTransforms();

            if (!File.Exists(DataAccess.fPath))
            {
                DataAccess.CreateEstimationXML();
            }
            DataAccess.ParseEstimationXML();

        }
        private void Mainform_Load(object sender, EventArgs e)
        {
            myColor = Color.Black;
            ourColor = Color.Empty;
            toolStripComboBoxlinethickness.SelectedIndex = 0;
        }
        #region xyPlaneVari
        // The transformations.
        private Matrix Transform = null, InverseTransform = null;
        /*The Transform and InverseTransform variables are the matrices used to transform the drawing and to find 
       * the inverse points for mouse coordinates.*/
        private const float DrawingScale = 30F;
        // The world coordinate bounds.
        private float Wxmin, Wxmax, Wymin, Wymax;
        /* Wxmin, Wxmax, Wymin, and Wymax store the world coordinates used to draw the ellipses.*/
        private const int GridGap = 30;
        #endregion
        #region xyPlaneFunc
        private void MakeBackgroundGrid()
        {
            Bitmap bm = new Bitmap(picbox_drawhere.ClientSize.Width, picbox_drawhere.ClientSize.Height);
            for (int x = 0; x < picbox_drawhere.ClientSize.Width; x += GridGap)
            {
                for (int y = 0; y < picbox_drawhere.ClientSize.Height; y += GridGap)
                {
                    bm.SetPixel(x, y, Color.Gray);
                }
            }

            picbox_drawhere.BackgroundImage = bm;
        }
        private void CreateTransforms()
        {
            // Make the draw transformation. (World --> Device)
            Transform = new Matrix();
            Transform.Scale(DrawingScale, DrawingScale);
            float cx = picbox_drawhere.ClientSize.Width / 2;
            float cy = picbox_drawhere.ClientSize.Height / 2;
            Transform.Translate(cx, cy, MatrixOrder.Append);

            // Make the inverse transformation. (Device --> World)
            InverseTransform = Transform.Clone();
            InverseTransform.Invert();

            // Calculate the world coordinate bounds.
            Wxmin = -cx / DrawingScale;
            Wxmax = cx / DrawingScale;
            Wymin = -cy / DrawingScale;
            Wymax = cy / DrawingScale;
        }



        // Convert from device coordinates to world coordinates.
        private PointF DeviceToWorld(PointF point)
        {
            PointF[] points = { point };
            InverseTransform.TransformPoints(points);
            return points[0];
        }
        private void Form1_Resize(object sender, EventArgs e)
        {

        }
        #endregion
        #region PIC_MOUSE_EVE
        int hit_point;
        List<PointF> HitPolygon;
        private void picbox_drawhere_MouseUp(object sender, MouseEventArgs e)
        {
            ePt = DeviceToWorld(e.Location);
            _mouseDown = false;
            if (toolis == Drawtools._select)
            {
                picbox_drawhere.Cursor = Cursors.Arrow;
                isDragging = false;
                isResizing = false;
                isMovingpoint = false;

            }
            if (!myRect.IsEmpty && toolis == Drawtools._rectangle)
            {
                myRect = plotRect.ShapeRect(sPt, ePt);
                drawShape = new RectangleShape
                {
                    ShapeType = RECTSHAPE,
                    Location = myRect.Location,
                    Size = myRect.Size,
                    ForeColor = myColor,
                    BackColor = ourColor,
                    PenThickness = lineThick,
                    Name = "NoName",
                    Cement = DataAccess.estimator.Cement,
                    Gravel = DataAccess.estimator.Gravel,
                    Sand = DataAccess.estimator.Sand,
                    Lime = DataAccess.estimator.Lime,
                    Depth = abovedepth,
                    Area = Calculate.RectangleArea(myRect.Width, myRect.Height)
                };
                shapes.Add(drawShape);
                myRect = RectangleF.Empty;
                picbox_drawhere.Refresh();

            }
            if (!myCirc.IsEmpty && toolis == Drawtools._circle)
            {
                myCirc = plotRect.ShapeRect(sPt, ePt);
                drawShape = new CircleShape
                {
                    ShapeType = CIRSHAPE,
                    Location = myCirc.Location,
                    Size = myCirc.Size,
                    ForeColor = myColor,
                    BackColor = ourColor,
                    PenThickness = lineThick,
                    Name = "NoName",
                    Cement = DataAccess.estimator.Cement,
                    Gravel = DataAccess.estimator.Gravel,
                    Sand = DataAccess.estimator.Sand,
                    Lime = DataAccess.estimator.Lime,
                    Depth = abovedepth,
                    Area = Calculate.EllipseArea(myCirc.Width, myCirc.Height)
                };
                shapes.Add(drawShape);
                myCirc = RectangleF.Empty;
                picbox_drawhere.Refresh();


            }


        }
        private void picbox_drawhere_MouseMove(object sender, MouseEventArgs e)
        {
            ePt = DeviceToWorld(e.Location);

            if (toolis == Drawtools._select)
            {
                if (isDragging)
                {
                    picbox_drawhere.Cursor = Cursors.SizeAll;
                    if (selectedShape.ShapeType == RECTSHAPE || selectedShape.ShapeType == CIRSHAPE)
                        selectedShape.Location = new PointF(ePt.X - clickOffsetX, ePt.Y - clickOffsetY);

                    else if (selectedShape.ShapeType == POLSHAPE)
                    {
                        // See how far the first point will move.
                        float new_x1 = ePt.X + clickOffsetX;
                        float new_y1 = ePt.Y + clickOffsetY;

                        float dx = new_x1 - HitPolygon[0].X;
                        float dy = new_y1 - HitPolygon[0].Y;
                        if (dx == 0 && dy == 0) return;
                        for (int i = 0; i < HitPolygon.Count; i++)
                        {
                            HitPolygon[i] = new PointF(
                                HitPolygon[i].X + dx,
                                HitPolygon[i].Y + dy);
                        }

                        selectedShape.Locations = HitPolygon;

                    }

                    picbox_drawhere.Invalidate();

                }
                else if (isResizing)
                {
                    int minSize = 1;

                    // Keep track of the old size. Useful
                    // for invalidating when NOT double-buffering.
                    //RectangleF oldPosition = selectedShape.GetLargestPossibleRegion();

                    // Resize the control, according to the resize mode.
                    switch (resizingMode)
                    {
                        case Shape.HitSpot.Top:
                        case Shape.HitSpot.TopRightCorner:
                            if (ePt.Y < (selectedShape.Location.Y + selectedShape.Size.Height - minSize))
                            {
                                selectedShape.Size = new SizeF(selectedShape.Size.Width,
                                    selectedShape.Location.Y + selectedShape.Size.Height - (ePt.Y - clickOffsetY));
                                selectedShape.Location = new PointF(selectedShape.Location.X, ePt.Y - clickOffsetY);
                            }
                            break;
                        case Shape.HitSpot.Bottom:
                            if (ePt.Y > (selectedShape.Location.Y + minSize))
                            {
                                selectedShape.Size = new SizeF(selectedShape.Size.Width, ePt.Y - selectedShape.Location.Y);
                            }
                            break;
                        case Shape.HitSpot.Left:
                        case Shape.HitSpot.BottomLeftCorner:
                        case Shape.HitSpot.TopLeftCorner:
                            if (ePt.X < (selectedShape.Location.X + selectedShape.Size.Width - minSize))
                            {
                                selectedShape.Size = new SizeF((selectedShape.Location.X + selectedShape.Size.Width) - (ePt.X - clickOffsetX), selectedShape.Size.Height);
                                selectedShape.Location = new PointF(ePt.X - clickOffsetX, selectedShape.Location.Y);
                            }
                            break;
                        case Shape.HitSpot.Right:
                            if (ePt.X > (selectedShape.Location.X + minSize))
                            {
                                selectedShape.Size = new SizeF(ePt.X - selectedShape.Location.X, selectedShape.Size.Height);
                            }
                            break;
                        case Shape.HitSpot.BottomRightCorner:
                            if (ePt.Y > (selectedShape.Location.Y + minSize))
                            {
                                selectedShape.Size = new SizeF(selectedShape.Size.Width, ePt.Y - selectedShape.Location.Y);
                            }
                            if (ePt.X > (selectedShape.Location.X + minSize))
                            {
                                selectedShape.Size = new SizeF(ePt.X - selectedShape.Location.X, selectedShape.Size.Height);
                            }
                            break;
                    }
                    if (selectedShape.ShapeType == RECTSHAPE)
                        selectedShape.Area = Calculate.RectangleArea(selectedShape.Size.Width, selectedShape.Size.Height);
                    else if (selectedShape.ShapeType == CIRSHAPE)
                        selectedShape.Area = Calculate.EllipseArea(selectedShape.Size.Width, selectedShape.Size.Height);
                    picbox_drawhere.Refresh();
                }
                else if (isMovingpoint && _mouseDown)
                {
                    if (selectedShape != null)
                    {
                        HitPolygon[hit_point] = ePt;
                        selectedShape.Locations = HitPolygon;
                        selectedShape.Area = Math.Abs(Calculate.PolygonArea(HitPolygon.ToArray()));

                    }
                    picbox_drawhere.Refresh();

                }
                else
                {

                    if ((selectedShape != null) && (selectedShape.Selected))
                    {
                        if (selectedShape.ShapeType == RECTSHAPE || selectedShape.ShapeType == CIRSHAPE)
                        {
                            if (selectedShape.HitTestFocusBorder(ePt, out resizingMode))
                            {
                                switch (resizingMode)
                                {
                                    case Shape.HitSpot.Top:
                                    case Shape.HitSpot.Bottom:
                                    case Shape.HitSpot.TopRightCorner:
                                        picbox_drawhere.Cursor = Cursors.SizeNS;
                                        break;
                                    case Shape.HitSpot.Left:
                                    case Shape.HitSpot.Right:
                                    case Shape.HitSpot.BottomLeftCorner:
                                    case Shape.HitSpot.TopLeftCorner:
                                        picbox_drawhere.Cursor = Cursors.SizeWE;
                                        break;
                                    case Shape.HitSpot.BottomRightCorner:
                                        picbox_drawhere.Cursor = Cursors.SizeNWSE;
                                        break;
                                    default:
                                        picbox_drawhere.Cursor = Cursors.Arrow;
                                        break;
                                }
                            }
                            else
                            {
                                picbox_drawhere.Cursor = Cursors.Arrow;
                            }

                        }
                        else if (selectedShape.ShapeType == POLSHAPE)
                        {
                            if (selectedShape.MouseIsOverCornerPoint(ePt, selectedShape.Locations, out hit_point))
                            {
                                picbox_drawhere.Cursor = Cursors.Hand;
                                isMovingpoint = true;

                            }
                            else
                            {
                                picbox_drawhere.Cursor = Cursors.Arrow;
                                isMovingpoint = false;
                            }
                        }
                    }
                    else
                    {
                        picbox_drawhere.Cursor = Cursors.Arrow;
                    }

                }


            }
            if (_mouseDown)
            {

                if (toolis == Drawtools._rectangle)
                {
                    ClearSelectedShape();
                    myRect = plotRect.ShapeRect(sPt, ePt);
                    picbox_drawhere.Refresh();
                }

                if (toolis == Drawtools._circle)
                {
                    ClearSelectedShape();
                    myCirc = plotRect.ShapeRect(sPt, ePt);
                    picbox_drawhere.Refresh();
                }
            }
            if (toolis == Drawtools._polygon)
            {

                if (reqStraightLine)
                {
                    float deg = Math.Abs(Calculate.AngelBetweenTwopoints(ePt, sPt));

                    if (deg >= 0 && deg <= 45) //Hoz
                    {
                        ePt = new PointF(ePt.X, sPt.Y);
                    }
                    else if (deg >= 45 && deg <= 90) //Ver
                    {
                        ePt = new PointF(sPt.X, ePt.Y);
                    }
                    else if (deg >= 90 && deg <= 135)//Hoz
                    {
                        ePt = new PointF(sPt.X, ePt.Y);
                    }
                    else if (deg >= 135 && deg <= 180)//Ver
                    {
                        ePt = new PointF(ePt.X, sPt.Y);
                    }


                }

            }
            if (myPolygons != null && myPolygons.Count > 0)
            {
                picbox_drawhere.Refresh();
            }
            Set_Shape_Status();
        }
        private void picbox_drawhere_MouseDown(object sender, MouseEventArgs e)
        {
            sPt = DeviceToWorld(e.Location);
            _mouseDown = true;

            if (toolis == Drawtools._select)
            {
                Shape.HitSpot hitSpot;
                if ((selectedShape != null) && (selectedShape.Selected) &&
                 (selectedShape.HitTestFocusBorder(new PointF(sPt.X, sPt.Y), out hitSpot)))
                {
                    // The border was clicked. Turn on resize mode.
                    clickOffsetX = sPt.X - selectedShape.Location.X;
                    clickOffsetY = sPt.Y - selectedShape.Location.Y;
                    isResizing = true;
                }
                else
                {
                    // Retrieve a reference to the selected shape
                    // using hit testing.
                    ClearSelectedShape();
                    selectedShape = shapes.HitTest(sPt);
                    if (selectedShape != null)
                    {
                        selectedShape.Selected = true;
                        picbox_drawhere.Refresh();

                        if (e.Button == MouseButtons.Left)
                        {

                            // Start dragging mode.
                            if (selectedShape.ShapeType == POLSHAPE)
                            {
                                HitPolygon = selectedShape.Locations;
                                clickOffsetX = HitPolygon[0].X - sPt.X;
                                clickOffsetY = HitPolygon[0].Y - sPt.Y;
                            }
                            else
                            {
                                clickOffsetX = sPt.X - selectedShape.Location.X;
                                clickOffsetY = sPt.Y - selectedShape.Location.Y;
                            }
                            if (!isMovingpoint)
                            {
                                picbox_drawhere.Cursor = Cursors.SizeAll;
                                isDragging = true;
                            }

                        }
                    }

                }


            }
            if (toolis == Drawtools._rectangle)
            {
                ClearSelectedShape();
                curPen = new Pen(myColor, lineThick);
                plotRect = new RectanglePlotter();
            }
            if (toolis == Drawtools._polygon)
            {
                ClearSelectedShape();
                if (myPolygons == null)
                    myPolygons = new List<PointF>();
                curPen = new Pen(myColor, lineThick);
                if (reqStraightLine)
                    myPolygons.Add(ePt);
                else
                    myPolygons.Add(sPt);
                picbox_drawhere.Refresh();

            }
            if (toolis == Drawtools._circle)
            {
                ClearSelectedShape();
                curPen = new Pen(myColor, lineThick);
                plotRect = new RectanglePlotter();
            }
            if (e.Button == MouseButtons.Right)
            {
                if (toolis == Drawtools._select)
                {
                    if (selectedShape != null)
                    {
                        mnuselectshape.Show(this, new Point(e.X, e.Y));
                    }
                }
                if (toolis == Drawtools._polygon)
                {
                    if (myPolygons.Count > 2)
                    {
                        drawShape = new PolygonShape()
                        {

                            Locations = myPolygons,
                            ShapeType = POLSHAPE,
                            BackColor = ourColor,
                            ForeColor = myColor,
                            PenThickness = lineThick,
                            Name = "NoName",
                            Cement = DataAccess.estimator.Cement,
                            Gravel = DataAccess.estimator.Gravel,
                            Sand = DataAccess.estimator.Sand,
                            Lime = DataAccess.estimator.Lime,
                            Depth = abovedepth,
                            Area = Math.Abs(Calculate.PolygonArea(myPolygons.ToArray()))
                        };
                        shapes.Add(drawShape);
                        myPolygons = null;
                    }

                }

            }
            Set_Shape_Status();
        }
        #endregion
        #region ToolStrips
        void Color_ToolsButtonHighLight(ToolStripButton setbutton)
        {
            toolStripButtonselect.BackColor = Color.Empty;
            toolStripButtonCircle.BackColor = Color.Empty;
            toolStripButtonpolygon.BackColor = Color.Empty;
            toolStripButtonRect.BackColor = Color.Empty;
            setbutton.BackColor = Color.Aqua;
        }


        private void toolStripButtonRect_Click(object sender, EventArgs e)
        {
            toolis = Drawtools._rectangle;
            picbox_drawhere.Cursor = Cursors.Cross;
            Color_ToolsButtonHighLight(toolStripButtonRect);
        }

        private void toolStripButtonColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {

                myColor = dlgColor.Color;
                if (selectedShape != null)
                    selectedShape.ForeColor = myColor;
                picbox_drawhere.Refresh();
            }
        }

        private void toolStripButtondelete_Click(object sender, EventArgs e)
        {
            if (selectedShape == null) return;
            shapes.Remove(selectedShape);
            ClearSelectedShape();
        }

        private void toolStripButtontoback_Click(object sender, EventArgs e)
        {
            if (selectedShape == null) return;
            shapes.SendShapeToBack(selectedShape);
            picbox_drawhere.Refresh();
        }

        private void toolStripButtontofront_Click(object sender, EventArgs e)
        {
            if (selectedShape == null) return;
            shapes.BringShapeToFront(selectedShape);
            picbox_drawhere.Refresh();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Grant files (*.gcc)|*.gcc|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs =
                        File.Create(saveFileDialog.FileName))
                    {
                        BinaryFormatter f = new BinaryFormatter();
                        f.Serialize(fs, shapes);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error while saving. " + err.Message);
                }
            }
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Grant files (*.gcc)|*.gcc";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ShapesCollection newShapes = null;
                try
                {
                    using (FileStream fs =
                        File.Open(openFileDialog.FileName, FileMode.Open))
                    {
                        BinaryFormatter f = new BinaryFormatter();
                        newShapes = (ShapesCollection)f.Deserialize(fs, null);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error while loading. " + err.Message);
                }

                // Trigger a refresh.
                shapes = newShapes;
                picbox_drawhere.Refresh();
            }
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            if (shapes.Count > 0)
            {
                var confirm = MessageBox.Show("Are you sure to clear all?", "Caution!", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    shapes.Clear();
                    picbox_drawhere.Refresh();
                }

            }

        }

        private void fillColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedShape == null)
                return;
            ColorDialog dlgColor = new ColorDialog();
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                selectedShape.BackColor = dlgColor.Color;
                picbox_drawhere.Refresh();
            }
        }

        private void clearColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedShape == null)
                return;
            selectedShape.BackColor = Color.Empty;
            picbox_drawhere.Refresh();
        }

        private void bringToFrontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedShape == null) return;
            shapes.BringShapeToFront(selectedShape);
            picbox_drawhere.Refresh();
        }

        private void sendToBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedShape == null) return;
            shapes.SendShapeToBack(selectedShape);
            picbox_drawhere.Refresh();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedShape == null) return;
            shapes.Remove(selectedShape);
            ClearSelectedShape();
        }

        private void estimateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedShape != null)
            {

                Estimationform frm = new Estimationform(selectedShape);
                frm.ShowDialog();
            }

        }

        private void toolStripComboBoxlinethickness_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBoxlinethickness.SelectedIndex == 0)
            {
                lineThick = 0.01F;
            }
            else if (toolStripComboBoxlinethickness.SelectedIndex == 1)
            {
                lineThick = 0.1F;
            }
            else if (toolStripComboBoxlinethickness.SelectedIndex == 2)
            {
                lineThick = 1F;
            }
            SendKeys.Send("{ESC}");
            this.ActiveControl = null;


        }
        private void toolStripButtonprice_Click(object sender, EventArgs e)
        {
            PricesetForm psf = new PricesetForm();
            psf.ShowDialog();
        }

        private void setDeptAboveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepthForm df = new DepthForm(abovedepth);
            if (df.ShowDialog() == DialogResult.OK)
            {
                abovedepth = (float)df.numericUpDownZDepth.Value;
                if (selectedShape != null)
                    selectedShape.Depth = abovedepth;
            }
        }

        private void toolStripButtonfillcolor_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {

                ourColor = dlgColor.Color;
                if (selectedShape != null)
                    selectedShape.BackColor = ourColor;
                picbox_drawhere.Refresh();
            }
        }

        private void toolStripButtongrantreport_Click(object sender, EventArgs e)
        {
            if (shapes.Count > 0)
            {
                ReportForm reportForm = new ReportForm(shapes);
                reportForm.ShowDialog();
            }

        }

        private void toolStripButtonprint_Click(object sender, EventArgs e)
        {
            if (shapes.Count > 0)
            {
                ClearSelectedShape();
                printPreview.ShowDialog();
            }
        }
        private void toolStripButtonselect_Click(object sender, EventArgs e)
        {
            toolis = Drawtools._select;
            picbox_drawhere.Cursor = Cursors.Arrow;
            Color_ToolsButtonHighLight(toolStripButtonselect);
        }

        private void toolStripButtonpolygon_Click(object sender, EventArgs e)
        {
            toolis = Drawtools._polygon;
            picbox_drawhere.Cursor = Cursors.Cross;
            Color_ToolsButtonHighLight(toolStripButtonpolygon);
            myPolygons = null;
        }
        private void toolStripButtonCircle_Click(object sender, EventArgs e)
        {
            toolis = Drawtools._circle;
            picbox_drawhere.Cursor = Cursors.Cross;
            Color_ToolsButtonHighLight(toolStripButtonCircle);
        }
        #endregion
        #region KEYBOARD
        private void Mainform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {

                reqStraightLine = true;
            }
        }

        private void Mainform_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {

                reqStraightLine = false;
            }
        }
        #endregion
        #region Drawing

        private void picbox_drawhere_Resize(object sender, EventArgs e)
        {
            CreateTransforms();
            picbox_drawhere.Refresh();
        }
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Transform = Transform;
            foreach (Shape item in shapes)
                item.Render(graphics);

        }

        private void printDocument_QueryPageSettings(object sender, System.Drawing.Printing.QueryPageSettingsEventArgs e)
        {
            e.PageSettings.PaperSize = new PaperSize("Construction", picbox_drawhere.Width, picbox_drawhere.Height);
        }





        private void picbox_drawhere_Paint(object sender, PaintEventArgs e)
        {
            // If we don't have the transforms yet, get them.
            if (Transform == null) CreateTransforms();
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Transform = Transform;

            Font font = new Font(FontFamily.GenericSansSerif, 0.15F, FontStyle.Regular);
            // Use a pen that isn't scaled.
            using (Pen thin_pen = new Pen(Color.Green, 0.1F))
            {
                // Draw the axes.
                float tic = 0.08f;
                thin_pen.Width = 2 / DrawingScale;
                //Draw Horizontal Line
                e.Graphics.DrawLine(thin_pen, Wxmin, 0, Wxmax, 0);

                //Draw vertical tic
                for (int x = (int)Wxmin; x <= Wxmax; x++)
                {
                    if (x != 0)
                        e.Graphics.DrawString(x.ToString(), font, Brushes.Black, new PointF(x, tic));
                    e.Graphics.DrawLine(new Pen(Color.Red, thin_pen.Width), x, -tic, x, tic);

                }

                e.Graphics.DrawLine(thin_pen, 0, Wymin, 0, Wymax);
                //Draw Horizontal tic
                for (int y = (int)Wymin; y <= Wymax; y++)
                {
                    if (y != 0)
                        e.Graphics.DrawString(y.ToString(), font, Brushes.Black, new PointF(tic, y));
                    e.Graphics.DrawLine(new Pen(Color.Red, thin_pen.Width), -tic, y, tic, y);
                }

            }
            shapes.ReverseSort();
            foreach (Shape shape in shapes)
                shape.Render(e.Graphics);

            if (!myRect.IsEmpty)
            {
                e.Graphics.DrawRectangle(curPen, myRect.X, myRect.Y, myRect.Width, myRect.Height);
                e.Graphics.FillRectangle(new SolidBrush(ourColor), myRect.X, myRect.Y, myRect.Width, myRect.Height);
            }

            if (!myCirc.IsEmpty)
            {
                e.Graphics.DrawEllipse(curPen, myCirc.X, myCirc.Y, myCirc.Width, myCirc.Height);
                e.Graphics.FillEllipse(new SolidBrush(ourColor), myCirc.X, myCirc.Y, myCirc.Width, myCirc.Height);
                e.Graphics.DrawRectangle(curPen, myCirc.X, myCirc.Y, myCirc.Width, myCirc.Height);
            }

            if (myPolygons != null)
            {
                e.Graphics.DrawLine(curPen, myPolygons[myPolygons.Count - 1], ePt);
                e.Graphics.DrawLine(curPen, myPolygons[0], ePt);
                if (myPolygons.Count > 1)
                {
                    e.Graphics.DrawLines(curPen, myPolygons.ToArray());
                    e.Graphics.FillPolygon(new SolidBrush(ourColor), myPolygons.ToArray());
                }

            }

        }

        void Set_Shape_Status()
        {
            labelxpointvalue.Text = Math.Round(ePt.X, 1).ToString();
            labelypointvalue.Text = Math.Round(ePt.Y, 1).ToString();
            labeldepthvalue.Text = abovedepth.ToString();
            if (toolis == Drawtools._select)
            {
                labeldegreevalue.Text = "00";
                labellengthvalue.Text = "00";

                if (selectedShape != null)
                {
                    labeldepthvalue.Text = selectedShape.Depth.ToString();
                    if (selectedShape.ShapeType == RECTSHAPE)
                        labelwdithheightvalue.Text = Math.Round(selectedShape.Size.Width, 2).ToString() + " x " + Math.Round(selectedShape.Size.Height, 2).ToString();
                    if (selectedShape.ShapeType == CIRSHAPE)
                        labelwdithheightvalue.Text = Math.Round(selectedShape.Size.Width, 2).ToString() + " x " + Math.Round(selectedShape.Size.Height, 2).ToString();
                }
            }
            if (toolis == Drawtools._polygon && myPolygons != null)
            {
                float degree = Math.Abs(Calculate.AngelBetweenTwopoints(sPt, ePt));
                labeldegreevalue.Text = Math.Round(degree, 2).ToString();
                float length = Calculate.LengthBetweenTwopoints(sPt, ePt);
                labellengthvalue.Text = Math.Round(length, 2).ToString();
            }
            if (toolis == Drawtools._rectangle && !myRect.IsEmpty)
            {
                labelwdithheightvalue.Text = Math.Round(myRect.Width, 2).ToString() + " x " + Math.Round(myRect.Height, 2).ToString();
            }
            if (toolis == Drawtools._circle && !myCirc.IsEmpty)
            {
                labelwdithheightvalue.Text = Math.Round(myCirc.Width, 2).ToString() + " x " + Math.Round(myCirc.Height, 2).ToString();
            }
        }
        private void ClearSelectedShape()
        {
            if (selectedShape != null)
            {
                selectedShape.Selected = false;
                picbox_drawhere.Refresh();
            }
            selectedShape = null;
            Set_Shape_Status();
        }
        #endregion

        
    }
}
