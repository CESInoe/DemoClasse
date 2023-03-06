using DemoClasse;
using System.Linq;

List<Enemy> list = Enemy.InitList();

Console.WriteLine("First enemy :" + list.FirstOrDefault().DescribeSelf());

Console.WriteLine("There is " + list.Count() + " Enemy");

Console.WriteLine("The last enemy with more than 2 attack point is called " + list.Where(e => e.Attack > 2).Select(x => x.Name).LastOrDefault());
