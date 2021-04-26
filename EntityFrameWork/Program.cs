using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EntityFrameWork
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DatabaseFirstOefEntities ctx = new DatabaseFirstOefEntities())
            {

                Console.WriteLine("Eerste oef: \n");
                foreach (var item in ctx.Customers)
                {
                    Console.WriteLine($"{item.id}, {item.first_name}, {item.last_name}, {item.age}");
                }

                Console.WriteLine("\nTweede oef:\n");
                var collection = ctx.Customers.Select(c => c.first_name);
                foreach (var item in collection)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("\nDerde oef:\n");
                var collectionOef3 = ctx.Customers.OrderBy(c => c.age).Select(c => c.first_name);
                foreach (var item in collectionOef3)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("\nVierde oef:\n");

                var collectionOef4 = ctx.Customers.Select(c => c.last_name).ToArray();
                var reversed = collectionOef4;
                



                foreach (var item in collectionOef4)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("\nVijfde oef:\n");

                var collectionOef5 = ctx.Customers.GroupBy(c => c.age);
                foreach (var group in collectionOef5)
                {
                    Console.WriteLine(group.Key);
                    foreach (var item in group)
                    {
                        Console.WriteLine("> " + item.first_name);
                    }
                }

                Console.WriteLine("\nZesde oef:\n");

                var collectionOef6 = ctx.Customers.OrderBy(c => c.last_name.Length).ThenBy(c => c.first_name.Length);
                foreach (var item in collectionOef6)
                {
                    Console.WriteLine(item.first_name + " " + item.last_name);
                }
                Console.WriteLine("\nZevende oef:\n");

                //var collectionOef7 = ctx.Customers.Add(new Customer() { first_name = "Quinten", last_name = "Davids", age = 24 });
                //ctx.SaveChanges();
                Console.WriteLine("\nAchtste oef:\n");
                //var collectionOef8 = ctx.Customers.Remove(ctx.Customers.FirstOrDefault(c => c.id == 1));
                var collectionOef9 = ctx.Customers.FirstOrDefault(c => c.first_name == "Anke" && c.last_name == "Hedeman").age = 40;
                ctx.SaveChanges();
                foreach (var item in ctx.Customers)
                {
                    Console.WriteLine(item.id + "" + item.first_name + " " + item.last_name + " " + item.age );
                }
                var collectionOef10 = ctx.Customers.Select(c => c);
                
                
            }
            Console.ReadLine();
        }
    }
}
