using sprrrrrrrrrrrrrrrrrr;
using System;

public class Program
{
    public static void Main()
    {
        //ZADANIE 1
        string tekst = "przykładowy tekst do zaszyfrowania";
        int klucz = 3;

        string zaszyfrowany = Szyfrowanie.ZaszyfrujCezara(tekst, klucz);
        string odszyfrowany = Szyfrowanie.OdszyfrujCezara(zaszyfrowany, klucz);

        Console.WriteLine($"Tekst oryginalny: {tekst}");
        Console.WriteLine($"Tekst zaszyfrowany: {zaszyfrowany}");
        Console.WriteLine($"Tekst odszyfrowany: {odszyfrowany}");




        //ZADANIE 2
        //nie wypisuje się
        Console.WriteLine();
        Console.WriteLine();



        //ZADANIE 3
        //email napisany jest, ponieważ miałem ambitne plany dodania czegoś od siebie lecz nie działa mi to 
        //a jak chce go skasować to wyrzuca błędy więc zostawiłem go ale go nie wypisuje
        Student student1 = new Student("Mateusz", "Barszcz", "jkowalski@studia.pl", "uwewue", "xdr5tgb");
        student1.RocznikStudiow = 3;

        Student student2 = new Student("Filip", "Grzyb", "anowak@studia.pl", "ebeebe", "bgt5rdx");
        student2.RocznikStudiow = 2;

        Console.WriteLine(student1.ToString());
        Console.WriteLine(student2.ToString());

        if (student1.Equals(student2))
        {
            Console.WriteLine("Student nr.1 i Student nr.2 są identyczne.");
        }
        else
        {
            Console.WriteLine("Student nr.1 i Student nr.2 są różne.");
        }



    }
}

