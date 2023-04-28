using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprrrrrrrrrrrrrrrrrr
{
    public static class Szyfrowanie
    {
        //szyfrowanie
        public static string ZaszyfrujCezara(string tekst, int klucz)
        {
            if(tekst == null)
            {
                throw new ArgumentNullException(nameof(tekst));
            }

            if (tekst.Length == 0)
            {
                throw new ArgumentException("PODANY TEKST MUSI BYĆ DŁUŻSZY NIŻ 0", nameof(tekst));
            }

            klucz %= 26; //klucz jest w przedziale od [0, 25]

            char[] zaszyfrowany = new char[tekst.Length];
            
            for (int i = 0; i < tekst.Length; i++)
            {
                char znak = tekst[i];

                if (char.IsLetter(znak))
                {
                    char start = char.IsUpper(znak) ? 'A' : 'a';
                    znak = (char)(((znak + klucz) - start) % 26 + start);
                }

                zaszyfrowany[i] = znak;
            }

            return new string(zaszyfrowany);
        }


        //deszyfrowanie
        public static string OdszyfrujCezara(string szyfr, int klucz)
        {
            if (szyfr == null)
            {
                throw new ArgumentNullException(nameof(szyfr));
            }

            if (szyfr.Length == 0)
            {
                throw new ArgumentException("SZYFR NIE MOŻE BYĆ PUSTY.", nameof(szyfr));
            }

            klucz %= 26;

            char[] odszyfrowany = new char[szyfr.Length];

            for (int i = 0; i < szyfr.Length; i++)
            {
                char znak = szyfr[i];

                if (char.IsLetter(znak))
                {
                    char start = char.IsUpper(znak) ? 'A': 'a';
                }

                odszyfrowany[i] = znak;
            }

            return new string(odszyfrowany);
        }
    }
}
