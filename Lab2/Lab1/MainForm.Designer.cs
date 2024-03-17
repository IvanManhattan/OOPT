using System.Windows.Forms;

namespace Lab1
{
  partial class MainForm
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
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(10, 10);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
      this.pictureBox1.MaximumSize = new System.Drawing.Size(800, 600);
      this.pictureBox1.MinimumSize = new System.Drawing.Size(800, 600);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(800, 600);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 16;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(1182, 865);
      this.Controls.Add(this.pictureBox1);
      this.Location = new System.Drawing.Point(15, 15);
      this.Name = "MainForm";
      this.Text = "Geometry";
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Timer timer1;

    private System.Windows.Forms.PictureBox pictureBox1;

    #endregion
  }
}

