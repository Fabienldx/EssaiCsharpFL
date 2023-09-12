using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssaiCsharpFL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quel est votre nom ?");
            string nom = Console.ReadLine();
            Console.WriteLine("Quel est votre prénom ?");
            string prenom = Console.ReadLine();
            Console.WriteLine("Quel est votre âge ?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Votre nom et prénom sont {0} {1}, et vous avez {2} ans", nom, prenom, age);
            Console.ReadKey();
        }
    }
}
