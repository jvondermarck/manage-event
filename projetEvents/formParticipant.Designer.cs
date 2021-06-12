
namespace projetEvents
{
    partial class formParticipant
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formParticipant));
            this.btnadd = new System.Windows.Forms.Button();
            this.RTBobj = new System.Windows.Forms.RichTextBox();
            this.RTBcontenu = new System.Windows.Forms.RichTextBox();
            this.lblparticipant = new System.Windows.Forms.Label();
            this.lblcontenu = new System.Windows.Forms.Label();
            this.lblobj = new System.Windows.Forms.Label();
            this.lblajoutparticipant = new System.Windows.Forms.Label();
            this.lblevent = new System.Windows.Forms.Label();
            this.cboajoutparticipant = new System.Windows.Forms.ComboBox();
            this.cboevent = new System.Windows.Forms.ComboBox();
            this.dgvparticipant = new System.Windows.Forms.DataGridView();
            this.lblChooseModeInvit = new System.Windows.Forms.Label();
            this.rdbMailAuto = new System.Windows.Forms.RadioButton();
            this.rdbMailPersonnalise = new System.Windows.Forms.RadioButton();
            this.lblInviter = new System.Windows.Forms.Label();
            this.btninviter = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvparticipant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btninviter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(436, 8);
            this.btnadd.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(109, 55);
            this.btnadd.TabIndex = 50;
            this.btnadd.Text = "Ajouter un invité";
            this.toolTip.SetToolTip(this.btnadd, "Ajouter un nouvelle invité");
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Visible = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // RTBobj
            // 
            this.RTBobj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.RTBobj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTBobj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBobj.ForeColor = System.Drawing.Color.White;
            this.RTBobj.Location = new System.Drawing.Point(143, 419);
            this.RTBobj.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.RTBobj.Name = "RTBobj";
            this.RTBobj.Size = new System.Drawing.Size(802, 35);
            this.RTBobj.TabIndex = 48;
            this.RTBobj.Text = "";
            // 
            // RTBcontenu
            // 
            this.RTBcontenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.RTBcontenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTBcontenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBcontenu.ForeColor = System.Drawing.Color.White;
            this.RTBcontenu.Location = new System.Drawing.Point(143, 469);
            this.RTBcontenu.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.RTBcontenu.Name = "RTBcontenu";
            this.RTBcontenu.Size = new System.Drawing.Size(802, 154);
            this.RTBcontenu.TabIndex = 47;
            this.RTBcontenu.Text = "";
            // 
            // lblparticipant
            // 
            this.lblparticipant.AutoSize = true;
            this.lblparticipant.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblparticipant.ForeColor = System.Drawing.Color.White;
            this.lblparticipant.Location = new System.Drawing.Point(19, 179);
            this.lblparticipant.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblparticipant.Name = "lblparticipant";
            this.lblparticipant.Size = new System.Drawing.Size(555, 33);
            this.lblparticipant.TabIndex = 46;
            this.lblparticipant.Text = "Liste des participants à cette évènements :";
            // 
            // lblcontenu
            // 
            this.lblcontenu.AutoSize = true;
            this.lblcontenu.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontenu.ForeColor = System.Drawing.Color.White;
            this.lblcontenu.Location = new System.Drawing.Point(19, 516);
            this.lblcontenu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblcontenu.Name = "lblcontenu";
            this.lblcontenu.Size = new System.Drawing.Size(100, 27);
            this.lblcontenu.TabIndex = 45;
            this.lblcontenu.Text = "Contenu";
            // 
            // lblobj
            // 
            this.lblobj.AutoSize = true;
            this.lblobj.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblobj.ForeColor = System.Drawing.Color.White;
            this.lblobj.Location = new System.Drawing.Point(42, 424);
            this.lblobj.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblobj.Name = "lblobj";
            this.lblobj.Size = new System.Drawing.Size(68, 27);
            this.lblobj.TabIndex = 44;
            this.lblobj.Text = "Objet";
            // 
            // lblajoutparticipant
            // 
            this.lblajoutparticipant.AutoSize = true;
            this.lblajoutparticipant.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblajoutparticipant.ForeColor = System.Drawing.Color.White;
            this.lblajoutparticipant.Location = new System.Drawing.Point(555, 21);
            this.lblajoutparticipant.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblajoutparticipant.Name = "lblajoutparticipant";
            this.lblajoutparticipant.Size = new System.Drawing.Size(148, 27);
            this.lblajoutparticipant.TabIndex = 43;
            this.lblajoutparticipant.Text = "Futur invité :";
            // 
            // lblevent
            // 
            this.lblevent.AutoSize = true;
            this.lblevent.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblevent.ForeColor = System.Drawing.Color.White;
            this.lblevent.Location = new System.Drawing.Point(20, 19);
            this.lblevent.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblevent.Name = "lblevent";
            this.lblevent.Size = new System.Drawing.Size(151, 27);
            this.lblevent.TabIndex = 42;
            this.lblevent.Text = "Evenement : ";
            // 
            // cboajoutparticipant
            // 
            this.cboajoutparticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.cboajoutparticipant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboajoutparticipant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboajoutparticipant.ForeColor = System.Drawing.Color.White;
            this.cboajoutparticipant.FormattingEnabled = true;
            this.cboajoutparticipant.Location = new System.Drawing.Point(692, 18);
            this.cboajoutparticipant.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cboajoutparticipant.Name = "cboajoutparticipant";
            this.cboajoutparticipant.Size = new System.Drawing.Size(265, 35);
            this.cboajoutparticipant.TabIndex = 39;
            this.cboajoutparticipant.SelectionChangeCommitted += new System.EventHandler(this.Cboajoutparticipant_SelectionChangeCommitted);
            // 
            // cboevent
            // 
            this.cboevent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.cboevent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboevent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboevent.ForeColor = System.Drawing.Color.White;
            this.cboevent.FormattingEnabled = true;
            this.cboevent.Location = new System.Drawing.Point(158, 16);
            this.cboevent.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cboevent.Name = "cboevent";
            this.cboevent.Size = new System.Drawing.Size(250, 35);
            this.cboevent.TabIndex = 40;
            this.cboevent.SelectionChangeCommitted += new System.EventHandler(this.Cboevent_SelectionChangeCommitted);
            // 
            // dgvparticipant
            // 
            this.dgvparticipant.AllowUserToAddRows = false;
            this.dgvparticipant.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvparticipant.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvparticipant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvparticipant.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvparticipant.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgvparticipant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvparticipant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvparticipant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvparticipant.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvparticipant.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvparticipant.EnableHeadersVisualStyles = false;
            this.dgvparticipant.GridColor = System.Drawing.Color.White;
            this.dgvparticipant.Location = new System.Drawing.Point(24, 226);
            this.dgvparticipant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvparticipant.Name = "dgvparticipant";
            this.dgvparticipant.ReadOnly = true;
            this.dgvparticipant.RowHeadersVisible = false;
            this.dgvparticipant.RowHeadersWidth = 51;
            this.dgvparticipant.RowTemplate.Height = 24;
            this.dgvparticipant.Size = new System.Drawing.Size(921, 176);
            this.dgvparticipant.TabIndex = 52;
            this.dgvparticipant.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvparticipant_CellClick);
            // 
            // lblChooseModeInvit
            // 
            this.lblChooseModeInvit.AutoSize = true;
            this.lblChooseModeInvit.ForeColor = System.Drawing.Color.White;
            this.lblChooseModeInvit.Location = new System.Drawing.Point(19, 86);
            this.lblChooseModeInvit.Name = "lblChooseModeInvit";
            this.lblChooseModeInvit.Size = new System.Drawing.Size(329, 27);
            this.lblChooseModeInvit.TabIndex = 53;
            this.lblChooseModeInvit.Text = "Choissisez le mode d\'invitation :";
            this.lblChooseModeInvit.Visible = false;
            // 
            // rdbMailAuto
            // 
            this.rdbMailAuto.AutoSize = true;
            this.rdbMailAuto.ForeColor = System.Drawing.Color.White;
            this.rdbMailAuto.Location = new System.Drawing.Point(321, 86);
            this.rdbMailAuto.Name = "rdbMailAuto";
            this.rdbMailAuto.Size = new System.Drawing.Size(331, 31);
            this.rdbMailAuto.TabIndex = 54;
            this.rdbMailAuto.TabStop = true;
            this.rdbMailAuto.Text = "Envoyer un mail automatique";
            this.rdbMailAuto.UseVisualStyleBackColor = true;
            this.rdbMailAuto.Visible = false;
            this.rdbMailAuto.CheckedChanged += new System.EventHandler(this.rdbMailAuto_CheckedChanged);
            // 
            // rdbMailPersonnalise
            // 
            this.rdbMailPersonnalise.AutoSize = true;
            this.rdbMailPersonnalise.ForeColor = System.Drawing.Color.White;
            this.rdbMailPersonnalise.Location = new System.Drawing.Point(321, 123);
            this.rdbMailPersonnalise.Name = "rdbMailPersonnalise";
            this.rdbMailPersonnalise.Size = new System.Drawing.Size(208, 31);
            this.rdbMailPersonnalise.TabIndex = 55;
            this.rdbMailPersonnalise.TabStop = true;
            this.rdbMailPersonnalise.Text = "Mail personnalisé";
            this.rdbMailPersonnalise.UseVisualStyleBackColor = true;
            this.rdbMailPersonnalise.Visible = false;
            this.rdbMailPersonnalise.CheckedChanged += new System.EventHandler(this.rdbMailPersonnalise_CheckedChanged);
            // 
            // lblInviter
            // 
            this.lblInviter.AutoSize = true;
            this.lblInviter.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInviter.ForeColor = System.Drawing.Color.White;
            this.lblInviter.Location = new System.Drawing.Point(738, 71);
            this.lblInviter.Name = "lblInviter";
            this.lblInviter.Size = new System.Drawing.Size(205, 27);
            this.lblInviter.TabIndex = 57;
            this.lblInviter.Text = "Envoyer l\'invitation";
            // 
            // btninviter
            // 
            this.btninviter.Image = ((System.Drawing.Image)(resources.GetObject("btninviter.Image")));
            this.btninviter.Location = new System.Drawing.Point(753, 89);
            this.btninviter.Name = "btninviter";
            this.btninviter.Size = new System.Drawing.Size(144, 93);
            this.btninviter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btninviter.TabIndex = 56;
            this.btninviter.TabStop = false;
            this.btninviter.Click += new System.EventHandler(this.Btninv_Click);
            this.btninviter.MouseEnter += new System.EventHandler(this.btninviter_MouseEnter);
            this.btninviter.MouseLeave += new System.EventHandler(this.btninviter_MouseLeave);
            // 
            // formParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(980, 674);
            this.Controls.Add(this.lblInviter);
            this.Controls.Add(this.btninviter);
            this.Controls.Add(this.rdbMailPersonnalise);
            this.Controls.Add(this.rdbMailAuto);
            this.Controls.Add(this.lblChooseModeInvit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.RTBobj);
            this.Controls.Add(this.RTBcontenu);
            this.Controls.Add(this.lblparticipant);
            this.Controls.Add(this.lblcontenu);
            this.Controls.Add(this.lblobj);
            this.Controls.Add(this.lblajoutparticipant);
            this.Controls.Add(this.lblevent);
            this.Controls.Add(this.cboajoutparticipant);
            this.Controls.Add(this.cboevent);
            this.Controls.Add(this.dgvparticipant);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formParticipant";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GdP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvparticipant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btninviter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.RichTextBox RTBobj;
        private System.Windows.Forms.RichTextBox RTBcontenu;
        private System.Windows.Forms.Label lblparticipant;
        private System.Windows.Forms.Label lblcontenu;
        private System.Windows.Forms.Label lblobj;
        private System.Windows.Forms.Label lblajoutparticipant;
        private System.Windows.Forms.Label lblevent;
        private System.Windows.Forms.ComboBox cboajoutparticipant;
        private System.Windows.Forms.ComboBox cboevent;
        private System.Windows.Forms.DataGridView dgvparticipant;
        private System.Windows.Forms.Label lblChooseModeInvit;
        private System.Windows.Forms.RadioButton rdbMailAuto;
        private System.Windows.Forms.RadioButton rdbMailPersonnalise;
        private System.Windows.Forms.PictureBox btninviter;
        private System.Windows.Forms.Label lblInviter;
        private System.Windows.Forms.ToolTip toolTip;
    }
}