using System.Drawing;
using System.Drawing.Drawing2D;

namespace lab3
{
  public partial class Form1 : Form
  {
    ShapeObjectsEditor shapeObjectsEditor = new();
    MyToolStrip toolStrip = new();
    Graphics gfx;
    Bitmap bmp;
    public Form1()
    {
      InitializeComponent();
    }

    private void pictureBox_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        shapeObjectsEditor.InitPen(Color.Black, Color.Orange, DashStyle.Solid, (float)brushSizePicker.Value);
        bmp = new(pictureBox.BackgroundImage);
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
        bmp = new(Width, Height);
        gfx = Graphics.FromImage(bmp);
        pictureBox.Image = bmp;
        shapeObjectsEditor.OnMouseMove(e, gfx);
      }
    }

    private void dotButton_Click(object sender, EventArgs e)
    {
      toolStrip.Dot(shapeObjectsEditor);
    }

    private void lineButton_Click(object sender, EventArgs e)
    {
      toolStrip.Line(shapeObjectsEditor);
    }

    private void rectangleButton_Click(object sender, EventArgs e)
    {
      toolStrip.Rectangle(shapeObjectsEditor);
    }

    private void elipseButton_Click(object sender, EventArgs e)
    {
      toolStrip.Elipse(shapeObjectsEditor);
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
      Text = "Очищено";
      pictureBox.Image = null;
      pictureBox.BackgroundImage = null;
    }
  }
}