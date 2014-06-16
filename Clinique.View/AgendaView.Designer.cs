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
            this.gpbAgenda = new System.Windows.Forms.GroupBox();
            this.lblVeterinaire = new System.Windows.Forms.Label();
            this.cbbVeterinaire = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDossierMedical = new System.Windows.Forms.Button();
            this.vsbAgenda = new System.Windows.Forms.VScrollBar();
            this.gpbAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbAgenda
            // 
            this.gpbAgenda.Controls.Add(this.dateTimePicker1);
            this.gpbAgenda.Controls.Add(this.lblDate);
            this.gpbAgenda.Controls.Add(this.cbbVeterinaire);
            this.gpbAgenda.Controls.Add(this.lblVeterinaire);
            this.gpbAgenda.Location = new System.Drawing.Point(0, 0);
            this.gpbAgenda.Name = "gpbAgenda";
            this.gpbAgenda.Size = new System.Drawing.Size(474, 56);
            this.gpbAgenda.TabIndex = 0;
            this.gpbAgenda.TabStop = false;
            this.gpbAgenda.Text = "De";
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
            // cbbVeterinaire
            // 
            this.cbbVeterinaire.FormattingEnabled = true;
            this.cbbVeterinaire.Location = new System.Drawing.Point(70, 19);
            this.cbbVeterinaire.Name = "cbbVeterinaire";
            this.cbbVeterinaire.Size = new System.Drawing.Size(121, 21);
            this.cbbVeterinaire.TabIndex = 1;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(252, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 304);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnDossierMedical
            // 
            this.btnDossierMedical.Location = new System.Drawing.Point(370, 389);
            this.btnDossierMedical.Name = "btnDossierMedical";
            this.btnDossierMedical.Size = new System.Drawing.Size(104, 65);
            this.btnDossierMedical.TabIndex = 5;
            this.btnDossierMedical.Text = "&Dossier médical";
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
            this.ClientSize = new System.Drawing.Size(486, 466);
            this.Controls.Add(this.vsbAgenda);
            this.Controls.Add(this.btnDossierMedical);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gpbAgenda);
            this.Name = "AgendaForm";
            this.Text = "Agenda";
            this.gpbAgenda.ResumeLayout(false);
            this.gpbAgenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAgenda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cbbVeterinaire;
        private System.Windows.Forms.Label lblVeterinaire;
        private System.Windows.Forms.Button btnDossierMedical;
        private System.Windows.Forms.VScrollBar vsbAgenda;
    }
}