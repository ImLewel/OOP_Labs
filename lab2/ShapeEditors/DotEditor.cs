using System.Drawing;
using System.Windows.Forms;
using lab2.Shapes;

namespace lab2.ShapeEditors
{
  class DotEditor : ShapeEditor
  {
    public override void OnMouseUp(MouseEventArgs e, Graphics g)
    {
      this.x2 = e.X;
      this.y2 = e.Y;

      Pen newPen = new Pen(Color.Black, 3f);

      Dot DotShape = new Dot();
      DotShape.Set(this.x1, this.y1, this.x2, this.y2);
      DotShape.Show(g, newPen);

      newPen.Dispose();
    }
  }
}
