namespace Techniche.Widgets
{
    public class Circle : Widget
    {
        public int Diameter { get; }


        public override string ToString()
        {
            return $"Circle {PositionString} size={Diameter}";
        }

        public override bool Validate()
        {
            return base.Validate() &&
                   Validator.Positive(Diameter, nameof(Diameter));
        }

        public Circle(int posX, int posY, int diameter) : base(posX, posY)
        {
            Diameter = diameter;
        }
    }
}