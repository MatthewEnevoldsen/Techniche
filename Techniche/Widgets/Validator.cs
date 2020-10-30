namespace Techniche.Widgets
{
    static class Validator
    {
        public static bool InRangeInc(int value, int min, int max, string argName)
        {
            return max >= value && value >= min;
        }

        public static bool Positive(int value, string argName)
        {
            return value > 0;
        }

    }
}