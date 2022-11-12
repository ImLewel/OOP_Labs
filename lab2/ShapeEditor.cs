using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace lab2
{
  abstract class ShapeEditor
  {
    protected int x1, y1, x2, y2;
    protected Pen pen;
    protected SolidBrush brush;

    public void OnMouseDown(MouseEventArgs e)
    {
      this.x1 = e.X;
      this.y1 = e.Y;
    }

    public abstract void OnMouseUp(MouseEventArgs e, Graphics g);

    public virtual void OnMouseMove(MouseEventArgs e, Graphics g)
    {
      this.OnMouseUp(e, g);
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
