namespace Techniche.Widgets
{
    public class Textbox : Rectangle
    {
        public Textbox(int posX, int posY, int width, int height, string text = null) : base(posX, posY, width, height)
        {
            Text = text ?? "";
        }

        private string Text { get; }

        public override string ToString()
        {
            return $"Textbox {PositionString} width={Width} height={Height} text=\"{Text}\"";
        }
    }
}