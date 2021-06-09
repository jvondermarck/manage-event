
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnmail = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btninviter = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvparticipant)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmail
            // 
            this.btnmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnmail.FlatAppearance.BorderSize = 0;
            this.btnmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmail.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmail.ForeColor = System.Drawing.Color.White;
            this.btnmail.Location = new System.Drawing.Point(782, 440);
            this.btnmail.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnmail.Name = "btnmail";
            this.btnmail.Size = new System.Drawing.Size(174, 38);
            this.btnmail.TabIndex = 51;
            this.btnmail.Text = "Ecrire un mail ?";
            this.btnmail.UseVisualStyleBackColor = false;
            this.btnmail.Click += new System.EventHandler(this.Btnmail_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(429, 10);
            this.btnadd.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(90, 55);
            this.btnadd.TabIndex = 50;
            this.btnadd.Text = "Ajouter invité";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Visible = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btninviter
            // 
            this.btninviter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btninviter.FlatAppearance.BorderSize = 0;
            this.btninviter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninviter.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninviter.ForeColor = System.Drawing.Color.White;
            this.btninviter.Location = new System.Drawing.Point(766, 540);
            this.btninviter.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btninviter.Name = "btninviter";
            this.btninviter.Size = new System.Drawing.Size(200, 74);
            this.btninviter.TabIndex = 49;
            this.btninviter.Text = "Envoyer l\'invitation";
            this.btninviter.UseVisualStyleBackColor = false;
            this.btninviter.Click += new System.EventHandler(this.Btninv_Click);
            // 
            // RTBobj
            // 
            this.RTBobj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.RTBobj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTBobj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBobj.ForeColor = System.Drawing.Color.White;
            this.RTBobj.Location = new System.Drawing.Point(141, 379);
            this.RTBobj.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.RTBobj.Name = "RTBobj";
            this.RTBobj.Size = new System.Drawing.Size(585, 35);
            this.RTBobj.TabIndex = 48;
            this.RTBobj.Text = "";
            // 
            // RTBcontenu
            // 
            this.RTBcontenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.RTBcontenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTBcontenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBcontenu.ForeColor = System.Drawing.Color.White;
            this.RTBcontenu.Location = new System.Drawing.Point(141, 448);
            this.RTBcontenu.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.RTBcontenu.Name = "RTBcontenu";
            this.RTBcontenu.Size = new System.Drawing.Size(585, 182);
            this.RTBcontenu.TabIndex = 47;
            this.RTBcontenu.Text = "";
            // 
            // lblparticipant
            // 
            this.lblparticipant.AutoSize = true;
            this.lblparticipant.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblparticipant.ForeColor = System.Drawing.Color.White;
            this.lblparticipant.Location = new System.Drawing.Point(19, 79);
            this.lblparticipant.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblparticipant.Name = "lblparticipant";
            this.lblparticipant.Size = new System.Drawing.Size(439, 27);
            this.lblparticipant.TabIndex = 46;
            this.lblparticipant.Text = "Liste des participants à cette évènements :";
            // 
            // lblcontenu
            // 
            this.lblcontenu.AutoSize = true;
            this.lblcontenu.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontenu.ForeColor = System.Drawing.Color.White;
            this.lblcontenu.Location = new System.Drawing.Point(19, 451);
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
            this.lblobj.Location = new System.Drawing.Point(32, 379);
            this.lblobj.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblobj.Name = "lblobj";
            this.lblobj.Size = new System.Drawing.Size(68, 27);
            this.lblobj.TabIndex = 44;
            this.lblobj.Text = "Objet";
            // 
            // lblajoutparticipant
            // 
            this.lblajoutparticipant.AutoSize = true;
            this.lblajoutparticipant.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblajoutparticipant.ForeColor = System.Drawing.Color.White;
            this.lblajoutparticipant.Location = new System.Drawing.Point(544, 21);
            this.lblajoutparticipant.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblajoutparticipant.Name = "lblajoutparticipant";
            this.lblajoutparticipant.Size = new System.Drawing.Size(136, 27);
            this.lblajoutparticipant.TabIndex = 43;
            this.lblajoutparticipant.Text = "Futur invité :";
            // 
            // lblevent
            // 
            this.lblevent.AutoSize = true;
            this.lblevent.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblevent.ForeColor = System.Drawing.Color.White;
            this.lblevent.Location = new System.Drawing.Point(19, 19);
            this.lblevent.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblevent.Name = "lblevent";
            this.lblevent.Size = new System.Drawing.Size(143, 27);
            this.lblevent.TabIndex = 42;
            this.lblevent.Text = "Evenement : ";
            // 
            // cboajoutparticipant
            // 
            this.cboajoutparticipant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboajoutparticipant.FormattingEnabled = true;
            this.cboajoutparticipant.Location = new System.Drawing.Point(691, 16);
            this.cboajoutparticipant.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cboajoutparticipant.Name = "cboajoutparticipant";
            this.cboajoutparticipant.Size = new System.Drawing.Size(265, 35);
            this.cboajoutparticipant.TabIndex = 39;
            this.cboajoutparticipant.SelectionChangeCommitted += new System.EventHandler(this.Cboajoutparticipant_SelectionChangeCommitted);
            // 
            // cboevent
            // 
            this.cboevent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboevent.FormattingEnabled = true;
            this.cboevent.Location = new System.Drawing.Point(153, 16);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvparticipant.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvparticipant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvparticipant.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvparticipant.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgvparticipant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvparticipant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvparticipant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvparticipant.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvparticipant.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvparticipant.EnableHeadersVisualStyles = false;
            this.dgvparticipant.GridColor = System.Drawing.Color.White;
            this.dgvparticipant.Location = new System.Drawing.Point(37, 124);
            this.dgvparticipant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvparticipant.Name = "dgvparticipant";
            this.dgvparticipant.ReadOnly = true;
            this.dgvparticipant.RowHeadersVisible = false;
            this.dgvparticipant.RowHeadersWidth = 51;
            this.dgvparticipant.RowTemplate.Height = 24;
            this.dgvparticipant.Size = new System.Drawing.Size(898, 226);
            this.dgvparticipant.TabIndex = 52;
            this.dgvparticipant.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvparticipant_CellClick);
            // 
            // formParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(980, 674);
            this.Controls.Add(this.btnmail);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btninviter);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmail;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btninviter;
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
    }
}