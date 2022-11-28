namespace lab5
{
  partial class MyTable
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.shapeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shape_x1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shape_y1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shape_x2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shape_y2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shape_penSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.deleteButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AllowUserToResizeColumns = false;
      this.dataGridView1.AllowUserToResizeRows = false;
      this.dataGridView1.ColumnHeadersHeight = 30;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shapeName,
            this.shape_x1,
            this.shape_y1,
            this.shape_x2,
            this.shape_y2,
            this.shape_penSize});
      this.dataGridView1.Location = new System.Drawing.Point(0, 0);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.RowHeadersWidth = 60;
      this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dataGridView1.RowTemplate.Height = 29;
      this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.dataGridView1.Size = new System.Drawing.Size(865, 450);
      this.dataGridView1.TabIndex = 0;
      // 
      // shapeName
      // 
      this.shapeName.Frozen = true;
      this.shapeName.HeaderText = "Назва";
      this.shapeName.MinimumWidth = 6;
      this.shapeName.Name = "shapeName";
      this.shapeName.ReadOnly = true;
      this.shapeName.Width = 125;
      // 
      // shape_x1
      // 
      this.shape_x1.Frozen = true;
      this.shape_x1.HeaderText = "x1";
      this.shape_x1.MinimumWidth = 6;
      this.shape_x1.Name = "shape_x1";
      this.shape_x1.ReadOnly = true;
      this.shape_x1.Width = 125;
      // 
      // shape_y1
      // 
      this.shape_y1.Frozen = true;
      this.shape_y1.HeaderText = "y1";
      this.shape_y1.MinimumWidth = 6;
      this.shape_y1.Name = "shape_y1";
      this.shape_y1.ReadOnly = true;
      this.shape_y1.Width = 125;
      // 
      // shape_x2
      // 
      this.shape_x2.Frozen = true;
      this.shape_x2.HeaderText = "x2";
      this.shape_x2.MinimumWidth = 6;
      this.shape_x2.Name = "shape_x2";
      this.shape_x2.ReadOnly = true;
      this.shape_x2.Width = 125;
      // 
      // shape_y2
      // 
      this.shape_y2.Frozen = true;
      this.shape_y2.HeaderText = "y2";
      this.shape_y2.MinimumWidth = 6;
      this.shape_y2.Name = "shape_y2";
      this.shape_y2.ReadOnly = true;
      this.shape_y2.Width = 125;
      // 
      // shape_penSize
      // 
      this.shape_penSize.Frozen = true;
      this.shape_penSize.HeaderText = "Розмір олівця";
      this.shape_penSize.MinimumWidth = 6;
      this.shape_penSize.Name = "shape_penSize";
      this.shape_penSize.ReadOnly = true;
      this.shape_penSize.Width = 125;
      // 
      // deleteButton
      // 
      this.deleteButton.Location = new System.Drawing.Point(760, 0);
      this.deleteButton.Name = "deleteButton";
      this.deleteButton.Size = new System.Drawing.Size(94, 29);
      this.deleteButton.TabIndex = 1;
      this.deleteButton.Text = "Видалити";
      this.deleteButton.UseVisualStyleBackColor = true;
      // 
      // MyTable
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(866, 450);
      this.ControlBox = false;
      this.Controls.Add(this.deleteButton);
      this.Controls.Add(this.dataGridView1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MyTable";
      this.Text = "Таблиця фігур";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    internal DataGridView dataGridView1;
    private DataGridViewTextBoxColumn shapeName;
    private DataGridViewTextBoxColumn shape_x1;
    private DataGridViewTextBoxColumn shape_y1;
    private DataGridViewTextBoxColumn shape_x2;
    private DataGridViewTextBoxColumn shape_y2;
    private DataGridViewTextBoxColumn shape_penSize;
    internal Button deleteButton;
  }
}