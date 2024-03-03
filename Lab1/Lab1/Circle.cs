using System.Drawing;

namespace Lab1 {
    public class Circle : DisplayObject {
        private int _radius;

        public int Radius {
            get => _radius;
            set => _radius = value;
        }

        public Circle(Point mainPoint, Color color, int borderThickness, 
            Color borderColor, int radius) : 
            base(mainPoint, color, borderThickness, borderColor) {
            _radius = radius;
            InitFrame();
        }

        public override void Draw(Graphics g) {
            Pen tempPen = new Pen(BorderColor);
            Brush tempBrush = new SolidBrush(MainColor);
            System.Drawing.Rectangle tempRect = new System.Drawing.Rectangle(
                FrameMainPoint, new Size(BorderWidth, BorderHeight));

            g.DrawEllipse(tempPen, tempRect);
            g.FillEllipse(tempBrush, tempRect);
            
        }

        // If ellipse inherits circle class it will be better to get rid of sealed
        public sealed override void InitFrame() {
            BorderWidth = Radius << 1;
            BorderHeight = Radius << 1;
            FrameMainPoint = new Point(MainPoint.X - Radius, MainPoint.Y - Radius);
        }
    }
}