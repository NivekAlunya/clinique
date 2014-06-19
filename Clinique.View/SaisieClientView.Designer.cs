namespace Clinique.View
{
    partial class SaisieClientView
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
            this.txtNomClient = new System.Windows.Forms.TextBox();
            this.txtNomAnimal = new System.Windows.Forms.TextBox();
            this.lblNomClient = new System.Windows.Forms.Label();
            this.lblNomAnimal = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomClient
            // 
            this.txtNomClient.Location = new System.Drawing.Point(99, 35);
            this.txtNomClient.Name = "txtNomClient";
            this.txtNomClient.Size = new System.Drawing.Size(184, 20);
            this.txtNomClient.TabIndex = 0;
            // 
            // txtNomAnimal
            // 
            this.txtNomAnimal.Location = new System.Drawing.Point(99, 91);
            this.txtNomAnimal.Name = "txtNomAnimal";
            this.txtNomAnimal.Size = new System.Drawing.Size(184, 20);
            this.txtNomAnimal.TabIndex = 1;
            // 
            // lblNomClient
            // 
            this.lblNomClient.AutoSize = true;
            this.lblNomClient.Location = new System.Drawing.Point(12, 38);
            this.lblNomClient.Name = "lblNomClient";
            this.lblNomClient.Size = new System.Drawing.Size(72, 13);
            this.lblNomClient.TabIndex = 2;
            this.lblNomClient.Text = "Nom du client";
            // 
            // lblNomAnimal
            // 
            this.lblNomAnimal.AutoSize = true;
            this.lblNomAnimal.Location = new System.Drawing.Point(12, 94);
            this.lblNomAnimal.Name = "lblNomAnimal";
            this.lblNomAnimal.Size = new System.Drawing.Size(81, 13);
            this.lblNomAnimal.TabIndex = 3;
            this.lblNomAnimal.Text = "Nom de l\'animal";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(52, 141);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "&Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(165, 141);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "&Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // SaisieClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 176);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblNomAnimal);
            this.Controls.Add(this.lblNomClient);
            this.Controls.Add(this.txtNomAnimal);
            this.Controls.Add(this.txtNomClient);
            this.Name = "SaisieClientView";
            this.Text = "SaisieClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomClient;
        private System.Windows.Forms.TextBox txtNomAnimal;
        private System.Windows.Forms.Label lblNomClient;
        private System.Windows.Forms.Label lblNomAnimal;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}