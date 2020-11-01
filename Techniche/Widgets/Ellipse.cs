namespace Techniche.Widgets
{
    public class Ellipse : Widget
    {
        public Ellipse(int posX, int posY, int horizontalDiameter, int verticalDiameter) : base(posX, posY)
        {
            HorizontalDiameter = horizontalDiameter;
            VerticalDiameter = verticalDiameter;
        }

        public int HorizontalDiameter { get; }
        public int VerticalDiameter { get; }

        public override string ToString()
        {
            return $"Ellipse {PositionString} diameterH = {HorizontalDiameter} diameterV = {VerticalDiameter}";
        }

        public override bool Validate()
        {
            return base.Validate() &&
                   Validator.Positive(HorizontalDiameter, nameof(HorizontalDiameter)) &&
                   Validator.Positive(VerticalDiameter, nameof(VerticalDiameter));
        }
    }
}