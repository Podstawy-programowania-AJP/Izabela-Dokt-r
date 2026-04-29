using System;
using System.Collections.Generic;

class Ksiazka
{
    public string Tytul { get; set; }
    public string Autor { get; set; }
    public int RokWydania { get; set; }
}

class Program
{
    static void Main()
    {
        List<Ksiazka> biblioteka = new List<Ksiazka>();

        while (true)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1 - Dodaj ksiazke");
            Console.WriteLine("2 - Wyswietl ksiazki");
            Console.WriteLine("3 - Usun ksiazke");
            Console.WriteLine("4 - Wyjscie");
            Console.Write("Wybierz opcje: ");

            string wybor = Console.ReadLine();

            if (wybor == "1")
            {
                Ksiazka nowa = new Ksiazka();

                Console.Write("Tytul: ");
                nowa.Tytul = Console.ReadLine();

                Console.Write("Autor: ");
                nowa.Autor = Console.ReadLine();

                int rok;
                Console.Write("Rok: ");
                while (!int.TryParse(Console.ReadLine(), out rok))
                {
                    Console.Write("Podaj poprawny rok: ");
                }
                nowa.RokWydania = rok;

                biblioteka.Add(nowa);
                Console.WriteLine("Dodano!");
            }
            else if (wybor == "2")
            {
                Console.WriteLine("\n--- Lista ksiazek ---");

                if (biblioteka.Count == 0)
                {
                    Console.WriteLine("Brak ksiazek.");
                }
                else
                {
                    for (int i = 0; i < biblioteka.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {biblioteka[i].Tytul} - {biblioteka[i].Autor}");
                    }
                }
            }
            else if (wybor == "3")
            {
                Console.WriteLine("\n--- Usun ksiazke ---");

                if (biblioteka.Count == 0)
                {
                    Console.WriteLine("Brak ksiazek do usuniecia.");
                }
                else
                {
                    for (int i = 0; i < biblioteka.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {biblioteka[i].Tytul}");
                    }

                    Console.Write("Podaj numer ksiazki do usuniecia: ");
                    int index;

                    if (int.TryParse(Console.ReadLine(), out index) &&
                        index > 0 && index <= biblioteka.Count)
                    {
                        biblioteka.RemoveAt(index - 1);
                        Console.WriteLine("Usunieto ksiazke!");
                    }
                    else
                    {
                        Console.WriteLine("blad");
                    }
                }
            }
            else if (wybor == "4")
            {
                Console.WriteLine("Koniec programu.");
                break;
            }
        }
    }
}