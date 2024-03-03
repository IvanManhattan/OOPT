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
            CheckCollision();
            FrameMainPoint = new Point(
                MainPoint.X - (BorderWidth >> 1), MainPoint.Y - (BorderHeight >> 1)
            );
        }

        public override void CheckCollision() {
            if (MainPoint.X + _width >= MainForm.PictureBoxWidth) {
                var point = MainPoint;
                point.X = MainForm.PictureBoxWidth - _width - BorderThickness / 2;
                MainPoint = point;
            }
            if (MainPoint.Y + _height >= MainForm.PictureBoxHeight) {
                var point = MainPoint;
                point.Y = MainForm.PictureBoxHeight - _height - BorderThickness / 2;
                MainPoint = point;
            }
            if (MainPoint.X - _width <= 0) {
                var point = MainPoint;
                point.X = 10 + _width + BorderThickness;
                MainPoint = point;
            }
            if (MainPoint.Y - _height <= 0) {
                var point = MainPoint;
                point.Y = 10 + _height + BorderThickness;
                MainPoint = point;
            }
        }
    }
}