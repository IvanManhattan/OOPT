
using System.Drawing;
using System.Windows.Forms;

namespace Lab1
{
  public partial class MainForm : Form {
    private Graphics g;
    public MainForm() {
      InitializeComponent();
    }

    private void MainForm_Paint(object sender, PaintEventArgs e) { 
      
    }

    private void pictureBox1_Paint(object sender, PaintEventArgs e) {
      
      pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
      Graphics g = Graphics.FromImage(pictureBox1.Image);
      DisplayObject rect = new Rectangle(new Point(10, 10), Color.Red, 14, Color.Blue,
          new Point(0, 0), 10, 10, 80, 200);
      rect.Draw(g);

      DisplayObject triangle = new Triangle(new Point(100, 100), Color.Green, 0, Color.Bisque,
        new Point(100, 100), new Point(100, 100), new Point(150, 150), new Point(200, 100));
      triangle.Draw(g);
    }
  }
}
