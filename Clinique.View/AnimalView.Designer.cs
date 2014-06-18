namespace Clinique.View
{
    partial class AnimalForm
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
            this.gpbHaut = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnDossierMedical = new System.Windows.Forms.Button();
            this.gpbClient = new System.Windows.Forms.GroupBox();
            this.cbbClient = new System.Windows.Forms.ComboBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.lblEspèce = new System.Windows.Forms.Label();
            this.lblTatouage = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCouleur = new System.Windows.Forms.TextBox();
            this.txtTatouage = new System.Windows.Forms.TextBox();
            this.cbbSexe = new System.Windows.Forms.ComboBox();
            this.cbbEspece = new System.Windows.Forms.ComboBox();
            this.gpbHaut.SuspendLayout();
            this.gpbClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbHaut
            // 
            this.gpbHaut.Controls.Add(this.btnAnnuler);
            this.gpbHaut.Controls.Add(this.btnValider);
            this.gpbHaut.Controls.Add(this.btnDossierMedical);
            this.gpbHaut.Location = new System.Drawing.Point(0, 0);
            this.gpbHaut.Name = "gpbHaut";
            this.gpbHaut.Size = new System.Drawing.Size(391, 95);
            this.gpbHaut.TabIndex = 0;
            this.gpbHaut.TabStop = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(298, 19);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 70);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "&Annuler";
            this.btnAnnuler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(217, 19);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 70);
            this.btnValider.TabIndex = 1;
            this.btnValider.Text = "&Valider";
            this.btnValider.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // btnDossierMedical
            // 
            this.btnDossierMedical.Location = new System.Drawing.Point(12, 19);
            this.btnDossierMedical.Name = "btnDossierMedical";
            this.btnDossierMedical.Size = new System.Drawing.Size(75, 70);
            this.btnDossierMedical.TabIndex = 0;
            this.btnDossierMedical.Text = "&Dossier médical";
            this.btnDossierMedical.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDossierMedical.UseVisualStyleBackColor = true;
            // 
            // gpbClient
            // 
            this.gpbClient.Controls.Add(this.cbbClient);
            this.gpbClient.Location = new System.Drawing.Point(0, 101);
            this.gpbClient.Name = "gpbClient";
            this.gpbClient.Size = new System.Drawing.Size(391, 57);
            this.gpbClient.TabIndex = 3;
            this.gpbClient.TabStop = false;
            this.gpbClient.Text = "Client :";
            // 
            // cbbClient
            // 
            this.cbbClient.FormattingEnabled = true;
            this.cbbClient.Location = new System.Drawing.Point(12, 19);
            this.cbbClient.Name = "cbbClient";
            this.cbbClient.Size = new System.Drawing.Size(372, 21);
            this.cbbClient.TabIndex = 0;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(3, 169);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 13);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Code";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(3, 197);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "Nom";
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Location = new System.Drawing.Point(3, 223);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(43, 13);
            this.lblCouleur.TabIndex = 6;
            this.lblCouleur.Text = "Couleur";
            // 
            // lblEspèce
            // 
            this.lblEspèce.AutoSize = true;
            this.lblEspèce.Location = new System.Drawing.Point(3, 248);
            this.lblEspèce.Name = "lblEspèce";
            this.lblEspèce.Size = new System.Drawing.Size(74, 13);
            this.lblEspèce.TabIndex = 7;
            this.lblEspèce.Text = "Race/Espèce";
            // 
            // lblTatouage
            // 
            this.lblTatouage.AutoSize = true;
            this.lblTatouage.Location = new System.Drawing.Point(3, 273);
            this.lblTatouage.Name = "lblTatouage";
            this.lblTatouage.Size = new System.Drawing.Size(53, 13);
            this.lblTatouage.TabIndex = 8;
            this.lblTatouage.Text = "Tatouage";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(63, 165);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(129, 20);
            this.txtCode.TabIndex = 9;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(63, 193);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(129, 20);
            this.txtNom.TabIndex = 1;
            // 
            // txtCouleur
            // 
            this.txtCouleur.Location = new System.Drawing.Point(63, 219);
            this.txtCouleur.Name = "txtCouleur";
            this.txtCouleur.Size = new System.Drawing.Size(129, 20);
            this.txtCouleur.TabIndex = 2;
            // 
            // txtTatouage
            // 
            this.txtTatouage.Location = new System.Drawing.Point(62, 270);
            this.txtTatouage.Name = "txtTatouage";
            this.txtTatouage.Size = new System.Drawing.Size(129, 20);
            this.txtTatouage.TabIndex = 4;
            // 
            // cbbSexe
            // 
            this.cbbSexe.FormattingEnabled = true;
            this.cbbSexe.Location = new System.Drawing.Point(227, 193);
            this.cbbSexe.Name = "cbbSexe";
            this.cbbSexe.Size = new System.Drawing.Size(121, 21);
            this.cbbSexe.TabIndex = 5;
            // 
            // cbbEspece
            // 
            this.cbbEspece.FormattingEnabled = true;
            this.cbbEspece.Location = new System.Drawing.Point(67, 243);
            this.cbbEspece.Name = "cbbEspece";
            this.cbbEspece.Size = new System.Drawing.Size(125, 21);
            this.cbbEspece.TabIndex = 12;
            // 
            // AnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 319);
            this.Controls.Add(this.cbbEspece);
            this.Controls.Add(this.cbbSexe);
            this.Controls.Add(this.txtTatouage);
            this.Controls.Add(this.txtCouleur);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblTatouage);
            this.Controls.Add(this.lblEspèce);
            this.Controls.Add(this.lblCouleur);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.gpbClient);
            this.Controls.Add(this.gpbHaut);
            this.Name = "AnimalForm";
            this.Text = "Animaux";
            this.gpbHaut.ResumeLayout(false);
            this.gpbClient.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbHaut;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnDossierMedical;
        private System.Windows.Forms.GroupBox gpbClient;
        private System.Windows.Forms.ComboBox cbbClient;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.Label lblEspèce;
        private System.Windows.Forms.Label lblTatouage;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtCouleur;
        private System.Windows.Forms.TextBox txtTatouage;
        private System.Windows.Forms.ComboBox cbbSexe;
        private System.Windows.Forms.ComboBox cbbEspece;
    }
}