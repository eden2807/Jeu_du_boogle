using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_du_boogle
{
    public class Joueur
    {
        //-----[ Attributs ]-----//
        #region Attributs

        private string nom;
        private int score;
        private int nbMotsTrouves;

        #endregion


        //---[ Constructeurs ]---//
        #region Constructeurs

        // Constructeur naturel
        public Joueur() { }

        // Constructeur avec paramètres
        public Joueur(string nom, int score, int nbMotsTrouves)
        {
            this.nom = nom;
            this.score = score;
            this.nbMotsTrouves = nbMotsTrouves;
        }

        // Constructeur par clônage
        public Joueur(Joueur g)
        {
            this.nom = g.nom;
            this.score = g.score;
            this.nbMotsTrouves = g.nbMotsTrouves;
        }

        #endregion


        //----[ Propriétés ]----//
        #region Propriétés

        #endregion


        //-----[ Méthodes ]-----//
        #region Méthodes

        #endregion
    }
}
