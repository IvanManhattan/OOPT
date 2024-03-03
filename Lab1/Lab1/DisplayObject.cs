using System.Drawing;

namespace Lab1 {
    
    public abstract class DisplayObject {
        private Point _mainPoint;
        private Color _mainColor;
        private int _borderThickness;
        private Color _borderColor;
        private Point _frameMainPoint;
        private int _borderWidth;
        private int _borderHeight;
        private static readonly int FrameBorder = 3;

        public int BorderWidth {
            get => _borderWidth;
            set => _borderWidth = value;
        }

        public int BorderHeight {
            get => _borderHeight;
            set => _borderHeight = value;
        }

        public Point MainPoint {
            get => _mainPoint;
            set => _mainPoint = value;
        }

        public Color MainColor {
            get => _mainColor;
            set => _mainColor = value;
        }

        public int BorderThickness {
            get => _borderThickness;
            set => _borderThickness = value;
        }

        public Color BorderColor {
            get => _borderColor;
            set => _borderColor = value;
        }

        public Point FrameMainPoint {
            get => _frameMainPoint;
            set => _frameMainPoint = value;
        }
        
        public DisplayObject(Point mainPoint, Color color, int borderThickness, 
            Color borderColor) {

            _mainPoint = mainPoint;
            _mainColor = color;
            _borderThickness = borderThickness;
            _borderColor = borderColor;

        }

        public void Move() {
            // TODO
        }

        public abstract void Draw(Graphics g);

        public virtual void DrawFrame(Graphics g) {
            System.Drawing.Rectangle backRect =
                new System.Drawing.Rectangle(FrameMainPoint, new Size(BorderWidth, BorderHeight));
            Pen backPen = new Pen(Color.Black, FrameBorder);    
            g.DrawRectangle(backPen, backRect);
        }
        public abstract void InitFrame();
    }
}