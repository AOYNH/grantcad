using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrantCalculator
{
    public static class Calculate
    {

        // Calculate the distance squared between two points.
        public static float FindDistanceToPointSquared(PointF pt1, PointF pt2)
        {
            float dx = pt1.X - pt2.X;
            float dy = pt1.Y - pt2.Y;
            return dx * dx + dy * dy;
        }
        public static double Differentiate(float p1, float p2)
        {
            double diff = p2 - p1;
            return diff;
        }
        public static float LengthBetweenTwopoints(PointF pt, PointF pts)
        {
            float num = pt.X - pts.X;
            float num2 = pt.Y - pts.Y;
            float value = num * num + num2 * num2;
            double num3 = Math.Sqrt(value);
            return (float)num3;
        }
        public static float AngelBetweenTwopoints(PointF pt1, PointF pt2)
        {
            double dx = Differentiate(pt1.X , pt2.X);
            double dy = Differentiate(pt1.Y , pt2.Y);
            double num3 = Math.Atan2(dy, dx) * 57.295779513082323;
            return (float)num3;
        }
        public static float RectangleArea(float width, float height)
        {
            return width * height;
        }
        // Return the polygon's area in "square units."
        // The value will be negative if the polygon is
        // oriented clockwise.
        public static float PolygonArea(PointF[] ptfs)
        {
            // Add the first point to the end.
            int num_points = ptfs.Length;
            PointF[] pts = new PointF[num_points + 1];
            ptfs.CopyTo(pts, 0);
            pts[num_points] = ptfs[0];

            // Get the areas.
            float area = 0;
            for (int i = 0; i < num_points; i++)
            {
                area +=
                    (pts[i + 1].X - pts[i].X) *
                    (pts[i + 1].Y + pts[i].Y) / 2;
            }

            // Return the result.
            return area;
        }
        public static float EllipseArea(float width, float height)
        {
            //width - semi major axis
            //height - semi minor axis
            float Area;

            Area = (float)3.142 * width * height;

            return Area;

        }
        public static int ShapeRatio(Shape shape)
        {
            return shape.Cement + shape.Gravel + shape.Sand + shape.Lime;
        }
        public static float CubicFeet(float area,float depth)
        {
            return area * depth;
        }
        public static float AverageCubic(int particalRatio,int ratio,float cubicfeet)
        {
            return (cubicfeet / ratio) * particalRatio;
        }
        public static float MaterialPrice(float material,float price)
        {
            return material * price;
        }
      }
    }
