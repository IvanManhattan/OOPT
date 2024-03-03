using System.Drawing;

namespace Lab1 {
    public class Square : DisplayObject {
        private int _widthHeight;
       
        public int WidthHeight {
            get => _widthHeight;
            set => _widthHeight = value;
        }
        
        public Square(Point mainPoint, Color color, int borderThickness, 
            Color borderColor, int widthHeight) 
            : base(mainPoint, color, borderThickness, borderColor) {
            _widthHeight = widthHeight;
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
            g.FillRectangle(tempBrush, tempRect);
            
        }

        public sealed override void InitFrame() {
            BorderWidth = _widthHeight;
            BorderHeight = _widthHeight;
            CheckCollision();
            FrameMainPoint = new Point(
                MainPoint.X - (BorderWidth >> 1), MainPoint.Y - (BorderHeight >> 1)
            );
        }

        public override void CheckCollision() {
            if (MainPoint.X + (BorderWidth >> 1) >= MainForm.PictureBoxWidth) {
                var point = MainPoint;
                point.X = MainForm.PictureBoxWidth - (BorderWidth >> 1) - BorderThickness / 2;
                MainPoint = point;
            }
            if (MainPoint.Y + (BorderWidth >> 1) >= MainForm.PictureBoxHeight) {
                var point = MainPoint;
                point.Y = MainForm.PictureBoxHeight - (BorderWidth >> 1) - BorderThickness / 2;
                MainPoint = point;
            }
            if (MainPoint.X - (BorderWidth >> 1) <= 0) {
                var point = MainPoint;
                point.X = 10 + (BorderWidth >> 1) + BorderThickness;
                MainPoint = point;
            }
            if (MainPoint.Y - (BorderWidth >> 1) <= 0) {
                var point = MainPoint;
                point.Y = 10 + (BorderWidth >> 1) + BorderThickness;
                MainPoint = point;
            }
        }
    }
}