using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_du_boogle
{
    public class De
    {

        //-----[ Attributs ]-----//
        #region Attributs
        string[] lettres;
        int face;

        char Lettre_Visible;
        #endregion

        //---[ Constructeurs ]---//
        #region Constructeurs
        public De(string[] lettres) 
        {
            if (lettres.Length != 6)
                throw new ArgumentException("Le dé doit avoir 6 lettres exactement");
            //si la taille de lettres est différente de 6, on sort.
            

            for(int i = 0; i < lettres.Length; i++)
            {
                char dumpchar = lettres[0][i];
                for(int j = 0; j < lettres[i].Length; j++)
                {
                    if (lettres[i][j] == dumpchar) // on vérifie que chaque caractère est unique à la main.
                    {
                        throw new ArgumentException("les lettres ne sont pas uniques !"); 
                    }
                }
            }

            this.lettres = lettres;
            this.face = 0;
        }
        #endregion

        //----[ Propriétés ]----//
        #region Propriétés

        public string[] Lettres
        {
            get { return this.lettres; }
        }



        #endregion


        //-----[ Méthodes ]-----//
        #region Méthodes

        #endregion
    }

}
