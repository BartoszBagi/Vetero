namespace Vetero.Application.Helpers
{
    public static class MathHelper
    {
        public static double CalculatePercents(double firstValue, double secondValue)
        {
            if (firstValue != 0 && secondValue != 0)
            {
                double denominator, divider;
                if (firstValue < secondValue)
                {
                    denominator = firstValue;
                    divider = secondValue;
                }
                else
                {
                    denominator = secondValue;
                    divider = firstValue;
                }
                var result = (denominator / divider) * 100;
                return result;
            }

            if (firstValue == 0 && secondValue == 0)
                return 100;

            if(firstValue == 0 || secondValue == 0)
            {
                var value = firstValue != 0 ? firstValue : secondValue;

                if (value < 0 - 8 || value > 0 + 8)
                    return 0;
                if (value < 0 - 7 || value > 0 + 7)
                    return 12;
                if (value < 0 - 6 || value > 0 + 6)
                    return 25;
                if (value < 0 - 5 || value > 0 + 5)
                    return 32;
                if (value < 0 - 4 || value > 0 + 4)
                    return 45;
                if (value < 0 - 3 || value > 0 + 3)
                    return 60;
                if (value < 0 - 2 || value > 0 + 2)
                    return 75;
                if (value < 0 - 1 || value > 0 + 1)
                    return 90;
                if ((value > 0 && value < 1) || (value > -1 && value < 0))
                    return 99;
            }
            return 100;
        }
    }
}
