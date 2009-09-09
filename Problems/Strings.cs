using System;


namespace Problems
{
    public static class Strings
    {
        public static string Reverse(this string text)
        {
            if (text == null)
                throw new ArgumentNullException("text");

            int length = text.Length;
            var arr = new char[length];

            for (int i = 0; i < length; i++)
                arr[i] = text[length - 1 - i];

            return new string(arr);
        }


        public static bool IsPalindrome(this string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;

            var c = text.ToCharArray();

            int length = text.Length;
            int halfLength = length / 2;

            for (int i = 0; i < halfLength; i++)
            {
                if (c[i] != c[length - 1 - i])
                    return false;
            }
            return true;

            // return text.Equals(text.Reverse());  // TODO: Check performance. Simpler, but slower?
        }
    }
}