using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_du_boogle
{
    internal class Jeu
    {
        public static void Main(string[] args)
        {
//--------------------[ Configuration initiale ]--------------------//

            // Choix de la langue //
            #region Langue

            Console.WriteLine("---[ BIENVENUE AU JEU DU BOOGLE ! ]---\n");

            Console.WriteLine("Veuillez sélectionner la langue :");
            Console.WriteLine("\t Français : F");
            Console.WriteLine("\t English : E");

            string langue;
            do
            {
                Console.Write("---> ");
                langue = Console.ReadLine();
                if (langue != "E" && langue != "F") Console.WriteLine("Le caractère saisi est invalide. Veuillez recommencer.");
            }
            while (langue != "E" && langue != "F");
            Console.WriteLine();

            if (langue == "F") Console.WriteLine("---[ Vous avez sélectionné FRANCAIS ]---\n");
            if (langue == "E") Console.WriteLine("---[ You have selected ENGLISH ]---\n");

            // Il manquera la configuration des fichiers dictionnaire (et lettres ?) en fonction de la langue

            #endregion

            // Taille du plateau //
            #region Plateau

            #endregion

            // Pseudos des joueurs //
            #region Pseudos

            Joueur joueur1 = new Joueur("toto", 0, null);
            Joueur joueur2 = new Joueur("toto2", 0, null);

            #endregion


//--------------------[ Les parties du jeu ]--------------------//

            List<string> listeMots = new List<string>();

            listeMots.Add("Coucou");
            listeMots.Add("Bonjour");
            listeMots.Add("Aucune");
            listeMots.Add("Idée");

            Console.WriteLine(listeMots.Count);
            listeMots.Add("Salut");
            Console.WriteLine(listeMots.Count);

            joueur1.MotsTrouves = listeMots;
            Console.WriteLine(joueur1.Contain("Coucou"));
        }
    }
}
