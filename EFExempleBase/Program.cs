using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFExempleBase
{
    class Program
    {
        static void Main(string[] args)
        {
            ContextDB context= new ContextDB();
            context.Database.Log =
                Console.WriteLine;

            Client cl = new Client()
            {
                Nom = "Mohamed",
                adresse = "Tanger"
            };

            context.Clients.Add(cl);
            context.SaveChanges();

            Console.ReadKey();
        }
    }
}
