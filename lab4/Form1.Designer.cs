namespace lab4
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.pictureBox = new System.Windows.Forms.PictureBox();
      this.brushSizePicker = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.dotButton = new System.Windows.Forms.ToolStripButton();
      this.lineButton = new System.Windows.Forms.ToolStripButton();
      this.rectangleButton = new System.Windows.Forms.ToolStripButton();
      this.elipseButton = new System.Windows.Forms.ToolStripButton();
      this.cubeButton = new System.Windows.Forms.ToolStripButton();
      this.barButton = new System.Windows.Forms.ToolStripButton();
      this.clearButton = new System.Windows.Forms.ToolStripButton();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.brushSizePicker)).BeginInit();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
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
      // toolStrip1
      // 
      this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dotButton,
            this.lineButton,
            this.rectangleButton,
            this.elipseButton,
            this.cubeButton,
            this.barButton,
            this.clearButton});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(1275, 27);
      this.toolStrip1.TabIndex = 4;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // dotButton
      // 
      this.dotButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.dotButton.Image = ((System.Drawing.Image)(resources.GetObject("dotButton.Image")));
      this.dotButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.dotButton.Name = "dotButton";
      this.dotButton.Size = new System.Drawing.Size(29, 24);
      this.dotButton.Text = "Крапка";
      this.dotButton.Click += new System.EventHandler(this.dotButton_Click);
      // 
      // lineButton
      // 
      this.lineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.lineButton.Image = ((System.Drawing.Image)(resources.GetObject("lineButton.Image")));
      this.lineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.lineButton.Name = "lineButton";
      this.lineButton.Size = new System.Drawing.Size(29, 24);
      this.lineButton.Text = "Лінія";
      this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
      // 
      // rectangleButton
      // 
      this.rectangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.rectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("rectangleButton.Image")));
      this.rectangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.rectangleButton.Name = "rectangleButton";
      this.rectangleButton.Size = new System.Drawing.Size(29, 24);
      this.rectangleButton.Text = "Прямокутник";
      this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
      // 
      // elipseButton
      // 
      this.elipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.elipseButton.Image = ((System.Drawing.Image)(resources.GetObject("elipseButton.Image")));
      this.elipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.elipseButton.Name = "elipseButton";
      this.elipseButton.Size = new System.Drawing.Size(29, 24);
      this.elipseButton.Text = "Еліпс";
      this.elipseButton.Click += new System.EventHandler(this.elipseButton_Click);
      // 
      // cubeButton
      // 
      this.cubeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.cubeButton.Image = ((System.Drawing.Image)(resources.GetObject("cubeButton.Image")));
      this.cubeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.cubeButton.Name = "cubeButton";
      this.cubeButton.Size = new System.Drawing.Size(29, 24);
      this.cubeButton.Text = "toolStripButton1";
      this.cubeButton.ToolTipText = "Куб";
      this.cubeButton.Click += new System.EventHandler(this.cubeButton_Click);
      // 
      // barButton
      // 
      this.barButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.barButton.Image = ((System.Drawing.Image)(resources.GetObject("barButton.Image")));
      this.barButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.barButton.Name = "barButton";
      this.barButton.Size = new System.Drawing.Size(29, 24);
      this.barButton.Text = "toolStripButton2";
      this.barButton.ToolTipText = "Лінія з кружками";
      this.barButton.Click += new System.EventHandler(this.barButton_Click);
      // 
      // clearButton
      // 
      this.clearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.clearButton.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.Image")));
      this.clearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.clearButton.Name = "clearButton";
      this.clearButton.Size = new System.Drawing.Size(29, 24);
      this.clearButton.Text = "Очистити";
      this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.ClientSize = new System.Drawing.Size(1275, 697);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.brushSizePicker);
      this.Controls.Add(this.pictureBox);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "Form1";
      this.Text = "Оберіть фігуру";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.brushSizePicker)).EndInit();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private PictureBox pictureBox;
    private NumericUpDown brushSizePicker;
    private Label label1;
    private ToolStrip toolStrip1;
    private ToolStripButton dotButton;
    private ToolStripButton lineButton;
    private ToolStripButton rectangleButton;
    private ToolStripButton elipseButton;
    private ToolStripButton clearButton;
    private ToolStripButton cubeButton;
    private ToolStripButton barButton;
  }
}