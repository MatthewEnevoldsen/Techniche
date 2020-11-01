namespace Techniche.Widgets
{
    public class Rectangle : Widget
    {

        public int Width { get; }
        public int Height { get; }

        public override string ToString()
        {
            return  $"Rectangle {PositionString} width={Width} height={Height}";
        }

        public override bool Validate()
        {
            return base.Validate() &&
                   Validator.Positive(Width, nameof(Width)) &&
                   Validator.Positive(Height, nameof(Height));
        }

        public Rectangle(int posX, int posY, int width, int height) : base(posX, posY)
        {
            Width = width;
            Height = height;
        }
    }
}