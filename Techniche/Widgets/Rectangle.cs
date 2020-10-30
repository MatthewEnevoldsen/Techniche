namespace Techniche.Widgets
{
    public class Rectangle : Widget
    {
        public Rectangle(Position position, int width, int height) : base(position)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; }
        public int Height { get; }

        public override string ToString()
        {
            return  $"Rectangle {Position} width={Width} height={Height}";
        }

        public override bool Validate()
        {
            return base.Validate() &&
                   Validator.Positive(Width, nameof(Width)) &&
                   Validator.Positive(Height, nameof(Height));
        }
    }
}