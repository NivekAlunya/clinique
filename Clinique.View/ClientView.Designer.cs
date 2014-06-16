namespace Clinique.View
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbClient = new System.Windows.Forms.GroupBox();
            this.txtRechercherClient = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnSupprimerClient1 = new System.Windows.Forms.Button();
            this.btnAjouterClient1 = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtAdresse1 = new System.Windows.Forms.TextBox();
            this.txtAdresse2 = new System.Windows.Forms.TextBox();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.dgvAnimaux = new System.Windows.Forms.DataGridView();
            this.btnAjouterClient2 = new System.Windows.Forms.Button();
            this.btnSupprimerClient2 = new System.Windows.Forms.Button();
            this.btnEditerEditer = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.gpbClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimaux)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbClient
            // 
            this.gpbClient.Controls.Add(this.txtRechercherClient);
            this.gpbClient.Controls.Add(this.btnRechercher);
            this.gpbClient.Controls.Add(this.btnSupprimerClient1);
            this.gpbClient.Controls.Add(this.btnAjouterClient1);
            this.gpbClient.Controls.Add(this.btnDernier);
            this.gpbClient.Controls.Add(this.btnSuivant);
            this.gpbClient.Controls.Add(this.btnPrecedent);
            this.gpbClient.Controls.Add(this.btnPremier);
            this.gpbClient.Location = new System.Drawing.Point(0, 0);
            this.gpbClient.Name = "gpbClient";
            this.gpbClient.Size = new System.Drawing.Size(816, 89);
            this.gpbClient.TabIndex = 0;
            this.gpbClient.TabStop = false;
            // 
            // txtRechercherClient
            // 
            this.txtRechercherClient.Location = new System.Drawing.Point(579, 39);
            this.txtRechercherClient.Name = "txtRechercherClient";
            this.txtRechercherClient.Size = new System.Drawing.Size(100, 20);
            this.txtRechercherClient.TabIndex = 6;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(735, 12);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 71);
            this.btnRechercher.TabIndex = 7;
            this.btnRechercher.Text = "&Rechercher";
            this.btnRechercher.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnSupprimerClient1
            // 
            this.btnSupprimerClient1.Location = new System.Drawing.Point(456, 12);
            this.btnSupprimerClient1.Name = "btnSupprimerClient1";
            this.btnSupprimerClient1.Size = new System.Drawing.Size(75, 71);
            this.btnSupprimerClient1.TabIndex = 5;
            this.btnSupprimerClient1.Text = "&Supprimer";
            this.btnSupprimerClient1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSupprimerClient1.UseVisualStyleBackColor = true;
            // 
            // btnAjouterClient1
            // 
            this.btnAjouterClient1.Location = new System.Drawing.Point(375, 12);
            this.btnAjouterClient1.Name = "btnAjouterClient1";
            this.btnAjouterClient1.Size = new System.Drawing.Size(75, 71);
            this.btnAjouterClient1.TabIndex = 4;
            this.btnAjouterClient1.Text = "&Ajouter";
            this.btnAjouterClient1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAjouterClient1.UseVisualStyleBackColor = true;
            this.btnAjouterClient1.Click += new System.EventHandler(this.btnAjouterClient1_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(255, 12);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(75, 71);
            this.btnDernier.TabIndex = 3;
            this.btnDernier.Text = "&Dernier";
            this.btnDernier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDernier.UseVisualStyleBackColor = true;
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(174, 12);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(75, 71);
            this.btnSuivant.TabIndex = 2;
            this.btnSuivant.Text = "&Suivant";
            this.btnSuivant.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuivant.UseVisualStyleBackColor = true;
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(93, 12);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(75, 71);
            this.btnPrecedent.TabIndex = 1;
            this.btnPrecedent.Text = "&Précédent";
            this.btnPrecedent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrecedent.UseVisualStyleBackColor = true;
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(12, 12);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(75, 71);
            this.btnPremier.TabIndex = 0;
            this.btnPremier.Text = "&Premier";
            this.btnPremier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPremier.UseVisualStyleBackColor = true;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(93, 107);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(156, 20);
            this.txtCode.TabIndex = 7;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(93, 133);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(156, 20);
            this.txtNom.TabIndex = 8;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(93, 159);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(156, 20);
            this.txtPrenom.TabIndex = 9;
            // 
            // txtAdresse1
            // 
            this.txtAdresse1.Location = new System.Drawing.Point(93, 185);
            this.txtAdresse1.Name = "txtAdresse1";
            this.txtAdresse1.Size = new System.Drawing.Size(156, 20);
            this.txtAdresse1.TabIndex = 10;
            // 
            // txtAdresse2
            // 
            this.txtAdresse2.Location = new System.Drawing.Point(93, 211);
            this.txtAdresse2.Name = "txtAdresse2";
            this.txtAdresse2.Size = new System.Drawing.Size(156, 20);
            this.txtAdresse2.TabIndex = 11;
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Location = new System.Drawing.Point(93, 237);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(156, 20);
            this.txtCodePostal.TabIndex = 12;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(93, 263);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(156, 20);
            this.txtVille.TabIndex = 13;
            // 
            // dgvAnimaux
            // 
            this.dgvAnimaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimaux.Location = new System.Drawing.Point(255, 107);
            this.dgvAnimaux.Name = "dgvAnimaux";
            this.dgvAnimaux.Size = new System.Drawing.Size(561, 176);
            this.dgvAnimaux.TabIndex = 14;
            // 
            // btnAjouterClient2
            // 
            this.btnAjouterClient2.Location = new System.Drawing.Point(523, 310);
            this.btnAjouterClient2.Name = "btnAjouterClient2";
            this.btnAjouterClient2.Size = new System.Drawing.Size(75, 71);
            this.btnAjouterClient2.TabIndex = 15;
            this.btnAjouterClient2.Text = "&Ajouter";
            this.btnAjouterClient2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAjouterClient2.UseVisualStyleBackColor = true;
            this.btnAjouterClient2.Click += new System.EventHandler(this.btnAjouterClient2_Click);
            // 
            // btnSupprimerClient2
            // 
            this.btnSupprimerClient2.Location = new System.Drawing.Point(604, 310);
            this.btnSupprimerClient2.Name = "btnSupprimerClient2";
            this.btnSupprimerClient2.Size = new System.Drawing.Size(75, 71);
            this.btnSupprimerClient2.TabIndex = 16;
            this.btnSupprimerClient2.Text = "&Supprimer";
            this.btnSupprimerClient2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSupprimerClient2.UseVisualStyleBackColor = true;
            // 
            // btnEditerEditer
            // 
            this.btnEditerEditer.Location = new System.Drawing.Point(685, 310);
            this.btnEditerEditer.Name = "btnEditerEditer";
            this.btnEditerEditer.Size = new System.Drawing.Size(75, 71);
            this.btnEditerEditer.TabIndex = 17;
            this.btnEditerEditer.Text = "&Editer";
            this.btnEditerEditer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditerEditer.UseVisualStyleBackColor = true;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(23, 114);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 13);
            this.lblCode.TabIndex = 18;
            this.lblCode.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Adresse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Code postal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ville";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(523, 387);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 71);
            this.btnValider.TabIndex = 24;
            this.btnValider.Text = "&Valider";
            this.btnValider.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Visible = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(604, 387);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 71);
            this.btnAnnuler.TabIndex = 25;
            this.btnAnnuler.Text = "&Annuler";
            this.btnAnnuler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 462);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnEditerEditer);
            this.Controls.Add(this.btnSupprimerClient2);
            this.Controls.Add(this.btnAjouterClient2);
            this.Controls.Add(this.dgvAnimaux);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtCodePostal);
            this.Controls.Add(this.txtAdresse2);
            this.Controls.Add(this.txtAdresse1);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.gpbClient);
            this.Name = "ClientForm";
            this.Text = "Clients";
            this.gpbClient.ResumeLayout(false);
            this.gpbClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimaux)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbClient;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.TextBox txtRechercherClient;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnSupprimerClient1;
        private System.Windows.Forms.Button btnAjouterClient1;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtAdresse1;
        private System.Windows.Forms.TextBox txtAdresse2;
        private System.Windows.Forms.TextBox txtCodePostal;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.DataGridView dgvAnimaux;
        private System.Windows.Forms.Button btnAjouterClient2;
        private System.Windows.Forms.Button btnSupprimerClient2;
        private System.Windows.Forms.Button btnEditerEditer;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}