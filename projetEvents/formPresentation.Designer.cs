
namespace projetEvents
{
    partial class formPresentation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPresentation));
            this.lblEvenemts = new System.Windows.Forms.Label();
            this.lblParticipant = new System.Windows.Forms.Label();
            this.lblDepenses = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pcbAddDepense = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAddDepense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEvenemts
            // 
            this.lblEvenemts.AutoSize = true;
            this.lblEvenemts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(59)))), ((int)(((byte)(191)))));
            this.lblEvenemts.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvenemts.ForeColor = System.Drawing.Color.White;
            this.lblEvenemts.Location = new System.Drawing.Point(134, 63);
            this.lblEvenemts.Name = "lblEvenemts";
            this.lblEvenemts.Size = new System.Drawing.Size(111, 46);
            this.lblEvenemts.TabIndex = 0;
            this.lblEvenemts.Text = "label1";
            // 
            // lblParticipant
            // 
            this.lblParticipant.AutoSize = true;
            this.lblParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(119)))), ((int)(((byte)(41)))));
            this.lblParticipant.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipant.ForeColor = System.Drawing.Color.White;
            this.lblParticipant.Location = new System.Drawing.Point(134, 248);
            this.lblParticipant.Name = "lblParticipant";
            this.lblParticipant.Size = new System.Drawing.Size(111, 46);
            this.lblParticipant.TabIndex = 0;
            this.lblParticipant.Text = "label1";
            // 
            // lblDepenses
            // 
            this.lblDepenses.AutoSize = true;
            this.lblDepenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.lblDepenses.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepenses.ForeColor = System.Drawing.Color.White;
            this.lblDepenses.Location = new System.Drawing.Point(131, 441);
            this.lblDepenses.Name = "lblDepenses";
            this.lblDepenses.Size = new System.Drawing.Size(114, 40);
            this.lblDepenses.TabIndex = 0;
            this.lblDepenses.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(408, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Besoin d\'ajouter une nouvelle dépense ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(506, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliquez juste en-dessous";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::projetEvents.Properties.Resources.homePart;
            this.pictureBox4.Location = new System.Drawing.Point(27, 229);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(315, 155);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pcbAddDepense
            // 
            this.pcbAddDepense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbAddDepense.Image = global::projetEvents.Properties.Resources.Group_9;
            this.pcbAddDepense.Location = new System.Drawing.Point(433, 224);
            this.pcbAddDepense.Name = "pcbAddDepense";
            this.pcbAddDepense.Size = new System.Drawing.Size(440, 257);
            this.pcbAddDepense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbAddDepense.TabIndex = 2;
            this.pcbAddDepense.TabStop = false;
            this.pcbAddDepense.Click += new System.EventHandler(this.btnAdd_Click);
            this.pcbAddDepense.MouseEnter += new System.EventHandler(this.pcbAddDepense_MouseEnter);
            this.pcbAddDepense.MouseLeave += new System.EventHandler(this.pcbAddDepense_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(315, 155);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::projetEvents.Properties.Resources.homeDep;
            this.pictureBox3.Location = new System.Drawing.Point(27, 416);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(315, 155);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // formPresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(960, 610);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblParticipant);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pcbAddDepense);
            this.Controls.Add(this.lblDepenses);
            this.Controls.Add(this.lblEvenemts);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formPresentation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "formPresentation";
            this.Load += new System.EventHandler(this.formPresentation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAddDepense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEvenemts;
        private System.Windows.Forms.Label lblParticipant;
        private System.Windows.Forms.Label lblDepenses;
        private System.Windows.Forms.PictureBox pcbAddDepense;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip;
    }
}