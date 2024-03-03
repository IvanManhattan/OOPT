using System.Drawing;

namespace Lab1 {
    public class Rectangle : DisplayObject {
        private int _x, _y;
        private int _width, _height;
        
        public int X {
            get => _x;
            set => _x = value;
        }

        public int Y {
            get => _y;
            set => _y = value;
        }

        public int Width {
            get => _width;
            set => _width = value;
        }

        public int Height {
            get => _height;
            set => _height = value;
        }

        public Rectangle(Point mainPoint, Color color, int borderThickness, Color borderColor, 
            int x, int y, int width, int height) 
            : base(mainPoint, color, borderThickness, borderColor) {
            _x = x;
            _y = y;
            _width = width;
            _height = height;

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
            BorderWidth = _width;
            BorderHeight = _height;
            FrameMainPoint = new Point(_x, _y);
            MainPoint = FrameMainPoint;
        }
    }
    
   
}