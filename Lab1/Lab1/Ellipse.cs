using System.Drawing;

namespace Lab1 {
    public class Ellipse : DisplayObject {
        private int _width;
        private int _height;

        public int Width {
            get => _width;
            set => _width = value;
        }

        public int Height {
            get => _height;
            set => _height = value;
        }

        public Ellipse(Point mainPoint, Color color, int borderThickness, 
            Color borderColor, int width, int height) 
            : base(mainPoint, color, borderThickness, borderColor) {
            _width = width;
            _height = height;
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

        public sealed override void InitFrame() {
            BorderWidth = _width;
            BorderHeight = _height;
            FrameMainPoint = new Point(
                MainPoint.X - (BorderWidth >> 1), MainPoint.X - (BorderHeight >> 1)
            );
        }
    }
}