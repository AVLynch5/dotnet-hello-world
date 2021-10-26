using System;

namespace Problem2
{
    public class Kata
    {
        public static bool Check(object[] a, object x)
        {
            foreach (object i in a)
            {
                if (i.Equals(x))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
