using System.Drawing;

namespace Lab1 {
    public class GameField : DisplayObject {
        private int _x1, _x2, _y1, _y2;

        public int X1 {
            get => _x1;
            set => _x1 = value;
        }

        public int X2 {
            get => _x2;
            set => _x2 = value;
        }

        public int Y1 {
            get => _y1;
            set => _y1 = value;
        }

        public int Y2 {
            get => _y2;
            set => _y2 = value;
        }

        public GameField(Color color, int borderThickness, Color borderColor, int x1, int x2, int y1, int y2)
            : base(color, borderThickness, borderColor) {
            _x1 = x1;
            _x2 = x2;
            _y1 = y1;
            _y2 = y2;

            InitFrame();
        }

        public override void Draw(Graphics g) {
            System.Drawing.Rectangle tempRect = new System.Drawing.Rectangle();
            tempRect.Width = BorderWidth;
            tempRect.Height = BorderHeight;
            tempRect.X = FrameMainPoint.X;
            tempRect.Y = FrameMainPoint.Y;

            Pen tempPen = new Pen(BorderColor, BorderThickness);
            Brush tempBrush = new SolidBrush(MainColor);
            
            g.DrawRectangle(tempPen, tempRect);
        }

        public sealed override void InitFrame() {
            BorderWidth = _x2 - _x1;
            BorderHeight = _y2 - _y1;
            FrameMainPoint = new Point(_x1, _y1);
            MainPoint = FrameMainPoint;
        }

        public override void CheckCollision() {
            
        }
    }
}