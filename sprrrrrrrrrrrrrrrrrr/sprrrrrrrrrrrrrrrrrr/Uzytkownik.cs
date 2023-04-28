using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprrrrrrrrrrrrrrrrrr
{
    public abstract class Uzytkownik
    {
        private string imie;
        private string nazwisko;
        private string login;
        private string haslo;

        public Uzytkownik(string imie, string nazwisko, string email)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.login = GenerujLogin(imie, nazwisko);
            this.haslo = GenerujHaslo(nazwisko);
        }

        public string Imie { get { return imie; } }
        public string Nazwisko { get { return nazwisko; } }
        public string Login { get { return login; } }
        public string Haslo { get { return haslo; } }

        public abstract void ZmienLogin(string nowyLogin, string staryLoginOdUzytkownika);
        public abstract void ZmienHaslo(string noweHaslo, string stareHasloOdUzytkownika);

        public string UkryjLogin()
        {
            return Szyfrowanie.ZaszyfrujCezara(login, 3);
        }

        public string UkryjHaslo()
        {
            return Szyfrowanie.ZaszyfrujCezara(haslo, 3);
        }

        public string PokazLogin()
        {
            return login;
        }

        public string PokazHaslo()
        {
            return haslo;
        }

        private string GenerujLogin(string imie, string nazwisko)
        {
            string login = imie.ToLower() + "_" + nazwisko.ToLower();
            return Szyfrowanie.ZaszyfrujCezara(login, 3);
        }

        private string GenerujHaslo(string nazwisko)
        {
            string haslo = nazwisko.Substring(0, 3) + new Random().Next(100000, 1000000);
            return Szyfrowanie.ZaszyfrujCezara(haslo, 3);
        }
    }
}

