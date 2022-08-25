using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrantCalculator
{
    [Serializable]
    public abstract class Shape : IComparable
    {
		// Support sorting based on z-order. This makes it easy
		// to paint groups of Shape controls in the right order.
		public int CompareTo(object shape)
		{
			return ZOrder.CompareTo(((Shape)shape).ZOrder);
		}

		// Even internally, all access to the path should
		// go through the Path property, so that the path
		// is regenerated if null.
		[NonSerialized]
		private GraphicsPath path = null;
		public GraphicsPath Path
		{
			get
			{
				// The path is refreshed automatically
				// as needed.
				if (path == null)
				{
					RefreshPath();
				}
				return path;
			}
		}

		// Create the corresponding GraphicsPath for the shape.
		private void RefreshPath()
		{
			path = GeneratePath();
		}

		protected abstract GraphicsPath GeneratePath();

		[NonSerialized]
		private Region region;
		public Region Region
		{
			get
			{
				if (region == null)
				{
					region = new Region(Path);
				}
				return region;
			}
		}

		// This is useful when refreshing the form.
		// It takes into account the region occupied by the
		// border and focus rectangle.
		public virtual RectangleF GetLargestPossibleRegion()
		{
			RectangleF rect = Path.GetBounds();
			rect.Inflate(new SizeF(focusBorderSpace, focusBorderSpace));
			return rect;
			//return new Region(rect);
		}

		// Check if the point is in the shape.
		public virtual bool HitTest(PointF point)
		{
            //  if (rotation != 0)
            //matrix.RotateAt(rotation, new PointF(location.X, location.Y),
            //  Drawing.Drawing2D.MatrixOrder.Append)

            //path.Transform(matrix)

            return Path.IsVisible(point);
		}

		// Check if the point is in the outline of the shape.
		public virtual bool HitTestBorder(PointF point)
		{
			if (outlinePen == null)
			{
				return false;
			}
			else
			{
				return Path.IsOutlineVisible(point, outlinePen);
			}
		}

		public enum HitSpot
		{
			Top, Bottom, Left, Right,
			TopLeftCorner, BottomLeftCorner,
			TopRightCorner, BottomRightCorner,
			None
		}

		public bool HitTestFocusBorder(PointF point, out HitSpot hitSpot)
		{
			hitSpot = HitSpot.None;
			if (!selected)
			{
				return false;
			}
			else
			{
				RectangleF rectInner = Path.GetBounds();
				RectangleF rectOuter = rectInner;
				rectOuter.Inflate(new SizeF(focusBorderSpace, focusBorderSpace));
				if (rectOuter.Contains(point) && !rectInner.Contains(point))
				{
				 
					// Here's the simplest hit-testing code.
					// However, it's insufficient because it doesn't indicate
					// the side where the hit took place.
				}
				else
				{
					return false;
				}

				bool top = false;
				bool bottom = false;
				bool left = false;
				bool right = false;
				if (Math.Abs(point.X - location.X) < focusBorderSpace)
				{
					left = true;
				}
				if (Math.Abs(point.X - (location.X + size.Width)) < focusBorderSpace)
				{
					right = true;
				}
				if (Math.Abs(point.Y - location.Y) < focusBorderSpace)
				{
					top = true;
				}
				if (Math.Abs(point.Y - (location.Y + size.Height)) < focusBorderSpace)
				{
					bottom = true;
				}
				if (top && left) hitSpot = HitSpot.TopLeftCorner;
				else if (top && right) hitSpot = HitSpot.TopRightCorner;
				else if (bottom && left) hitSpot = HitSpot.BottomLeftCorner;
				else if (bottom && right) hitSpot = HitSpot.BottomRightCorner;
				else if (top) hitSpot = HitSpot.Top;
				else if (bottom) hitSpot = HitSpot.Bottom;
				else if (left) hitSpot = HitSpot.Left;
				else if (right) hitSpot = HitSpot.Right;

				if (hitSpot == HitSpot.None)
					return false;
				else
					return true;
			}
		}
		// See if the mouse is over a corner point.
		// The "size" of an object for mouse over purposes.
		private const float object_radius = .15F;

		// We're over an object if the distance squared
		// between the mouse and the object is less than this.
		private const float over_dist_squared = object_radius * object_radius;
		public bool MouseIsOverCornerPoint(PointF mouse_pt,List<PointF> Polygons, out int hit_pt)
		{
			 	// See if we're over one of the polygon's corner points.
				for (int i = 0; i < Polygons.Count; i++)
				{
					// See if we're over this point.
					if (Calculate.FindDistanceToPointSquared(Polygons[i], mouse_pt) < over_dist_squared)
					{
						// We're over this point.
						hit_pt = i;
						return true;
					}
				}
			hit_pt = -1;
			return false;
		}
		private string name;
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
		private string shapetype;
		public string ShapeType
        {
			get
			{
				return shapetype;
			}
			set
			{
				shapetype = value;
			}
		}
		// The following properties duplicate some of the Control-class
		// functionality that's needed.
		private Color foreColor;
		public Color ForeColor
		{
			get
			{
				return foreColor;
			}
			set
			{
				foreColor = value;
			}
		}

		private Color backColor;
		public Color BackColor
		{
			get
			{
				return backColor;
			}
			set
			{
				backColor = value;
			}
		}

		private int zOrder;
		public int ZOrder
		{
			get
			{
				return zOrder;
			}
			set
			{
				zOrder = value;
			}
		}

		private bool selected;
		public bool Selected
		{
			get
			{
				return selected;
			}
			set
			{
				selected = value;
			}
		}

		private SizeF size;
		public SizeF Size
		{
			get
			{
				return size;
			}
			set
			{
				size = value;
				path = null;
			}
		}

		private PointF location;
		public PointF Location
		{
			get
			{
				return location;
			}
			set
			{
				location = value;
				path = null;
			}
		}
		private List<PointF> locations;
	    public  List<PointF>Locations
        {
			get
			{
				return locations;
			}
			set
			{
				locations = value;
                path = null;
            }
		}
		private float area;
		public float Area
        {
            get
            {
				return area;
            }
            set
            {
				area = value;
            }
        }
		private int cement;
		public int Cement
		{
			get
			{
				return cement;
			}
			set
			{
				cement = value;
			}
		}

		private int gravel;
		public int Gravel
		{
			get
			{
				return gravel;
			}
			set
			{
				gravel = value;
			}
		}

		private int sand;
		public int Sand
		{
			get
			{
				return sand;
			}
			set
			{
				sand = value;
			}
		}

		private int lime;
		public int Lime
		{
			get
			{
				return lime;
			}
			set
			{
				lime = value;
			}
		}


		private float depth;
		public float Depth
		{
			get
			{
				return depth;
			}
			set
			{
				depth = value;
			}
		}
		 
		public float price;
		public float Price
		{
			get
			{
				return price;
			}
			set
			{
				price = value;
			}
		}
		// These details could be wrapped in properties
		// to provide more customization for line thickness
		// and border patterns.
		private float penThickness;
		public float PenThickness
		{
			get
			{
				return penThickness;
			}
			set
			{
				penThickness = value;
				 
			}
		}
	
		private float focusBorderSpace = 0.1F;
		[NonSerialized]
		Pen outlinePen;

		public void Render(Graphics g)
		{
			// Create the pen and brush.
			if (outlinePen != null)
			{
				outlinePen.Dispose();
			}
			

			outlinePen = new Pen(foreColor, penThickness);
			Brush surfaceBrush = new SolidBrush(backColor);

			// Paint the shape.
			g.FillPath(surfaceBrush, Path);
			g.DrawPath(outlinePen, Path);

			// If required, paint the focus box.
			if (Selected)
			{
				RectangleF rect =  Path.GetBounds();
				
				//rect.Inflate(new Size(focusBorderSpace, focusBorderSpace));
				float[] dashValues = { 2, 2, 2, 2 };
				Pen whitedashPen = new Pen(Color.Gray, 0.1F);
				whitedashPen.DashPattern = dashValues;
				g.DrawRectangle(whitedashPen, rect.X,rect.Y,rect.Width,rect.Height);
				 if(Locations!=null)
                {
					foreach (PointF point in Locations)
					{

						RectangleF rt = new RectangleF(
							point.X - .1F, point.Y - .1F,
							2 * .1F, 2 * .1F);

						g.DrawEllipse(new Pen(Color.Blue, 0.1F), rt);
						g.FillEllipse(Brushes.White, rt);
					}
				}
				

			}
			surfaceBrush.Dispose();
		}
	}
}
