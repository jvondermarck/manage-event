
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pcbReduceScreen = new System.Windows.Forms.PictureBox();
            this.pcbQuitter = new System.Windows.Forms.PictureBox();
            this.lblPresentationForm = new System.Windows.Forms.Label();
            this.lblNomForm = new System.Windows.Forms.Label();
            this.panelAllForm = new System.Windows.Forms.Panel();
            this.userControlMenu1 = new uControlMenu.userControlMenu();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbReduceScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQuitter)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            this.panelHeader.Controls.Add(this.pcbReduceScreen);
            this.panelHeader.Controls.Add(this.pcbQuitter);
            this.panelHeader.Controls.Add(this.lblPresentationForm);
            this.panelHeader.Controls.Add(this.lblNomForm);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1182, 96);
            this.panelHeader.TabIndex = 3;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
            // 
            // pcbReduceScreen
            // 
            this.pcbReduceScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbReduceScreen.Image = global::projetEvents.Properties.Resources.shrink;
            this.pcbReduceScreen.Location = new System.Drawing.Point(1106, 12);
            this.pcbReduceScreen.Name = "pcbReduceScreen";
            this.pcbReduceScreen.Size = new System.Drawing.Size(29, 24);
            this.pcbReduceScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbReduceScreen.TabIndex = 25;
            this.pcbReduceScreen.TabStop = false;
            this.pcbReduceScreen.Click += new System.EventHandler(this.pcbReduceScreen_Click);
            // 
            // pcbQuitter
            // 
            this.pcbQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbQuitter.Image = ((System.Drawing.Image)(resources.GetObject("pcbQuitter.Image")));
            this.pcbQuitter.Location = new System.Drawing.Point(1141, 12);
            this.pcbQuitter.Name = "pcbQuitter";
            this.pcbQuitter.Size = new System.Drawing.Size(29, 24);
            this.pcbQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbQuitter.TabIndex = 25;
            this.pcbQuitter.TabStop = false;
            this.pcbQuitter.Click += new System.EventHandler(this.pcbQuitter_Click);
            // 
            // lblPresentationForm
            // 
            this.lblPresentationForm.AutoSize = true;
            this.lblPresentationForm.BackColor = System.Drawing.Color.Transparent;
            this.lblPresentationForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPresentationForm.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentationForm.ForeColor = System.Drawing.Color.White;
            this.lblPresentationForm.Location = new System.Drawing.Point(512, 40);
            this.lblPresentationForm.Name = "lblPresentationForm";
            this.lblPresentationForm.Size = new System.Drawing.Size(608, 27);
            this.lblPresentationForm.TabIndex = 1;
            this.lblPresentationForm.Text = "Créez des évènements, invitez des gens, partagez l\'addition";
            // 
            // lblNomForm
            // 
            this.lblNomForm.AutoSize = true;
            this.lblNomForm.BackColor = System.Drawing.Color.Transparent;
            this.lblNomForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNomForm.Font = new System.Drawing.Font("Montserrat", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomForm.ForeColor = System.Drawing.Color.White;
            this.lblNomForm.Location = new System.Drawing.Point(231, 23);
            this.lblNomForm.Name = "lblNomForm";
            this.lblNomForm.Size = new System.Drawing.Size(289, 60);
            this.lblNomForm.TabIndex = 1;
            this.lblNomForm.Text = "Bienvenue ! ";
            // 
            // panelAllForm
            // 
            this.panelAllForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAllForm.Location = new System.Drawing.Point(204, 96);
            this.panelAllForm.Name = "panelAllForm";
            this.panelAllForm.Size = new System.Drawing.Size(978, 657);
            this.panelAllForm.TabIndex = 21;
            // 
            // userControlMenu1
            // 
            this.userControlMenu1.BarrePanel = 1;
            this.userControlMenu1.Location = new System.Drawing.Point(0, 0);
            this.userControlMenu1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlMenu1.Name = "userControlMenu1";
            this.userControlMenu1.Size = new System.Drawing.Size(205, 753);
            this.userControlMenu1.TabIndex = 1;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.userControlMenu1);
            this.Controls.Add(this.panelAllForm);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Le Juste Partage";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbReduceScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQuitter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pcbQuitter;
        private System.Windows.Forms.PictureBox pcbReduceScreen;
        private uControlMenu.userControlMenu userControlMenu1;
        public System.Windows.Forms.Panel panelAllForm;
        public System.Windows.Forms.Label lblNomForm;
        public System.Windows.Forms.Label lblPresentationForm;
    }
}

