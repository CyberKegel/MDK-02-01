using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Cyphering
    {
        public static string Code_Message(string value)
        {
            ushort sr = 0x0001;

            var ch = value.ToArray();

            string newValue = "";
            foreach(var c in ch)
            {
                newValue += new_symp(c, sr);
            }

            return newValue;
        }

        private static char new_symp(char value, ushort val)
        {
            value = (char)(value ^ val);
            return value;
        }
    }
}
