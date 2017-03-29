namespace AbiCommercialDesign
{
    partial class frmClt
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
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblNumeroClient = new System.Windows.Forms.Label();
            this.lblRaisonSociale = new System.Windows.Forms.Label();
            this.lblDomaineActivite = new System.Windows.Forms.Label();
            this.lblAdresseClient = new System.Windows.Forms.Label();
            this.lblTéléphone = new System.Windows.Forms.Label();
            this.lblCA = new System.Windows.Forms.Label();
            this.lblEffectifs = new System.Windows.Forms.Label();
            this.grpTypeClient = new System.Windows.Forms.GroupBox();
            this.rdbTypeClientPrive = new System.Windows.Forms.RadioButton();
            this.rdbTypeClientPublic = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grpNature = new System.Windows.Forms.GroupBox();
            this.rdbAncienne = new System.Windows.Forms.RadioButton();
            this.rdbSecondaire = new System.Windows.Forms.RadioButton();
            this.rdbPrincipal = new System.Windows.Forms.RadioButton();
            this.txtNumeroClient = new System.Windows.Forms.TextBox();
            this.txtRaisonSociale = new System.Windows.Forms.TextBox();
            this.txtAdresseClient = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtCA = new System.Windows.Forms.TextBox();
            this.txtEffectif = new System.Windows.Forms.TextBox();
            this.lblCommentaires = new System.Windows.Forms.Label();
            this.txtCommentaires = new System.Windows.Forms.TextBox();
            this.btnContacts = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.grpTypeClient.SuspendLayout();
            this.grpNature.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(478, 299);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 0;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(559, 299);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 1;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(376, 299);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "&Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(295, 299);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "A&nnuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // lblNumeroClient
            // 
            this.lblNumeroClient.AutoSize = true;
            this.lblNumeroClient.Location = new System.Drawing.Point(13, 13);
            this.lblNumeroClient.Name = "lblNumeroClient";
            this.lblNumeroClient.Size = new System.Drawing.Size(88, 13);
            this.lblNumeroClient.TabIndex = 4;
            this.lblNumeroClient.Text = "Numero de Client";
            // 
            // lblRaisonSociale
            // 
            this.lblRaisonSociale.AutoSize = true;
            this.lblRaisonSociale.Location = new System.Drawing.Point(13, 42);
            this.lblRaisonSociale.Name = "lblRaisonSociale";
            this.lblRaisonSociale.Size = new System.Drawing.Size(122, 13);
            this.lblRaisonSociale.TabIndex = 5;
            this.lblRaisonSociale.Text = "Raison Sociale du Client";
            // 
            // lblDomaineActivite
            // 
            this.lblDomaineActivite.AutoSize = true;
            this.lblDomaineActivite.Location = new System.Drawing.Point(13, 76);
            this.lblDomaineActivite.Name = "lblDomaineActivite";
            this.lblDomaineActivite.Size = new System.Drawing.Size(94, 13);
            this.lblDomaineActivite.TabIndex = 6;
            this.lblDomaineActivite.Text = "Domaine d\'activité";
            // 
            // lblAdresseClient
            // 
            this.lblAdresseClient.AutoSize = true;
            this.lblAdresseClient.Location = new System.Drawing.Point(13, 106);
            this.lblAdresseClient.Name = "lblAdresseClient";
            this.lblAdresseClient.Size = new System.Drawing.Size(89, 13);
            this.lblAdresseClient.TabIndex = 7;
            this.lblAdresseClient.Text = "Adresse du Client";
            // 
            // lblTéléphone
            // 
            this.lblTéléphone.AutoSize = true;
            this.lblTéléphone.Location = new System.Drawing.Point(13, 132);
            this.lblTéléphone.Name = "lblTéléphone";
            this.lblTéléphone.Size = new System.Drawing.Size(58, 13);
            this.lblTéléphone.TabIndex = 8;
            this.lblTéléphone.Text = "Téléphone";
            // 
            // lblCA
            // 
            this.lblCA.AutoSize = true;
            this.lblCA.Location = new System.Drawing.Point(13, 158);
            this.lblCA.Name = "lblCA";
            this.lblCA.Size = new System.Drawing.Size(78, 13);
            this.lblCA.TabIndex = 9;
            this.lblCA.Text = "Chiffre d\'Affaire";
            // 
            // lblEffectifs
            // 
            this.lblEffectifs.AutoSize = true;
            this.lblEffectifs.Location = new System.Drawing.Point(13, 184);
            this.lblEffectifs.Name = "lblEffectifs";
            this.lblEffectifs.Size = new System.Drawing.Size(40, 13);
            this.lblEffectifs.TabIndex = 10;
            this.lblEffectifs.Text = "Effectif";
            // 
            // grpTypeClient
            // 
            this.grpTypeClient.Controls.Add(this.rdbTypeClientPrive);
            this.grpTypeClient.Controls.Add(this.rdbTypeClientPublic);
            this.grpTypeClient.Location = new System.Drawing.Point(398, 13);
            this.grpTypeClient.Name = "grpTypeClient";
            this.grpTypeClient.Size = new System.Drawing.Size(134, 43);
            this.grpTypeClient.TabIndex = 11;
            this.grpTypeClient.TabStop = false;
            this.grpTypeClient.Text = "Type de Client";
            // 
            // rdbTypeClientPrive
            // 
            this.rdbTypeClientPrive.AutoSize = true;
            this.rdbTypeClientPrive.Location = new System.Drawing.Point(68, 19);
            this.rdbTypeClientPrive.Name = "rdbTypeClientPrive";
            this.rdbTypeClientPrive.Size = new System.Drawing.Size(49, 17);
            this.rdbTypeClientPrive.TabIndex = 1;
            this.rdbTypeClientPrive.TabStop = true;
            this.rdbTypeClientPrive.Text = "Privé";
            this.rdbTypeClientPrive.UseVisualStyleBackColor = true;
            // 
            // rdbTypeClientPublic
            // 
            this.rdbTypeClientPublic.AutoSize = true;
            this.rdbTypeClientPublic.Location = new System.Drawing.Point(8, 19);
            this.rdbTypeClientPublic.Name = "rdbTypeClientPublic";
            this.rdbTypeClientPublic.Size = new System.Drawing.Size(54, 17);
            this.rdbTypeClientPublic.TabIndex = 0;
            this.rdbTypeClientPublic.TabStop = true;
            this.rdbTypeClientPublic.Text = "Public";
            this.rdbTypeClientPublic.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // grpNature
            // 
            this.grpNature.Controls.Add(this.rdbAncienne);
            this.grpNature.Controls.Add(this.rdbSecondaire);
            this.grpNature.Controls.Add(this.rdbPrincipal);
            this.grpNature.Location = new System.Drawing.Point(398, 73);
            this.grpNature.Name = "grpNature";
            this.grpNature.Size = new System.Drawing.Size(234, 43);
            this.grpNature.TabIndex = 13;
            this.grpNature.TabStop = false;
            this.grpNature.Text = "Nature du Client";
            // 
            // rdbAncienne
            // 
            this.rdbAncienne.AutoSize = true;
            this.rdbAncienne.Location = new System.Drawing.Point(158, 19);
            this.rdbAncienne.Name = "rdbAncienne";
            this.rdbAncienne.Size = new System.Drawing.Size(70, 17);
            this.rdbAncienne.TabIndex = 2;
            this.rdbAncienne.TabStop = true;
            this.rdbAncienne.Text = "Ancienne";
            this.rdbAncienne.UseVisualStyleBackColor = true;
            // 
            // rdbSecondaire
            // 
            this.rdbSecondaire.AutoSize = true;
            this.rdbSecondaire.Location = new System.Drawing.Point(79, 19);
            this.rdbSecondaire.Name = "rdbSecondaire";
            this.rdbSecondaire.Size = new System.Drawing.Size(79, 17);
            this.rdbSecondaire.TabIndex = 1;
            this.rdbSecondaire.TabStop = true;
            this.rdbSecondaire.Text = "Secondaire";
            this.rdbSecondaire.UseVisualStyleBackColor = true;
            // 
            // rdbPrincipal
            // 
            this.rdbPrincipal.AutoSize = true;
            this.rdbPrincipal.Location = new System.Drawing.Point(8, 19);
            this.rdbPrincipal.Name = "rdbPrincipal";
            this.rdbPrincipal.Size = new System.Drawing.Size(65, 17);
            this.rdbPrincipal.TabIndex = 0;
            this.rdbPrincipal.TabStop = true;
            this.rdbPrincipal.Text = "Principal";
            this.rdbPrincipal.UseVisualStyleBackColor = true;
            // 
            // txtNumeroClient
            // 
            this.txtNumeroClient.Location = new System.Drawing.Point(160, 13);
            this.txtNumeroClient.Name = "txtNumeroClient";
            this.txtNumeroClient.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroClient.TabIndex = 1;
            // 
            // txtRaisonSociale
            // 
            this.txtRaisonSociale.Location = new System.Drawing.Point(160, 42);
            this.txtRaisonSociale.Name = "txtRaisonSociale";
            this.txtRaisonSociale.Size = new System.Drawing.Size(200, 20);
            this.txtRaisonSociale.TabIndex = 2;
            // 
            // txtAdresseClient
            // 
            this.txtAdresseClient.Location = new System.Drawing.Point(160, 103);
            this.txtAdresseClient.Name = "txtAdresseClient";
            this.txtAdresseClient.Size = new System.Drawing.Size(200, 20);
            this.txtAdresseClient.TabIndex = 4;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(160, 129);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(200, 20);
            this.txtTelephone.TabIndex = 5;
            // 
            // txtCA
            // 
            this.txtCA.Location = new System.Drawing.Point(160, 155);
            this.txtCA.Name = "txtCA";
            this.txtCA.Size = new System.Drawing.Size(200, 20);
            this.txtCA.TabIndex = 6;
            // 
            // txtEffectif
            // 
            this.txtEffectif.Location = new System.Drawing.Point(160, 181);
            this.txtEffectif.Name = "txtEffectif";
            this.txtEffectif.Size = new System.Drawing.Size(200, 20);
            this.txtEffectif.TabIndex = 7;
            // 
            // lblCommentaires
            // 
            this.lblCommentaires.AutoSize = true;
            this.lblCommentaires.Location = new System.Drawing.Point(13, 210);
            this.lblCommentaires.Name = "lblCommentaires";
            this.lblCommentaires.Size = new System.Drawing.Size(139, 13);
            this.lblCommentaires.TabIndex = 21;
            this.lblCommentaires.Text = "Commentaires Commerciaux";
            // 
            // txtCommentaires
            // 
            this.txtCommentaires.Location = new System.Drawing.Point(160, 207);
            this.txtCommentaires.Multiline = true;
            this.txtCommentaires.Name = "txtCommentaires";
            this.txtCommentaires.Size = new System.Drawing.Size(472, 86);
            this.txtCommentaires.TabIndex = 8;
            // 
            // btnContacts
            // 
            this.btnContacts.Location = new System.Drawing.Point(10, 299);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(123, 23);
            this.btnContacts.TabIndex = 23;
            this.btnContacts.Text = "&Contacts Clients";
            this.btnContacts.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(214, 299);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 24;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // frmClt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 336);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnContacts);
            this.Controls.Add(this.txtCommentaires);
            this.Controls.Add(this.lblCommentaires);
            this.Controls.Add(this.txtEffectif);
            this.Controls.Add(this.txtCA);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtAdresseClient);
            this.Controls.Add(this.txtRaisonSociale);
            this.Controls.Add(this.txtNumeroClient);
            this.Controls.Add(this.grpNature);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.grpTypeClient);
            this.Controls.Add(this.lblEffectifs);
            this.Controls.Add(this.lblCA);
            this.Controls.Add(this.lblTéléphone);
            this.Controls.Add(this.lblAdresseClient);
            this.Controls.Add(this.lblDomaineActivite);
            this.Controls.Add(this.lblRaisonSociale);
            this.Controls.Add(this.lblNumeroClient);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnSupprimer);
            this.Name = "frmClt";
            this.Text = "Fiche Client ABI";
            this.grpTypeClient.ResumeLayout(false);
            this.grpTypeClient.PerformLayout();
            this.grpNature.ResumeLayout(false);
            this.grpNature.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblNumeroClient;
        private System.Windows.Forms.Label lblRaisonSociale;
        private System.Windows.Forms.Label lblDomaineActivite;
        private System.Windows.Forms.Label lblAdresseClient;
        private System.Windows.Forms.Label lblTéléphone;
        private System.Windows.Forms.Label lblCA;
        private System.Windows.Forms.Label lblEffectifs;
        private System.Windows.Forms.GroupBox grpTypeClient;
        private System.Windows.Forms.RadioButton rdbTypeClientPrive;
        private System.Windows.Forms.RadioButton rdbTypeClientPublic;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox grpNature;
        private System.Windows.Forms.RadioButton rdbAncienne;
        private System.Windows.Forms.RadioButton rdbSecondaire;
        private System.Windows.Forms.RadioButton rdbPrincipal;
        private System.Windows.Forms.TextBox txtNumeroClient;
        private System.Windows.Forms.TextBox txtRaisonSociale;
        private System.Windows.Forms.TextBox txtAdresseClient;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtCA;
        private System.Windows.Forms.TextBox txtEffectif;
        private System.Windows.Forms.Label lblCommentaires;
        private System.Windows.Forms.TextBox txtCommentaires;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.Button btnAjouter;
    }
}