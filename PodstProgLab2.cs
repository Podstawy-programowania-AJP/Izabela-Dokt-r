Console.WriteLine("Poziom trudnosci latwy - 1");
Console.WriteLine("Poziom trudnosci sredni - 2");
Console.WriteLine("Poziom trudnosci trudny - 3");
Console.Write("Wpisz poziom trudnosci ");
int poziom = int.Parse(Console.ReadLine());
Random rand = new Random();
int wylosowanaLiczba = 0;
int maxproba = 0;
if (poziom == 1)
{
   
    wylosowanaLiczba = rand.Next(1, 51);
    maxproba = 10;
}
else if (poziom == 2)
{

    wylosowanaLiczba = rand.Next(1, 101);
    maxproba = 7;
}
else if (poziom == 3)
{

     wylosowanaLiczba = rand.Next(1, 201);
    maxproba = 5;
}

int proba = 0;
int strzal;
do
{
    Console.Write("Podaj liczbę: ");
    strzal = int.Parse(Console.ReadLine());
    proba++;
    if (strzal < wylosowanaLiczba) Console.WriteLine("Za mało!");
    else if (strzal > wylosowanaLiczba) Console.WriteLine(" Za dużo!");
} while (strzal != wylosowanaLiczba && proba < maxproba);
if (strzal == wylosowanaLiczba)
{
    Console.WriteLine($"Brawo! Zgadłeś w {proba} próbach.");
}