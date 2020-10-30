namespace Techniche.Widgets
{
    public abstract class Widget
    {
        protected Widget(Position position)
        {
            Position = position;
        }

        public Position Position { get; }

        public virtual bool Validate()
        {
            return Validator.InRangeInc(Position.X, 0, 1000, nameof(Position.X)) &&
            Validator.InRangeInc(Position.Y, 0, 1000, nameof(Position.Y));
        }
    }
}
