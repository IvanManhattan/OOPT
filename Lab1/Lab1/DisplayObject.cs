using System.Drawing;

namespace Lab1 {
    
    public abstract class DisplayObject {
        protected Point MainPoint;
        protected Color MainColor;
        protected int BorderThickness;
        protected Color BorderColor;

        protected Point FrameMainPoint;
        
        public DisplayObject(Point mainPoint, Color color, int borderThickness, 
            Color borderColor, Point frameMainPoint) {

            MainPoint = mainPoint;
            MainColor = color;
            BorderThickness = borderThickness;
            BorderColor = borderColor;
            FrameMainPoint = frameMainPoint;

        }

        public void Move() {
            // TODO
        }

        public abstract void Draw(Graphics g);
    }
}