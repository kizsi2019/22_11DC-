using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskola2
{
    internal class JelszoGeneralo
    {
        private Random Rnd;

        public JelszoGeneralo(Random r)
        {
            Rnd = r;
        }

        public string Jelszo(int jelszoHossz)
        {
            string jelszo = "";
            while (jelszo.Length < jelszoHossz)
            {
                char c = (char)Rnd.Next(48, 123);
                if ((c >= '0' && c <= '9') || (c >= 'a' && c <= 'z'))
                {
                    jelszo += c;
                }
            }
            return jelszo;
        }
    }
}
