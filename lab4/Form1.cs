using System.Drawing;
using System.Drawing.Drawing2D;
using lab4.Shapes;
namespace lab4
{
  public partial class Form1 : Form
  {
    MyEditor editor = new();
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
        editor.InitPen(Color.Black, Color.Orange, DashStyle.Solid, (float)brushSizePicker.Value);
        bmp = new(pictureBox.BackgroundImage);
        gfx = Graphics.FromImage(bmp);
        gfx.SmoothingMode = SmoothingMode.AntiAlias;
        editor.OnMouseUp(e, gfx);
        pictureBox.Image = bmp;
        editor.DisposePen();
      }
    }

    private void pictureBox_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        pictureBox.BackgroundImage = pictureBox.Image != null ? pictureBox.Image : new Bitmap(Width, Height);
        editor.InitPen(Color.Black, Color.Orange, DashStyle.Dash, (float)brushSizePicker.Value);
        editor.OnMouseDown(e);
      }
    }

    private void pictureBox_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        bmp = new(Width, Height);
        gfx = Graphics.FromImage(bmp);
        pictureBox.Image = bmp;
        editor.OnMouseMove(e, gfx);
      }
    }
    private void dotButton_Click(object sender, EventArgs e)
    {
      toolStrip.Button((sender as ToolStripButton).ToolTipText);
      editor.Start(new Dot());
    }

    private void lineButton_Click(object sender, EventArgs e)
    {
      toolStrip.Button((sender as ToolStripButton).ToolTipText);
      editor.Start(new Line());
    }

    private void rectangleButton_Click(object sender, EventArgs e)
    {
      toolStrip.Button((sender as ToolStripButton).ToolTipText);
      editor.Start(new RectangleShape());
    }

    private void elipseButton_Click(object sender, EventArgs e)
    {
      toolStrip.Button((sender as ToolStripButton).ToolTipText);
      editor.Start(new Elipse());
    }

    private void cubeButton_Click(object sender, EventArgs e)
    {
      toolStrip.Button((sender as ToolStripButton).ToolTipText);
      editor.Start(new Cube());
    }

    private void barButton_Click(object sender, EventArgs e)
    {
      toolStrip.Button((sender as ToolStripButton).ToolTipText);
      editor.Start(new Bar());
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
      Text = "Очищено";
      pictureBox.Image = null;
      pictureBox.BackgroundImage = null;
    }

  }
}