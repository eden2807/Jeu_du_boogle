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