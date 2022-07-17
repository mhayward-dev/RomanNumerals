using System.Text;

namespace RomanNumeralConversion
{
    internal static class RomanNumeralExtensions
    {
        internal static string ConvertToRomanNumeral(this int i)
        {
            // We shall set upper limit to 3999
            if (i > 3999)
                return "";

            var sBuilder = new StringBuilder();
            var numeralRanges = new List<RomanNumeralRange> {
                new RomanNumeralRange { Unit = 1000, Symbol = 'M' },
                new RomanNumeralRange { Unit = 100, Symbol = 'C', UpperLimitSymbol = 'M', HalfLimitSymbol = 'D' },
                new RomanNumeralRange { Unit = 10, Symbol = 'X', UpperLimitSymbol = 'C', HalfLimitSymbol = 'L' },
                new RomanNumeralRange { Unit = 1, Symbol = 'I', UpperLimitSymbol = 'X', HalfLimitSymbol = 'V' }
            };

            foreach(var range in numeralRanges)
            {
                var upperLimit = range.Unit * 10;
                var count = (i >= upperLimit ? i % upperLimit : i) / range.Unit;

                switch(count)
                {
                    case < 4:
                        sBuilder.Append(range.Symbol, count);
                        break;
                    case 4:
                        sBuilder.Append($"{range.Symbol}{range.HalfLimitSymbol}");
                        break;
                    case 5:
                        sBuilder.Append(range.HalfLimitSymbol);
                        break;
                    case 9:
                        sBuilder.Append($"{range.Symbol}{range.UpperLimitSymbol}");
                        break;
                    case > 5:
                        sBuilder.Append(range.HalfLimitSymbol);
                        sBuilder.Append(range.Symbol, count % 5);
                        break;
                }
            }

            return sBuilder.ToString();
        }

        internal static string ConvertToRomanNumeral_Old(this int i)
        {
            // This method was used for my original working.
            // Once condensed and the patterns were identified the method above superseded this one.
            var sBuilder = new StringBuilder();

            var cCount = (i >= 1000 ? i % 1000 : i) / 100;
            var xCount = (i >= 100 ? i % 100 : i) / 10;
            var iCount = (i >= 10 ? i % 10 : i) / 1;

            switch (cCount)
            {
                case < 4:
                    sBuilder.Append('C', cCount);
                    break;
                case 4:
                    sBuilder.Append("CD");
                    break;
                case 5:
                    sBuilder.Append('D');
                    break;
                case 9:
                    sBuilder.Append("CM");
                    break;
                case > 5:
                    sBuilder.Append('D');
                    sBuilder.Append('C', cCount % 5);
                    break;
            }

            switch (xCount)
            {
                case < 4:
                    sBuilder.Append('X', xCount);
                    break;
                case 4:
                    sBuilder.Append("XL");
                    break;
                case 5:
                    sBuilder.Append('L');
                    break;
                case 9:
                    sBuilder.Append("XC");
                    break;
                case > 5:
                    sBuilder.Append('L');
                    sBuilder.Append('X', xCount % 5);
                    break;
            }

            switch (iCount)
            {
                case < 4:
                    sBuilder.Append('I', iCount);
                    break;
                case 4:
                    sBuilder.Append("IV");
                    break;
                case 5:
                    sBuilder.Append('V');
                    break;
                case 9:
                    sBuilder.Append("IX");
                    break;
                case > 5:
                    sBuilder.Append('V');
                    sBuilder.Append('I', iCount % 5);
                    break;
            }

            return sBuilder.ToString();
        }
    }
}
