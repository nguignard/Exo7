namespace Exo6
{
    partial class frmLireStagiaire
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDeplacer = new System.Windows.Forms.GroupBox();
            this.lblNoStagiaire = new System.Windows.Forms.Label();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.grpStagiaire.SuspendLayout();
            this.grpDeplacer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDeplacer
            // 
            this.grpDeplacer.Controls.Add(this.lblNoStagiaire);
            this.grpDeplacer.Controls.Add(this.btnDernier);
            this.grpDeplacer.Controls.Add(this.btnSuivant);
            this.grpDeplacer.Controls.Add(this.btnPrecedent);
            this.grpDeplacer.Controls.Add(this.btnPremier);
            this.grpDeplacer.Location = new System.Drawing.Point(76, 204);
            this.grpDeplacer.Name = "grpDeplacer";
            this.grpDeplacer.Size = new System.Drawing.Size(339, 46);
            this.grpDeplacer.TabIndex = 1;
            this.grpDeplacer.TabStop = false;
            this.grpDeplacer.Text = "Se Déplacer";
            // 
            // lblNoStagiaire
            // 
            this.lblNoStagiaire.AutoSize = true;
            this.lblNoStagiaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoStagiaire.ForeColor = System.Drawing.Color.Red;
            this.lblNoStagiaire.Location = new System.Drawing.Point(48, 22);
            this.lblNoStagiaire.Name = "lblNoStagiaire";
            this.lblNoStagiaire.Size = new System.Drawing.Size(226, 13);
            this.lblNoStagiaire.TabIndex = 4;
            this.lblNoStagiaire.Text = "Il n\'y a aucun stagiaire pour le moment";
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(254, 17);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(75, 23);
            this.btnDernier.TabIndex = 3;
            this.btnDernier.Text = ">> &Dernier";
            this.btnDernier.UseVisualStyleBackColor = true;
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(173, 17);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(75, 23);
            this.btnSuivant.TabIndex = 2;
            this.btnSuivant.Text = "> &Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(92, 17);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(75, 23);
            this.btnPrecedent.TabIndex = 1;
            this.btnPrecedent.Text = "< &Precedent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(8, 17);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(75, 23);
            this.btnPremier.TabIndex = 0;
            this.btnPremier.Text = "<< Pre&mier";
            this.btnPremier.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(249, 256);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(330, 256);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // frmLireStagiaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(427, 291);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.grpDeplacer);
            this.Name = "frmLireStagiaire";
            this.Text = "Affiche un Stagiaire";
            this.Controls.SetChildIndex(this.grpStagiaire, 0);
            this.Controls.SetChildIndex(this.grpDeplacer, 0);
            this.Controls.SetChildIndex(this.btnAjouter, 0);
            this.Controls.SetChildIndex(this.btnQuitter, 0);
            this.grpStagiaire.ResumeLayout(false);
            this.grpStagiaire.PerformLayout();
            this.grpDeplacer.ResumeLayout(false);
            this.grpDeplacer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDeplacer;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblNoStagiaire;
    }
}
