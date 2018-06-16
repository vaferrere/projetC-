using BLL;
using Metier.Entities;
using Metier.FluentEntitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VueConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContextFluent context = new ContextFluent();
                Produit p = new Produit(452, "je suis le produit", "je suis la description", true, 45, 0.45, new Categorie("dat cat", true));
                context.Produits.Add(p);
                context.SaveChanges();
                List<Produit> list = context.Produits.ToList();

                foreach (Produit c in list)
                {
                    Console.WriteLine("yo:");
                    Console.WriteLine(c.Libelle);
                    Console.WriteLine(c.Categorie.Libelle);
                }

                Console.WriteLine("c'est ok!");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("il y a une erreur");
                Console.ReadLine();
            }

        }
    }
}
