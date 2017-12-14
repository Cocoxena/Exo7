using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exo6;

namespace Exo7
{
    public class Outils
    {
        public static Boolean EstEntier(String s)
        {
            /* vérifier que la chaine reçue représente bien un entier valide : 
             * - uniquement des chiffres              
             * - pas vide             
             * - pas plus de 9 chiffres (capacité maxi du type Int32)       
             */
            Int32 i;                // indice de parcours de chaîne             
            Char c;                 // caractère courant             
            Boolean code = true;    // code retour; OK a priori 

            // test longueur chaîne reçue             
            if (s.Length< 10 && s.Length> 0)
            {
                // vérifier 1 à 1 que tous les caractères sont des chiffres                 
                for (i = 0; i<s.Length; i++)
                {
                    c = s[i]; // extrait le i° car                     
                    if (!(Char.IsDigit(c))) // si ce n'est pas un chiffre                     
                    {
                        code = false; // erreur détectée                     
                    }
                } // fin de boucle for             
            }
            else // erreur de longueur de chaine             
            {                 
            code = false; // erreur détectée             
            }
            return code;
        }

    }
}
