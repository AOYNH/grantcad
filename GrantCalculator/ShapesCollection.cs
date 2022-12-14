using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrantCalculator
{
    [Serializable]
    public class ShapesCollection:CollectionBase
    {
        public void Add(Shape shapeToAdd)
        {
            // Reorder the shapes so the new shape is on top.
            foreach (Shape shape in List)
            {
                shape.ZOrder++;
            }
            shapeToAdd.ZOrder = 0;
            List.Add(shapeToAdd);
        }

        public void Remove(Shape shapeToRemove)
        {
            List.Remove(shapeToRemove);
        }

        public Shape this[int index]
        {
            get
            {
                return (Shape)this.List[index];
            }
        }

        public Shape HitTest(PointF point)
        {
            Sort();
            foreach (Shape shape in List)
            {
                if (shape.HitTest(point) || shape.HitTestBorder(point))
                {
                    return shape;
                }
            }
            return null;
        }

        public void Sort()
        {
            InnerList.Sort();
        }

        [NonSerialized]
        private IComparer ReverseComparer = new ReverseZOrderComparer();
        public void ReverseSort()
        {
            InnerList.Sort(ReverseComparer);
        }

        public void BringShapeToFront(Shape frontShape)
        {
            foreach (Shape shape in List)
            {
                shape.ZOrder++;
            }
            frontShape.ZOrder = 0;
        }

        public void SendShapeToBack(Shape backShape)
        {
            int maxZOrder = 0;
            foreach (Shape shape in List)
            {
                if (shape.ZOrder > maxZOrder) maxZOrder = shape.ZOrder;
            }
            maxZOrder++;
            backShape.ZOrder = maxZOrder;
        }
    }
    public class ReverseZOrderComparer : IComparer
    {
        public int Compare(object shapeA, object shapeB)
        {
            return ((Shape)shapeB).CompareTo((Shape)shapeA);
        }
    }
}
