using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageAutoCropper
{
    public static class RotatedRectAddons
    {
        public static bool IntersectsWith(this RotatedRect r1,RotatedRect r2)
        {
            var s = Intersect(r1, r2).Size;
            return s.Width * s.Height > 0;
        }
        public static RotatedRect Inflate(this RotatedRect rect, int width, int height)
        {
            rect.Size = new SizeF(rect.Size.Width + width, rect.Size.Height + height);
            return rect;
        }
        public static RotatedRect Intersect(RotatedRect rr1, RotatedRect rr2)
        {
            Mat vec = new Mat();
            CvInvoke.RotatedRectangleIntersection(rr1, rr2, vec);
            vec.ConvertTo(vec, DepthType.Cv32S);
            if (vec.Width * vec.Height <= 0) return new RotatedRect(new PointF(0, 0), new SizeF(0, 0), 0);
            return CvInvoke.MinAreaRect(vec);
        }
        public static RotatedRect Union(RotatedRect rr1, RotatedRect rr2)
        {
            List<PointF> allpts = new List<PointF>();

            PointF[] p1 = rr1.GetVertices();
            allpts.Add(p1[0]);
            allpts.Add(p1[1]);
            allpts.Add(p1[2]);
            allpts.Add(p1[3]);

            PointF[] p2 = rr2.GetVertices();
            allpts.Add(p2[0]);
            allpts.Add(p2[1]);
            allpts.Add(p2[2]);
            allpts.Add(p2[3]);

            return CvInvoke.MinAreaRect(allpts.ToArray());
        }
    }
}
