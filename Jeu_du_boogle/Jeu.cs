using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_du_boogle
{
    public class Jeu
    {
        
        public static void Main(string[] args)
        {
            //--------------------[ Configuration initiale ]--------------------//
            Random random;
            random = new Random();

            // Choix de la langue //
            #region Langue

            Console.WriteLine("---[ BIENVENUE AU JEU DU BOGGLE ! ]---\n");

            Console.WriteLine("Veuillez sélectionner la langue :");
            Console.WriteLine("\t Français : F");
            Console.WriteLine("\t English : E");

            // POUR TEST SEULEMENT - A VIRER ET DECOMMENTER LA LIGNE DU DESSOUS!
            string langue = "F";
            // string langue = "";
            do
            {
                Console.Write("---> ");
                // A DECOMMENTER - TEST SEULEMENT
                //langue = Console.ReadLine();
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
            De de2 = new De();

            de.Lance(random);
            //char valeurFace = 
            
            Dictionary<char, int[]> testDict = de.LettresDictionnaire();
            Console.WriteLine(de.AfficherDictionnaire(testDict));
        }
    }
}
