namespace Clinique.View
{
    partial class RendezVousForm
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
            this.grpClient = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAnimal = new System.Windows.Forms.ComboBox();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.grpVeto = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVeto = new System.Windows.Forms.ComboBox();
            this.grpDate = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbHeure = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpRendezVous = new System.Windows.Forms.DateTimePicker();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.grpClient.SuspendLayout();
            this.grpVeto.SuspendLayout();
            this.grpDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // grpClient
            // 
            this.grpClient.Controls.Add(this.label2);
            this.grpClient.Controls.Add(this.label1);
            this.grpClient.Controls.Add(this.cmbAnimal);
            this.grpClient.Controls.Add(this.cmbClient);
            this.grpClient.Location = new System.Drawing.Point(1, 1);
            this.grpClient.Name = "grpClient";
            this.grpClient.Size = new System.Drawing.Size(200, 100);
            this.grpClient.TabIndex = 0;
            this.grpClient.TabStop = false;
            this.grpClient.Text = "Pour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Animal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client";
            // 
            // cmbAnimal
            // 
            this.cmbAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnimal.FormattingEnabled = true;
            this.cmbAnimal.Location = new System.Drawing.Point(11, 70);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.Size = new System.Drawing.Size(159, 21);
            this.cmbAnimal.Sorted = true;
            this.cmbAnimal.TabIndex = 1;
            // 
            // cmbClient
            // 
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(11, 33);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(159, 21);
            this.cmbClient.Sorted = true;
            this.cmbClient.TabIndex = 0;
            // 
            // grpVeto
            // 
            this.grpVeto.Controls.Add(this.label3);
            this.grpVeto.Controls.Add(this.cmbVeto);
            this.grpVeto.Location = new System.Drawing.Point(207, 1);
            this.grpVeto.Name = "grpVeto";
            this.grpVeto.Size = new System.Drawing.Size(200, 100);
            this.grpVeto.TabIndex = 1;
            this.grpVeto.TabStop = false;
            this.grpVeto.Text = "Par";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Veterinaire";
            // 
            // cmbVeto
            // 
            this.cmbVeto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVeto.FormattingEnabled = true;
            this.cmbVeto.Location = new System.Drawing.Point(6, 36);
            this.cmbVeto.Name = "cmbVeto";
            this.cmbVeto.Size = new System.Drawing.Size(188, 21);
            this.cmbVeto.Sorted = true;
            this.cmbVeto.TabIndex = 1;
            // 
            // grpDate
            // 
            this.grpDate.Controls.Add(this.label5);
            this.grpDate.Controls.Add(this.cmbHeure);
            this.grpDate.Controls.Add(this.label4);
            this.grpDate.Controls.Add(this.dtpRendezVous);
            this.grpDate.Location = new System.Drawing.Point(413, 1);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(200, 100);
            this.grpDate.TabIndex = 2;
            this.grpDate.TabStop = false;
            this.grpDate.Text = "Quand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Heure";
            // 
            // cmbHeure
            // 
            this.cmbHeure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHeure.FormattingEnabled = true;
            this.cmbHeure.Location = new System.Drawing.Point(13, 70);
            this.cmbHeure.Name = "cmbHeure";
            this.cmbHeure.Size = new System.Drawing.Size(140, 21);
            this.cmbHeure.Sorted = true;
            this.cmbHeure.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date";
            // 
            // dtpRendezVous
            // 
            this.dtpRendezVous.Location = new System.Drawing.Point(13, 36);
            this.dtpRendezVous.Name = "dtpRendezVous";
            this.dtpRendezVous.Size = new System.Drawing.Size(181, 20);
            this.dtpRendezVous.TabIndex = 0;
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Location = new System.Drawing.Point(1, 107);
            this.dgvAgenda.MultiSelect = false;
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.ReadOnly = true;
            this.dgvAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgenda.Size = new System.Drawing.Size(612, 231);
            this.dgvAgenda.TabIndex = 5;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(538, 344);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(457, 344);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 7;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(376, 344);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // RendezVousForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 372);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.grpDate);
            this.Controls.Add(this.grpVeto);
            this.Controls.Add(this.grpClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RendezVousForm";
            this.Text = "Prise de Rendez Vous";
            this.grpClient.ResumeLayout(false);
            this.grpClient.PerformLayout();
            this.grpVeto.ResumeLayout(false);
            this.grpVeto.PerformLayout();
            this.grpDate.ResumeLayout(false);
            this.grpDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpClient;
        private System.Windows.Forms.GroupBox grpVeto;
        private System.Windows.Forms.GroupBox grpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAnimal;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.ComboBox cmbVeto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbHeure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpRendezVous;
        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnSupprimer;
    }
}