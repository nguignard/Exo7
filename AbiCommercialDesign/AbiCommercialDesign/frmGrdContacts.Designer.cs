﻿namespace Abi
{
    partial class frmGrdContacts
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
            this.btnDocuments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDocuments
            // 
            this.btnDocuments.Location = new System.Drawing.Point(13, 336);
            this.btnDocuments.Name = "btnDocuments";
            this.btnDocuments.Size = new System.Drawing.Size(75, 23);
            this.btnDocuments.TabIndex = 8;
            this.btnDocuments.Text = "Documents";
            this.btnDocuments.UseVisualStyleBackColor = true;
            // 
            // frmGrdContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(618, 371);
            this.Controls.Add(this.btnDocuments);
            this.Name = "frmGrdContacts";
            this.Controls.SetChildIndex(this.btnDocuments, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDocuments;
    }
}
