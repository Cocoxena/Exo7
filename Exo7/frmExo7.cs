using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exo6; // ajouté manuellement

namespace Exo7
{
    public partial class frmExo7 : Form
    {
        /*private DialogResult reponse;*/

        public frmExo7()
        {
            InitializeComponent();
        }

        /// <summary>
        /// désactiver les boutons Rechercher et supprimer si aucun stagiaire dans la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmExo7_Load(object sender, EventArgs e)
        {
            if (Donnees.ArrayStag.Count == 0)
            {
                this.btnRechercher.Enabled = false;
                this.btnSupprimer.Enabled = false;
            }
        }
        
        /// <summary>         
        /// rétablit la source de données de la dataGridView  
        /// et rafraîchit son affichage         
        /// </summary>   
        private void afficheStagiaires()
        {
            // DataTable : pour recopier les stagiaires             
            // (stockés en collection) ;             
            // à relier au DataGridView pour personnaliser son affichage            
            DataTable dt = new DataTable();
            DataRow dr;    // ligne de la datatable             
            Int32 i;       // var de boucle 

            // ajout à la datatable de 3 colonnes personnalisées 
            dt.Columns.Add(new DataColumn("Numéro OSIA", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Prénom", typeof(System.String)));

            // boucle remplissage de la DataTable à partir de la collection  
            for (i = 0; i < Donnees.ArrayStag.Count; i++)
            {
                // instanciation DataRow (=ligne de DataTable)                 
                dr = dt.NewRow();
                // affectation des 3 colonnes                
                // la collection voit les éléments comme des ‘Object’                  
                // ==>'caster' en MStagiaire pour en voir les attributs                
                dr[0] = ((MStagiaire)(Donnees.ArrayStag[i])).NumOsia;
                dr[1] = ((MStagiaire)(Donnees.ArrayStag[i])).Nom;
                dr[2] = ((MStagiaire)(Donnees.ArrayStag[i])).Prenom;
                // ajout de la ligne à la Datatable                 
                // (la propriété Rows est elle-même une collection...)                 
                dt.Rows.Add(dr);
            }
            // fin de boucle       
            
            // déterminer l'origine des données à afficher en DataGridView  
            // on pourrait donner la DataTable, on choisit la vue associée à la DataTable    
            // pour pouvoir effectuer des sélections directes
            this.grdStagiaires.DataSource = dt.DefaultView;
            // refraîchir l'affichage (même pas utile…)             
            this.grdStagiaires.Refresh();
            dt = null; // pas vraiment utile non plus…             
            dr = null;
        }


        /// <summary>        
        /// bouton Ajouter : instancier un form de saisie de stagiaire
        /// puis réafficher la datagridview
        /// + activation des boutons Supprimer et Rechercher
        /// </summary>         
        /// <param name="sender"></param>     
        /// <param name="e"></param>   
        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            // instancie un form de saisie de stagiaire et l'affiche en modal             
            frmAjouterStagiaire frmAjout = new frmAjouterStagiaire();
            // si on sort de la saisie par OK             
            if (frmAjout.ShowDialog() == DialogResult.OK)
            {
                // régénère l'affichage du dataGridView                  
                afficheStagiaires();
            }
            this.btnRechercher.Enabled = true;
            this.btnSupprimer.Enabled = true;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>         
        /// Double-clic sur le datagridview :  
        /// ouvrir la feuille détail en y affichant       
        /// le stagiaire correspondant à la ligne double-cliquée        
        /// </summary>         
        /// <param name="sender"></param>
        /// <param name="e"></param>   
        private void grdStagiaires_DoubleClick(object sender, EventArgs e)
        {
            // ouvrir la feuille détail en y affichant              
            // le stagiaire correspondant à la ligne double-cliquée 

            Int32 iStag;        // rang du stagiaire dans le tableau 

            // récupérer indice du stagiaire cliqué en DataGridView             
            iStag = this.grdStagiaires.CurrentRow.Index;


            /*
            //variable de réponse
            DialogResult = reponse;

            reponse = MessageBox.Show("Vous avez choisi ce stagiaire. ", "Sélection du stagiaire", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (reponse == DialogResult.No)
            {
                this.afficheStagiaires();
            }
            
            else
            {
                // récupérer indice du stagiaire cliqué en DataGridView             
                // ou afficher le afficher le form détail en modal
                frmVisualiser.ShowDialog(); // pas déclarée
            }
            */


            // instancier un objet stagiaire pointant vers              
            // le stagiaire d'origine dans la collection            
            MStagiaire leStagiaire = Donnees.ArrayStag[iStag] as MStagiaire;

            // instancier un form détail pour ce stagiaire             
            frmVisualiserStagiaire frmVisualiser = new frmVisualiserStagiaire(leStagiaire);
            // afficher le form détail en modal             
            frmVisualiser.ShowDialog();

            // en sortie du form détail, rafraichir la datagridview             
            this.afficheStagiaires();
            
        }

        private void grdStagiaires_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary> 
        /// filter les stagiaires affichées dans la DataGridView 
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (this.txtNomRecherche.Text != null)
            {
                // filter la vue associée à la DataTable     
                // (syntaxe de clause where SQL)      
                ((DataView)(this.grdStagiaires.DataSource)).RowFilter = "Nom like '%" + this.txtNomRecherche.Text + "%'";
            }
        }

        /// <summary> 
        /// Réafficher tous les stagiaires en supprimant le filtre 
        /// </summary> 
        /// <param name="sender"></param> 
        /// <param name="e"></param>
        private void btnTous_Click(object sender, EventArgs e)
        {
            this.txtNomRecherche.Text = null;
            ((DataView)(this.grdStagiaires.DataSource)).RowFilter = null;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Int32 istag;
            istag = this.grdStagiaires.CurrentRow.Index;
            Donnees.ArrayStag.RemoveAt(istag);

            if (Donnees.ArrayStag.Count == 0)
            {
                this.btnSupprimer.Enabled = false;
            }
            afficheStagiaires();
        }

        private void txtNomRecherche_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
