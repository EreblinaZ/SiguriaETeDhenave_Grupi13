using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigenereCipher
{
    class Keystream
    {
        public static String GetRandomString(int b)
        {
            var allowedChars = "ABCDEFGHJKLMNOPQRSTUVWXYZ";
            var length = b;

            var chars = new char[length];
            var rd = new Random();

            for (var i = 0; i < length; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            return new String(chars);
        }
    }
}
