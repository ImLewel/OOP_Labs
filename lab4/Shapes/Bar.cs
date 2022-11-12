using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace lab4.Shapes
{
  class Bar : Shape
  {
    Line line = new();
    Elipse el1 = new();
    Elipse el2 = new();
    int radius = 10;
    public override void Show(Graphics g, Pen pen)
    {
      line.Set(x1, y1, x2, y2);
      el1.Set(line.x1 - radius, line.y1 - radius, line.x1 + radius, line.y1 + radius);
      el2.Set(line.x2 - radius, line.y2 - radius, line.x2 + radius, line.y2 + radius);
      line.Show(g, pen);
      el1.Show(g, pen);
      el2.Show(g, pen);
    }
    public override void Fill(Graphics g, SolidBrush brush)
    {
      el1.Fill(g, brush);
      el2.Fill(g, brush);
    }
  }
}
