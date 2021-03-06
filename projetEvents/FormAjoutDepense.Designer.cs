
namespace projetEvents
{
    partial class FormAjoutDepense
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
            this.lblErrorBeneficiaire = new System.Windows.Forms.Label();
            this.lblErrorPayePar = new System.Windows.Forms.Label();
            this.lblErrorCombien = new System.Windows.Forms.Label();
            this.lblErrorQuoi = new System.Windows.Forms.Label();
            this.lblErrorEvenement = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.Annuler = new System.Windows.Forms.Button();
            this.Valider = new System.Windows.Forms.Button();
            this.txtCombien = new System.Windows.Forms.TextBox();
            this.txtQuoi = new System.Windows.Forms.TextBox();
            this.cboPayePar = new System.Windows.Forms.ComboBox();
            this.cboEvenements = new System.Windows.Forms.ComboBox();
            this.rtbCommentaire = new System.Windows.Forms.RichTextBox();
            this.clbListeBeneficiaire = new System.Windows.Forms.CheckedListBox();
            this.ckbToutLeMonde = new System.Windows.Forms.CheckBox();
            this.lblBeneficiaire = new System.Windows.Forms.Label();
            this.lblPayePar = new System.Windows.Forms.Label();
            this.lblCombien = new System.Windows.Forms.Label();
            this.lblQuoi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDepense = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pcbLoadingValidate = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoadingValidate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblErrorBeneficiaire
            // 
            this.lblErrorBeneficiaire.AutoSize = true;
            this.lblErrorBeneficiaire.Font = new System.Drawing.Font("Montserrat", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorBeneficiaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblErrorBeneficiaire.Location = new System.Drawing.Point(632, 168);
            this.lblErrorBeneficiaire.Name = "lblErrorBeneficiaire";
            this.lblErrorBeneficiaire.Size = new System.Drawing.Size(355, 24);
            this.lblErrorBeneficiaire.TabIndex = 41;
            this.lblErrorBeneficiaire.Text = "Sélectionner au moins un bénéficiaire";
            this.lblErrorBeneficiaire.Visible = false;
            // 
            // lblErrorPayePar
            // 
            this.lblErrorPayePar.AutoSize = true;
            this.lblErrorPayePar.Font = new System.Drawing.Font("Montserrat", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPayePar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblErrorPayePar.Location = new System.Drawing.Point(170, 320);
            this.lblErrorPayePar.Name = "lblErrorPayePar";
            this.lblErrorPayePar.Size = new System.Drawing.Size(264, 24);
            this.lblErrorPayePar.TabIndex = 40;
            this.lblErrorPayePar.Text = "Sélectionner un contribuant";
            this.lblErrorPayePar.Visible = false;
            // 
            // lblErrorCombien
            // 
            this.lblErrorCombien.AutoSize = true;
            this.lblErrorCombien.Font = new System.Drawing.Font("Montserrat", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCombien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblErrorCombien.Location = new System.Drawing.Point(170, 258);
            this.lblErrorCombien.Name = "lblErrorCombien";
            this.lblErrorCombien.Size = new System.Drawing.Size(264, 24);
            this.lblErrorCombien.TabIndex = 39;
            this.lblErrorCombien.Text = "Veuillez inscrire un montant";
            this.lblErrorCombien.Visible = false;
            // 
            // lblErrorQuoi
            // 
            this.lblErrorQuoi.AutoSize = true;
            this.lblErrorQuoi.Font = new System.Drawing.Font("Montserrat", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorQuoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblErrorQuoi.Location = new System.Drawing.Point(176, 193);
            this.lblErrorQuoi.Name = "lblErrorQuoi";
            this.lblErrorQuoi.Size = new System.Drawing.Size(233, 24);
            this.lblErrorQuoi.TabIndex = 38;
            this.lblErrorQuoi.Text = "Veuillez inscrire un motif";
            this.lblErrorQuoi.Visible = false;
            // 
            // lblErrorEvenement
            // 
            this.lblErrorEvenement.AutoSize = true;
            this.lblErrorEvenement.Font = new System.Drawing.Font("Montserrat", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEvenement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblErrorEvenement.Location = new System.Drawing.Point(168, 130);
            this.lblErrorEvenement.Name = "lblErrorEvenement";
            this.lblErrorEvenement.Size = new System.Drawing.Size(274, 24);
            this.lblErrorEvenement.TabIndex = 37;
            this.lblErrorEvenement.Text = "Sélectionnez un évènement...";
            this.lblErrorEvenement.Visible = false;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitre.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(33, 23);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(494, 38);
            this.lblTitre.TabIndex = 25;
            this.lblTitre.Text = "Saissisez une nouvelle dépense...";
            // 
            // Annuler
            // 
            this.Annuler.BackColor = System.Drawing.SystemColors.Highlight;
            this.Annuler.FlatAppearance.BorderSize = 0;
            this.Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Annuler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annuler.ForeColor = System.Drawing.Color.White;
            this.Annuler.Location = new System.Drawing.Point(671, 596);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(122, 38);
            this.Annuler.TabIndex = 34;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = false;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // Valider
            // 
            this.Valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.Valider.FlatAppearance.BorderSize = 0;
            this.Valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Valider.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valider.ForeColor = System.Drawing.Color.White;
            this.Valider.Location = new System.Drawing.Point(810, 596);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(116, 38);
            this.Valider.TabIndex = 35;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = false;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // txtCombien
            // 
            this.txtCombien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtCombien.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombien.ForeColor = System.Drawing.Color.White;
            this.txtCombien.Location = new System.Drawing.Point(167, 225);
            this.txtCombien.MaxLength = 7;
            this.txtCombien.Name = "txtCombien";
            this.txtCombien.Size = new System.Drawing.Size(254, 32);
            this.txtCombien.TabIndex = 28;
            this.txtCombien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCombien.Enter += new System.EventHandler(this.txtCombien_Enter);
            this.txtCombien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCombien_KeyPress);
            this.txtCombien.Leave += new System.EventHandler(this.txtCombien_Leave);
            this.txtCombien.MouseEnter += new System.EventHandler(this.txtCombien_MouseEnter);
            this.txtCombien.MouseLeave += new System.EventHandler(this.txtCombien_MouseLeave);
            // 
            // txtQuoi
            // 
            this.txtQuoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtQuoi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuoi.ForeColor = System.Drawing.Color.White;
            this.txtQuoi.Location = new System.Drawing.Point(167, 160);
            this.txtQuoi.MaxLength = 100;
            this.txtQuoi.Name = "txtQuoi";
            this.txtQuoi.Size = new System.Drawing.Size(254, 32);
            this.txtQuoi.TabIndex = 27;
            this.txtQuoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboPayePar
            // 
            this.cboPayePar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.cboPayePar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPayePar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPayePar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPayePar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPayePar.ForeColor = System.Drawing.Color.White;
            this.cboPayePar.FormattingEnabled = true;
            this.cboPayePar.Location = new System.Drawing.Point(167, 288);
            this.cboPayePar.Name = "cboPayePar";
            this.cboPayePar.Size = new System.Drawing.Size(254, 31);
            this.cboPayePar.TabIndex = 29;
            this.cboPayePar.SelectionChangeCommitted += new System.EventHandler(this.cboPayePar_SelectionChangeCommitted);
            // 
            // cboEvenements
            // 
            this.cboEvenements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.cboEvenements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboEvenements.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvenements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEvenements.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEvenements.ForeColor = System.Drawing.SystemColors.Window;
            this.cboEvenements.FormattingEnabled = true;
            this.cboEvenements.Location = new System.Drawing.Point(167, 99);
            this.cboEvenements.Name = "cboEvenements";
            this.cboEvenements.Size = new System.Drawing.Size(254, 31);
            this.cboEvenements.TabIndex = 25;
            this.cboEvenements.SelectionChangeCommitted += new System.EventHandler(this.cboEvenements_SelectionChangeCommitted);
            // 
            // rtbCommentaire
            // 
            this.rtbCommentaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.rtbCommentaire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCommentaire.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCommentaire.ForeColor = System.Drawing.Color.White;
            this.rtbCommentaire.Location = new System.Drawing.Point(39, 412);
            this.rtbCommentaire.Name = "rtbCommentaire";
            this.rtbCommentaire.Size = new System.Drawing.Size(382, 86);
            this.rtbCommentaire.TabIndex = 30;
            this.rtbCommentaire.Text = "";
            // 
            // clbListeBeneficiaire
            // 
            this.clbListeBeneficiaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.clbListeBeneficiaire.CheckOnClick = true;
            this.clbListeBeneficiaire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clbListeBeneficiaire.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbListeBeneficiaire.ForeColor = System.Drawing.Color.White;
            this.clbListeBeneficiaire.FormattingEnabled = true;
            this.clbListeBeneficiaire.HorizontalScrollbar = true;
            this.clbListeBeneficiaire.Location = new System.Drawing.Point(512, 207);
            this.clbListeBeneficiaire.Name = "clbListeBeneficiaire";
            this.clbListeBeneficiaire.Size = new System.Drawing.Size(428, 166);
            this.clbListeBeneficiaire.TabIndex = 32;
            this.clbListeBeneficiaire.SelectedValueChanged += new System.EventHandler(this.clbListeBeneficiaire_SelectedValueChanged);
            this.clbListeBeneficiaire.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.clbListeBeneficiaire_MouseDoubleClick);
            // 
            // ckbToutLeMonde
            // 
            this.ckbToutLeMonde.AutoSize = true;
            this.ckbToutLeMonde.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbToutLeMonde.ForeColor = System.Drawing.Color.White;
            this.ckbToutLeMonde.Location = new System.Drawing.Point(513, 379);
            this.ckbToutLeMonde.Name = "ckbToutLeMonde";
            this.ckbToutLeMonde.Size = new System.Drawing.Size(264, 31);
            this.ckbToutLeMonde.TabIndex = 33;
            this.ckbToutLeMonde.Text = "Tout cocher / décocher";
            this.ckbToutLeMonde.UseVisualStyleBackColor = true;
            this.ckbToutLeMonde.CheckedChanged += new System.EventHandler(this.ckbToutLeMonde_CheckedChanged);
            // 
            // lblBeneficiaire
            // 
            this.lblBeneficiaire.AutoSize = true;
            this.lblBeneficiaire.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeneficiaire.ForeColor = System.Drawing.Color.White;
            this.lblBeneficiaire.Location = new System.Drawing.Point(507, 165);
            this.lblBeneficiaire.Name = "lblBeneficiaire";
            this.lblBeneficiaire.Size = new System.Drawing.Size(156, 27);
            this.lblBeneficiaire.TabIndex = 23;
            this.lblBeneficiaire.Text = "Bénéficiaires : ";
            // 
            // lblPayePar
            // 
            this.lblPayePar.AutoSize = true;
            this.lblPayePar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayePar.ForeColor = System.Drawing.Color.White;
            this.lblPayePar.Location = new System.Drawing.Point(34, 292);
            this.lblPayePar.Name = "lblPayePar";
            this.lblPayePar.Size = new System.Drawing.Size(109, 27);
            this.lblPayePar.TabIndex = 22;
            this.lblPayePar.Text = "Payé par :";
            // 
            // lblCombien
            // 
            this.lblCombien.AutoSize = true;
            this.lblCombien.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombien.ForeColor = System.Drawing.Color.White;
            this.lblCombien.Location = new System.Drawing.Point(34, 225);
            this.lblCombien.Name = "lblCombien";
            this.lblCombien.Size = new System.Drawing.Size(114, 27);
            this.lblCombien.TabIndex = 21;
            this.lblCombien.Text = "Combien :";
            // 
            // lblQuoi
            // 
            this.lblQuoi.AutoSize = true;
            this.lblQuoi.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuoi.ForeColor = System.Drawing.Color.White;
            this.lblQuoi.Location = new System.Drawing.Point(35, 160);
            this.lblQuoi.Name = "lblQuoi";
            this.lblQuoi.Size = new System.Drawing.Size(74, 27);
            this.lblQuoi.TabIndex = 20;
            this.lblQuoi.Text = "Quoi : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(508, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "Quand :";
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentaire.ForeColor = System.Drawing.Color.White;
            this.lblCommentaire.Location = new System.Drawing.Point(35, 373);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(161, 27);
            this.lblCommentaire.TabIndex = 26;
            this.lblCommentaire.Text = "Commentaire :";
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvents.ForeColor = System.Drawing.Color.White;
            this.lblEvents.Location = new System.Drawing.Point(34, 99);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(143, 27);
            this.lblEvents.TabIndex = 18;
            this.lblEvents.Text = "Evènement : ";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(166, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "(Facultatif...)";
            // 
            // dtpDepense
            // 
            this.dtpDepense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDepense.CustomFormat = " dd/MM/yyyy";
            this.dtpDepense.Font = new System.Drawing.Font("JetBrains Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDepense.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepense.Location = new System.Drawing.Point(601, 99);
            this.dtpDepense.Name = "dtpDepense";
            this.dtpDepense.Size = new System.Drawing.Size(141, 31);
            this.dtpDepense.TabIndex = 31;
            // 
            // pcbLoadingValidate
            // 
            this.pcbLoadingValidate.Image = global::projetEvents.Properties.Resources.loading2;
            this.pcbLoadingValidate.Location = new System.Drawing.Point(585, 580);
            this.pcbLoadingValidate.Name = "pcbLoadingValidate";
            this.pcbLoadingValidate.Size = new System.Drawing.Size(69, 64);
            this.pcbLoadingValidate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLoadingValidate.TabIndex = 36;
            this.pcbLoadingValidate.TabStop = false;
            this.pcbLoadingValidate.Visible = false;
            // 
            // FormAjoutDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(978, 663);
            this.Controls.Add(this.dtpDepense);
            this.Controls.Add(this.lblErrorBeneficiaire);
            this.Controls.Add(this.lblErrorPayePar);
            this.Controls.Add(this.lblErrorCombien);
            this.Controls.Add(this.lblErrorQuoi);
            this.Controls.Add(this.lblErrorEvenement);
            this.Controls.Add(this.pcbLoadingValidate);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.txtCombien);
            this.Controls.Add(this.txtQuoi);
            this.Controls.Add(this.cboPayePar);
            this.Controls.Add(this.cboEvenements);
            this.Controls.Add(this.rtbCommentaire);
            this.Controls.Add(this.clbListeBeneficiaire);
            this.Controls.Add(this.ckbToutLeMonde);
            this.Controls.Add(this.lblBeneficiaire);
            this.Controls.Add(this.lblPayePar);
            this.Controls.Add(this.lblCombien);
            this.Controls.Add(this.lblQuoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCommentaire);
            this.Controls.Add(this.lblEvents);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAjoutDepense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormAjoutDepense";
            this.Load += new System.EventHandler(this.FormAjoutDepense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoadingValidate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrorBeneficiaire;
        private System.Windows.Forms.Label lblErrorPayePar;
        private System.Windows.Forms.Label lblErrorCombien;
        private System.Windows.Forms.Label lblErrorQuoi;
        private System.Windows.Forms.Label lblErrorEvenement;
        private System.Windows.Forms.PictureBox pcbLoadingValidate;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.TextBox txtCombien;
        private System.Windows.Forms.TextBox txtQuoi;
        private System.Windows.Forms.ComboBox cboPayePar;
        private System.Windows.Forms.ComboBox cboEvenements;
        private System.Windows.Forms.RichTextBox rtbCommentaire;
        private System.Windows.Forms.CheckedListBox clbListeBeneficiaire;
        private System.Windows.Forms.CheckBox ckbToutLeMonde;
        private System.Windows.Forms.Label lblBeneficiaire;
        private System.Windows.Forms.Label lblPayePar;
        private System.Windows.Forms.Label lblCombien;
        private System.Windows.Forms.Label lblQuoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCommentaire;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDepense;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}