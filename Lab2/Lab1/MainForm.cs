
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1
{
  public partial class MainForm : Form {
    private Graphics g;
    private GameField _gameField;
    private System.Drawing.Rectangle _gameFieldRectangle;
    private Rectangle[] _rectangles = new Rectangle[10];
    private Square[] _squares = new Square[10];
    private Circle[] _circles = new Circle[10];
    private Ellipse[] _ellipses = new Ellipse[10];
    private Triangle[] _triangles = new Triangle[10];

    public static readonly int PictureBoxWidth = 800;
    public static readonly int PictureBoxHeight = 600;
    public static readonly int StartPointX = 10;
    public static readonly int StartPointY = 10;
    
    // movement component
    private Timer _timer;
    private int _x, _y, _velocity = 1, _acceleration = 0;
    private const int InitialAcceleration = 1;
    
    public MainForm() {
      InitializeComponent();
      InitDisplayObjectArray();
      pictureBox1.SetBounds(StartPointX, StartPointY, PictureBoxWidth, PictureBoxHeight);

      _timer = new Timer();
      _timer.Interval = 10; // интервал обновления анимации
      _timer.Tick += timer1_Tick;
      _timer.Start();
    }

    private void MainForm_Paint(object sender, PaintEventArgs e) { 
      
    }
    
    private void pictureBox1_Paint(object sender, PaintEventArgs e) {
      /*pictureBox1.Image = new Bitmap(PictureBoxWidth, PictureBoxHeight);
      Graphics g = Graphics.FromImage(pictureBox1.Image);
      
      // TODO
      // insert into vars border width and some other stuff 
      DisplayObject gameField = new GameField(
        Color.White, 1, Color.Black, 10, PictureBoxWidth - 1, 10, PictureBoxHeight - 1
      );
      gameField.DrawFrame(g);*/
      
      //------------------------------

      /*for (int i = 0; i < 2; i++) {
        _rectangles[i].Draw(g);
        _triangles[i].Draw(g);
        //_triangles[i].DrawFrame(g);
        _circles[i].Draw(g);
        _squares[i].Draw(g);
        _ellipses[i].Draw(g);
      }*/
      
      e.Graphics.DrawRectangle(Pens.Black, _gameFieldRectangle);
      e.Graphics.FillRectangle(Brushes.Red, _x, 50, 50, 50);
      
    }

    private void InitDisplayObjectArray() {
      Random random = new Random();
      
      _gameField = new GameField(
        Color.White, 1, Color.Black, 
        StartPointX, pictureBox1.Width - StartPointX, 
        StartPointY, pictureBox1.Height - StartPointY
      );

      _gameFieldRectangle =
        new System.Drawing.Rectangle(_gameField.X1, _gameField.Y1, _gameField.BorderWidth, _gameField.BorderHeight
      );
      
       for (int i = 0; i < 2; i++) {
        _rectangles[i] = new Rectangle( 
          Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)), 
          random.Next(1, 10), 
          Color.FromArgb(random.Next(1, 255), random.Next(1, 255), random.Next(1, 255)),
          random.Next(10, PictureBoxWidth), random.Next(10, PictureBoxHeight), 
          random.Next(10, 200), random.Next(10, 200)
        );

        _triangles[i] = new Triangle(
          Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)),
          random.Next(1, 3),
          Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)),
          random.Next(10, PictureBoxWidth), random.Next(10, PictureBoxHeight),
          random.Next(10, PictureBoxWidth), random.Next(10, PictureBoxHeight),
          random.Next(10, PictureBoxWidth), random.Next(10, PictureBoxHeight)
        );
        
        _circles[i] = new Circle(
          Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)), 
          random.Next(0, 10), 
          Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)), 
          random.Next(10, 100)
        );

        _squares[i] = new Square(
          Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)), 
          random.Next(0, 10), 
          Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)), 
          random.Next(10, 100)
        );

        _ellipses[i] = new Ellipse(
          Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)), 
          random.Next(0, 10), 
          Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)), 
          random.Next(5, 200), random.Next(5, 200)
        );
      }
    }

    private void timer1_Tick(object sender, EventArgs e) {
      // Обновляем позицию прямоугольника с учетом равноускоренного движения
      _x += _velocity;
      _velocity += _acceleration;

      // Ограничиваем движение прямоугольника в PictureBox
      if (_x > pictureBox1.Width - 50 - StartPointX) // 50 - ширина прямоугольника
      {
        _x = pictureBox1.Width - 50 - StartPointX;
        _velocity = -_velocity; // меняем направление движения при столкновении со стеной
      }
      else if (_x < StartPointX)
      {
        _x = StartPointX;
        _velocity = -_velocity; // меняем направление движения при столкновении со стеной
      }

      pictureBox1.Invalidate(); // Обновляем PictureBox
    }
  }
}
