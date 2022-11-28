using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using lab5.Shapes;
namespace lab5
{
  class MyEditor
  {
    private static readonly MyEditor editorInstance = new MyEditor();
    protected int x1, y1, x2, y2;
    public Shape currShape;
    protected Pen pen;
    protected SolidBrush brush;
    private MyEditor() { 
    }
    public static MyEditor Instance
    {
      get
      {
        return editorInstance;
      }
    }
    public void Start(Shape shape)
    {
      currShape = shape;
    }

    public void Start(Shape shape, int _x1, int _y1, int _x2, int _y2, Graphics g)
    {
      currShape = shape;
      this.x1 = _x1;
      this.x2 = _x2;
      this.y1 = _y1;
      this.y2 = _y2;
      currShape.Set(x1, y1, x2, y2);
      g.SmoothingMode = SmoothingMode.AntiAlias;
      currShape.Show(g, pen);
      currShape.Fill(g, brush);
    }

    public int[] GetPoints()
    {
      return new int[] { x1, y1, x2, y2 };
    }

    public void OnMouseDown(MouseEventArgs e)
    {
      if (currShape != null)
      {
        this.x1 = e.X;
        this.y1 = e.Y;
      }
    }

    public void OnMouseUp(MouseEventArgs e, Graphics g)
    {
      if (currShape != null)
      {
        this.x2 = e.X;
        this.y2 = e.Y;
        currShape.Set(x1, y1, x2, y2);
        g.SmoothingMode = SmoothingMode.AntiAlias;
        currShape.Show(g, pen);
        currShape.Fill(g, brush);
      }
    }

    public virtual void OnMouseMove(MouseEventArgs e, Graphics g)
    {
      if (currShape != null)
      {
        this.x2 = e.X;
        this.y2 = e.Y;
        currShape.Set(x1, y1, x2, y2);
        g.SmoothingMode = SmoothingMode.AntiAlias;
        currShape.Show(g, pen);
      }
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
