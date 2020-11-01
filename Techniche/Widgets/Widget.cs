namespace Techniche.Widgets
{
    public abstract class Widget
    {
        protected Widget(int posX, int posY)
        {
            PositionX = posX;
            PositionY = posY;
        }

        public int PositionX { get; }
        public int PositionY { get; }

        protected string PositionString => $"({PositionX},{PositionY})";

        public virtual bool Validate()
        {
            return Validator.InRangeInc(PositionX, 0, 1000, nameof(PositionX)) &&
                   Validator.InRangeInc(PositionY, 0, 1000, nameof(PositionY));
        }
    }
}