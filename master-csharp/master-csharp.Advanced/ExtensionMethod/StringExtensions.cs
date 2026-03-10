using System;

public static class StringExtensions
{
    public static bool IsPalindrome(this string str)
    {
        string reversed = "";
        for (int i = str.Length - 1; i >= 0; i--)
            reversed += str[i];
        return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }
    public static string AddExclamation(this string s)
    {
        return s + "!";
    }

    public static string ToUpperCase(this string s)
    {
        return s.ToUpper();
    }
}

class ExtensionMethodUsage
{
    public static void Test()
    {
        string word = "Level";

        //  Extension Method
        if (word.IsPalindrome())
        {
            Console.WriteLine($"{word} هي كلمة palindrome");
        }
        else
        {
            Console.WriteLine($"{word} ليست palindrome");
        }
        string msg = "hello";

        string result = msg
            .AddExclamation()
            .ToUpperCase();

        Console.WriteLine(result); // Output: HELLO!
    }
}