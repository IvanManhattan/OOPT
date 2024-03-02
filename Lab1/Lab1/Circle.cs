using System.Drawing;

namespace Lab1 {
    public class Circle : DisplayObject {
        private int _radius;
        
        public Circle(Point mainPoint, Color color, int borderThickness, 
            Color borderColor, Point frameMainPoint, int radius) : 
            base(mainPoint, color, borderThickness, borderColor, frameMainPoint) {
            _radius = radius;
        }

        public override void Draw(Graphics g) {
            
        }
    }
}