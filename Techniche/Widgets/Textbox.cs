namespace Techniche.Widgets
{
    public class Textbox : Rectangle
    {
        private string Text { get; }

        public override string ToString()
        {
            return $"Textbox {Position} width={Width} height={Height} text=\"{Text}\"";
        }

        public Textbox(Position position, int width, int height, string text = null) : base(position, width, height)
        {
            Text = text ?? "";
        }
    }
}