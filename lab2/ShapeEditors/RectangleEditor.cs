using System.Drawing;
using System.Windows.Forms;
using lab2.Shapes;

namespace lab2.ShapeEditors
{
  class RectangleEditor : ShapeEditor
  {
    public override void OnMouseUp(MouseEventArgs e, Graphics g)
    {
      this.x2 = e.X;
      this.y2 = e.Y;

      RectangleShape rectangleShape = new RectangleShape();
      rectangleShape.Set(this.x1, this.y1, this.x2, this.y2);
      rectangleShape.Show(g, pen);
    }
  }
}
