using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using lab4.Shapes;
namespace lab4
{
  class MyEditor
  {
    protected int x1, y1, x2, y2;
    protected Shape currShape;
    protected Pen pen;
    protected SolidBrush brush;

    public void Start(Shape shape)
    {
      currShape = shape;
    }
    public void OnMouseDown(MouseEventArgs e)
    {
      this.x1 = e.X;
      this.y1 = e.Y;
    }

    public void OnMouseUp(MouseEventArgs e, Graphics g)
    {
      this.x2 = e.X;
      this.y2 = e.Y;
      currShape.Set(x1, y1, x2, y2);
      currShape.Show(g, pen);
      currShape.Fill(g, brush);
    }

    public virtual void OnMouseMove(MouseEventArgs e, Graphics g)
    {
      this.x2 = e.X;
      this.y2 = e.Y;
      currShape.Set(x1, y1, x2, y2);
      currShape.Show(g, pen);
    }

    public void InitPen(Color penColor, Color brushColor, DashStyle style, float size)
    {
      this.pen = new Pen(penColor);
      this.pen.DashStyle = style;
      this.pen.Width = size;
      this.brush = new SolidBrush(brushColor);
    }

    public void DisposePen()
    {
      this.pen.Dispose();
      this.brush.Dispose();
    }
  }
}
