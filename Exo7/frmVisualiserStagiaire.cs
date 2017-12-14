using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Exo6; // ajouté manuellement

namespace Exo7
{
    public partial class frmVisualiserStagiaire : Exo6.frmStagiaire
    {


        public frmVisualiserStagiaire(MStagiaire unStagiaire)
        {
            // créer une référence d’objet stagiaire              
            // pointant vers le stagiaire reçu en paramètre            
            this.leStagiaire = unStagiaire;

            InitializeComponent();
        }
        /// <summary>         
        /// la référence du stagiaire à afficher / modifier         
        /// </summary>         
        private MStagiaire leStagiaire;

        /// <summary>         
        /// constructeur adapté : mémorise le stagiaire à traiter 
        /// </summary>         
        /// <param name="unStagiaire">la reférence de l'objet MStagiaire à gérer dans ce form</param>
        private void frmVisualiserStagiaire_Load(object sender, EventArgs e)
        {
            // afficher le stagiaire 
            this.afficheStagiaire(this.leStagiaire);
        }

        /// <summary>        
        /// cette procédure affiche en textbox les données d'un stagiaire reçu        
        /// </summary>         
        /// <param name="unStagiaire">la référence du stagiaire à afficher</param>     
        private void afficheStagiaire(MStagiaire unStagiaire)
        {
            // affecter les textbox             
            this.txtNumero.Text = unStagiaire.NumOsia.ToString();
            this.txtNom.Text = unStagiaire.Nom;
            this.txtPrenom.Text = unStagiaire.Prenom;
            this.txtAdresse.Text = unStagiaire.Rue;
            this.txtCodePostal.Text = unStagiaire.CodePostal.ToString();
            this.txtNom.Text = unStagiaire.Nom;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // fermeture de la boite de dialogue par abandon des modifications effectuées    
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // fermeture de la boite de dialogue avec sauvegarde des données modifiées    
            Int32 istag = Donnees.ArrayStag.IndexOf(leStagiaire);
            ((MStagiaire)Donnees.ArrayStag[istag]).NumOsia = Int32.Parse(this.txtNumero.Text.Trim());
            ((MStagiaire)Donnees.ArrayStag[istag]).Nom = this.txtNom.Text;
            ((MStagiaire)Donnees.ArrayStag[istag]).Prenom = this.txtPrenom.Text;
            ((MStagiaire)Donnees.ArrayStag[istag]).Rue = this.txtAdresse.Text;
            ((MStagiaire)Donnees.ArrayStag[istag]).Ville = this.txtVille.Text;
            ((MStagiaire)Donnees.ArrayStag[istag]).CodePostal = this.txtCodePostal.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // fermeture de la boite de dialogue avec suppression du stagiaire sélectionné  
            Donnees.ArrayStag.Remove(this.leStagiaire);
            this.DialogResult = DialogResult.OK;
            this.Close();
        
        }
    }
}
