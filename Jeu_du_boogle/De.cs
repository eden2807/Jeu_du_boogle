using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Jeu_du_boogle
{
    public class De
    {

        //-----[ Attributs ]-----//
        #region Attributs

        string lettresDe;
        char lettreVisible;
        string lettresTxt = "Lettres.txt";

        #endregion


        //---[ Constructeurs ]---//
        #region Constructeurs

        // Constructeur naturel
        public De() 
        {
            Random nbAlea = new Random();

            // le dé a 6 faces, on génère donc une chaîne de 6 caractères aléatoires
            for (int i = 0; i < 6; i++)
            {
                nbAlea.Next(1, 101); // on choisit un nombre au hasard entre 1 et 100
                //this.lettresDe += ???;
            }

            this.lettresDe = "ABCDEF"; // temporaire

            this.lettreVisible = 'A'; // temporaire

            /*
            if (lettresDe.Length != 6)
                throw new ArgumentException("Le dé doit avoir 6 lettres exactement");
            // si la taille de lettres est différente de 6, on sort.

            for (int i = 0; i < lettresDe.Length; i++)
            {
                char dumpchar = lettresDe[0][i];
                for(int j = 0; j < lettresDe[i].Length; j++)
                {
                    if (lettresDe[i][j] == dumpchar) // on vérifie que chaque caractère est unique à la main.
                    {
                        throw new ArgumentException("les lettres ne sont pas uniques !"); 
                    }
                }
            }

            this.lettres = lettres;
            this.face = 0;
            */
        }

        #endregion


        //----[ Propriétés ]----//
        #region Propriétés

        public string LettresDe
        {
            get { return this.lettresDe; }
        }

        public char LettreVisible
        {
            get { return this.lettreVisible; }
        }

        #endregion


        //-----[ Méthodes ]-----//
        #region Méthodes

        /// <summary>
        /// Insère les valeurs du fichier "lettresTxt" dans un dictionnaire,
        /// dont les clés sont représentées par les lettres de l'alphabet,
        /// et chaque lettre (clé du dictionnaire) associe un tableau d'entiers de 3 colonnes.
        /// Voir détails plus bas...
        /// </summary>
        /// 
        /// <returns>
        /// La clé < A > de dict correspond au tableau :  [ 1 ; 9 ; 9 ]
        /// La clé < B > de dict correspond au tableau :  [ 3 ; 2 ; 11 ]
        /// La clé < C > de dict correspond au tableau :  [ 3 ; 2 ; 13 ]
        /// ...
        /// La clé < Z > de dict correspond au tableau : [ 10 ; 1 ; 100 ]
        /// </ returns >
        public Dictionary<char, int[]> LettresDictionnaire()
        {
            Dictionary<char, int[]> dict = new Dictionary<char, int[]>();
            int[] tabLigne;
            string[] lignes = File.ReadAllLines(this.lettresTxt);

            for (int i = 0; i < 26; i++) // 26 étant le nombre de lettres de l'alphabet
            {
                tabLigne = new int[3];
                // La colonne < 0 > représente le < poids > de la lettre
                // La colonne < 1 > représente la < fréquence d'apparition > de la lettre
                // La colonne < 2 > représente la < somme cumulative > des fréquences d'apparitions

                for (int j = 1; j <= 2; j++) // on récupère les 2 dernières colonnes de "lettresTxt"...
                {
                    // ... et on les insère dans les colonnes 0 et 1 de "tabLigne"
                    tabLigne[j-1] = int.Parse(lignes[i].Split(';')[j]);
                }

                // remplissage de la colonne 2 de "tabLigne"
                if (i == 0) tabLigne[2] = tabLigne[1]; // initialisation
                else tabLigne[2] += tabLigne[1] + dict[lignes[i-1][0]][2]; // somme cumulative

                // une fois qu'on a fini de remplir "tabLigne" on l'insère dans le dictionnaire
                dict.Add(lignes[i][0], tabLigne);
            }

            return dict;
        }

        public string AfficherDictionnaire(Dictionary<char, int[]> dict)
        {
            string str = "";

            if (dict != null)
            {
                if (dict.Count > 0)
                {
                    if (dict.Values != null) // vérification de l'existence des tableaux
                    {
                        foreach (var cle in dict.Keys)
                        {
                            // pour chaque clé on vérifie si le tableau a une longueur > 0
                            if (dict[cle].Length > 0)
                            {
                                str += cle + " : [ ";

                                for (int i = 0; i < dict[cle].Length - 1; i++)
                                {
                                    str += dict[cle][i] + " ; ";
                                }
                                str += dict[cle][dict[cle].Length - 1];

                                str += " ]\n";
                            }
                        }
                    }
                }
            }

            return str;
        }

        public Dictionary<char, int> charger_occurences_lettres()
        {

            Dictionary<char, int> Lettre_Occurrence = new Dictionary<char, int>();
            string[] tab_ligne_occurence = new string[2];
            string[] lignes_fichier = File.ReadAllLines(this.lettresTxt);
            char key;
            int value;
            for(int i =0; i < 26; i++)
            {
                tab_ligne_occurence[0] = lignes_fichier[i].Split(';')[0];
                tab_ligne_occurence[1] = lignes_fichier[i].Split(';')[2];

                key = char.Parse(tab_ligne_occurence[0]);
                value = int.Parse(tab_ligne_occurence[1]);

                Lettre_Occurrence.Add(key, value);

                tab_ligne_occurence[0] = "";
                tab_ligne_occurence[1] = "";
            }

            return Lettre_Occurrence;
        }

        #endregion
    }
}