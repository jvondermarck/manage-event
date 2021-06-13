
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
            this.components = new System.ComponentModel.Container();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gbDepense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.gbDepense.Location = new System.Drawing.Point(399, 9);
            this.gbDepense.Name = "gbDepense";
            this.gbDepense.Size = new System.Drawing.Size(563, 625);
            this.gbDepense.TabIndex = 7;
            this.gbDepense.TabStop = false;
            this.gbDepense.Visible = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(428, 565);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(113, 31);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Visible = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnValider.FlatAppearance.BorderSize = 0;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(305, 565);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(116, 31);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Visible = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // cbBeneficiaires
            // 
            this.cbBeneficiaires.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.cbBeneficiaires.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBeneficiaires.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBeneficiaires.ForeColor = System.Drawing.Color.White;
            this.cbBeneficiaires.FormattingEnabled = true;
            this.cbBeneficiaires.Location = new System.Drawing.Point(19, 565);
            this.cbBeneficiaires.Name = "cbBeneficiaires";
            this.cbBeneficiaires.Size = new System.Drawing.Size(272, 32);
            this.cbBeneficiaires.TabIndex = 7;
            this.cbBeneficiaires.Visible = false;
            // 
            // btnSupprimerDep
            // 
            this.btnSupprimerDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnSupprimerDep.FlatAppearance.BorderSize = 0;
            this.btnSupprimerDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerDep.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerDep.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerDep.Location = new System.Drawing.Point(28, 27);
            this.btnSupprimerDep.Name = "btnSupprimerDep";
            this.btnSupprimerDep.Size = new System.Drawing.Size(251, 36);
            this.btnSupprimerDep.TabIndex = 6;
            this.btnSupprimerDep.Text = "Supprimer cette dépense";
            this.btnSupprimerDep.UseVisualStyleBackColor = false;
            this.btnSupprimerDep.Click += new System.EventHandler(this.btnSupprimerDep_Click);
            // 
            // btnAjoutBeneficiaire
            // 
            this.btnAjoutBeneficiaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnAjoutBeneficiaire.FlatAppearance.BorderSize = 0;
            this.btnAjoutBeneficiaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjoutBeneficiaire.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutBeneficiaire.ForeColor = System.Drawing.Color.White;
            this.btnAjoutBeneficiaire.Location = new System.Drawing.Point(297, 27);
            this.btnAjoutBeneficiaire.Name = "btnAjoutBeneficiaire";
            this.btnAjoutBeneficiaire.Size = new System.Drawing.Size(245, 36);
            this.btnAjoutBeneficiaire.TabIndex = 5;
            this.btnAjoutBeneficiaire.Text = "Ajouter un bénéficiaire";
            this.btnAjoutBeneficiaire.UseVisualStyleBackColor = false;
            this.btnAjoutBeneficiaire.Click += new System.EventHandler(this.btnAjoutBeneficiaire_Click);
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
            this.lblAcheteur.Location = new System.Drawing.Point(23, 187);
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
            this.lblMontant.Location = new System.Drawing.Point(23, 142);
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
            this.lbBeneficiaires.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBeneficiaires.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.lbBeneficiaires.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbBeneficiaires.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBeneficiaires.ForeColor = System.Drawing.Color.White;
            this.lbBeneficiaires.FormattingEnabled = true;
            this.lbBeneficiaires.ItemHeight = 32;
            this.lbBeneficiaires.Location = new System.Drawing.Point(28, 286);
            this.lbBeneficiaires.Name = "lbBeneficiaires";
            this.lbBeneficiaires.Size = new System.Drawing.Size(498, 224);
            this.lbBeneficiaires.TabIndex = 0;
            // 
            // lbDepenses
            // 
            this.lbDepenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDepenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.lbDepenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbDepenses.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepenses.ForeColor = System.Drawing.Color.White;
            this.lbDepenses.FormattingEnabled = true;
            this.lbDepenses.ItemHeight = 32;
            this.lbDepenses.Location = new System.Drawing.Point(12, 213);
            this.lbDepenses.Name = "lbDepenses";
            this.lbDepenses.Size = new System.Drawing.Size(363, 64);
            this.lbDepenses.TabIndex = 6;
            this.lbDepenses.Visible = false;
            this.lbDepenses.SelectedIndexChanged += new System.EventHandler(this.lbDepenses_SelectedIndexChanged);
            // 
            // cbEvenement
            // 
            this.cbEvenement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.cbEvenement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvenement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEvenement.ForeColor = System.Drawing.Color.White;
            this.cbEvenement.FormattingEnabled = true;
            this.cbEvenement.Location = new System.Drawing.Point(12, 146);
            this.cbEvenement.Name = "cbEvenement";
            this.cbEvenement.Size = new System.Drawing.Size(363, 32);
            this.cbEvenement.TabIndex = 5;
            this.cbEvenement.SelectedIndexChanged += new System.EventHandler(this.cbEvenement_SelectedIndexChanged_1);
            this.cbEvenement.SelectionChangeCommitted += new System.EventHandler(this.cbEvenement_SelectionChangeCommitted);
            // 
            // lblNbDepenses
            // 
            this.lblNbDepenses.AutoSize = true;
            this.lblNbDepenses.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbDepenses.ForeColor = System.Drawing.Color.White;
            this.lblNbDepenses.Location = new System.Drawing.Point(12, 45);
            this.lblNbDepenses.Name = "lblNbDepenses";
            this.lblNbDepenses.Size = new System.Drawing.Size(92, 39);
            this.lblNbDepenses.TabIndex = 4;
            this.lblNbDepenses.Text = "Il y a ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::projetEvents.Properties.Resources.budget;
            this.pictureBox1.Location = new System.Drawing.Point(77, 489);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Saissiez une nouvelle dépense";
            // 
            // formDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(985, 665);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbDepense);
            this.Controls.Add(this.lbDepenses);
            this.Controls.Add(this.cbEvenement);
            this.Controls.Add(this.lblNbDepenses);
            this.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formDepense";
            this.Text = "formDepense";
            this.Load += new System.EventHandler(this.formDepense_Load);
            this.gbDepense.ResumeLayout(false);
            this.gbDepense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip;
    }
}