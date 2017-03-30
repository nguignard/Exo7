namespace Abi
{
    partial class frmContacts
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
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnContacts = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lblFonctionContact = new System.Windows.Forms.Label();
            this.lblIdActive = new System.Windows.Forms.Label();
            this.lbldContact = new System.Windows.Forms.Label();
            this.lblNomContact = new System.Windows.Forms.Label();
            this.lblPrenomContact = new System.Windows.Forms.Label();
            this.lblTelContact = new System.Windows.Forms.Label();
            this.lblEntreprise = new System.Windows.Forms.Label();
            this.lblProjets = new System.Windows.Forms.Label();
            this.txtEntreprise = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtFonction = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.grdProjets = new System.Windows.Forms.DataGridView();
            this.txtNumeroActivite = new System.Windows.Forms.TextBox();
            this.txtNumeroContact = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdProjets)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(238, 294);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 32;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(157, 294);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 31;
            this.btnAjouter.Text = "&Nouveau";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnContacts
            // 
            this.btnContacts.Location = new System.Drawing.Point(7, 294);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(123, 23);
            this.btnContacts.TabIndex = 30;
            this.btnContacts.Text = "&Documents";
            this.btnContacts.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(319, 294);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 29;
            this.btnAnnuler.Text = "A&nnuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(403, 294);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 28;
            this.btnValider.Text = "&Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(576, 294);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 27;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(495, 294);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 26;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // lblFonctionContact
            // 
            this.lblFonctionContact.AutoSize = true;
            this.lblFonctionContact.Location = new System.Drawing.Point(12, 77);
            this.lblFonctionContact.Name = "lblFonctionContact";
            this.lblFonctionContact.Size = new System.Drawing.Size(132, 13);
            this.lblFonctionContact.TabIndex = 33;
            this.lblFonctionContact.Text = "Fonction du Contact Client";
            // 
            // lblIdActive
            // 
            this.lblIdActive.AutoSize = true;
            this.lblIdActive.Location = new System.Drawing.Point(538, 9);
            this.lblIdActive.Name = "lblIdActive";
            this.lblIdActive.Size = new System.Drawing.Size(118, 13);
            this.lblIdActive.TabIndex = 34;
            this.lblIdActive.Text = "Numéro d\'activité Client";
            // 
            // lbldContact
            // 
            this.lbldContact.AutoSize = true;
            this.lbldContact.Location = new System.Drawing.Point(557, 50);
            this.lbldContact.Name = "lbldContact";
            this.lbldContact.Size = new System.Drawing.Size(99, 13);
            this.lbldContact.TabIndex = 35;
            this.lbldContact.Text = "Numéro de Contact";
            // 
            // lblNomContact
            // 
            this.lblNomContact.AutoSize = true;
            this.lblNomContact.Location = new System.Drawing.Point(12, 31);
            this.lblNomContact.Name = "lblNomContact";
            this.lblNomContact.Size = new System.Drawing.Size(29, 13);
            this.lblNomContact.TabIndex = 36;
            this.lblNomContact.Text = "Nom";
            // 
            // lblPrenomContact
            // 
            this.lblPrenomContact.AutoSize = true;
            this.lblPrenomContact.Location = new System.Drawing.Point(12, 53);
            this.lblPrenomContact.Name = "lblPrenomContact";
            this.lblPrenomContact.Size = new System.Drawing.Size(43, 13);
            this.lblPrenomContact.TabIndex = 37;
            this.lblPrenomContact.Text = "Prénom";
            // 
            // lblTelContact
            // 
            this.lblTelContact.AutoSize = true;
            this.lblTelContact.Location = new System.Drawing.Point(12, 99);
            this.lblTelContact.Name = "lblTelContact";
            this.lblTelContact.Size = new System.Drawing.Size(58, 13);
            this.lblTelContact.TabIndex = 38;
            this.lblTelContact.Text = "Téléphone";
            // 
            // lblEntreprise
            // 
            this.lblEntreprise.AutoSize = true;
            this.lblEntreprise.Location = new System.Drawing.Point(9, 9);
            this.lblEntreprise.Name = "lblEntreprise";
            this.lblEntreprise.Size = new System.Drawing.Size(54, 13);
            this.lblEntreprise.TabIndex = 39;
            this.lblEntreprise.Text = "Entreprise";
            // 
            // lblProjets
            // 
            this.lblProjets.AutoSize = true;
            this.lblProjets.Location = new System.Drawing.Point(12, 122);
            this.lblProjets.Name = "lblProjets";
            this.lblProjets.Size = new System.Drawing.Size(39, 13);
            this.lblProjets.TabIndex = 40;
            this.lblProjets.Text = "Projets";
            // 
            // txtEntreprise
            // 
            this.txtEntreprise.Location = new System.Drawing.Point(148, 6);
            this.txtEntreprise.Name = "txtEntreprise";
            this.txtEntreprise.Size = new System.Drawing.Size(299, 20);
            this.txtEntreprise.TabIndex = 41;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(148, 28);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(299, 20);
            this.txtNom.TabIndex = 42;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(148, 50);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(299, 20);
            this.txtPrenom.TabIndex = 43;
            // 
            // txtFonction
            // 
            this.txtFonction.Location = new System.Drawing.Point(148, 74);
            this.txtFonction.Name = "txtFonction";
            this.txtFonction.Size = new System.Drawing.Size(299, 20);
            this.txtFonction.TabIndex = 44;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(148, 96);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(299, 20);
            this.txtTelephone.TabIndex = 45;
            // 
            // grdProjets
            // 
            this.grdProjets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProjets.Location = new System.Drawing.Point(148, 122);
            this.grdProjets.Name = "grdProjets";
            this.grdProjets.ReadOnly = true;
            this.grdProjets.Size = new System.Drawing.Size(299, 150);
            this.grdProjets.TabIndex = 46;
            // 
            // txtNumeroActivite
            // 
            this.txtNumeroActivite.Location = new System.Drawing.Point(541, 28);
            this.txtNumeroActivite.Name = "txtNumeroActivite";
            this.txtNumeroActivite.Size = new System.Drawing.Size(115, 20);
            this.txtNumeroActivite.TabIndex = 47;
            // 
            // txtNumeroContact
            // 
            this.txtNumeroContact.Location = new System.Drawing.Point(541, 66);
            this.txtNumeroContact.Name = "txtNumeroContact";
            this.txtNumeroContact.Size = new System.Drawing.Size(115, 20);
            this.txtNumeroContact.TabIndex = 48;
            // 
            // frmContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 328);
            this.Controls.Add(this.txtNumeroContact);
            this.Controls.Add(this.txtNumeroActivite);
            this.Controls.Add(this.grdProjets);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtFonction);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtEntreprise);
            this.Controls.Add(this.lblProjets);
            this.Controls.Add(this.lblEntreprise);
            this.Controls.Add(this.lblTelContact);
            this.Controls.Add(this.lblPrenomContact);
            this.Controls.Add(this.lblNomContact);
            this.Controls.Add(this.lbldContact);
            this.Controls.Add(this.lblIdActive);
            this.Controls.Add(this.lblFonctionContact);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnContacts);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnSupprimer);
            this.Name = "frmContacts";
            this.Text = "ABI - Fiche Contact";
            ((System.ComponentModel.ISupportInitialize)(this.grdProjets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label lblFonctionContact;
        private System.Windows.Forms.Label lblIdActive;
        private System.Windows.Forms.Label lbldContact;
        private System.Windows.Forms.Label lblNomContact;
        private System.Windows.Forms.Label lblPrenomContact;
        private System.Windows.Forms.Label lblTelContact;
        private System.Windows.Forms.Label lblEntreprise;
        private System.Windows.Forms.Label lblProjets;
        private System.Windows.Forms.TextBox txtEntreprise;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtFonction;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.DataGridView grdProjets;
        private System.Windows.Forms.TextBox txtNumeroActivite;
        private System.Windows.Forms.TextBox txtNumeroContact;
    }
}