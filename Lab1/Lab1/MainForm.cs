
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1
{
  public partial class MainForm : Form {
    private Graphics g;
    private Rectangle[] _rectangles = new Rectangle[10];
    private Square[] _squares = new Square[10];
    private Circle[] _circles = new Circle[10];
    private Ellipse[] _ellipses = new Ellipse[10];
    private Triangle[] _triangles = new Triangle[10];

    public static readonly int PictureBoxWidth = 850;
    public static readonly int PictureBoxHeight = 600;

    public MainForm() {
      InitializeComponent();
      InitDisplayObjectArray();
      pictureBox1.SetBounds(10, 10, PictureBoxWidth, PictureBoxHeight);
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
      
      //------------------------------

      for (int i = 0; i < 10; i++) {
        _rectangles[i].Draw(g);
        _triangles[i].Draw(g);
        _circles[i].Draw(g);
        _squares[i].Draw(g);
        _ellipses[i].Draw(g);
      }

      /*Rectangle rectangle = new Rectangle(
        new Point(0, 0),  Color.Black, 10, Color.Blue, 
        900, 900, 150, 150
      );
      rectangle.Draw(g);*/
      
    }

    private void InitDisplayObjectArray() {
      Random random = new Random();
      
       for (int i = 0; i < 10; i++) {
        _rectangles[i] = new Rectangle(
          new Point(random.Next(50, pictureBox1.Size.Width), random.Next(0, pictureBox1.Size.Width)), 
          Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)), 
          random.Next(1, 10), 
          Color.FromArgb(random.Next(1, 255), random.Next(1, 255), random.Next(1, 255)),
          random.Next(10, PictureBoxWidth), random.Next(10, PictureBoxHeight), 
          random.Next(10, 200), random.Next(10, 200)
        );

        _triangles[i] = new Triangle(
          new Point(random.Next(50, pictureBox1.Size.Width), random.Next(50, pictureBox1.Size.Width)), 
          Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)), 
          random.Next(1, 3), 
          Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)), 
          new Point(random.Next(10, PictureBoxWidth), random.Next(10, PictureBoxHeight)), 
          new Point(random.Next(10, PictureBoxWidth), random.Next(10, PictureBoxHeight)), 
          new Point(random.Next(10, PictureBoxWidth), random.Next(10, PictureBoxHeight))
        );
        
        _circles[i] = new Circle(
          new Point(random.Next(10, PictureBoxWidth), random.Next(10, PictureBoxHeight)), 
          Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)), 
          random.Next(0, 10), 
          Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)), 
          random.Next(10, 100)
        );

        _squares[i] = new Square(
          new Point(random.Next(0, PictureBoxWidth), random.Next(0, PictureBoxHeight)), 
          Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)), 
          random.Next(0, 10), 
          Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)), 
          random.Next(10, 100)
        );

        _ellipses[i] = new Ellipse(
          new Point(random.Next(0, PictureBoxWidth), random.Next(0, PictureBoxHeight)), 
          Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)), 
          random.Next(0, 10), 
          Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)), 
          random.Next(5, 200), random.Next(5, 200)
        );
      }
    }
    
  }
}
