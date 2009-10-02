using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;


namespace Problems
{
    /// <summary>
    /// A natural string comparerer. The comparisson is done using the
    /// StrCmpLogicalW(string, string) method of shlwapi.dll.
    /// </summary>
    public sealed class NaturalStringComparer : IComparer<string>
    {
        private readonly int modifier = 1;


        public NaturalStringComparer(bool descending)
        {
            if (descending)
                modifier = -1;
        }


        public NaturalStringComparer()
            : this(false) {}


        #region IComparer<string> Members
        /// <summary>
        /// Compares two strings and returns a value indicating 
        /// whether one is less than, equal to, or greater than the other.
        /// The strings are compared ignoring the case.
        /// </summary>
        public int Compare(string a, string b)
        {
            return SafeNativeMethods.StrCmpLogicalW(a ?? "", b ?? "") * modifier;
        }
        #endregion
    }


    [SuppressUnmanagedCodeSecurity]
    internal static class SafeNativeMethods
    {
        [DllImport("shlwapi.dll", CharSet = CharSet.Unicode)]
        public static extern int StrCmpLogicalW(string psz1, string psz2);
    }
}