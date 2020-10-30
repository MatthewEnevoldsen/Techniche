namespace Techniche.Widgets
{
    public class Circle : Widget
    {
        public int Diameter { get; }

        public Circle(Position position, int diameter) : base(position)
        {
            Diameter = diameter;
        }

        public override string ToString()
        {
            return $"Circle {Position} size={Diameter}";
        }

        public override bool Validate()
        {
            return base.Validate() &&
                   Validator.Positive(Diameter, nameof(Diameter));
        }
    }
}