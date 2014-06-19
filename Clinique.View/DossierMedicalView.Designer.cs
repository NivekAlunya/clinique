namespace Clinique.View
{
    partial class DossierMedicalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DossierMedicalForm));
            this.lblNomAnimal = new System.Windows.Forms.Label();
            this.lblProprietaire = new System.Windows.Forms.Label();
            this.txtAnimal = new System.Windows.Forms.TextBox();
            this.txtProprietaire = new System.Windows.Forms.TextBox();
            this.txtEcran = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblNomAnimal
            // 
            this.lblNomAnimal.AutoSize = true;
            this.lblNomAnimal.Location = new System.Drawing.Point(12, 9);
            this.lblNomAnimal.Name = "lblNomAnimal";
            this.lblNomAnimal.Size = new System.Drawing.Size(102, 13);
            this.lblNomAnimal.TabIndex = 0;
            this.lblNomAnimal.Text = "Dossier médical de :";
            // 
            // lblProprietaire
            // 
            this.lblProprietaire.AutoSize = true;
            this.lblProprietaire.Location = new System.Drawing.Point(12, 40);
            this.lblProprietaire.Name = "lblProprietaire";
            this.lblProprietaire.Size = new System.Drawing.Size(66, 13);
            this.lblProprietaire.TabIndex = 2;
            this.lblProprietaire.Text = "Propriétaire :";
            // 
            // txtAnimal
            // 
            this.txtAnimal.CausesValidation = false;
            this.txtAnimal.Location = new System.Drawing.Point(120, 6);
            this.txtAnimal.Name = "txtAnimal";
            this.txtAnimal.ReadOnly = true;
            this.txtAnimal.Size = new System.Drawing.Size(100, 20);
            this.txtAnimal.TabIndex = 5;
            // 
            // txtProprietaire
            // 
            this.txtProprietaire.CausesValidation = false;
            this.txtProprietaire.Location = new System.Drawing.Point(120, 40);
            this.txtProprietaire.Name = "txtProprietaire";
            this.txtProprietaire.ReadOnly = true;
            this.txtProprietaire.Size = new System.Drawing.Size(100, 20);
            this.txtProprietaire.TabIndex = 6;
            // 
            // txtEcran
            // 
            this.txtEcran.Location = new System.Drawing.Point(15, 77);
            this.txtEcran.Name = "txtEcran";
            this.txtEcran.ReadOnly = true;
            this.txtEcran.Size = new System.Drawing.Size(492, 378);
            this.txtEcran.TabIndex = 7;
            this.txtEcran.Text = "";
            // 
            // DossierMedicalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 477);
            this.Controls.Add(this.txtEcran);
            this.Controls.Add(this.txtProprietaire);
            this.Controls.Add(this.txtAnimal);
            this.Controls.Add(this.lblProprietaire);
            this.Controls.Add(this.lblNomAnimal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DossierMedicalForm";
            this.Text = "Dossier Medical";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomAnimal;
        private System.Windows.Forms.Label lblProprietaire;
        private System.Windows.Forms.TextBox txtAnimal;
        private System.Windows.Forms.TextBox txtProprietaire;
        private System.Windows.Forms.RichTextBox txtEcran;
    }
}