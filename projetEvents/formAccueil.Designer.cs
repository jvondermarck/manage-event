
namespace projetEvents
{
    partial class formMain
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
            this.components = new System.ComponentModel.Container();
            this.lblEvents = new System.Windows.Forms.Label();
            this.lblQuoi = new System.Windows.Forms.Label();
            this.lblCombien = new System.Windows.Forms.Label();
            this.lblPayePar = new System.Windows.Forms.Label();
            this.lblBeneficiaire = new System.Windows.Forms.Label();
            this.ckbToutLeMonde = new System.Windows.Forms.CheckBox();
            this.clbListeBeneficiaire = new System.Windows.Forms.CheckedListBox();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.rtbCommentaire = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDepense = new System.Windows.Forms.DateTimePicker();
            this.cboEvenements = new System.Windows.Forms.ComboBox();
            this.cboPayePar = new System.Windows.Forms.ComboBox();
            this.txtQuoi = new System.Windows.Forms.TextBox();
            this.txtCombien = new System.Windows.Forms.TextBox();
            this.Valider = new System.Windows.Forms.Button();
            this.Annuler = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblErrorEvenement = new System.Windows.Forms.Label();
            this.lblErrorQuoi = new System.Windows.Forms.Label();
            this.lblErrorCombien = new System.Windows.Forms.Label();
            this.lblErrorPayePar = new System.Windows.Forms.Label();
            this.lblErrorBeneficiaire = new System.Windows.Forms.Label();
            this.pcbLoadingValidate = new System.Windows.Forms.PictureBox();
            this.userControlMenu1 = new uControlMenu.userControlMenu();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoadingValidate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvents.ForeColor = System.Drawing.Color.White;
            this.lblEvents.Location = new System.Drawing.Point(238, 202);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(143, 27);
            this.lblEvents.TabIndex = 1;
            this.lblEvents.Text = "Evènement : ";
            // 
            // lblQuoi
            // 
            this.lblQuoi.AutoSize = true;
            this.lblQuoi.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuoi.ForeColor = System.Drawing.Color.White;
            this.lblQuoi.Location = new System.Drawing.Point(239, 263);
            this.lblQuoi.Name = "lblQuoi";
            this.lblQuoi.Size = new System.Drawing.Size(74, 27);
            this.lblQuoi.TabIndex = 1;
            this.lblQuoi.Text = "Quoi : ";
            // 
            // lblCombien
            // 
            this.lblCombien.AutoSize = true;
            this.lblCombien.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombien.ForeColor = System.Drawing.Color.White;
            this.lblCombien.Location = new System.Drawing.Point(238, 328);
            this.lblCombien.Name = "lblCombien";
            this.lblCombien.Size = new System.Drawing.Size(114, 27);
            this.lblCombien.TabIndex = 1;
            this.lblCombien.Text = "Combien :";
            // 
            // lblPayePar
            // 
            this.lblPayePar.AutoSize = true;
            this.lblPayePar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayePar.ForeColor = System.Drawing.Color.White;
            this.lblPayePar.Location = new System.Drawing.Point(238, 395);
            this.lblPayePar.Name = "lblPayePar";
            this.lblPayePar.Size = new System.Drawing.Size(109, 27);
            this.lblPayePar.TabIndex = 1;
            this.lblPayePar.Text = "Payé par :";
            // 
            // lblBeneficiaire
            // 
            this.lblBeneficiaire.AutoSize = true;
            this.lblBeneficiaire.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeneficiaire.ForeColor = System.Drawing.Color.White;
            this.lblBeneficiaire.Location = new System.Drawing.Point(712, 290);
            this.lblBeneficiaire.Name = "lblBeneficiaire";
            this.lblBeneficiaire.Size = new System.Drawing.Size(156, 27);
            this.lblBeneficiaire.TabIndex = 1;
            this.lblBeneficiaire.Text = "Bénéficiaires : ";
            // 
            // ckbToutLeMonde
            // 
            this.ckbToutLeMonde.AutoSize = true;
            this.ckbToutLeMonde.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbToutLeMonde.ForeColor = System.Drawing.Color.White;
            this.ckbToutLeMonde.Location = new System.Drawing.Point(717, 536);
            this.ckbToutLeMonde.Name = "ckbToutLeMonde";
            this.ckbToutLeMonde.Size = new System.Drawing.Size(152, 31);
            this.ckbToutLeMonde.TabIndex = 8;
            this.ckbToutLeMonde.Text = "Tout cocher";
            this.ckbToutLeMonde.UseVisualStyleBackColor = true;
            this.ckbToutLeMonde.CheckedChanged += new System.EventHandler(this.ckbToutLeMonde_CheckedChanged);
            // 
            // clbListeBeneficiaire
            // 
            this.clbListeBeneficiaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.clbListeBeneficiaire.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbListeBeneficiaire.ForeColor = System.Drawing.Color.White;
            this.clbListeBeneficiaire.FormattingEnabled = true;
            this.clbListeBeneficiaire.Location = new System.Drawing.Point(716, 337);
            this.clbListeBeneficiaire.Name = "clbListeBeneficiaire";
            this.clbListeBeneficiaire.Size = new System.Drawing.Size(428, 193);
            this.clbListeBeneficiaire.TabIndex = 7;
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentaire.ForeColor = System.Drawing.Color.White;
            this.lblCommentaire.Location = new System.Drawing.Point(239, 476);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(161, 27);
            this.lblCommentaire.TabIndex = 1;
            this.lblCommentaire.Text = "Commentaire :";
            // 
            // rtbCommentaire
            // 
            this.rtbCommentaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.rtbCommentaire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCommentaire.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCommentaire.ForeColor = System.Drawing.Color.White;
            this.rtbCommentaire.Location = new System.Drawing.Point(243, 515);
            this.rtbCommentaire.Name = "rtbCommentaire";
            this.rtbCommentaire.Size = new System.Drawing.Size(381, 70);
            this.rtbCommentaire.TabIndex = 5;
            this.rtbCommentaire.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(712, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quand :";
            // 
            // dtpDepense
            // 
            this.dtpDepense.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDepense.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.dtpDepense.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDepense.Location = new System.Drawing.Point(818, 202);
            this.dtpDepense.Name = "dtpDepense";
            this.dtpDepense.Size = new System.Drawing.Size(124, 28);
            this.dtpDepense.TabIndex = 6;
            // 
            // cboEvenements
            // 
            this.cboEvenements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.cboEvenements.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEvenements.ForeColor = System.Drawing.Color.White;
            this.cboEvenements.FormattingEnabled = true;
            this.cboEvenements.Location = new System.Drawing.Point(371, 202);
            this.cboEvenements.Name = "cboEvenements";
            this.cboEvenements.Size = new System.Drawing.Size(254, 31);
            this.cboEvenements.TabIndex = 1;
            this.cboEvenements.SelectionChangeCommitted += new System.EventHandler(this.cboEvenements_SelectionChangeCommitted);
            // 
            // cboPayePar
            // 
            this.cboPayePar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.cboPayePar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPayePar.ForeColor = System.Drawing.Color.White;
            this.cboPayePar.FormattingEnabled = true;
            this.cboPayePar.Location = new System.Drawing.Point(371, 391);
            this.cboPayePar.Name = "cboPayePar";
            this.cboPayePar.Size = new System.Drawing.Size(254, 31);
            this.cboPayePar.TabIndex = 4;
            // 
            // txtQuoi
            // 
            this.txtQuoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtQuoi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuoi.ForeColor = System.Drawing.Color.White;
            this.txtQuoi.Location = new System.Drawing.Point(371, 263);
            this.txtQuoi.Name = "txtQuoi";
            this.txtQuoi.Size = new System.Drawing.Size(254, 32);
            this.txtQuoi.TabIndex = 2;
            this.txtQuoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCombien
            // 
            this.txtCombien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtCombien.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombien.ForeColor = System.Drawing.Color.White;
            this.txtCombien.Location = new System.Drawing.Point(371, 328);
            this.txtCombien.Name = "txtCombien";
            this.txtCombien.Size = new System.Drawing.Size(254, 32);
            this.txtCombien.TabIndex = 3;
            this.txtCombien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Valider
            // 
            this.Valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.Valider.FlatAppearance.BorderSize = 0;
            this.Valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Valider.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valider.ForeColor = System.Drawing.Color.White;
            this.Valider.Location = new System.Drawing.Point(1036, 690);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(108, 38);
            this.Valider.TabIndex = 10;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = false;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // Annuler
            // 
            this.Annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(20)))), ((int)(((byte)(100)))));
            this.Annuler.FlatAppearance.BorderSize = 0;
            this.Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Annuler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annuler.ForeColor = System.Drawing.Color.White;
            this.Annuler.Location = new System.Drawing.Point(912, 690);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(108, 38);
            this.Annuler.TabIndex = 9;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = false;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelHeader.Controls.Add(this.button1);
            this.panelHeader.Controls.Add(this.label5);
            this.panelHeader.Controls.Add(this.label3);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1182, 96);
            this.panelHeader.TabIndex = 3;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.button1.Location = new System.Drawing.Point(1093, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 37);
            this.button1.TabIndex = 24;
            this.button1.TabStop = false;
            this.button1.Text = "Quitter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(512, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(608, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "Créez des évènements, invitez des gens, partagez l\'addition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Montserrat", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(233, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 60);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bienvenue ! ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(253, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(406, 33);
            this.label4.TabIndex = 1;
            this.label4.Text = "Saissisez une nouvelle dépense...";
            // 
            // lblErrorEvenement
            // 
            this.lblErrorEvenement.AutoSize = true;
            this.lblErrorEvenement.Font = new System.Drawing.Font("Montserrat", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEvenement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblErrorEvenement.Location = new System.Drawing.Point(372, 235);
            this.lblErrorEvenement.Name = "lblErrorEvenement";
            this.lblErrorEvenement.Size = new System.Drawing.Size(274, 24);
            this.lblErrorEvenement.TabIndex = 17;
            this.lblErrorEvenement.Text = "Sélectionnez un évènement...";
            this.lblErrorEvenement.Visible = false;
            // 
            // lblErrorQuoi
            // 
            this.lblErrorQuoi.AutoSize = true;
            this.lblErrorQuoi.Font = new System.Drawing.Font("Montserrat", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorQuoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblErrorQuoi.Location = new System.Drawing.Point(372, 298);
            this.lblErrorQuoi.Name = "lblErrorQuoi";
            this.lblErrorQuoi.Size = new System.Drawing.Size(233, 24);
            this.lblErrorQuoi.TabIndex = 17;
            this.lblErrorQuoi.Text = "Veuillez inscrire un motif";
            this.lblErrorQuoi.Visible = false;
            // 
            // lblErrorCombien
            // 
            this.lblErrorCombien.AutoSize = true;
            this.lblErrorCombien.Font = new System.Drawing.Font("Montserrat", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCombien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblErrorCombien.Location = new System.Drawing.Point(374, 363);
            this.lblErrorCombien.Name = "lblErrorCombien";
            this.lblErrorCombien.Size = new System.Drawing.Size(264, 24);
            this.lblErrorCombien.TabIndex = 17;
            this.lblErrorCombien.Text = "Veuillez inscrire un montant";
            this.lblErrorCombien.Visible = false;
            // 
            // lblErrorPayePar
            // 
            this.lblErrorPayePar.AutoSize = true;
            this.lblErrorPayePar.Font = new System.Drawing.Font("Montserrat", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPayePar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblErrorPayePar.Location = new System.Drawing.Point(374, 429);
            this.lblErrorPayePar.Name = "lblErrorPayePar";
            this.lblErrorPayePar.Size = new System.Drawing.Size(264, 24);
            this.lblErrorPayePar.TabIndex = 17;
            this.lblErrorPayePar.Text = "Sélectionner un contribuant";
            this.lblErrorPayePar.Visible = false;
            // 
            // lblErrorBeneficiaire
            // 
            this.lblErrorBeneficiaire.AutoSize = true;
            this.lblErrorBeneficiaire.Font = new System.Drawing.Font("Montserrat", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorBeneficiaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblErrorBeneficiaire.Location = new System.Drawing.Point(756, 570);
            this.lblErrorBeneficiaire.Name = "lblErrorBeneficiaire";
            this.lblErrorBeneficiaire.Size = new System.Drawing.Size(364, 24);
            this.lblErrorBeneficiaire.TabIndex = 17;
            this.lblErrorBeneficiaire.Text = "Sélectionner au moins un bénéficiaires";
            this.lblErrorBeneficiaire.Visible = false;
            // 
            // pcbLoadingValidate
            // 
            this.pcbLoadingValidate.Image = global::projetEvents.Properties.Resources.loading2;
            this.pcbLoadingValidate.Location = new System.Drawing.Point(810, 674);
            this.pcbLoadingValidate.Name = "pcbLoadingValidate";
            this.pcbLoadingValidate.Size = new System.Drawing.Size(69, 64);
            this.pcbLoadingValidate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLoadingValidate.TabIndex = 16;
            this.pcbLoadingValidate.TabStop = false;
            this.pcbLoadingValidate.Visible = false;
            // 
            // userControlMenu1
            // 
            this.userControlMenu1.BarrePanel = 1;
            this.userControlMenu1.Location = new System.Drawing.Point(0, 2);
            this.userControlMenu1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlMenu1.Name = "userControlMenu1";
            this.userControlMenu1.Size = new System.Drawing.Size(207, 753);
            this.userControlMenu1.TabIndex = 20;
            this.userControlMenu1.TabStop = false;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.userControlMenu1);
            this.Controls.Add(this.lblErrorBeneficiaire);
            this.Controls.Add(this.lblErrorPayePar);
            this.Controls.Add(this.lblErrorCombien);
            this.Controls.Add(this.lblErrorQuoi);
            this.Controls.Add(this.lblErrorEvenement);
            this.Controls.Add(this.pcbLoadingValidate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.txtCombien);
            this.Controls.Add(this.txtQuoi);
            this.Controls.Add(this.cboPayePar);
            this.Controls.Add(this.cboEvenements);
            this.Controls.Add(this.dtpDepense);
            this.Controls.Add(this.rtbCommentaire);
            this.Controls.Add(this.clbListeBeneficiaire);
            this.Controls.Add(this.ckbToutLeMonde);
            this.Controls.Add(this.lblBeneficiaire);
            this.Controls.Add(this.lblPayePar);
            this.Controls.Add(this.lblCombien);
            this.Controls.Add(this.lblQuoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCommentaire);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Le Juste Partage";
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoadingValidate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Label lblQuoi;
        private System.Windows.Forms.Label lblCombien;
        private System.Windows.Forms.Label lblPayePar;
        private System.Windows.Forms.Label lblBeneficiaire;
        private System.Windows.Forms.CheckBox ckbToutLeMonde;
        private System.Windows.Forms.CheckedListBox clbListeBeneficiaire;
        private System.Windows.Forms.Label lblCommentaire;
        private System.Windows.Forms.RichTextBox rtbCommentaire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDepense;
        private System.Windows.Forms.ComboBox cboEvenements;
        private System.Windows.Forms.ComboBox cboPayePar;
        private System.Windows.Forms.TextBox txtQuoi;
        private System.Windows.Forms.TextBox txtCombien;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pcbLoadingValidate;
        private System.Windows.Forms.Label lblErrorEvenement;
        private System.Windows.Forms.Label lblErrorPayePar;
        private System.Windows.Forms.Label lblErrorCombien;
        private System.Windows.Forms.Label lblErrorQuoi;
        private System.Windows.Forms.Button button1;
        private uControlMenu.userControlMenu userControlMenu1;
        private System.Windows.Forms.Label lblErrorBeneficiaire;
    }
}

