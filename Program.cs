using KajakKolcsonzo;
List<Kolcsonzes> kolcsonzesekosz = new List<Kolcsonzes>();
string[] kolcsonzesek = File.ReadAllLines("kolcsonzesek.txt");
Console.WriteLine("Adatok beolvasása a kolcsonzesek.txt fájlból...\n");
Console.WriteLine("Rögzített hajókölcsönzések:");
foreach (string sor in kolcsonzesek)
{
    
    kolcsonzesekosz.Add(new Kolcsonzes(sor));
    Console.WriteLine(new Kolcsonzes(sor));
}
var ideiglenes=kolcsonzesekosz.MaxBy(x=>x.FizetendoOsszeg());
Console.WriteLine("\n Összesített statisztika:");
Console.WriteLine($"Kölcsönző teljes bevétele: {kolcsonzesekosz.Sum(x=>x.FizetendoOsszeg())} Ft");
Console.WriteLine($"Átlagos kölcsönzési idő: {kolcsonzesekosz.Average(x=>x.BereltOrak):F0} óra");
Console.WriteLine($"Legtöbbet fizető bérlő: {ideiglenes.BerloNev} ({ideiglenes.FizetendoOsszeg()} Ft)");
Console.WriteLine($"Késés nélkül visszahozott KENU kölcsönzések száma: {kolcsonzesekosz.Count(x=>x.HajoTipus=="KENU" && x.KesesPerc==0)} db");
Console.WriteLine("\nKésedelmi pótdíjat fizető bérlők:");
foreach (var mesterkesok in kolcsonzesekosz)
{
    if (mesterkesok.KesesPerc > 15)
    {
        Console.WriteLine($"{mesterkesok.BerloNev} ({mesterkesok.KesesPerc} perc)");
    }
}
