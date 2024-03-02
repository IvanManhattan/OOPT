using System.Drawing;

namespace Lab1 {
    public class Rectangle : DisplayObject {
        private int _x, _y;
        private int _width, _height;

        public Rectangle(Point mainPoint, Color color, int borderThickness, Color borderColor, 
            Point frameMainPoint, int x, int y, int width, int height) 
            : base(mainPoint, color, borderThickness, borderColor, frameMainPoint) {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }


        public override void Draw(Graphics g) {
            /*g.DrawRectangle(new Pen(MainColor), _x, _y, _width, _height);
            g.DrawRectangle(new Pen(MainColor), new System.Drawing.Rectangle());*/
            
            System.Drawing.Rectangle backRect = new System.Drawing.Rectangle();
            backRect.Width = _width;
            backRect.Height = _height;
            backRect.X = FrameMainPoint.X;
            backRect.Y = FrameMainPoint.Y;
            MainPoint = FrameMainPoint;
            
            System.Drawing.Rectangle tempRect = new System.Drawing.Rectangle();
            tempRect.Width = _width;
            tempRect.Height = _height;
            tempRect.X = _x;
            tempRect.Y = _y;

            Pen tempPen = new Pen(BorderColor, BorderThickness);

            Brush tempBrush = new SolidBrush(MainColor);
            
            g.DrawRectangle(tempPen, tempRect);
            g.FillRectangle(tempBrush, tempRect);
            

        }
    }
    
   
}