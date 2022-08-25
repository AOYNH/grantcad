using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrantCalculator
{
    class RectanglePlotter
    {
        public RectangleF ShapeRect(PointF p1, PointF p2)
        {
            RectangleF r = new RectangleF(0, 0, 0, 0);

            if (p1.X < p2.X)//top left corner to bottom right
            {
                if (p1.Y < p2.Y)
                {
                    r = RectangleF.FromLTRB(p1.X, p1.Y, p2.X, p2.Y);
                }
                else if (p1.Y > p2.Y)//bottom left corner to top right
                {
                    r = RectangleF.FromLTRB(p1.X, p2.Y, p2.X, p1.Y);
                }
            }
            else if (p1.X > p2.X)//top right corner to bottom left
            {
                if (p1.Y < p2.Y)
                {
                    r = RectangleF.FromLTRB(p2.X, p1.Y, p1.X, p2.Y);
                }
                else if (p1.Y > p2.Y)//bottom right corner to top left
                {
                    r = RectangleF.FromLTRB(p2.X, p2.Y, p1.X, p1.Y);
                }
            }

            return r;
        }
    }
}
