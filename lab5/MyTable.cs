namespace lab5
{
  public partial class MyTable : Form
  {
    public MyTable()
    {
      InitializeComponent();
      File.WriteAllText("Data.txt", String.Empty);
    }

    public void AddData(string name, int[] arr, float penSize)
    {
      if (arr[0] != 0)
      {
        File.AppendAllText("Data.txt", $"{name} {arr[0]} {arr[1]} {arr[2]} {arr[3]} {penSize}\n");
      }
    }

    public void ShowData()
    {
      dataGridView1.Rows.Clear();
      foreach (var line in File.ReadLines("Data.txt"))
      {
        var array = line.Split();
        dataGridView1.Rows.Add(array);
        //dataGridView1.ClearSelection();
      }
    }

    public void Clear()
    {
      File.WriteAllText("Data.txt", String.Empty);
      ShowData();
    }

    private void MyTable_FormClosing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = true;
      Hide();
    }
  }
}
