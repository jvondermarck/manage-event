namespace uControlMenu
{
    partial class userControlMenu
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

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitre = new System.Windows.Forms.Label();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.btnBilan = new System.Windows.Forms.Button();
            this.btnDepense = new System.Windows.Forms.Button();
            this.btnEvenements = new System.Windows.Forms.Button();
            this.btnParticipant = new System.Windows.Forms.Button();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelMenu.Controls.Add(this.sidePanel);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.labelTitre);
            this.panelMenu.Controls.Add(this.pcbLogo);
            this.panelMenu.Controls.Add(this.btnBilan);
            this.panelMenu.Controls.Add(this.btnDepense);
            this.panelMenu.Controls.Add(this.btnEvenements);
            this.panelMenu.Controls.Add(this.btnParticipant);
            this.panelMenu.Controls.Add(this.btnAccueil);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(207, 753);
            this.panelMenu.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(198)))));
            this.sidePanel.Location = new System.Drawing.Point(-1, 250);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(11, 59);
            this.sidePanel.TabIndex = 4;
            this.sidePanel.Tag = "1";
            this.sidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidePanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Partage";
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.BackColor = System.Drawing.Color.Transparent;
            this.labelTitre.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.White;
            this.labelTitre.Location = new System.Drawing.Point(25, 166);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(139, 39);
            this.labelTitre.TabIndex = 3;
            this.labelTitre.Text = "Le Juste";
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = global::uControlMenu.Properties.Resources.high_five;
            this.pcbLogo.Location = new System.Drawing.Point(60, 36);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(103, 100);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 2;
            this.pcbLogo.TabStop = false;
            // 
            // btnBilan
            // 
            this.btnBilan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBilan.FlatAppearance.BorderSize = 0;
            this.btnBilan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBilan.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBilan.ForeColor = System.Drawing.Color.White;
            this.btnBilan.Image = global::uControlMenu.Properties.Resources.bilan2;
            this.btnBilan.Location = new System.Drawing.Point(-2, 510);
            this.btnBilan.Name = "btnBilan";
            this.btnBilan.Size = new System.Drawing.Size(222, 59);
            this.btnBilan.TabIndex = 1;
            this.btnBilan.Tag = "5";
            this.btnBilan.Text = "   Bilan";
            this.btnBilan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBilan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBilan.UseVisualStyleBackColor = true;
            this.btnBilan.Click += new System.EventHandler(this.btnBilan_Click);
            this.btnBilan.Leave += new System.EventHandler(this.btnBilan_Leave);
            // 
            // btnDepense
            // 
            this.btnDepense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepense.FlatAppearance.BorderSize = 0;
            this.btnDepense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepense.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepense.ForeColor = System.Drawing.Color.White;
            this.btnDepense.Image = global::uControlMenu.Properties.Resources.depenses2;
            this.btnDepense.Location = new System.Drawing.Point(-2, 445);
            this.btnDepense.Name = "btnDepense";
            this.btnDepense.Size = new System.Drawing.Size(222, 59);
            this.btnDepense.TabIndex = 1;
            this.btnDepense.Tag = "4";
            this.btnDepense.Text = "   Dépenses";
            this.btnDepense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDepense.UseVisualStyleBackColor = true;
            this.btnDepense.Click += new System.EventHandler(this.btnDepense_Click);
            this.btnDepense.Leave += new System.EventHandler(this.btnDepense_Leave);
            // 
            // btnEvenements
            // 
            this.btnEvenements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEvenements.FlatAppearance.BorderSize = 0;
            this.btnEvenements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvenements.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvenements.ForeColor = System.Drawing.Color.White;
            this.btnEvenements.Image = global::uControlMenu.Properties.Resources.events2;
            this.btnEvenements.Location = new System.Drawing.Point(-2, 315);
            this.btnEvenements.Name = "btnEvenements";
            this.btnEvenements.Size = new System.Drawing.Size(222, 59);
            this.btnEvenements.TabIndex = 1;
            this.btnEvenements.Tag = "2";
            this.btnEvenements.Text = "  Evènements";
            this.btnEvenements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvenements.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEvenements.UseVisualStyleBackColor = true;
            this.btnEvenements.Click += new System.EventHandler(this.btnEvenements_Click);
            this.btnEvenements.Leave += new System.EventHandler(this.btnEvenements_Leave);
            // 
            // btnParticipant
            // 
            this.btnParticipant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParticipant.FlatAppearance.BorderSize = 0;
            this.btnParticipant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParticipant.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParticipant.ForeColor = System.Drawing.Color.White;
            this.btnParticipant.Image = global::uControlMenu.Properties.Resources.participant2;
            this.btnParticipant.Location = new System.Drawing.Point(-2, 380);
            this.btnParticipant.Name = "btnParticipant";
            this.btnParticipant.Size = new System.Drawing.Size(222, 59);
            this.btnParticipant.TabIndex = 1;
            this.btnParticipant.Tag = "3";
            this.btnParticipant.Text = "   Participant";
            this.btnParticipant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParticipant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnParticipant.UseVisualStyleBackColor = true;
            this.btnParticipant.Click += new System.EventHandler(this.btnParticipant_Click);
            this.btnParticipant.Leave += new System.EventHandler(this.btnParticipant_Leave);
            // 
            // btnAccueil
            // 
            this.btnAccueil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccueil.FlatAppearance.BorderSize = 0;
            this.btnAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccueil.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccueil.ForeColor = System.Drawing.Color.White;
            this.btnAccueil.Image = global::uControlMenu.Properties.Resources.accueil2;
            this.btnAccueil.Location = new System.Drawing.Point(-2, 250);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(222, 59);
            this.btnAccueil.TabIndex = 1;
            this.btnAccueil.Tag = "1";
            this.btnAccueil.Text = "   Accueil";
            this.btnAccueil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccueil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccueil.UseVisualStyleBackColor = true;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            this.btnAccueil.Leave += new System.EventHandler(this.btnAccueil_Leave);
            this.btnAccueil.MouseHover += new System.EventHandler(this.btnAccueil_MouseHover);
            // 
            // userControlMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMenu);
            this.Name = "userControlMenu";
            this.Size = new System.Drawing.Size(207, 753);
            this.Load += new System.EventHandler(this.userControlMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Button btnBilan;
        private System.Windows.Forms.Button btnDepense;
        private System.Windows.Forms.Button btnEvenements;
        private System.Windows.Forms.Button btnParticipant;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Label label1;
    }
}
