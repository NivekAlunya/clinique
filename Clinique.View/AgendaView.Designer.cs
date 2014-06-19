namespace Clinique.View
{
    partial class AgendaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendaForm));
            this.gpbAgenda = new System.Windows.Forms.GroupBox();
            this.dtpRendezVous = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbVeto = new System.Windows.Forms.ComboBox();
            this.lblVeterinaire = new System.Windows.Forms.Label();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.btnDossierMedical = new System.Windows.Forms.Button();
            this.vsbAgenda = new System.Windows.Forms.VScrollBar();
            this.gpbAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbAgenda
            // 
            this.gpbAgenda.Controls.Add(this.dtpRendezVous);
            this.gpbAgenda.Controls.Add(this.lblDate);
            this.gpbAgenda.Controls.Add(this.cmbVeto);
            this.gpbAgenda.Controls.Add(this.lblVeterinaire);
            this.gpbAgenda.Location = new System.Drawing.Point(0, 0);
            this.gpbAgenda.Name = "gpbAgenda";
            this.gpbAgenda.Size = new System.Drawing.Size(474, 56);
            this.gpbAgenda.TabIndex = 0;
            this.gpbAgenda.TabStop = false;
            this.gpbAgenda.Text = "De";
            // 
            // dtpRendezVous
            // 
            this.dtpRendezVous.Location = new System.Drawing.Point(252, 19);
            this.dtpRendezVous.Name = "dtpRendezVous";
            this.dtpRendezVous.Size = new System.Drawing.Size(200, 20);
            this.dtpRendezVous.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(216, 22);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // cmbVeto
            // 
            this.cmbVeto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVeto.FormattingEnabled = true;
            this.cmbVeto.Location = new System.Drawing.Point(70, 19);
            this.cmbVeto.Name = "cmbVeto";
            this.cmbVeto.Size = new System.Drawing.Size(121, 21);
            this.cmbVeto.TabIndex = 1;
            // 
            // lblVeterinaire
            // 
            this.lblVeterinaire.AutoSize = true;
            this.lblVeterinaire.Location = new System.Drawing.Point(7, 22);
            this.lblVeterinaire.Name = "lblVeterinaire";
            this.lblVeterinaire.Size = new System.Drawing.Size(57, 13);
            this.lblVeterinaire.TabIndex = 0;
            this.lblVeterinaire.Text = "Vétérinaire";
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Location = new System.Drawing.Point(0, 62);
            this.dgvAgenda.MultiSelect = false;
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.ReadOnly = true;
            this.dgvAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgenda.Size = new System.Drawing.Size(458, 304);
            this.dgvAgenda.TabIndex = 4;
            // 
            // btnDossierMedical
            // 
            this.btnDossierMedical.Image = ((System.Drawing.Image)(resources.GetObject("btnDossierMedical.Image")));
            this.btnDossierMedical.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDossierMedical.Location = new System.Drawing.Point(370, 389);
            this.btnDossierMedical.Name = "btnDossierMedical";
            this.btnDossierMedical.Size = new System.Drawing.Size(104, 77);
            this.btnDossierMedical.TabIndex = 5;
            this.btnDossierMedical.Text = "&Dossier médical";
            this.btnDossierMedical.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDossierMedical.UseVisualStyleBackColor = true;
            // 
            // vsbAgenda
            // 
            this.vsbAgenda.Location = new System.Drawing.Point(461, 62);
            this.vsbAgenda.Name = "vsbAgenda";
            this.vsbAgenda.Size = new System.Drawing.Size(13, 304);
            this.vsbAgenda.TabIndex = 6;
            // 
            // AgendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 466);
            this.Controls.Add(this.vsbAgenda);
            this.Controls.Add(this.btnDossierMedical);
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.gpbAgenda);
            this.Name = "AgendaForm";
            this.Text = "Agenda";
            this.gpbAgenda.ResumeLayout(false);
            this.gpbAgenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAgenda;
        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.DateTimePicker dtpRendezVous;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbVeto;
        private System.Windows.Forms.Label lblVeterinaire;
        private System.Windows.Forms.Button btnDossierMedical;
        private System.Windows.Forms.VScrollBar vsbAgenda;
    }
}