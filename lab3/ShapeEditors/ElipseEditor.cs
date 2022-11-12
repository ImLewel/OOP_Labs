using System.Drawing;
using System.Windows.Forms;
using lab3.Shapes;

namespace lab3.ShapeEditors
{
  class ElipseEditor : ShapeEditor
  {
    public override void OnMouseUp(MouseEventArgs e, Graphics g)
    {
      this.x2 = e.X;
      this.y2 = e.Y;

      Elipse ellipseShape = new Elipse();
      ellipseShape.Set(this.x1, this.y1, this.x2, this.y2);
      ellipseShape.Fill(g, brush);
      ellipseShape.Show(g, pen);
    }

    public override void OnMouseMove(MouseEventArgs e, Graphics g)
    {
      this.x2 = e.X;
      this.y2 = e.Y;

      Elipse ellipseShape = new Elipse();
      ellipseShape.Set(this.x1, this.y1, this.x2, this.y2);
      ellipseShape.Show(g, pen);
    }
  }
}
