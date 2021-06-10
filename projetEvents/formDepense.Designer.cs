
namespace projetEvents
{
    partial class formDepense
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
            this.gbDepense = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.cbBeneficiaires = new System.Windows.Forms.ComboBox();
            this.btnSupprimerDep = new System.Windows.Forms.Button();
            this.btnAjoutBeneficiaire = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAcheteur = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lbBeneficiaires = new System.Windows.Forms.ListBox();
            this.lbDepenses = new System.Windows.Forms.ListBox();
            this.cbEvenement = new System.Windows.Forms.ComboBox();
            this.lblNbDepenses = new System.Windows.Forms.Label();
            this.gbDepense.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDepense
            // 
            this.gbDepense.Controls.Add(this.btnAnnuler);
            this.gbDepense.Controls.Add(this.btnValider);
            this.gbDepense.Controls.Add(this.cbBeneficiaires);
            this.gbDepense.Controls.Add(this.btnSupprimerDep);
            this.gbDepense.Controls.Add(this.btnAjoutBeneficiaire);
            this.gbDepense.Controls.Add(this.label4);
            this.gbDepense.Controls.Add(this.lblAcheteur);
            this.gbDepense.Controls.Add(this.lblMontant);
            this.gbDepense.Controls.Add(this.lblDescription);
            this.gbDepense.Controls.Add(this.lbBeneficiaires);
            this.gbDepense.Location = new System.Drawing.Point(410, 9);
            this.gbDepense.Name = "gbDepense";
            this.gbDepense.Size = new System.Drawing.Size(550, 625);
            this.gbDepense.TabIndex = 7;
            this.gbDepense.TabStop = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(434, 565);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(113, 31);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Visible = false;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(312, 565);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(116, 31);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Visible = false;
            // 
            // cbBeneficiaires
            // 
            this.cbBeneficiaires.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.cbBeneficiaires.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBeneficiaires.ForeColor = System.Drawing.Color.White;
            this.cbBeneficiaires.FormattingEnabled = true;
            this.cbBeneficiaires.Location = new System.Drawing.Point(28, 565);
            this.cbBeneficiaires.Name = "cbBeneficiaires";
            this.cbBeneficiaires.Size = new System.Drawing.Size(272, 32);
            this.cbBeneficiaires.TabIndex = 7;
            this.cbBeneficiaires.Visible = false;
            // 
            // btnSupprimerDep
            // 
            this.btnSupprimerDep.Location = new System.Drawing.Point(28, 27);
            this.btnSupprimerDep.Name = "btnSupprimerDep";
            this.btnSupprimerDep.Size = new System.Drawing.Size(251, 29);
            this.btnSupprimerDep.TabIndex = 6;
            this.btnSupprimerDep.Text = "Supprimer cette dépense";
            this.btnSupprimerDep.UseVisualStyleBackColor = true;
            // 
            // btnAjoutBeneficiaire
            // 
            this.btnAjoutBeneficiaire.Location = new System.Drawing.Point(312, 27);
            this.btnAjoutBeneficiaire.Name = "btnAjoutBeneficiaire";
            this.btnAjoutBeneficiaire.Size = new System.Drawing.Size(224, 29);
            this.btnAjoutBeneficiaire.TabIndex = 5;
            this.btnAjoutBeneficiaire.Text = "Ajouter un bénéficiaire";
            this.btnAjoutBeneficiaire.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bénéficiaires :";
            // 
            // lblAcheteur
            // 
            this.lblAcheteur.AutoSize = true;
            this.lblAcheteur.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcheteur.ForeColor = System.Drawing.Color.White;
            this.lblAcheteur.Location = new System.Drawing.Point(23, 189);
            this.lblAcheteur.Name = "lblAcheteur";
            this.lblAcheteur.Size = new System.Drawing.Size(156, 27);
            this.lblAcheteur.TabIndex = 3;
            this.lblAcheteur.Text = "Dépensé par : ";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant.ForeColor = System.Drawing.Color.White;
            this.lblMontant.Location = new System.Drawing.Point(23, 145);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(114, 27);
            this.lblMontant.TabIndex = 2;
            this.lblMontant.Text = "Montant : ";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(23, 97);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(143, 27);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description : ";
            // 
            // lbBeneficiaires
            // 
            this.lbBeneficiaires.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.lbBeneficiaires.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbBeneficiaires.ForeColor = System.Drawing.Color.White;
            this.lbBeneficiaires.FormattingEnabled = true;
            this.lbBeneficiaires.ItemHeight = 24;
            this.lbBeneficiaires.Location = new System.Drawing.Point(29, 286);
            this.lbBeneficiaires.Name = "lbBeneficiaires";
            this.lbBeneficiaires.Size = new System.Drawing.Size(519, 240);
            this.lbBeneficiaires.TabIndex = 0;
            // 
            // lbDepenses
            // 
            this.lbDepenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.lbDepenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbDepenses.ForeColor = System.Drawing.Color.White;
            this.lbDepenses.FormattingEnabled = true;
            this.lbDepenses.ItemHeight = 24;
            this.lbDepenses.Location = new System.Drawing.Point(8, 106);
            this.lbDepenses.Name = "lbDepenses";
            this.lbDepenses.Size = new System.Drawing.Size(382, 528);
            this.lbDepenses.TabIndex = 6;
            // 
            // cbEvenement
            // 
            this.cbEvenement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.cbEvenement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvenement.ForeColor = System.Drawing.Color.White;
            this.cbEvenement.FormattingEnabled = true;
            this.cbEvenement.Location = new System.Drawing.Point(8, 49);
            this.cbEvenement.Name = "cbEvenement";
            this.cbEvenement.Size = new System.Drawing.Size(382, 32);
            this.cbEvenement.TabIndex = 5;
            // 
            // lblNbDepenses
            // 
            this.lblNbDepenses.AutoSize = true;
            this.lblNbDepenses.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbDepenses.ForeColor = System.Drawing.Color.White;
            this.lblNbDepenses.Location = new System.Drawing.Point(12, 9);
            this.lblNbDepenses.Name = "lblNbDepenses";
            this.lblNbDepenses.Size = new System.Drawing.Size(61, 27);
            this.lblNbDepenses.TabIndex = 4;
            this.lblNbDepenses.Text = "Il y a ";
            // 
            // formDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(985, 665);
            this.Controls.Add(this.gbDepense);
            this.Controls.Add(this.lbDepenses);
            this.Controls.Add(this.cbEvenement);
            this.Controls.Add(this.lblNbDepenses);
            this.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formDepense";
            this.Text = "formDepense";
            this.gbDepense.ResumeLayout(false);
            this.gbDepense.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDepense;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox cbBeneficiaires;
        private System.Windows.Forms.Button btnSupprimerDep;
        private System.Windows.Forms.Button btnAjoutBeneficiaire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAcheteur;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ListBox lbBeneficiaires;
        private System.Windows.Forms.ListBox lbDepenses;
        private System.Windows.Forms.ComboBox cbEvenement;
        private System.Windows.Forms.Label lblNbDepenses;
    }
}