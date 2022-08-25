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
    public class RectangleShape:Shape
    {
        protected override GraphicsPath GeneratePath()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new RectangleF(Location,Size));
            return path;
        }
    }
}
