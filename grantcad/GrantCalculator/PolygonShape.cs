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
    class PolygonShape:Shape
    {
        protected override GraphicsPath GeneratePath()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(Locations.ToArray());
            return path;
        }
     
    }
}
