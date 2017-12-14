using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Exo7;   // ajouté manuellement

namespace Exo6
{
    public partial class frmAjouterStagiaire : Exo6.frmStagiaire
    {
        public frmAjouterStagiaire()
        {
            InitializeComponent();
        }

        /// <summary> 
        /// méthode déclenchée par le bouton OK :  
        /// instancie un Objet MSstagiaire et le renseigne
        /// puis le référence dans la collection d’objets 
        /// </summary> /// <param name="sender"></param> 
        /// <param name="e"></param> 
        private void btnOK_Click(object sender, EventArgs e)
        {
            // controle vraissemblance des données saisies sur le form 
            if (this.controle())
            {
                if (this.instancie())
                {
                    // cas général : 
                    // si l'instanciation stagiaire et 
                    // son ajout à la collection est OK :     
                    // - incrémentation compteurs de stagiaires  
                    MStagiaire.Nstag += 1;
                    // - fermeture de la boite de dialogue par validation           
                    this.DialogResult = DialogResult.OK;
                }
            }
            
            /*

            // créer une référence d'objet MStagiaire 
            MStagiaire nouveauStagiaire = new MStagiaire();

            try
            {
                // affecter les données de l'objet MStagiaire :          
                // variables simples, ou propriétés ce qui déclenche alors          
                // le code des méthodes set         //          
                // conversion NumOsia saisi en textbox vers le type integer         
                nouveauStagiaire.NumOsia = Int32.Parse(base.txtNumero.Text.Trim());
                // avec conversion en MAJ         
                nouveauStagiaire.Nom = base.txtNom.Text;
                // avec conversion en min         
                nouveauStagiaire.Prenom = base.txtPrenom.Text;
                nouveauStagiaire.Rue = base.txtAdresse.Text;
                // avec conversion en MAJ         
                nouveauStagiaire.Ville = base.txtVille.Text;
                // avec controle de saisie         
                nouveauStagiaire.CodePostal = base.txtCodePostal.Text.Trim();
                //ajouter la référence d'objet MStagiaire dans la collection         
                Donnees.ArrayStag.Add(nouveauStagiaire);
            }
            catch (Exception ex)
            {
                nouveauStagiaire = null;
                MessageBox.Show("Erreur: \n" + ex.Message, "Ajout de stagiaire");
            }
            
            // incrémentation compteur de stagiaires         
            MStagiaire.Nstag += 1;
            // fermeture de la boite de dialogue par validation  
            this.DialogResult = DialogResult.OK;

           */
        }

        /// <summary>         
        /// fonction de contrôle de vraissemblance des différents          
        /// champs du form :          
        /// (appelée avant d'instancier un objet MStagiaire       
        /// et d'affecter ses membres) 
        /// </summary>         
        /// <returns> Booléen : true = OK, false = erreur</returns>         
        private Boolean controle()
        {
            // contrôler la vraissemblance de tous les champs   
            Boolean code = true; // le code de retour ; OK a priori 

            // appel fonction générique de contrôle     
            if (!(Outils.EstEntier(this.txtNumero.Text)))
            {
                // la chaîne reçue n'est pas convertible     
                code = false;
                MessageBox.Show("le code OSIA saisi n'est pas un entier valide", "ERREUR", MessageBoxButtons.OK);
            }
            if (!(Outils.EstEntier(this.txtCodePostal.Text)))
            {
                code = false;
                MessageBox.Show("le code postal saisi n'est pas correct", "ERREUR", MessageBoxButtons.OK);
            }
            return code;
        }

        // suppression de la méthode estentier, remplacée par EstEntier qui appartient à la classe Outils
        /*
        /// <summary>  
        /// fonction générique de contrôle qu'une chaine reçue    
        /// pourra se convertir en Int32  
        /// </summary>       
        /// <returns> Booléen : true = OK, false = erreur</returns>     
        /// <param name="s">la String à controler</param>   
       
        private Boolean estEntier(String s)
        {
             vérifier que la chaine reçue représente bien un entier valide : 
             * - uniquement des chiffres              
             * - pas vide             
             * - pas plus de 9 chiffres (capacité maxi du type Int32)       
            
            Int32 i;                // indice de parcours de chaîne             
            Char c;                 // caractère courant             
            Boolean code = true;    // code retour; OK a priori 

            // test longueur chaîne reçue             
            if (s.Length < 10 && s.Length > 0)
            {
                // vérifier 1 à 1 que tous les caractères sont des chiffres                 
                for (i = 0; i < s.Length; i++)
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
        */
        


        /// <summary>
        /// fonction qui instancie un nouvel objet MStagiaire         
        /// puis tente d'affecter ses membres (var. ou prop.)  
        /// avec interception erreur éventuelle levée par la classe MStagiaire       
        /// </summary>         
        /// <returns>Boolean : true = OK, false = erreur</returns>        
        private Boolean instancie()
        {
            // créer une référence d'objet MStagiaire  
            MStagiaire nouveauStagiaire = new MStagiaire();
            try
            {
                // affecter les données de l'objet MStagiaire : 
                // variables simples, ou propriétés    
                // ce qui déclenche alors le code des méthodes set  
                //                  
                // conversion numosia saisi en textbox vers le type integer 
                nouveauStagiaire.NumOsia = Int32.Parse(base.txtNumero.Text.Trim());
                // avec conversion en MAJ                 
                nouveauStagiaire.Nom = base.txtNom.Text;
                // avec conversion en min                 
                nouveauStagiaire.Prenom = base.txtPrenom.Text;
                nouveauStagiaire.Rue = base.txtAdresse.Text;
                // avec conversion en MAJ                
                nouveauStagiaire.Ville = base.txtVille.Text;
                // avec controle de saisie                 
                nouveauStagiaire.CodePostal = base.txtCodePostal.Text.Trim();
                //ajouter la référence d'objet MStagiaire dans la collection              
                Donnees.ArrayStag.Add(nouveauStagiaire);
                return true;
            }
            catch (Exception ex)
            {
                nouveauStagiaire = null;
                MessageBox.Show("Erreur : \n" + ex.Message, "Ajout de stagiaire");
                return false;

            }
        }   

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // fermeture de la boite de dialogue par abandon     
            this.DialogResult = DialogResult.Cancel; 
        }

        private void frmAjouterStagiaire_Load(object sender, EventArgs e)
        {

        }
    }
}
