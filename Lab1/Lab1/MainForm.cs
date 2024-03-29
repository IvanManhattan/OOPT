﻿
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

    public static readonly int PictureBoxWidth = 800;
    public static readonly int PictureBoxHeight = 600;

    public MainForm() {
      InitializeComponent();
      InitDisplayObjectArray();
      //Size = new Size(1200, 900);
      pictureBox1.SetBounds(10, 10, PictureBoxWidth, PictureBoxHeight);
    }

    private void MainForm_Paint(object sender, PaintEventArgs e) { 
      
    }

    private void pictureBox1_Paint(object sender, PaintEventArgs e) {
      pictureBox1.Image = new Bitmap(PictureBoxWidth, PictureBoxHeight);
      Graphics g = Graphics.FromImage(pictureBox1.Image);
      
      // TODO
      // insert into vars border width and some other stuff 
      DisplayObject gameField = new GameField(Color.White, 1, Color.Black, 10, PictureBoxWidth - 1, 10, PictureBoxHeight - 1);
      gameField.DrawFrame(g);
      
      //------------------------------

      /*for (int i = 0; i < 2; i++) {
        _rectangles[i].Draw(g);
        _triangles[i].Draw(g);
        //_triangles[i].DrawFrame(g);
        _circles[i].Draw(g);
        _squares[i].Draw(g);
        _ellipses[i].Draw(g);
      }*/

      //_triangles[0] = new Triangle(new Point(0, 0), Color.Wheat, 1, Color.Black, 70, 70, 120, 160, 200, 200);

      
      /*Rectangle rectangle = new Rectangle(
        new Point(0, 0),  Color.Black, 10, Color.Blue, 
        900, 900, 150, 150
      );
      rectangle.Draw(g);*/
      
    }

    private void InitDisplayObjectArray() {
      Random random = new Random();
      
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
    
  }
}
