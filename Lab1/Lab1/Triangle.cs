using System;
using System.Drawing;

namespace Lab1 {
    public class Triangle : DisplayObject {
        private Point _point1;
        private Point _point2;
        private Point _point3;
        
        public Triangle(Point mainPoint, Color color, int borderThickness, Color borderColor, Point frameMainPoint, Point point1, Point point2, Point point3) : base(mainPoint, color, borderThickness, borderColor, frameMainPoint) {
            _point1 = point1;
            _point2 = point2;
            _point3 = point3;
        }

        public override void Draw(Graphics g) {

            var points = new Point[] {
                _point1, _point2, _point3
            };
            int lowestX = 1000, highestX = -1;
            int lowestY = 1000, highestY = -1;
            int highestDistance = -1;
            Point startPoint = new Point();
            
            System.Drawing.Rectangle backRect = new System.Drawing.Rectangle();

            for (int i = 0; i < points.Length; i++) {
                if (points[i].X > highestX) 
                    highestX = points[i].X;
                if (points[i].X < lowestX) 
                    lowestX = points[i].X;
                if (points[i].Y > highestY) 
                    highestY = points[i].Y;
                if (points[i].Y < lowestY) 
                    lowestY = points[i].Y;
            }

            int widthBackRect = highestX - lowestX;
            int heightBackRect = highestY - lowestY;

            for (int i = 0; i < points.Length; i++) {
                if (points[i].X == lowestX && points[i].Y == lowestY) {
                    startPoint = points[i];
                    backRect.X = startPoint.X;
                    backRect.Y = startPoint.Y;
                    break;
                }
                if (points[i].X == lowestX && points[i].Y == highestY) {
                    startPoint = points[i];
                    backRect.X = startPoint.X;
                    backRect.Y = startPoint.Y - heightBackRect;
                    break;
                }
                if (points[i].X == highestX && points[i].Y == lowestY) {
                    startPoint = points[i];
                    backRect.X = startPoint.X - widthBackRect;
                    backRect.Y = startPoint.Y;
                    break;
                }
                if (points[i].X == highestX && points[i].Y == highestY) {
                    startPoint = points[i];
                    backRect.X = startPoint.X - widthBackRect;
                    backRect.Y = startPoint.Y - heightBackRect;
                    break;
                }
            }

            backRect.Width = widthBackRect;
            backRect.Height = heightBackRect;
            
            Pen tempPen = new Pen(BorderColor, BorderThickness);
            Brush tempBrush = new SolidBrush(MainColor);

            Pen backPen = new Pen(Color.Crimson, 0);
            Brush backBrush = new SolidBrush(Color.Yellow);
            
            g.DrawRectangle(backPen, backRect);
            g.FillRectangle(backBrush, backRect);
            g.DrawPolygon(tempPen, points);
            g.FillPolygon(tempBrush, points);
        }
    }
}