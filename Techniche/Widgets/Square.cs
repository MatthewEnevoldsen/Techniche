namespace Techniche.Widgets
{
    public class Square  : Widget
    {
        public int Width { get; }

        public override string ToString()
        {
            return $"Square {PositionString} size={Width}";
        }
        public override bool Validate()
        {
            return base.Validate() &&
                   Validator.Positive(Width, nameof(Width));
        }

        public Square(int posX, int posY, int width) : base(posX, posY)
        {
            Width = width;
        }
    }
}