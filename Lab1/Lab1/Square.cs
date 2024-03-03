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
            FrameMainPoint = new Point(
                MainPoint.X - (BorderWidth >> 1), MainPoint.X - (BorderHeight >> 1)
            );
        }
    }
}