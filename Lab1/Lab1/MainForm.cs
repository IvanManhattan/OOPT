
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
      DisplayObject mainFrameRectangle = new Rectangle(
        new Point(10, 10), Color.White, 1, Color.Black,
        pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Size.Width - 12, pictureBox1.Size.Height - 12
      );
      mainFrameRectangle.DrawFrame(g);
      
      /*DisplayObject rect = new Rectangle(
        new Point(10, 10), Color.Red, 14, Color.Blue,
        10, 10, 80, 200);
      rect.Draw(g);
      //rect.DrawFrame(g);

      DisplayObject triangle = new Triangle(
        new Point(100, 100), Color.Green, 0, Color.Bisque, 
        new Point(100, 100), new Point(150, 150), new Point(200, 100));
      triangle.Draw(g);
      //triangle.DrawFrame(g);
      
      DisplayObject triangle2 = new Triangle(
        new Point(100, 100), Color.Orange, 0, Color.Bisque, 
        new Point(500, 100), new Point(250, 150), new Point(400, 400));
      triangle2.Draw(g);
      //triangle2.DrawFrame(g);

      DisplayObject cirlce = new Circle(
        new Point(200, 400), Color.Chartreuse, 
        5, Color.Aqua, 120
      );
      cirlce.Draw(g);
      //ellipse.DrawFrame(g);

      DisplayObject square = new Square(new Point(220, 220), Color.Gold, 6, Color.Chocolate, 200);
      square.Draw(g);
      //square.DrawFrame(g);

      DisplayObject ellipse = new Ellipse(new Point(600, 600), Color.Coral, 8, Color.Firebrick, 400, 100);
      ellipse.Draw(g);
      ellipse.DrawFrame(g);*/
      
      
      
    }
  }
}
