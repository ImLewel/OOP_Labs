using System.Drawing;
using System.Drawing.Drawing2D;

namespace lab2
{
  public partial class Form1 : Form
  {
    ShapeObjectsEditor shapeObjectsEditor = new ShapeObjectsEditor();
    Graphics gfx;
    Bitmap bmp;
    public Form1()
    {
      InitializeComponent();
    }

    private void rectangleItem_Click(object sender, EventArgs e)
    {
      Text = "Прямокутник";
      shapeObjectsEditor.RectangleEditor();
    }

    private void lineItem_Click(object sender, EventArgs e)
    {
      Text = "Лінія";
      shapeObjectsEditor.LineEditor();
    }

    private void elipseItem_Click(object sender, EventArgs e)
    {
      Text = "Еліпс";
      shapeObjectsEditor.ElipseEditor();
    }

    private void pictureBox_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        shapeObjectsEditor.InitPen(Color.Black, Color.Orange, DashStyle.Solid, (float)brushSizePicker.Value);
        bmp = new Bitmap(pictureBox.BackgroundImage);
        gfx = Graphics.FromImage(bmp);
        gfx.SmoothingMode = SmoothingMode.AntiAlias;
        shapeObjectsEditor.OnMouseUp(e, gfx);
        pictureBox.Image = bmp;
        shapeObjectsEditor.DisposePen();
      }
    }

    private void pictureBox_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        pictureBox.BackgroundImage = pictureBox.Image != null ? pictureBox.Image : new Bitmap(Width, Height);
        shapeObjectsEditor.InitPen(Color.Black, Color.Orange, DashStyle.Dash, (float)brushSizePicker.Value);
        shapeObjectsEditor.OnMouseDown(e);
      }
    }

    private void pictureBox_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        bmp = new Bitmap(Width, Height);
        gfx = Graphics.FromImage(bmp);
        pictureBox.Image = bmp;
        shapeObjectsEditor.OnMouseMove(e, gfx);
      }
    }

    private void dotItem_Click(object sender, EventArgs e)
    {
      Text = "Крапка";
      shapeObjectsEditor.DotEditor();
    }

    private void clearItem_Click(object sender, EventArgs e)
    {
      Text = "Очищено";
      pictureBox.Image = null;
      pictureBox.BackgroundImage = null;
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}