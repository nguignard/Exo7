namespace Abi
{
    partial class frmGrdContact
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
            this.btnCltDspQuitter = new System.Windows.Forms.Button();
            this.btnCltDspSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.grdCltDsp = new System.Windows.Forms.DataGridView();
            this.btnCltDspRechercher = new System.Windows.Forms.Button();
            this.btnCltDspTous = new System.Windows.Forms.Button();
            this.txtCltDspNomRecherche = new System.Windows.Forms.TextBox();
            this.lblCltDspNomRecherche = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCltDsp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCltDspQuitter
            // 
            this.btnCltDspQuitter.Location = new System.Drawing.Point(532, 368);
            this.btnCltDspQuitter.Name = "btnCltDspQuitter";
            this.btnCltDspQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnCltDspQuitter.TabIndex = 15;
            this.btnCltDspQuitter.Text = "&Quitter";
            this.btnCltDspQuitter.UseVisualStyleBackColor = true;
            // 
            // btnCltDspSupprimer
            // 
            this.btnCltDspSupprimer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCltDspSupprimer.Location = new System.Drawing.Point(451, 368);
            this.btnCltDspSupprimer.Name = "btnCltDspSupprimer";
            this.btnCltDspSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnCltDspSupprimer.TabIndex = 14;
            this.btnCltDspSupprimer.Text = "&Supprimer";
            this.btnCltDspSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(370, 368);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 13;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // grdCltDsp
            // 
            this.grdCltDsp.AllowUserToAddRows = false;
            this.grdCltDsp.AllowUserToDeleteRows = false;
            this.grdCltDsp.AllowUserToOrderColumns = true;
            this.grdCltDsp.AllowUserToResizeColumns = false;
            this.grdCltDsp.AllowUserToResizeRows = false;
            this.grdCltDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCltDsp.Location = new System.Drawing.Point(14, 83);
            this.grdCltDsp.MultiSelect = false;
            this.grdCltDsp.Name = "grdCltDsp";
            this.grdCltDsp.ReadOnly = true;
            this.grdCltDsp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCltDsp.Size = new System.Drawing.Size(593, 268);
            this.grdCltDsp.TabIndex = 12;
            // 
            // btnCltDspRechercher
            // 
            this.btnCltDspRechercher.Location = new System.Drawing.Point(451, 40);
            this.btnCltDspRechercher.Name = "btnCltDspRechercher";
            this.btnCltDspRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnCltDspRechercher.TabIndex = 11;
            this.btnCltDspRechercher.Text = "&Rechercher";
            this.btnCltDspRechercher.UseVisualStyleBackColor = true;
            // 
            // btnCltDspTous
            // 
            this.btnCltDspTous.Location = new System.Drawing.Point(532, 40);
            this.btnCltDspTous.Name = "btnCltDspTous";
            this.btnCltDspTous.Size = new System.Drawing.Size(75, 23);
            this.btnCltDspTous.TabIndex = 10;
            this.btnCltDspTous.Text = "&Tous";
            this.btnCltDspTous.UseVisualStyleBackColor = true;
            // 
            // txtCltDspNomRecherche
            // 
            this.txtCltDspNomRecherche.Location = new System.Drawing.Point(114, 42);
            this.txtCltDspNomRecherche.Name = "txtCltDspNomRecherche";
            this.txtCltDspNomRecherche.Size = new System.Drawing.Size(317, 20);
            this.txtCltDspNomRecherche.TabIndex = 9;
            // 
            // lblCltDspNomRecherche
            // 
            this.lblCltDspNomRecherche.AutoSize = true;
            this.lblCltDspNomRecherche.Location = new System.Drawing.Point(11, 45);
            this.lblCltDspNomRecherche.Name = "lblCltDspNomRecherche";
            this.lblCltDspNomRecherche.Size = new System.Drawing.Size(94, 13);
            this.lblCltDspNomRecherche.TabIndex = 8;
            this.lblCltDspNomRecherche.Text = "&Nom Recherché : ";
            // 
            // frmGrdContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 430);
            this.Controls.Add(this.btnCltDspQuitter);
            this.Controls.Add(this.btnCltDspSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.grdCltDsp);
            this.Controls.Add(this.btnCltDspRechercher);
            this.Controls.Add(this.btnCltDspTous);
            this.Controls.Add(this.txtCltDspNomRecherche);
            this.Controls.Add(this.lblCltDspNomRecherche);
            this.Name = "frmGrdContact";
            this.Text = "frmGrdContact";
            ((System.ComponentModel.ISupportInitialize)(this.grdCltDsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnCltDspQuitter;
        protected System.Windows.Forms.Button btnCltDspSupprimer;
        protected System.Windows.Forms.Button btnAjouter;
        protected System.Windows.Forms.DataGridView grdCltDsp;
        protected System.Windows.Forms.Button btnCltDspRechercher;
        protected System.Windows.Forms.Button btnCltDspTous;
        protected System.Windows.Forms.TextBox txtCltDspNomRecherche;
        protected System.Windows.Forms.Label lblCltDspNomRecherche;
    }
}