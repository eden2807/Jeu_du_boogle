using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_du_boogle
{
    public static class Jeu
    {
        public static void Main(string[] args)
        {
            // Configuration initiale //

            Console.WriteLine("---[ BIENVENUE AU JEU DU BOOGLE ! ]---\n");

            Console.WriteLine("Veuillez sélectionner la langue :");
            Console.WriteLine("\t Français : F");
            Console.WriteLine("\t English : E");

            char langue;
            do
            {
                Console.Write("--->");
                langue = Convert.ToChar(Console.ReadLine());
                if (langue != 'E' || langue != 'F') Console.WriteLine("Le caractère saisi est invalide. Veuillez recommencer.");
            }
            while (langue != 'E' || langue != 'F');

            if (langue == 'F') Console.WriteLine("---[ Vous avez sélectionné FRANCAIS ]---");
            if (langue == 'E') Console.WriteLine("---[ You have selected ENGLISH ]---");
        }
    }
}
