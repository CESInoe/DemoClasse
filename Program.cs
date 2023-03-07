using DemoClasse;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

List<Enemy> list = Enemy.InitList();

// Moyenne d'attaque :
Console.WriteLine("Moyenne d'attaque : " + list.Average(x => x.Attack));

//Moyenne de défense :
Console.WriteLine("Moyenne defense : " + list.Average(x => x.Defense));

// Liste des 5 ennemies les plus fort (stats aditionées )
Console.WriteLine("5 enemies les plus forts ");
var fives = list.OrderByDescending(e => e.Attack + e.Defense + e.Health).Take(5);
foreach (var enemy in fives)
{
    Console.WriteLine(enemy.DescribeSelf());
}

// Liste des noms d'ennemies utilisés plusieurs fois 
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Enemies qui existe plusieurs fois");
var duplicates = list.GroupBy(x => x.Name).Where(y => y.Count() > 1).Select(z=> z.Key);
foreach (var enemy in duplicates)
{
    Console.Write($"cet est présent plusieurs fois  {enemy}");
}

// List des enemies présent plusieurs fois (stats et nom identique )
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Enemies qui sont identiques ");
var duplicateFull = list.GroupBy(w => new { w.Name, w.Attack, w.Defense, w.Health, w.FavoriteBiome }).Where(y => y.Count() > 1);
foreach (var enemy in duplicateFull)
{
    Console.WriteLine(enemy.First().DescribeSelf());
}


//Liste des biomes, du nombre d'ennemis dedans, et de leur somme de point de vie. 
Console.WriteLine();
Console.WriteLine("Ennemy par biome");
var biomes = list.GroupBy(x => x.FavoriteBiome);
foreach (var biome in biomes) {
    Console.WriteLine($"Biome : {biome.Key} est le biome favoris de {biome.Count()} enemies, qui ont au total {biome.Sum(x => x.Health)} point de vie");
}


Console.WriteLine("J'attend une réponse");
var test = list.First().Test();
System.Threading.Thread.Sleep(6000);
Console.WriteLine("J'ai pas attendu");
Console.WriteLine("ta réponse est :" + await test);