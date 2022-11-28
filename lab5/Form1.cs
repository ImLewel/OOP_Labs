using System.Drawing;
using System.Drawing.Drawing2D;
using lab5.Shapes;
namespace lab5
{
  public partial class Form1 : Form
  {
    MyEditor editor = MyEditor.Instance;
    MyTable ShapeTableForm = new MyTable();
    DataGridView Table;
    Button deleteBtn;
    MyToolStrip toolStrip = new();
    Graphics gfx;
    Bitmap bmp;
    Dictionary<string, Shape> shapeDict = new()
    {
      { "Крапка", new Dot() },
      { "Лінія", new Line() },
      { "Прямокутник", new RectangleShape() },
      { "Еліпс", new Elipse() },
      { "Куб", new Cube() },
      { "Гантеля", new Bar() },
    };
    public Form1()
    {
      InitializeComponent();
      Table = ShapeTableForm.dataGridView1;
      Table.CellClick += this.ShapeTable_Cell_Click;
      deleteBtn = ShapeTableForm.deleteButton;
      deleteBtn.Click += this.DeleteBtn_Click;
    }

    private void pictureBox_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        if (shapeDict.ContainsKey(Text))
        {
          editor.InitPen(Color.Black, Color.Orange, DashStyle.Solid, (float)brushSizePicker.Value);
          bmp = new(pictureBox.BackgroundImage);
          gfx = Graphics.FromImage(bmp);
          //gfx.SmoothingMode = SmoothingMode.AntiAlias;
          editor.OnMouseUp(e, gfx);
          ShapeTableForm.AddData(this.Text, editor.GetPoints(), (float)brushSizePicker.Value);
          ShapeTableForm.ShowData();
          pictureBox.Image = bmp;
          editor.DisposePen();
        }
      }
    }

    private void pictureBox_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        if (shapeDict.ContainsKey(Text))
        {
          pictureBox.BackgroundImage = pictureBox.Image != null ? pictureBox.Image : new Bitmap(Width, Height);
          editor.InitPen(Color.Black, Color.Orange, DashStyle.Dash, (float)brushSizePicker.Value);
          editor.OnMouseDown(e);
        }
      }
    }

    private void pictureBox_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        if (shapeDict.ContainsKey(Text))
        {
          bmp = new(Width, Height);
          gfx = Graphics.FromImage(bmp);
          pictureBox.Image = bmp;
          editor.OnMouseMove(e, gfx);
        }
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

    private void tableButton_Click(object sender, EventArgs e)
    {
      if (!ShapeTableForm.Visible)
      {
        tableButton.Text = "Закрити таблицю";
        ShapeTableForm.Show();
      }
      else
      {
        tableButton.Text = "Відкрити таблицю";
        ShapeTableForm.Hide();
      }
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
      Text = "Очищено";
      pictureBox.Image = null;
      pictureBox.BackgroundImage = null;
      ShapeTableForm.Clear();
    }
    private void ShapeTable_Cell_Click(object sender, DataGridViewCellEventArgs e)
    {
      SelectOrErase(false);
    }

    private void DeleteBtn_Click(object sender, EventArgs e)
    {
      SelectOrErase(true);
    }

    bool SelectOrErase(bool toDelete)
    {
      if (Table.RowCount != 0)
      {
        int currRow = Table.CurrentCell.RowIndex;
        pictureBox.Image = new Bitmap(Width, Height);
        pictureBox.BackgroundImage = pictureBox.Image;
        for (int i = 0; i < Table.RowCount; i++)
        {
          int x1 = Convert.ToInt32(Table.Rows[i].Cells[1].Value);
          int y1 = Convert.ToInt32(Table.Rows[i].Cells[2].Value);
          int x2 = Convert.ToInt32(Table.Rows[i].Cells[3].Value);
          int y2 = Convert.ToInt32(Table.Rows[i].Cells[4].Value);
          string shape = Table.Rows[i].Cells[0].Value.ToString();
          float penSize = (float)Convert.ToInt32(Table.Rows[i].Cells[5].Value);
          string? content = String.Empty;
          if (i == currRow)
          {
            editor.InitPen(Color.Red, Color.Blue, DashStyle.Solid, penSize);
            if (toDelete)
            {
              foreach (var line in File.ReadLines("Data.txt"))
              {
                if (line != $"{shape} {x1} {y1} {x2} {y2} {penSize}") content += $"{line}\n";
              }
              File.WriteAllText("Data.txt", content);
              ShapeTableForm.ShowData();
              SelectOrErase(false);
              return false;
            }
          }
          else editor.InitPen(Color.Black, Color.Orange, DashStyle.Solid, penSize);
          bmp = new(pictureBox.Image);
          gfx = Graphics.FromImage(bmp);
          editor.Start(shapeDict[shape], x1, y1, x2, y2, gfx);
          pictureBox.Image = bmp;
          editor.DisposePen();
          if (shapeDict.ContainsKey(Text)) editor.Start(shapeDict[Text]);
        }
      }
      return true;
    }
  }
}