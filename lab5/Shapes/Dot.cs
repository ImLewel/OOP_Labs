using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace lab5.Shapes
{
  class Dot : Shape
  {
    public override void Show(Graphics g, Pen pen)
    {
      g.DrawRectangle(pen, this.x2, this.y2, pen.Width, pen.Width);
    }
  }
}
