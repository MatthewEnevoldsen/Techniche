namespace Techniche.Widgets
{
    public class Square  : Widget
    {

        public int Width { get; }

        public Square(Position position, int width) : base(position)
        {
            Width = width;
        }

        public override string ToString()
        {
            return $"Square {Position} size={Width}";
        }
        public override bool Validate()
        {
            return base.Validate() &&
                   Validator.Positive(Width, nameof(Width));
        }
    }
}