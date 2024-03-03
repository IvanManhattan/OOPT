using System.Drawing;

namespace Lab1 {
    public class Triangle : DisplayObject {

        private Point[] _points = new Point[3];

        public Point[] Points {
            get => _points;
            set => _points = value;
        }

        public Triangle(Point mainPoint, Color color, int borderThickness, Color borderColor, 
            Point point1, Point point2, Point point3) 
            : base(mainPoint, color, borderThickness, borderColor) {
            
            _points[0] = point1;
            _points[1] = point2;
            _points[2] = point3;
            
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
    }
}