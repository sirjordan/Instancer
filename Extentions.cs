using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extentions
{
    public static class Extentions
    {
        public static bool Random(this bool n)
        {
            int rnd = Guid.NewGuid().GetHashCode();
            return rnd > 0;
        }
        public static char Random(this char n)
        {
            int rnd = Guid.NewGuid().GetHashCode();
            return (char)rnd;
        }
        public static sbyte Random(this sbyte n)
        {
            int rnd = Guid.NewGuid().GetHashCode();
            return (sbyte)rnd;
        }
        public static byte Random(this byte n)
        {
            int rnd = Guid.NewGuid().GetHashCode();
            return (byte)rnd;
        }
        public static short Random(this short n)
        {
            int rnd = Guid.NewGuid().GetHashCode();
            return (short)rnd;
        }
        public static ushort Random(this ushort n)
        {
            int rnd = Guid.NewGuid().GetHashCode();
            return (ushort)rnd;
        }
        public static int Random(this int n)
        {
            int rnd = Guid.NewGuid().GetHashCode();
            return (int)rnd;
        }
        public static uint Random(this uint n)
        {
            int rnd = Guid.NewGuid().GetHashCode();
            return (uint)rnd;
        }
        public static long Random(this long n)
        {
            int rnd = Guid.NewGuid().GetHashCode();
            return (long)rnd;
        }
        public static ulong Random(this ulong n)
        {
            int rnd = Guid.NewGuid().GetHashCode();
            return (ulong)rnd;
        }
        public static float Random(this float n)
        {
            int rnd = Guid.NewGuid().GetHashCode();
            return (float)rnd;
        }
        public static double Random(this double n)
        {
            int rnd = Guid.NewGuid().GetHashCode();
            return (double)rnd;
        }
        public static decimal Random(this decimal n)
        {
            int rnd = Guid.NewGuid().GetHashCode();
            return (decimal)rnd;
        }
        public static DateTime Random(this DateTime n)
        {
            int rnd = Guid.NewGuid().GetHashCode();
            DateTime.FromBinary(rnd);
            return DateTime.FromBinary(rnd);
        }
        public static string Random(this string n)
        {
            Guid rnd = Guid.NewGuid();
            return rnd.ToString();
        }
    }
}
