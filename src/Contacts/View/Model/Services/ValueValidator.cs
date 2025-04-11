using System.Text.RegularExpressions;
using System.Xml.Linq;

public static class ValueValidator
{
    public static bool NullOnEmptyStringMatching(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return true;
        }
        return false;
    }

    public static bool StringLengthMatching(string value, int max)
    {
        if (value.Length > max)
        {
            return true;
        }
        return false;
    }

    public static bool PatternMatching(string value, string pattern)
    {
        if (Regex.IsMatch(value, pattern))
        {
            return true;
        }
        return false;
    }
}
