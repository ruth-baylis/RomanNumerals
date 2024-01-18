using System.Text;

namespace RomanNumerals
{
    public class RomanConverter
    {
        private record Pair(int Number, string Symbol);

        private readonly List<Pair> pairs = new() {
            new Pair(1000, "M"),
            new Pair(900, "CM"),
            new Pair(500, "D"),
            new Pair(400, "CD"),
            new Pair(100, "C"),
            new Pair(90, "XC"),
            new Pair(50, "L"),
            new Pair(40, "XL"),
            new Pair(10, "X"),
            new Pair(9, "IX"),
            new Pair(5, "V"),
            new Pair(4, "IV"),
            new Pair(1, "I")
        };

        public string FromInteger(int n)
        {
            if (n < 1 || n > 2000)
            {
                throw new ArgumentOutOfRangeException(
                    paramName: nameof(n),
                    message: "The input must be a positive integer between 1 and 2000."
                );
            }

            StringBuilder stringBuilder = new();

            foreach (var pair in pairs)
            {
                while (n >= pair.Number)
                {
                    stringBuilder.Append(pair.Symbol);
                    n -= pair.Number;
                }
            }

            var result = stringBuilder.ToString();

            return result;
        }
    }
}