
namespace projetEvents
{
    partial class inviteNewEvents
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
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.cbToutCocher = new System.Windows.Forms.CheckBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.clbParticipants = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnEnvoyer.FlatAppearance.BorderSize = 0;
            this.btnEnvoyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnvoyer.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvoyer.ForeColor = System.Drawing.Color.White;
            this.btnEnvoyer.Location = new System.Drawing.Point(579, 548);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(163, 36);
            this.btnEnvoyer.TabIndex = 13;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = false;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            // 
            // cbToutCocher
            // 
            this.cbToutCocher.AutoSize = true;
            this.cbToutCocher.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbToutCocher.ForeColor = System.Drawing.Color.White;
            this.cbToutCocher.Location = new System.Drawing.Point(85, 471);
            this.cbToutCocher.Name = "cbToutCocher";
            this.cbToutCocher.Size = new System.Drawing.Size(152, 31);
            this.cbToutCocher.TabIndex = 12;
            this.cbToutCocher.Text = "Tout cocher";
            this.cbToutCocher.UseVisualStyleBackColor = true;
            this.cbToutCocher.CheckedChanged += new System.EventHandler(this.cbToutCocher_CheckedChanged);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(759, 547);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(151, 37);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(80, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cochez les participants à inviter à cet évènement :";
            // 
            // clbParticipants
            // 
            this.clbParticipants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.clbParticipants.CheckOnClick = true;
            this.clbParticipants.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbParticipants.ForeColor = System.Drawing.Color.White;
            this.clbParticipants.FormattingEnabled = true;
            this.clbParticipants.Location = new System.Drawing.Point(85, 181);
            this.clbParticipants.Name = "clbParticipants";
            this.clbParticipants.Size = new System.Drawing.Size(756, 274);
            this.clbParticipants.TabIndex = 9;
            this.clbParticipants.SelectedIndexChanged += new System.EventHandler(this.clbParticipants_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quels sont les invités à cet évènement ?";
            // 
            // inviteNewEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(962, 627);
            this.Controls.Add(this.btnEnvoyer);
            this.Controls.Add(this.cbToutCocher);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clbParticipants);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "inviteNewEvents";
            this.Text = "inviteNewEvents";
            this.Load += new System.EventHandler(this.inviteNewEvents_Load);
            this.Click += new System.EventHandler(this.btnAnnuler_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.CheckBox cbToutCocher;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clbParticipants;
        private System.Windows.Forms.Label label1;
    }
}