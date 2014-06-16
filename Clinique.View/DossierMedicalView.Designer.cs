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
            this.lblNomAnimal = new System.Windows.Forms.Label();
            this.cbbNomAnimal = new System.Windows.Forms.ComboBox();
            this.lblProprietaire = new System.Windows.Forms.Label();
            this.cbbProprietaire = new System.Windows.Forms.ComboBox();
            this.ltvConsultationq = new System.Windows.Forms.ListView();
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
            // cbbNomAnimal
            // 
            this.cbbNomAnimal.FormattingEnabled = true;
            this.cbbNomAnimal.Location = new System.Drawing.Point(120, 6);
            this.cbbNomAnimal.Name = "cbbNomAnimal";
            this.cbbNomAnimal.Size = new System.Drawing.Size(121, 21);
            this.cbbNomAnimal.TabIndex = 1;
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
            // cbbProprietaire
            // 
            this.cbbProprietaire.FormattingEnabled = true;
            this.cbbProprietaire.Location = new System.Drawing.Point(120, 35);
            this.cbbProprietaire.Name = "cbbProprietaire";
            this.cbbProprietaire.Size = new System.Drawing.Size(121, 21);
            this.cbbProprietaire.TabIndex = 3;
            // 
            // ltvConsultationq
            // 
            this.ltvConsultationq.Location = new System.Drawing.Point(15, 77);
            this.ltvConsultationq.Name = "ltvConsultationq";
            this.ltvConsultationq.Size = new System.Drawing.Size(480, 354);
            this.ltvConsultationq.TabIndex = 4;
            this.ltvConsultationq.UseCompatibleStateImageBehavior = false;
            // 
            // DossierMedicalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 477);
            this.Controls.Add(this.ltvConsultationq);
            this.Controls.Add(this.cbbProprietaire);
            this.Controls.Add(this.lblProprietaire);
            this.Controls.Add(this.cbbNomAnimal);
            this.Controls.Add(this.lblNomAnimal);
            this.Name = "DossierMedicalForm";
            this.Text = "Dossier Medical";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomAnimal;
        private System.Windows.Forms.ComboBox cbbNomAnimal;
        private System.Windows.Forms.Label lblProprietaire;
        private System.Windows.Forms.ComboBox cbbProprietaire;
        private System.Windows.Forms.ListView ltvConsultationq;
    }
}