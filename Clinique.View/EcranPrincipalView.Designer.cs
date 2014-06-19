namespace Clinique.View
{
    partial class EcranPrincipalView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.secretariatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priseDeRendezvousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dossierClientAnimauxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseAJourDuStockDeVaccinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosssierMedicauxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseaJourDuBaremeDeTarificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbEcranPrincipal = new System.Windows.Forms.GroupBox();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnDossierMedical = new System.Windows.Forms.Button();
            this.btnRelance = new System.Windows.Forms.Button();
            this.btnClientAnimal = new System.Windows.Forms.Button();
            this.btnRendezVous = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gpbEcranPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secretariatToolStripMenuItem,
            this.veterinaireToolStripMenuItem,
            this.parametrageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // secretariatToolStripMenuItem
            // 
            this.secretariatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priseDeRendezvousToolStripMenuItem,
            this.dossierClientAnimauxToolStripMenuItem,
            this.relancesToolStripMenuItem,
            this.miseAJourDuStockDeVaccinToolStripMenuItem});
            this.secretariatToolStripMenuItem.Name = "secretariatToolStripMenuItem";
            this.secretariatToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.secretariatToolStripMenuItem.Text = "&Secretariat";
            // 
            // priseDeRendezvousToolStripMenuItem
            // 
            this.priseDeRendezvousToolStripMenuItem.Name = "priseDeRendezvousToolStripMenuItem";
            this.priseDeRendezvousToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.priseDeRendezvousToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.priseDeRendezvousToolStripMenuItem.Text = "&Prise de rendez-vous";
            this.priseDeRendezvousToolStripMenuItem.Click += new System.EventHandler(this.priseDeRendezvousToolStripMenuItem_Click);
            // 
            // dossierClientAnimauxToolStripMenuItem
            // 
            this.dossierClientAnimauxToolStripMenuItem.Name = "dossierClientAnimauxToolStripMenuItem";
            this.dossierClientAnimauxToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.dossierClientAnimauxToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.dossierClientAnimauxToolStripMenuItem.Text = "&Dossier Client/Animaux";
            this.dossierClientAnimauxToolStripMenuItem.Click += new System.EventHandler(this.dossierClientAnimauxToolStripMenuItem_Click);
            // 
            // relancesToolStripMenuItem
            // 
            this.relancesToolStripMenuItem.Enabled = false;
            this.relancesToolStripMenuItem.Name = "relancesToolStripMenuItem";
            this.relancesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.relancesToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.relancesToolStripMenuItem.Text = "&Relances";
            // 
            // miseAJourDuStockDeVaccinToolStripMenuItem
            // 
            this.miseAJourDuStockDeVaccinToolStripMenuItem.Enabled = false;
            this.miseAJourDuStockDeVaccinToolStripMenuItem.Name = "miseAJourDuStockDeVaccinToolStripMenuItem";
            this.miseAJourDuStockDeVaccinToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.miseAJourDuStockDeVaccinToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.miseAJourDuStockDeVaccinToolStripMenuItem.Text = "&Mise à jour du stock de vaccin";
            // 
            // veterinaireToolStripMenuItem
            // 
            this.veterinaireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaToolStripMenuItem,
            this.dosssierMedicauxToolStripMenuItem});
            this.veterinaireToolStripMenuItem.Name = "veterinaireToolStripMenuItem";
            this.veterinaireToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.veterinaireToolStripMenuItem.Text = "&Veterinaire";
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Enabled = false;
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.agendaToolStripMenuItem.Text = "&Agenda";
            // 
            // dosssierMedicauxToolStripMenuItem
            // 
            this.dosssierMedicauxToolStripMenuItem.Enabled = false;
            this.dosssierMedicauxToolStripMenuItem.Name = "dosssierMedicauxToolStripMenuItem";
            this.dosssierMedicauxToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.dosssierMedicauxToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.dosssierMedicauxToolStripMenuItem.Text = "&Dosssier Medicaux";
            // 
            // parametrageToolStripMenuItem
            // 
            this.parametrageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veterinairesToolStripMenuItem,
            this.miseaJourDuBaremeDeTarificationToolStripMenuItem});
            this.parametrageToolStripMenuItem.Name = "parametrageToolStripMenuItem";
            this.parametrageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.parametrageToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.parametrageToolStripMenuItem.Text = "&Paramétrage";
            // 
            // veterinairesToolStripMenuItem
            // 
            this.veterinairesToolStripMenuItem.Name = "veterinairesToolStripMenuItem";
            this.veterinairesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.veterinairesToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.veterinairesToolStripMenuItem.Text = "&veterinaires ";
            this.veterinairesToolStripMenuItem.Click += new System.EventHandler(this.veterinairesToolStripMenuItem_Click);
            // 
            // miseaJourDuBaremeDeTarificationToolStripMenuItem
            // 
            this.miseaJourDuBaremeDeTarificationToolStripMenuItem.Enabled = false;
            this.miseaJourDuBaremeDeTarificationToolStripMenuItem.Name = "miseaJourDuBaremeDeTarificationToolStripMenuItem";
            this.miseaJourDuBaremeDeTarificationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.miseaJourDuBaremeDeTarificationToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.miseaJourDuBaremeDeTarificationToolStripMenuItem.Text = "&Mise à jour du barème de tarification";
            // 
            // gpbEcranPrincipal
            // 
            this.gpbEcranPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbEcranPrincipal.Controls.Add(this.btnAgenda);
            this.gpbEcranPrincipal.Controls.Add(this.btnDossierMedical);
            this.gpbEcranPrincipal.Controls.Add(this.btnRelance);
            this.gpbEcranPrincipal.Controls.Add(this.btnClientAnimal);
            this.gpbEcranPrincipal.Controls.Add(this.btnRendezVous);
            this.gpbEcranPrincipal.Location = new System.Drawing.Point(732, 27);
            this.gpbEcranPrincipal.Name = "gpbEcranPrincipal";
            this.gpbEcranPrincipal.Size = new System.Drawing.Size(102, 538);
            this.gpbEcranPrincipal.TabIndex = 1;
            this.gpbEcranPrincipal.TabStop = false;
            // 
            // btnAgenda
            // 
            this.btnAgenda.Location = new System.Drawing.Point(10, 234);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(84, 47);
            this.btnAgenda.TabIndex = 4;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgenda.UseVisualStyleBackColor = true;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // btnDossierMedical
            // 
            this.btnDossierMedical.Enabled = false;
            this.btnDossierMedical.Location = new System.Drawing.Point(10, 311);
            this.btnDossierMedical.Name = "btnDossierMedical";
            this.btnDossierMedical.Size = new System.Drawing.Size(84, 47);
            this.btnDossierMedical.TabIndex = 3;
            this.btnDossierMedical.Text = "Dossier Médical";
            this.btnDossierMedical.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDossierMedical.UseVisualStyleBackColor = true;
            // 
            // btnRelance
            // 
            this.btnRelance.Enabled = false;
            this.btnRelance.Location = new System.Drawing.Point(10, 160);
            this.btnRelance.Name = "btnRelance";
            this.btnRelance.Size = new System.Drawing.Size(84, 47);
            this.btnRelance.TabIndex = 2;
            this.btnRelance.Text = "Relance";
            this.btnRelance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRelance.UseVisualStyleBackColor = true;
            // 
            // btnClientAnimal
            // 
            this.btnClientAnimal.Location = new System.Drawing.Point(10, 87);
            this.btnClientAnimal.Name = "btnClientAnimal";
            this.btnClientAnimal.Size = new System.Drawing.Size(84, 47);
            this.btnClientAnimal.TabIndex = 1;
            this.btnClientAnimal.Text = "Client Animal";
            this.btnClientAnimal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientAnimal.UseVisualStyleBackColor = true;
            this.btnClientAnimal.Click += new System.EventHandler(this.btnClientAnimal_Click);
            // 
            // btnRendezVous
            // 
            this.btnRendezVous.Location = new System.Drawing.Point(10, 19);
            this.btnRendezVous.Name = "btnRendezVous";
            this.btnRendezVous.Size = new System.Drawing.Size(84, 47);
            this.btnRendezVous.TabIndex = 0;
            this.btnRendezVous.Text = "Rendez-vous";
            this.btnRendezVous.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRendezVous.UseVisualStyleBackColor = true;
            this.btnRendezVous.Click += new System.EventHandler(this.btnRendezVous_Click);
            // 
            // EcranPrincipalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 566);
            this.Controls.Add(this.gpbEcranPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EcranPrincipalView";
            this.Text = "EcranPrincipalView";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpbEcranPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem secretariatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priseDeRendezvousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dossierClientAnimauxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseAJourDuStockDeVaccinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veterinaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosssierMedicauxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veterinairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseaJourDuBaremeDeTarificationToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpbEcranPrincipal;
        private System.Windows.Forms.Button btnDossierMedical;
        private System.Windows.Forms.Button btnRelance;
        private System.Windows.Forms.Button btnClientAnimal;
        private System.Windows.Forms.Button btnRendezVous;
        private System.Windows.Forms.Button btnAgenda;
    }
}