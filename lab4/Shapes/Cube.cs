using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace lab4.Shapes
{
  class Cube : Shape
  {
    public override void Show(Graphics g, Pen pen)
    {
      RectangleShape rect1 = new();
      RectangleShape rect2 = new();
      rect1.Set(x1, y1, x2, y2);
      rect2.Set(x1 + Math.Abs(x1 - x2), y1 + Math.Abs(x1 - x2), x2 + Math.Abs(x1 - x2), y2 + Math.Abs(x1 - x2));
      rect1.Show(g, pen);
      rect2.Show(g, pen);
      g.DrawLine(pen, rect1.x1 + (rect1.x1 - rect1.x2), rect1.y1 + (rect1.y1 - rect1.y2), rect2.x1 + (rect2.x1 - rect2.x2), rect2.y1 + (rect2.y1 - rect2.y2));
      g.DrawLine(pen, rect1.x1 + (rect1.x1 - rect1.x2), rect1.y1 - (rect1.y1 - rect1.y2), rect2.x1 + (rect2.x1 - rect2.x2), rect2.y1 - (rect2.y1 - rect2.y2));
      g.DrawLine(pen, rect1.x1 - (rect1.x1 - rect1.x2), rect1.y1 + (rect1.y1 - rect1.y2), rect2.x1 - (rect2.x1 - rect2.x2), rect2.y1 + (rect2.y1 - rect2.y2));
      g.DrawLine(pen, rect1.x1 - (rect1.x1 - rect1.x2), rect1.y1 - (rect1.y1 - rect1.y2), rect2.x1 - (rect2.x1 - rect2.x2), rect2.y1 - (rect2.y1 - rect2.y2));
    }
  }
}