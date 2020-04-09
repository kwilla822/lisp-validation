namespace Validation
{
    public class LispValidator
    {
        public static bool Validate(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            var result = 0;
            foreach (var chr in input)
            {
                if (chr == '(') result += 1;
                if (chr == ')') result -= 1;

                if (result < 0)
                    break;
            }

            return result == 0;
        }
    }
}