using System.Drawing;

namespace lab4
{
  abstract class Shape
  {
    public int x1, y1, x2, y2;

    public void Set(int _x1, int _y1, int _x2, int _y2)
    {
      this.x1 = _x1;
      this.y1 = _y1;
      this.x2 = _x2;
      this.y2 = _y2;
    }

    public abstract void Show(Graphics g, Pen pen);
    public virtual void Fill(Graphics g, SolidBrush brush) { }
  }
}