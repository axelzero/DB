using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDBContext())
            {
                var magazin = new Magazin()
                {
                    Name = "Rozetka"
                };

                var magazin2 = new Magazin()
                {
                    Name = "Comfy"
                };

                context.Magazins.Add(magazin);
                context.Magazins.Add(magazin2);
                context.SaveChanges();

                var tovars = new List<Tovar>()
                {
                    new Tovar() { Name = "Mouse", About = "For working on PC", MagazId = magazin.Id, Price = 5f },
                    new Tovar() {Name = "Keyboard", About= "For working on PC", Price = 7f, MagazId = magazin.Id},
                    new Tovar() {Name = "Monitor", About= "For working on PC", Price = 10f, MagazId = magazin.Id },
                    new Tovar() {Name = "PC", About= "For working", Price = 25f, MagazId = magazin.Id },
                    new Tovar() {Name = "PC", About= "For working", Price = 25f, MagazId = magazin2.Id }
                };
               
                context.Tovars.AddRange(tovars);
                context.SaveChanges();

                foreach (var tovar in tovars)
                {
                    Console.WriteLine($"Name {tovar.Name}  \tPrice{tovar.Price} \n{tovar.About} \nMagazin name {tovar.Magazin?.Name}");
                }

                var sortTovars = tovars.GroupBy(x => x.Price);

                Console.WriteLine($"id {magazin.Id}  name {magazin.Name}");

                foreach (var item in sortTovars)
                {
                    Console.WriteLine(item.Key + " - " + item.Count());
                }

                
                Console.ReadKey();
            }
        }
    }
}
