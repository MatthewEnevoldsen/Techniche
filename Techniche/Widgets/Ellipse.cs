namespace Techniche.Widgets
{
    public class Ellipse  : Widget
    {
        public int HorizontalDiameter { get; }
        public int VerticalDiameter { get; }

        public Ellipse(Position position, int horizontalDiameter, int verticalDiameter) : base(position)
        {
            HorizontalDiameter = horizontalDiameter;
            VerticalDiameter = verticalDiameter;
        }

        public override string ToString()
        {
            return $"Ellipse {Position} diameterH = {HorizontalDiameter} diameterV = {VerticalDiameter}";
        }

        public override bool Validate()
        {
            return base.Validate() &&
                   Validator.Positive(HorizontalDiameter, nameof(HorizontalDiameter)) &&
                   Validator.Positive(VerticalDiameter, nameof(VerticalDiameter));
        }
    }
}