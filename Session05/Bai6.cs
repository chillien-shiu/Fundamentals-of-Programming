using System;
using System.Linq;

class Exercise6
{
    public static bool IsPangram(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return false;

        var letters = input.ToLower()
                           .Where(c => char.IsLetter(c))
                           .Distinct();

        return letters.Count() == 26;
    }
}