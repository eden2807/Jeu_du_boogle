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

            Console.WriteLine("---[ BIENVENUE AU JEU DU BOGGLE ! ]---\n");

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


            //--------------------[ Déroulement du jeu ]--------------------//

            // Tests classe JOUEUR //

            /*
            List<string> listeMots = new List<string>();

            listeMots.Add("COUCOU");
            listeMots.Add("BONJOUR");
            listeMots.Add("SALUT");
            listeMots.Add("LOL");
            Console.WriteLine(listeMots.Count);

            joueur1.MotsTrouves = listeMots;
            Console.WriteLine(listeMots[0]);
            Console.WriteLine(joueur1.Contain("COUCOU"));
            Console.WriteLine(joueur1.Contain("Coucou"));

            joueur1.Add_Mot("HellO");
            Console.WriteLine(joueur1.MotsTrouves[4]);
            Console.WriteLine(joueur1.Contain("Hello"));
            Console.WriteLine();

            Console.WriteLine(joueur1.toString());
            */

            // Tests classe DE //

            De de = new De();
            Dictionary<char, int[]> testDict = de.LettresDictionnaire();
            Console.WriteLine(de.AfficherDictionnaire(testDict));
        }
    }
}
