using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Witaj w moim pierwszym programie");
        
        Console.WriteLine("Podaj swoje imie");
        string imie = Console.ReadLine();
        Console.WriteLine("Podaj swoj rok urodzenia");
        int rok_uro = int.Parse(Console.ReadLine());

        int aktualny_rok = 2026;
 
        int wiek = aktualny_rok-rok_uro;



        Console.WriteLine("Jaki jest twój ulubiony jezyk?");
        string jezyk = Console.ReadLine();



        Console.WriteLine("Czesc "+ imie+ " !");
        Console.WriteLine("Masz około " + wiek + " lat");
        Console.WriteLine("twoj ulubiony jezyk programowania to " + jezyk );
    }
}