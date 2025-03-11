using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageAutoCropper
{
    public static class GraphicsAddons
    {
        public static void DrawRotatedRectangle(this Graphics g, Pen pen, RotatedRect rect)
        {
            g.DrawPolygon(pen, rect.GetVertices());
        }
    }
}
