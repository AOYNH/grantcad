
namespace GrantCalculator
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.picbox_drawhere = new System.Windows.Forms.PictureBox();
            this.toolStripShapeControl = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonprice = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtongrantreport = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonprint = new System.Windows.Forms.ToolStripButton();
            this.toolStripDrawControl = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonselect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCircle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonpolygon = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonfillcolor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtontofront = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtontoback = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtondelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabellinethickness = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxlinethickness = new System.Windows.Forms.ToolStripComboBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mnuselectshape = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fillColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bringToFrontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDeptAboveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estimateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labeldegree = new System.Windows.Forms.Label();
            this.labeldegreevalue = new System.Windows.Forms.Label();
            this.labellength = new System.Windows.Forms.Label();
            this.labellengthvalue = new System.Windows.Forms.Label();
            this.labeldepth = new System.Windows.Forms.Label();
            this.labeldepthvalue = new System.Windows.Forms.Label();
            this.unitpanel = new System.Windows.Forms.Panel();
            this.labelwidthheight = new System.Windows.Forms.Label();
            this.labelwdithheightvalue = new System.Windows.Forms.Label();
            this.labelxpoint = new System.Windows.Forms.Label();
            this.labelxpointvalue = new System.Windows.Forms.Label();
            this.labelypiont = new System.Windows.Forms.Label();
            this.labelypointvalue = new System.Windows.Forms.Label();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_drawhere)).BeginInit();
            this.toolStripShapeControl.SuspendLayout();
            this.toolStripDrawControl.SuspendLayout();
            this.mnuselectshape.SuspendLayout();
            this.unitpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbox_drawhere
            // 
            this.picbox_drawhere.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picbox_drawhere.BackColor = System.Drawing.Color.White;
            this.picbox_drawhere.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox_drawhere.Cursor = System.Windows.Forms.Cursors.Default;
            this.picbox_drawhere.Location = new System.Drawing.Point(57, 124);
            this.picbox_drawhere.Name = "picbox_drawhere";
            this.picbox_drawhere.Size = new System.Drawing.Size(994, 456);
            this.picbox_drawhere.TabIndex = 0;
            this.picbox_drawhere.TabStop = false;
            this.picbox_drawhere.Paint += new System.Windows.Forms.PaintEventHandler(this.picbox_drawhere_Paint);
            this.picbox_drawhere.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picbox_drawhere_MouseDown);
            this.picbox_drawhere.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picbox_drawhere_MouseMove);
            this.picbox_drawhere.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picbox_drawhere_MouseUp);
            this.picbox_drawhere.Resize += new System.EventHandler(this.picbox_drawhere_Resize);
            // 
            // toolStripShapeControl
            // 
            this.toolStripShapeControl.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripShapeControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripButtonOpen,
            this.toolStripButtonSave,
            this.toolStripButtonprice,
            this.toolStripButtongrantreport,
            this.toolStripButtonprint});
            this.toolStripShapeControl.Location = new System.Drawing.Point(0, 0);
            this.toolStripShapeControl.Name = "toolStripShapeControl";
            this.toolStripShapeControl.Size = new System.Drawing.Size(1109, 34);
            this.toolStripShapeControl.TabIndex = 2;
            this.toolStripShapeControl.Text = "toolStrip1";
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(51, 29);
            this.toolStripButtonNew.Text = "New";
            this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(60, 29);
            this.toolStripButtonOpen.Text = "Open";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(53, 29);
            this.toolStripButtonSave.Text = "Save";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonprice
            // 
            this.toolStripButtonprice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonprice.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonprice.Image")));
            this.toolStripButtonprice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonprice.Name = "toolStripButtonprice";
            this.toolStripButtonprice.Size = new System.Drawing.Size(53, 29);
            this.toolStripButtonprice.Text = "Price";
            this.toolStripButtonprice.Click += new System.EventHandler(this.toolStripButtonprice_Click);
            // 
            // toolStripButtongrantreport
            // 
            this.toolStripButtongrantreport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtongrantreport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtongrantreport.Image")));
            this.toolStripButtongrantreport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtongrantreport.Name = "toolStripButtongrantreport";
            this.toolStripButtongrantreport.Size = new System.Drawing.Size(69, 29);
            this.toolStripButtongrantreport.Text = "Report";
            this.toolStripButtongrantreport.Click += new System.EventHandler(this.toolStripButtongrantreport_Click);
            // 
            // toolStripButtonprint
            // 
            this.toolStripButtonprint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonprint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonprint.Image")));
            this.toolStripButtonprint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonprint.Name = "toolStripButtonprint";
            this.toolStripButtonprint.Size = new System.Drawing.Size(52, 29);
            this.toolStripButtonprint.Text = "Print";
            this.toolStripButtonprint.Click += new System.EventHandler(this.toolStripButtonprint_Click);
            // 
            // toolStripDrawControl
            // 
            this.toolStripDrawControl.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripDrawControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonselect,
            this.toolStripButtonRect,
            this.toolStripButtonCircle,
            this.toolStripButtonpolygon,
            this.toolStripSeparator6,
            this.toolStripButtonColor,
            this.toolStripSeparator1,
            this.toolStripButtonfillcolor,
            this.toolStripSeparator2,
            this.toolStripButtontofront,
            this.toolStripSeparator3,
            this.toolStripButtontoback,
            this.toolStripSeparator5,
            this.toolStripButtondelete,
            this.toolStripSeparator4,
            this.toolStripLabellinethickness,
            this.toolStripComboBoxlinethickness});
            this.toolStripDrawControl.Location = new System.Drawing.Point(0, 34);
            this.toolStripDrawControl.Name = "toolStripDrawControl";
            this.toolStripDrawControl.Size = new System.Drawing.Size(1109, 34);
            this.toolStripDrawControl.TabIndex = 3;
            this.toolStripDrawControl.Text = "toolStrip1";
            // 
            // toolStripButtonselect
            // 
            this.toolStripButtonselect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonselect.Image")));
            this.toolStripButtonselect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonselect.Name = "toolStripButtonselect";
            this.toolStripButtonselect.Size = new System.Drawing.Size(86, 29);
            this.toolStripButtonselect.Text = "Select";
            this.toolStripButtonselect.Click += new System.EventHandler(this.toolStripButtonselect_Click);
            // 
            // toolStripButtonRect
            // 
            this.toolStripButtonRect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRect.Image")));
            this.toolStripButtonRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRect.Name = "toolStripButtonRect";
            this.toolStripButtonRect.Size = new System.Drawing.Size(116, 29);
            this.toolStripButtonRect.Text = "Rectangle";
            this.toolStripButtonRect.Click += new System.EventHandler(this.toolStripButtonRect_Click);
            // 
            // toolStripButtonCircle
            // 
            this.toolStripButtonCircle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCircle.Image")));
            this.toolStripButtonCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCircle.Name = "toolStripButtonCircle";
            this.toolStripButtonCircle.Size = new System.Drawing.Size(82, 29);
            this.toolStripButtonCircle.Text = "Circle";
            this.toolStripButtonCircle.Click += new System.EventHandler(this.toolStripButtonCircle_Click);
            // 
            // toolStripButtonpolygon
            // 
            this.toolStripButtonpolygon.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonpolygon.Image")));
            this.toolStripButtonpolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonpolygon.Name = "toolStripButtonpolygon";
            this.toolStripButtonpolygon.Size = new System.Drawing.Size(105, 29);
            this.toolStripButtonpolygon.Text = "Polygon";
            this.toolStripButtonpolygon.Click += new System.EventHandler(this.toolStripButtonpolygon_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripButtonColor
            // 
            this.toolStripButtonColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonColor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonColor.Image")));
            this.toolStripButtonColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonColor.Name = "toolStripButtonColor";
            this.toolStripButtonColor.Size = new System.Drawing.Size(59, 29);
            this.toolStripButtonColor.Text = "Color";
            this.toolStripButtonColor.Click += new System.EventHandler(this.toolStripButtonColor_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripButtonfillcolor
            // 
            this.toolStripButtonfillcolor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonfillcolor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonfillcolor.Image")));
            this.toolStripButtonfillcolor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonfillcolor.Name = "toolStripButtonfillcolor";
            this.toolStripButtonfillcolor.Size = new System.Drawing.Size(37, 29);
            this.toolStripButtonfillcolor.Text = "Fill";
            this.toolStripButtonfillcolor.Click += new System.EventHandler(this.toolStripButtonfillcolor_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripButtontofront
            // 
            this.toolStripButtontofront.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtontofront.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtontofront.Image")));
            this.toolStripButtontofront.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtontofront.Name = "toolStripButtontofront";
            this.toolStripButtontofront.Size = new System.Drawing.Size(81, 29);
            this.toolStripButtontofront.Text = "To Front";
            this.toolStripButtontofront.Click += new System.EventHandler(this.toolStripButtontofront_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripButtontoback
            // 
            this.toolStripButtontoback.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtontoback.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtontoback.Image")));
            this.toolStripButtontoback.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtontoback.Name = "toolStripButtontoback";
            this.toolStripButtontoback.Size = new System.Drawing.Size(75, 29);
            this.toolStripButtontoback.Text = "To Back";
            this.toolStripButtontoback.Click += new System.EventHandler(this.toolStripButtontoback_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripButtondelete
            // 
            this.toolStripButtondelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtondelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtondelete.Image")));
            this.toolStripButtondelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtondelete.Name = "toolStripButtondelete";
            this.toolStripButtondelete.Size = new System.Drawing.Size(66, 29);
            this.toolStripButtondelete.Text = "Delete";
            this.toolStripButtondelete.Click += new System.EventHandler(this.toolStripButtondelete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripLabellinethickness
            // 
            this.toolStripLabellinethickness.Name = "toolStripLabellinethickness";
            this.toolStripLabellinethickness.Size = new System.Drawing.Size(87, 29);
            this.toolStripLabellinethickness.Text = "Thickness";
            // 
            // toolStripComboBoxlinethickness
            // 
            this.toolStripComboBoxlinethickness.Items.AddRange(new object[] {
            "Small",
            "Bold",
            "Hibold"});
            this.toolStripComboBoxlinethickness.Name = "toolStripComboBoxlinethickness";
            this.toolStripComboBoxlinethickness.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripComboBoxlinethickness.Size = new System.Drawing.Size(121, 34);
            this.toolStripComboBoxlinethickness.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxlinethickness_SelectedIndexChanged);
            // 
            // mnuselectshape
            // 
            this.mnuselectshape.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuselectshape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillColorToolStripMenuItem,
            this.clearColorToolStripMenuItem,
            this.bringToFrontToolStripMenuItem,
            this.sendToBackToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.setDeptAboveToolStripMenuItem,
            this.estimateToolStripMenuItem});
            this.mnuselectshape.Name = "mnuselectshape";
            this.mnuselectshape.Size = new System.Drawing.Size(228, 228);
            // 
            // fillColorToolStripMenuItem
            // 
            this.fillColorToolStripMenuItem.Name = "fillColorToolStripMenuItem";
            this.fillColorToolStripMenuItem.Size = new System.Drawing.Size(227, 32);
            this.fillColorToolStripMenuItem.Text = "Fill Color";
            this.fillColorToolStripMenuItem.Click += new System.EventHandler(this.fillColorToolStripMenuItem_Click);
            // 
            // clearColorToolStripMenuItem
            // 
            this.clearColorToolStripMenuItem.Name = "clearColorToolStripMenuItem";
            this.clearColorToolStripMenuItem.Size = new System.Drawing.Size(227, 32);
            this.clearColorToolStripMenuItem.Text = "Clear Color";
            this.clearColorToolStripMenuItem.Click += new System.EventHandler(this.clearColorToolStripMenuItem_Click);
            // 
            // bringToFrontToolStripMenuItem
            // 
            this.bringToFrontToolStripMenuItem.Name = "bringToFrontToolStripMenuItem";
            this.bringToFrontToolStripMenuItem.Size = new System.Drawing.Size(227, 32);
            this.bringToFrontToolStripMenuItem.Text = "Bring To Front";
            this.bringToFrontToolStripMenuItem.Click += new System.EventHandler(this.bringToFrontToolStripMenuItem_Click);
            // 
            // sendToBackToolStripMenuItem
            // 
            this.sendToBackToolStripMenuItem.Name = "sendToBackToolStripMenuItem";
            this.sendToBackToolStripMenuItem.Size = new System.Drawing.Size(227, 32);
            this.sendToBackToolStripMenuItem.Text = "Send To Back";
            this.sendToBackToolStripMenuItem.Click += new System.EventHandler(this.sendToBackToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(227, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // setDeptAboveToolStripMenuItem
            // 
            this.setDeptAboveToolStripMenuItem.Name = "setDeptAboveToolStripMenuItem";
            this.setDeptAboveToolStripMenuItem.Size = new System.Drawing.Size(227, 32);
            this.setDeptAboveToolStripMenuItem.Text = "Set-Depth(Above)";
            this.setDeptAboveToolStripMenuItem.Click += new System.EventHandler(this.setDeptAboveToolStripMenuItem_Click);
            // 
            // estimateToolStripMenuItem
            // 
            this.estimateToolStripMenuItem.Name = "estimateToolStripMenuItem";
            this.estimateToolStripMenuItem.Size = new System.Drawing.Size(227, 32);
            this.estimateToolStripMenuItem.Text = "Estimate";
            this.estimateToolStripMenuItem.Click += new System.EventHandler(this.estimateToolStripMenuItem_Click);
            // 
            // labeldegree
            // 
            this.labeldegree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeldegree.AutoSize = true;
            this.labeldegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldegree.Location = new System.Drawing.Point(576, 5);
            this.labeldegree.Name = "labeldegree";
            this.labeldegree.Size = new System.Drawing.Size(78, 20);
            this.labeldegree.TabIndex = 4;
            this.labeldegree.Text = "#Degree";
            // 
            // labeldegreevalue
            // 
            this.labeldegreevalue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeldegreevalue.AutoSize = true;
            this.labeldegreevalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldegreevalue.Location = new System.Drawing.Point(664, 3);
            this.labeldegreevalue.Name = "labeldegreevalue";
            this.labeldegreevalue.Size = new System.Drawing.Size(36, 25);
            this.labeldegreevalue.TabIndex = 5;
            this.labeldegreevalue.Text = "00";
            this.labeldegreevalue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labellength
            // 
            this.labellength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labellength.AutoSize = true;
            this.labellength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellength.Location = new System.Drawing.Point(429, 4);
            this.labellength.Name = "labellength";
            this.labellength.Size = new System.Drawing.Size(75, 20);
            this.labellength.TabIndex = 6;
            this.labellength.Text = "#Length";
            // 
            // labellengthvalue
            // 
            this.labellengthvalue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labellengthvalue.AutoSize = true;
            this.labellengthvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellengthvalue.Location = new System.Drawing.Point(505, 2);
            this.labellengthvalue.Name = "labellengthvalue";
            this.labellengthvalue.Size = new System.Drawing.Size(36, 25);
            this.labellengthvalue.TabIndex = 5;
            this.labellengthvalue.Text = "00";
            this.labellengthvalue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labeldepth
            // 
            this.labeldepth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeldepth.AutoSize = true;
            this.labeldepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldepth.Location = new System.Drawing.Point(299, 3);
            this.labeldepth.Name = "labeldepth";
            this.labeldepth.Size = new System.Drawing.Size(68, 20);
            this.labeldepth.TabIndex = 6;
            this.labeldepth.Text = "#Depth";
            // 
            // labeldepthvalue
            // 
            this.labeldepthvalue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeldepthvalue.AutoSize = true;
            this.labeldepthvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldepthvalue.Location = new System.Drawing.Point(381, 1);
            this.labeldepthvalue.Name = "labeldepthvalue";
            this.labeldepthvalue.Size = new System.Drawing.Size(36, 25);
            this.labeldepthvalue.TabIndex = 5;
            this.labeldepthvalue.Text = "00";
            this.labeldepthvalue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // unitpanel
            // 
            this.unitpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unitpanel.BackColor = System.Drawing.Color.White;
            this.unitpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.unitpanel.Controls.Add(this.labelwidthheight);
            this.unitpanel.Controls.Add(this.labeldepth);
            this.unitpanel.Controls.Add(this.labeldegree);
            this.unitpanel.Controls.Add(this.labellength);
            this.unitpanel.Controls.Add(this.labeldegreevalue);
            this.unitpanel.Controls.Add(this.labelwdithheightvalue);
            this.unitpanel.Controls.Add(this.labeldepthvalue);
            this.unitpanel.Controls.Add(this.labellengthvalue);
            this.unitpanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.unitpanel.Location = new System.Drawing.Point(296, 87);
            this.unitpanel.Name = "unitpanel";
            this.unitpanel.Size = new System.Drawing.Size(755, 31);
            this.unitpanel.TabIndex = 7;
            // 
            // labelwidthheight
            // 
            this.labelwidthheight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelwidthheight.AutoSize = true;
            this.labelwidthheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelwidthheight.Location = new System.Drawing.Point(-1, 4);
            this.labelwidthheight.Name = "labelwidthheight";
            this.labelwidthheight.Size = new System.Drawing.Size(118, 20);
            this.labelwidthheight.TabIndex = 6;
            this.labelwidthheight.Text = "#WidthHeight";
            // 
            // labelwdithheightvalue
            // 
            this.labelwdithheightvalue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelwdithheightvalue.AutoSize = true;
            this.labelwdithheightvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelwdithheightvalue.Location = new System.Drawing.Point(128, 1);
            this.labelwdithheightvalue.Name = "labelwdithheightvalue";
            this.labelwdithheightvalue.Size = new System.Drawing.Size(83, 25);
            this.labelwdithheightvalue.TabIndex = 5;
            this.labelwdithheightvalue.Text = "00 x 00";
            this.labelwdithheightvalue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelxpoint
            // 
            this.labelxpoint.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelxpoint.AutoSize = true;
            this.labelxpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelxpoint.Location = new System.Drawing.Point(15, 326);
            this.labelxpoint.Name = "labelxpoint";
            this.labelxpoint.Size = new System.Drawing.Size(17, 20);
            this.labelxpoint.TabIndex = 8;
            this.labelxpoint.Text = "x";
            // 
            // labelxpointvalue
            // 
            this.labelxpointvalue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelxpointvalue.AutoSize = true;
            this.labelxpointvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelxpointvalue.Location = new System.Drawing.Point(4, 348);
            this.labelxpointvalue.Name = "labelxpointvalue";
            this.labelxpointvalue.Size = new System.Drawing.Size(29, 20);
            this.labelxpointvalue.TabIndex = 9;
            this.labelxpointvalue.Text = "00";
            // 
            // labelypiont
            // 
            this.labelypiont.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelypiont.AutoSize = true;
            this.labelypiont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelypiont.Location = new System.Drawing.Point(522, 583);
            this.labelypiont.Name = "labelypiont";
            this.labelypiont.Size = new System.Drawing.Size(17, 20);
            this.labelypiont.TabIndex = 10;
            this.labelypiont.Text = "y";
            // 
            // labelypointvalue
            // 
            this.labelypointvalue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelypointvalue.AutoSize = true;
            this.labelypointvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelypointvalue.Location = new System.Drawing.Point(545, 586);
            this.labelypointvalue.Name = "labelypointvalue";
            this.labelypointvalue.Size = new System.Drawing.Size(29, 20);
            this.labelypointvalue.TabIndex = 11;
            this.labelypointvalue.Text = "00";
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            this.printDocument.QueryPageSettings += new System.Drawing.Printing.QueryPageSettingsEventHandler(this.printDocument_QueryPageSettings);
            // 
            // printPreview
            // 
            this.printPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreview.Document = this.printDocument;
            this.printPreview.Enabled = true;
            this.printPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreview.Icon")));
            this.printPreview.Name = "printPreview";
            this.printPreview.ShowIcon = false;
            this.printPreview.Visible = false;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1109, 612);
            this.Controls.Add(this.labelypointvalue);
            this.Controls.Add(this.labelypiont);
            this.Controls.Add(this.labelxpointvalue);
            this.Controls.Add(this.labelxpoint);
            this.Controls.Add(this.unitpanel);
            this.Controls.Add(this.toolStripDrawControl);
            this.Controls.Add(this.toolStripShapeControl);
            this.Controls.Add(this.picbox_drawhere);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grant CAD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mainform_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Mainform_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_drawhere)).EndInit();
            this.toolStripShapeControl.ResumeLayout(false);
            this.toolStripShapeControl.PerformLayout();
            this.toolStripDrawControl.ResumeLayout(false);
            this.toolStripDrawControl.PerformLayout();
            this.mnuselectshape.ResumeLayout(false);
            this.unitpanel.ResumeLayout(false);
            this.unitpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_drawhere;
        private System.Windows.Forms.ToolStrip toolStripShapeControl;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStrip toolStripDrawControl;
        private System.Windows.Forms.ToolStripButton toolStripButtonRect;
        private System.Windows.Forms.ToolStripButton toolStripButtonCircle;
        private System.Windows.Forms.ToolStripButton toolStripButtonpolygon;
        private System.Windows.Forms.ToolStripButton toolStripButtonselect;
        private System.Windows.Forms.ToolStripButton toolStripButtontofront;
        private System.Windows.Forms.ToolStripButton toolStripButtontoback;
        private System.Windows.Forms.ToolStripButton toolStripButtondelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonColor;
        private System.Windows.Forms.ToolStripButton toolStripButtonfillcolor;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ContextMenuStrip mnuselectshape;
        private System.Windows.Forms.ToolStripMenuItem fillColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bringToFrontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estimateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabellinethickness;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxlinethickness;
        private System.Windows.Forms.ToolStripButton toolStripButtonprice;
        private System.Windows.Forms.ToolStripMenuItem setDeptAboveToolStripMenuItem;
        private System.Windows.Forms.Label labeldegree;
        private System.Windows.Forms.Label labeldegreevalue;
        private System.Windows.Forms.Label labellength;
        private System.Windows.Forms.Label labellengthvalue;
        private System.Windows.Forms.Label labeldepth;
        private System.Windows.Forms.Label labeldepthvalue;
        private System.Windows.Forms.Panel unitpanel;
        private System.Windows.Forms.Label labelwidthheight;
        private System.Windows.Forms.Label labelwdithheightvalue;
        private System.Windows.Forms.Label labelxpoint;
        private System.Windows.Forms.Label labelxpointvalue;
        private System.Windows.Forms.Label labelypiont;
        private System.Windows.Forms.Label labelypointvalue;
        private System.Windows.Forms.ToolStripButton toolStripButtongrantreport;
        private System.Windows.Forms.ToolStripButton toolStripButtonprint;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreview;
    }
}

