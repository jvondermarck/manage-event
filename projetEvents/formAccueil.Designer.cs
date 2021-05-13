
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.userControlMenu2 = new uControlMenu.userControlMenu();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvents.ForeColor = System.Drawing.Color.White;
            this.lblEvents.Location = new System.Drawing.Point(225, 202);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(140, 23);
            this.lblEvents.TabIndex = 1;
            this.lblEvents.Text = "Evènement : ";
            // 
            // lblQuoi
            // 
            this.lblQuoi.AutoSize = true;
            this.lblQuoi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuoi.ForeColor = System.Drawing.Color.White;
            this.lblQuoi.Location = new System.Drawing.Point(256, 263);
            this.lblQuoi.Name = "lblQuoi";
            this.lblQuoi.Size = new System.Drawing.Size(72, 23);
            this.lblQuoi.TabIndex = 1;
            this.lblQuoi.Text = "Quoi : ";
            // 
            // lblCombien
            // 
            this.lblCombien.AutoSize = true;
            this.lblCombien.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombien.ForeColor = System.Drawing.Color.White;
            this.lblCombien.Location = new System.Drawing.Point(240, 328);
            this.lblCombien.Name = "lblCombien";
            this.lblCombien.Size = new System.Drawing.Size(111, 23);
            this.lblCombien.TabIndex = 1;
            this.lblCombien.Text = "Combien :";
            // 
            // lblPayePar
            // 
            this.lblPayePar.AutoSize = true;
            this.lblPayePar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayePar.ForeColor = System.Drawing.Color.White;
            this.lblPayePar.Location = new System.Drawing.Point(240, 390);
            this.lblPayePar.Name = "lblPayePar";
            this.lblPayePar.Size = new System.Drawing.Size(111, 23);
            this.lblPayePar.TabIndex = 1;
            this.lblPayePar.Text = "Payé par :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(712, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bénéficiaires : ";
            // 
            // ckbToutLeMonde
            // 
            this.ckbToutLeMonde.AutoSize = true;
            this.ckbToutLeMonde.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbToutLeMonde.ForeColor = System.Drawing.Color.White;
            this.ckbToutLeMonde.Location = new System.Drawing.Point(961, 579);
            this.ckbToutLeMonde.Name = "ckbToutLeMonde";
            this.ckbToutLeMonde.Size = new System.Drawing.Size(173, 27);
            this.ckbToutLeMonde.TabIndex = 2;
            this.ckbToutLeMonde.Text = "Tout le monde";
            this.ckbToutLeMonde.UseVisualStyleBackColor = true;
            this.ckbToutLeMonde.CheckedChanged += new System.EventHandler(this.ckbToutLeMonde_CheckedChanged);
            // 
            // clbListeBeneficiaire
            // 
            this.clbListeBeneficiaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.clbListeBeneficiaire.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbListeBeneficiaire.ForeColor = System.Drawing.Color.White;
            this.clbListeBeneficiaire.FormattingEnabled = true;
            this.clbListeBeneficiaire.Location = new System.Drawing.Point(716, 328);
            this.clbListeBeneficiaire.Name = "clbListeBeneficiaire";
            this.clbListeBeneficiaire.Size = new System.Drawing.Size(428, 234);
            this.clbListeBeneficiaire.Sorted = true;
            this.clbListeBeneficiaire.TabIndex = 3;
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentaire.ForeColor = System.Drawing.Color.White;
            this.lblCommentaire.Location = new System.Drawing.Point(240, 467);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(156, 23);
            this.lblCommentaire.TabIndex = 1;
            this.lblCommentaire.Text = "Commentaire :";
            // 
            // rtbCommentaire
            // 
            this.rtbCommentaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.rtbCommentaire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCommentaire.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCommentaire.ForeColor = System.Drawing.Color.White;
            this.rtbCommentaire.Location = new System.Drawing.Point(244, 515);
            this.rtbCommentaire.Name = "rtbCommentaire";
            this.rtbCommentaire.Size = new System.Drawing.Size(381, 175);
            this.rtbCommentaire.TabIndex = 4;
            this.rtbCommentaire.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(712, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quand :";
            // 
            // dtpDepense
            // 
            this.dtpDepense.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDepense.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.dtpDepense.Location = new System.Drawing.Point(818, 202);
            this.dtpDepense.Name = "dtpDepense";
            this.dtpDepense.Size = new System.Drawing.Size(316, 28);
            this.dtpDepense.TabIndex = 5;
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
            this.cboEvenements.TabIndex = 6;
            // 
            // cboPayePar
            // 
            this.cboPayePar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.cboPayePar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPayePar.ForeColor = System.Drawing.Color.White;
            this.cboPayePar.FormattingEnabled = true;
            this.cboPayePar.Location = new System.Drawing.Point(371, 389);
            this.cboPayePar.Name = "cboPayePar";
            this.cboPayePar.Size = new System.Drawing.Size(254, 31);
            this.cboPayePar.TabIndex = 6;
            // 
            // txtQuoi
            // 
            this.txtQuoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtQuoi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuoi.ForeColor = System.Drawing.Color.White;
            this.txtQuoi.Location = new System.Drawing.Point(371, 263);
            this.txtQuoi.Name = "txtQuoi";
            this.txtQuoi.Size = new System.Drawing.Size(254, 32);
            this.txtQuoi.TabIndex = 7;
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
            this.txtCombien.TabIndex = 7;
            this.txtCombien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Valider
            // 
            this.Valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(20)))), ((int)(((byte)(100)))));
            this.Valider.FlatAppearance.BorderSize = 0;
            this.Valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Valider.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valider.ForeColor = System.Drawing.Color.White;
            this.Valider.Location = new System.Drawing.Point(883, 689);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(108, 38);
            this.Valider.TabIndex = 8;
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
            this.Annuler.Location = new System.Drawing.Point(1009, 689);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(108, 38);
            this.Annuler.TabIndex = 8;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = false;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // userControlMenu2
            // 
            this.userControlMenu2.BarrePanel = 1;
            this.userControlMenu2.Location = new System.Drawing.Point(0, 0);
            this.userControlMenu2.Margin = new System.Windows.Forms.Padding(4);
            this.userControlMenu2.Name = "userControlMenu2";
            this.userControlMenu2.Size = new System.Drawing.Size(207, 753);
            this.userControlMenu2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 96);
            this.panel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(234, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 56);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bienvenue ! ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(253, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(403, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Saissisez une nouvelle dépense...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(531, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(696, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Créez des évènements, invitez des gens, partagez l\'addition";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userControlMenu2);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPayePar);
            this.Controls.Add(this.lblCombien);
            this.Controls.Add(this.lblQuoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCommentaire);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Le Juste Partage";
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Label lblQuoi;
        private System.Windows.Forms.Label lblCombien;
        private System.Windows.Forms.Label lblPayePar;
        private System.Windows.Forms.Label label1;
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
        private uControlMenu.userControlMenu userControlMenu2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

