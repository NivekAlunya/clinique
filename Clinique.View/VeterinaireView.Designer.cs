namespace Clinique.View
{
    partial class VeterinaireView
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
            this.grpAction = new System.Windows.Forms.GroupBox();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lstVeterinaires = new System.Windows.Forms.ListBox();
            this.grpAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAction
            // 
            this.grpAction.Controls.Add(this.btnInit);
            this.grpAction.Controls.Add(this.btnAjouter);
            this.grpAction.Controls.Add(this.btnSupprimer);
            this.grpAction.Location = new System.Drawing.Point(0, 0);
            this.grpAction.Name = "grpAction";
            this.grpAction.Size = new System.Drawing.Size(291, 44);
            this.grpAction.TabIndex = 0;
            this.grpAction.TabStop = false;
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(66, 12);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(24, 24);
            this.btnInit.TabIndex = 3;
            this.btnInit.Text = "R";
            this.btnInit.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(6, 12);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(24, 24);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "+";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(36, 12);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(24, 24);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "-";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // lstVeterinaires
            // 
            this.lstVeterinaires.FormattingEnabled = true;
            this.lstVeterinaires.Location = new System.Drawing.Point(0, 47);
            this.lstVeterinaires.Name = "lstVeterinaires";
            this.lstVeterinaires.Size = new System.Drawing.Size(291, 225);
            this.lstVeterinaires.TabIndex = 1;
            // 
            // VeterinaireView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.lstVeterinaires);
            this.Controls.Add(this.grpAction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VeterinaireView";
            this.Text = "Vétérinaires";
            this.grpAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAction;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.ListBox lstVeterinaires;
    }
}