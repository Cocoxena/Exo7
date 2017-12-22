namespace Appli1
{
    partial class frmAppli1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxVitesse = new System.Windows.Forms.GroupBox();
            this.gbxTemperature = new System.Windows.Forms.GroupBox();
            this.rbtVitesse100 = new System.Windows.Forms.RadioButton();
            this.rbtVitesse200 = new System.Windows.Forms.RadioButton();
            this.rbtVitesse300 = new System.Windows.Forms.RadioButton();
            this.rbtVitesse500 = new System.Windows.Forms.RadioButton();
            this.rbtTemp50 = new System.Windows.Forms.RadioButton();
            this.rbtTemp80 = new System.Windows.Forms.RadioButton();
            this.rbtTemp100 = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnRetablir = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.gbxParametres = new System.Windows.Forms.GroupBox();
            this.lblVitesse = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.txtVitesse = new System.Windows.Forms.TextBox();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.gbxVitesse.SuspendLayout();
            this.gbxTemperature.SuspendLayout();
            this.gbxParametres.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxVitesse
            // 
            this.gbxVitesse.Controls.Add(this.rbtVitesse500);
            this.gbxVitesse.Controls.Add(this.rbtVitesse300);
            this.gbxVitesse.Controls.Add(this.rbtVitesse200);
            this.gbxVitesse.Controls.Add(this.rbtVitesse100);
            this.gbxVitesse.Location = new System.Drawing.Point(25, 12);
            this.gbxVitesse.Name = "gbxVitesse";
            this.gbxVitesse.Size = new System.Drawing.Size(381, 91);
            this.gbxVitesse.TabIndex = 0;
            this.gbxVitesse.TabStop = false;
            this.gbxVitesse.Text = "Vitesse du mélangeur en tours par minute";
            // 
            // gbxTemperature
            // 
            this.gbxTemperature.Controls.Add(this.rbtTemp100);
            this.gbxTemperature.Controls.Add(this.rbtTemp80);
            this.gbxTemperature.Controls.Add(this.rbtTemp50);
            this.gbxTemperature.Location = new System.Drawing.Point(25, 109);
            this.gbxTemperature.Name = "gbxTemperature";
            this.gbxTemperature.Size = new System.Drawing.Size(294, 83);
            this.gbxTemperature.TabIndex = 1;
            this.gbxTemperature.TabStop = false;
            this.gbxTemperature.Text = "Température du mélangeur";
            // 
            // rbtVitesse100
            // 
            this.rbtVitesse100.AutoSize = true;
            this.rbtVitesse100.Location = new System.Drawing.Point(21, 38);
            this.rbtVitesse100.Name = "rbtVitesse100";
            this.rbtVitesse100.Size = new System.Drawing.Size(43, 17);
            this.rbtVitesse100.TabIndex = 0;
            this.rbtVitesse100.TabStop = true;
            this.rbtVitesse100.Text = "100";
            this.rbtVitesse100.UseVisualStyleBackColor = true;
            // 
            // rbtVitesse200
            // 
            this.rbtVitesse200.AutoSize = true;
            this.rbtVitesse200.Location = new System.Drawing.Point(113, 38);
            this.rbtVitesse200.Name = "rbtVitesse200";
            this.rbtVitesse200.Size = new System.Drawing.Size(43, 17);
            this.rbtVitesse200.TabIndex = 1;
            this.rbtVitesse200.TabStop = true;
            this.rbtVitesse200.Text = "200";
            this.rbtVitesse200.UseVisualStyleBackColor = true;
            // 
            // rbtVitesse300
            // 
            this.rbtVitesse300.AutoSize = true;
            this.rbtVitesse300.Location = new System.Drawing.Point(203, 38);
            this.rbtVitesse300.Name = "rbtVitesse300";
            this.rbtVitesse300.Size = new System.Drawing.Size(43, 17);
            this.rbtVitesse300.TabIndex = 2;
            this.rbtVitesse300.TabStop = true;
            this.rbtVitesse300.Text = "300";
            this.rbtVitesse300.UseVisualStyleBackColor = true;
            // 
            // rbtVitesse500
            // 
            this.rbtVitesse500.AutoSize = true;
            this.rbtVitesse500.Location = new System.Drawing.Point(295, 38);
            this.rbtVitesse500.Name = "rbtVitesse500";
            this.rbtVitesse500.Size = new System.Drawing.Size(43, 17);
            this.rbtVitesse500.TabIndex = 3;
            this.rbtVitesse500.TabStop = true;
            this.rbtVitesse500.Text = "500";
            this.rbtVitesse500.UseVisualStyleBackColor = true;
            // 
            // rbtTemp50
            // 
            this.rbtTemp50.AutoSize = true;
            this.rbtTemp50.Location = new System.Drawing.Point(21, 36);
            this.rbtTemp50.Name = "rbtTemp50";
            this.rbtTemp50.Size = new System.Drawing.Size(37, 17);
            this.rbtTemp50.TabIndex = 0;
            this.rbtTemp50.TabStop = true;
            this.rbtTemp50.Text = "50";
            this.rbtTemp50.UseVisualStyleBackColor = true;
            // 
            // rbtTemp80
            // 
            this.rbtTemp80.AutoSize = true;
            this.rbtTemp80.Location = new System.Drawing.Point(113, 36);
            this.rbtTemp80.Name = "rbtTemp80";
            this.rbtTemp80.Size = new System.Drawing.Size(37, 17);
            this.rbtTemp80.TabIndex = 1;
            this.rbtTemp80.TabStop = true;
            this.rbtTemp80.Text = "80";
            this.rbtTemp80.UseVisualStyleBackColor = true;
            // 
            // rbtTemp100
            // 
            this.rbtTemp100.AutoSize = true;
            this.rbtTemp100.Location = new System.Drawing.Point(203, 36);
            this.rbtTemp100.Name = "rbtTemp100";
            this.rbtTemp100.Size = new System.Drawing.Size(43, 17);
            this.rbtTemp100.TabIndex = 2;
            this.rbtTemp100.TabStop = true;
            this.rbtTemp100.Text = "100";
            this.rbtTemp100.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(332, 208);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(74, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnRetablir
            // 
            this.btnRetablir.Location = new System.Drawing.Point(332, 246);
            this.btnRetablir.Name = "btnRetablir";
            this.btnRetablir.Size = new System.Drawing.Size(74, 23);
            this.btnRetablir.TabIndex = 3;
            this.btnRetablir.Text = "Rétablir";
            this.btnRetablir.UseVisualStyleBackColor = true;
            this.btnRetablir.Click += new System.EventHandler(this.btnRetablir_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(332, 288);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(74, 23);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // gbxParametres
            // 
            this.gbxParametres.Controls.Add(this.txtTemperature);
            this.gbxParametres.Controls.Add(this.txtVitesse);
            this.gbxParametres.Controls.Add(this.lblTemperature);
            this.gbxParametres.Controls.Add(this.lblVitesse);
            this.gbxParametres.Location = new System.Drawing.Point(25, 208);
            this.gbxParametres.Name = "gbxParametres";
            this.gbxParametres.Size = new System.Drawing.Size(294, 103);
            this.gbxParametres.TabIndex = 5;
            this.gbxParametres.TabStop = false;
            this.gbxParametres.Text = "Paramètres obtenus";
            // 
            // lblVitesse
            // 
            this.lblVitesse.AutoSize = true;
            this.lblVitesse.Location = new System.Drawing.Point(8, 32);
            this.lblVitesse.Name = "lblVitesse";
            this.lblVitesse.Size = new System.Drawing.Size(50, 13);
            this.lblVitesse.TabIndex = 0;
            this.lblVitesse.Text = "Vitesse : ";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(6, 74);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(76, 13);
            this.lblTemperature.TabIndex = 1;
            this.lblTemperature.Text = "Température : ";
            // 
            // txtVitesse
            // 
            this.txtVitesse.Location = new System.Drawing.Point(82, 29);
            this.txtVitesse.Name = "txtVitesse";
            this.txtVitesse.Size = new System.Drawing.Size(191, 20);
            this.txtVitesse.TabIndex = 2;
            this.txtVitesse.TextChanged += new System.EventHandler(this.txtVitesse_TextChanged);
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(82, 71);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(191, 20);
            this.txtTemperature.TabIndex = 3;
            this.txtTemperature.TextChanged += new System.EventHandler(this.txtTemperature_TextChanged);
            // 
            // frmAppli1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 323);
            this.Controls.Add(this.gbxParametres);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRetablir);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbxTemperature);
            this.Controls.Add(this.gbxVitesse);
            this.Name = "frmAppli1";
            this.Text = "Paramètres de l\'analyseur";
            this.Load += new System.EventHandler(this.frmAppli1_Load);
            this.gbxVitesse.ResumeLayout(false);
            this.gbxVitesse.PerformLayout();
            this.gbxTemperature.ResumeLayout(false);
            this.gbxTemperature.PerformLayout();
            this.gbxParametres.ResumeLayout(false);
            this.gbxParametres.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxVitesse;
        private System.Windows.Forms.RadioButton rbtVitesse500;
        private System.Windows.Forms.RadioButton rbtVitesse300;
        private System.Windows.Forms.RadioButton rbtVitesse200;
        private System.Windows.Forms.RadioButton rbtVitesse100;
        private System.Windows.Forms.GroupBox gbxTemperature;
        private System.Windows.Forms.RadioButton rbtTemp100;
        private System.Windows.Forms.RadioButton rbtTemp80;
        private System.Windows.Forms.RadioButton rbtTemp50;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnRetablir;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.GroupBox gbxParametres;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.TextBox txtVitesse;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblVitesse;
    }
}

