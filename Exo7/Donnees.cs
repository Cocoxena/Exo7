using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Exo6
{
    /// <summary> 
    /// classe générale des données à gérer 
    /// ----------------------------------- 
    /// classe qui regroupe les données
    /// de l'application de gestion des stagiaires 
    /// dans une collection d'objets définie en static (= non instanciable)  
    /// </summary>  

    public class Donnees
    {
        /// <summary>     
        /// collection d'objets MStagiaire     
        /// </summary>     
        public static ArrayList ArrayStag = new ArrayList(); 
    }
}
