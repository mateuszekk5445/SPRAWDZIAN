using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprrrrrrrrrrrrrrrrrr
{
    
    public class Student : Uzytkownik
    {
        private string login;
        private string haslo;
        public object RocznikStudiow;

        public Student(string imie, string nazwisko, string email, string login, string haslo) : 
            base(imie, nazwisko, email)
        {
            this.login = login;
            this.haslo = haslo;
        }

        public override void ZmienHaslo(string noweHaslo, string stareHasloOdUzytkownika)
        {
            if (haslo == stareHasloOdUzytkownika)
            {
                haslo = noweHaslo;
            }
            else
            {
                throw new ArgumentException("Stare hasło jest nieprawidłowe.");
            }
        }

        public override void ZmienLogin(string nowyLogin, string staryLoginOdUzytkownika)
        {
            if (login == staryLoginOdUzytkownika)
            {
                login = nowyLogin;
            }
            else
            {
                throw new ArgumentException("Stary login jest nieprawidłowy.");
            }
        }

        public override string ToString()
        {
            return $"Student: {Imie} {Nazwisko} ({login}, {haslo.GetHashCode()})";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Student other = (Student)obj;
            return login == other.login && haslo == other.haslo;
        }

        //mamy metodę abstrakcyjną w klasie bazowej
        //- jest brak implementacji w klasie bazowej
        //- implementuje ją w klasie dziedziczącej
        public void WyswietlDane()
        {
            Console.WriteLine($"Imię i nazwisko: {Imie} {Nazwisko} ,rocznik studiów: {RocznikStudiow}");
        }
 
    }
}
