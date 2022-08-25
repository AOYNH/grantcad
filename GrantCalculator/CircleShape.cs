using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrantCalculator
{
    [Serializable]
    public class CircleShape:Shape
    {
        protected override GraphicsPath GeneratePath()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(new RectangleF(Location, Size));
            return path;
        }
    }
}
