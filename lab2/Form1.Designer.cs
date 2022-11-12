namespace lab2
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.MenuToolStrip = new System.Windows.Forms.MenuStrip();
      this.Shapes = new System.Windows.Forms.ToolStripMenuItem();
      this.rectangleItem = new System.Windows.Forms.ToolStripMenuItem();
      this.lineItem = new System.Windows.Forms.ToolStripMenuItem();
      this.elipseItem = new System.Windows.Forms.ToolStripMenuItem();
      this.dotItem = new System.Windows.Forms.ToolStripMenuItem();
      this.clearItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pictureBox = new System.Windows.Forms.PictureBox();
      this.brushSizePicker = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.MenuToolStrip.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.brushSizePicker)).BeginInit();
      this.SuspendLayout();
      // 
      // MenuToolStrip
      // 
      this.MenuToolStrip.BackColor = System.Drawing.SystemColors.ControlLight;
      this.MenuToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.MenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Shapes});
      this.MenuToolStrip.Location = new System.Drawing.Point(0, 0);
      this.MenuToolStrip.Name = "MenuToolStrip";
      this.MenuToolStrip.Size = new System.Drawing.Size(1275, 28);
      this.MenuToolStrip.TabIndex = 0;
      this.MenuToolStrip.Text = "MenuToolStrip";
      // 
      // Shapes
      // 
      this.Shapes.AutoToolTip = true;
      this.Shapes.BackColor = System.Drawing.SystemColors.InactiveCaption;
      this.Shapes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleItem,
            this.lineItem,
            this.elipseItem,
            this.dotItem,
            this.clearItem});
      this.Shapes.Name = "Shapes";
      this.Shapes.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
      this.Shapes.Size = new System.Drawing.Size(82, 24);
      this.Shapes.Text = "Форми";
      // 
      // rectangleItem
      // 
      this.rectangleItem.Name = "rectangleItem";
      this.rectangleItem.Size = new System.Drawing.Size(185, 26);
      this.rectangleItem.Text = "Прямокутник";
      this.rectangleItem.Click += new System.EventHandler(this.rectangleItem_Click);
      // 
      // lineItem
      // 
      this.lineItem.Name = "lineItem";
      this.lineItem.Size = new System.Drawing.Size(185, 26);
      this.lineItem.Text = "Лінія";
      this.lineItem.Click += new System.EventHandler(this.lineItem_Click);
      // 
      // elipseItem
      // 
      this.elipseItem.Name = "elipseItem";
      this.elipseItem.Size = new System.Drawing.Size(185, 26);
      this.elipseItem.Text = "Еліпс";
      this.elipseItem.Click += new System.EventHandler(this.elipseItem_Click);
      // 
      // dotItem
      // 
      this.dotItem.Name = "dotItem";
      this.dotItem.Size = new System.Drawing.Size(185, 26);
      this.dotItem.Text = "Крапка";
      this.dotItem.Click += new System.EventHandler(this.dotItem_Click);
      // 
      // clearItem
      // 
      this.clearItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.clearItem.Name = "clearItem";
      this.clearItem.Size = new System.Drawing.Size(185, 26);
      this.clearItem.Text = "Очистити";
      this.clearItem.Click += new System.EventHandler(this.clearItem_Click);
      // 
      // pictureBox
      // 
      this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.pictureBox.Location = new System.Drawing.Point(12, 69);
      this.pictureBox.Name = "pictureBox";
      this.pictureBox.Size = new System.Drawing.Size(1251, 616);
      this.pictureBox.TabIndex = 1;
      this.pictureBox.TabStop = false;
      this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
      this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
      this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
      // 
      // brushSizePicker
      // 
      this.brushSizePicker.DecimalPlaces = 1;
      this.brushSizePicker.Location = new System.Drawing.Point(188, 38);
      this.brushSizePicker.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
      this.brushSizePicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.brushSizePicker.Name = "brushSizePicker";
      this.brushSizePicker.Size = new System.Drawing.Size(150, 27);
      this.brushSizePicker.TabIndex = 2;
      this.brushSizePicker.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(15, 40);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(167, 20);
      this.label1.TabIndex = 3;
      this.label1.Text = "Оберіть розмір олівця";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.ClientSize = new System.Drawing.Size(1275, 697);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.brushSizePicker);
      this.Controls.Add(this.pictureBox);
      this.Controls.Add(this.MenuToolStrip);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MainMenuStrip = this.MenuToolStrip;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.MenuToolStrip.ResumeLayout(false);
      this.MenuToolStrip.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.brushSizePicker)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MenuStrip MenuToolStrip;
    private ToolStripMenuItem Shapes;
    private ToolStripMenuItem rectangleItem;
    private ToolStripMenuItem lineItem;
    private ToolStripMenuItem elipseItem;
    private ToolStripMenuItem dotItem;
    private ToolStripMenuItem clearItem;
    private PictureBox pictureBox;
    private NumericUpDown brushSizePicker;
    private Label label1;
  }
}