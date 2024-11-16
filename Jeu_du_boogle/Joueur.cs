using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Jeu_du_boogle
{
    public class Joueur
    {
        //-----[ Attributs ]-----//
        #region Attributs

        private string nom;
        private int score;
        private List<string> motsTrouves;

        #endregion


        //---[ Constructeurs ]---//
        #region Constructeurs

        // Constructeur naturel
        public Joueur() { }

        // Constructeur avec paramètres
        public Joueur(string nom, int score, List<string> motsTrouves)
        {
            if (nom != null) this.nom = nom;
            this.score = score;
            this.motsTrouves = motsTrouves;
        }

        // Constructeur par clônage
        public Joueur(Joueur g)
        {
            if (nom != null) this.nom = g.nom;
            this.score = g.score;
            this.motsTrouves = g.motsTrouves;
        }

        #endregion


        //----[ Propriétés ]----//
        #region Propriétés

        public string Nom
        {
            get { return this.nom; }
        }

        public int Score
        {
            get { return this.score; }
        }

        public int NbMotsTrouves
        {
            get { return this.motsTrouves.Count; }
        }

        public List<string> MotsTrouves
        {
            get { return this.motsTrouves; }
            set { this.motsTrouves = value; }
        }

        #endregion


        //-----[ Méthodes ]-----//
        #region Méthodes

        /// <summary>
        /// Teste si "mot" appartient aux mots trouvés par le joueur
        /// </summary>
        /// <param name="mot"></param>
        /// <returns></returns>
        public bool Contain(string mot)
        {
            return this.motsTrouves.Contains(mot.ToUpper());
        }

        public void Add_Mot(string mot)
        {
            this.motsTrouves.Add(mot.ToUpper());
        }

        public string toString()
        {
            string s = "Nom : " + this.nom + "\n"
                     + "Score : " + this.score + "\n"
                     + "Mots trouvés : " + "\n";

            for (int i = 0; i < this.motsTrouves.Count; i++)
            {
                s += this.motsTrouves[i].ToUpper() + "\n";
            }

            return s;
        }

        #endregion
    }
}
