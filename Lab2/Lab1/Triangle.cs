using System.Drawing;

namespace Lab1 {
    public class Triangle : DisplayObject {

        private int _x1, _y1;
        private int _x2, _y2;
        private int _x3, _y3;

        private Point[] _points;
        
        public Triangle(Color color, int borderThickness, Color borderColor, 
            int x1, int y1, int x2, int y2, int x3, int y3) 
            : base(color, borderThickness, borderColor) {
            
            _x1 = x1;
            _y1 = y1;
            _x2 = x2;
            _y2 = y2;
            _x3 = x3;
            _y3 = y3;


            InitFrame();
        }

        public override void Draw(Graphics g) {
            
            Pen tempPen = new Pen(BorderColor, BorderThickness);
            Brush tempBrush = new SolidBrush(MainColor);

            g.DrawPolygon(tempPen, _points);
            g.FillPolygon(tempBrush, _points);
        }

        public sealed override void InitFrame() {
            
            int lowestX = 1000, highestX = -1;
            int lowestY = 1000, highestY = -1;

            _points = new Point[] { new Point(_x1, _y1), new Point(_x2, _y2), new Point(_x3, _y3) };
            
            for (int i = 0; i < _points.Length; i++) {
                if (_points[i].X > highestX) 
                    highestX = _points[i].X;
                if (_points[i].X < lowestX) 
                    lowestX = _points[i].X;
                if (_points[i].Y > highestY) 
                    highestY = _points[i].Y;
                if (_points[i].Y < lowestY) 
                    lowestY = _points[i].Y;
            }

            BorderWidth = highestX - lowestX;
            BorderHeight = highestY - lowestY;

            for (int i = 0; i < _points.Length; i++) {
                if (_points[i].X == lowestX && _points[i].Y == lowestY) {
                    FrameMainPoint = _points[i];
                    break;
                }
                if (_points[i].X == lowestX && _points[i].Y == highestY) {
                    FrameMainPoint = _points[i];
                    var point = FrameMainPoint;
                    point.Y = FrameMainPoint.Y - BorderHeight;
                    FrameMainPoint = point;
                    break;
                }
                if (_points[i].X == highestX && _points[i].Y == lowestY) {
                    FrameMainPoint = _points[i];
                    var point = FrameMainPoint;
                    point.X = FrameMainPoint.X - BorderWidth;
                    FrameMainPoint = point;
                    break;
                }
                if (_points[i].X == highestX && _points[i].Y == highestY) {
                    FrameMainPoint = _points[i];
                    var point1 = FrameMainPoint;
                    point1.X = FrameMainPoint.X - BorderWidth;
                    FrameMainPoint = point1;
                    var point2 = FrameMainPoint;
                    point2.Y = FrameMainPoint.Y - BorderHeight;
                    FrameMainPoint = point2;
                    break;
                }
            }
        }

        public override void CheckCollision() {
            
        }
    }
}