using KajakKolcsonzo;
Console.ForegroundColor = ConsoleColor.Cyan;
List<Kolcsonzes> kolcsonzesekosz = new List<Kolcsonzes>();
string[] kolcsonzesek = File.ReadAllLines("kolcsonzesek.txt");
Console.WriteLine("Adatok beolvasása a kolcsonzesek.txt fájlból...\n");
Console.WriteLine("Rögzített hajókölcsönzések:");
foreach (string sor in kolcsonzesek)
{
    
    kolcsonzesekosz.Add(new Kolcsonzes(sor));
    Console.WriteLine(new Kolcsonzes(sor));
}