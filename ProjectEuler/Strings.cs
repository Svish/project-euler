using System;


namespace ProjectEuler
{
    public static class Strings
    {
        public static string Truncate(this string subject, int length)
        {
            if(subject.Length <= length)
                return subject;
            return subject.Substring(0, length);
        }

        public static string Reverse(this string subject)
        {
            if (subject == null)
                throw new ArgumentNullException("subject");

            var length = subject.Length;
            var arr = new char[length];

            for (var i = 0; i < length; i++)
                arr[i] = subject[length - 1 - i];

            return new string(arr);
        }


        public static bool IsPalindrome(this string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;

            var c = text.ToCharArray();

            var length = text.Length;
            var halfLength = length / 2;

            for (var i = 0; i < halfLength; i++)
            {
                if (c[i] != c[length - 1 - i])
                    return false;
            }
            return true;

            // return text.Equals(text.Reverse());  // TODO: Check performance. Simpler, but slower?
        }
    }
}