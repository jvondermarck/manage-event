
namespace projetEvents
{
    partial class formBilan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tpRefund = new System.Windows.Forms.TabControl();
            this.tpRecap = new System.Windows.Forms.TabPage();
            this.lblDepenseConcerne = new System.Windows.Forms.Label();
            this.cboParticipant = new System.Windows.Forms.ComboBox();
            this.lblPart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEvent = new System.Windows.Forms.ComboBox();
            this.lblTotalDepense = new System.Windows.Forms.Label();
            this.dgvDepenseConcerme = new System.Windows.Forms.DataGridView();
            this.dgvMesDepenses = new System.Windows.Forms.DataGridView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtbRecap = new System.Windows.Forms.RichTextBox();
            this.btnQuiDoitQuoiQui = new System.Windows.Forms.Button();
            this.dgvBilanEvent = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tpRefund.SuspendLayout();
            this.tpRecap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepenseConcerme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesDepenses)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilanEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // tpRefund
            // 
            this.tpRefund.CausesValidation = false;
            this.tpRefund.Controls.Add(this.tpRecap);
            this.tpRefund.Controls.Add(this.tabPage2);
            this.tpRefund.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpRefund.Location = new System.Drawing.Point(-10, 9);
            this.tpRefund.Margin = new System.Windows.Forms.Padding(0);
            this.tpRefund.Multiline = true;
            this.tpRefund.Name = "tpRefund";
            this.tpRefund.Padding = new System.Drawing.Point(0, 0);
            this.tpRefund.SelectedIndex = 0;
            this.tpRefund.Size = new System.Drawing.Size(1033, 660);
            this.tpRefund.TabIndex = 1;
            // 
            // tpRecap
            // 
            this.tpRecap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tpRecap.Controls.Add(this.lblDepenseConcerne);
            this.tpRecap.Controls.Add(this.cboParticipant);
            this.tpRecap.Controls.Add(this.lblPart);
            this.tpRecap.Controls.Add(this.label1);
            this.tpRecap.Controls.Add(this.cboEvent);
            this.tpRecap.Controls.Add(this.lblTotalDepense);
            this.tpRecap.Controls.Add(this.dgvDepenseConcerme);
            this.tpRecap.Controls.Add(this.dgvMesDepenses);
            this.tpRecap.Controls.Add(this.btnGenerate);
            this.tpRecap.Controls.Add(this.label4);
            this.tpRecap.Controls.Add(this.label3);
            this.tpRecap.ForeColor = System.Drawing.Color.White;
            this.tpRecap.Location = new System.Drawing.Point(4, 36);
            this.tpRecap.Margin = new System.Windows.Forms.Padding(0);
            this.tpRecap.Name = "tpRecap";
            this.tpRecap.Size = new System.Drawing.Size(1025, 620);
            this.tpRecap.TabIndex = 0;
            this.tpRecap.Text = "   Recap     ";
            // 
            // lblDepenseConcerne
            // 
            this.lblDepenseConcerne.AutoSize = true;
            this.lblDepenseConcerne.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepenseConcerne.ForeColor = System.Drawing.Color.White;
            this.lblDepenseConcerne.Location = new System.Drawing.Point(411, 342);
            this.lblDepenseConcerne.Name = "lblDepenseConcerne";
            this.lblDepenseConcerne.Size = new System.Drawing.Size(82, 27);
            this.lblDepenseConcerne.TabIndex = 4;
            this.lblDepenseConcerne.Text = "Total = ";
            // 
            // cboParticipant
            // 
            this.cboParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cboParticipant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParticipant.ForeColor = System.Drawing.Color.White;
            this.cboParticipant.FormattingEnabled = true;
            this.cboParticipant.Location = new System.Drawing.Point(698, 27);
            this.cboParticipant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboParticipant.Name = "cboParticipant";
            this.cboParticipant.Size = new System.Drawing.Size(249, 35);
            this.cboParticipant.TabIndex = 1;
            this.cboParticipant.Visible = false;
            this.cboParticipant.SelectionChangeCommitted += new System.EventHandler(this.cboParticipant_SelectionChangeCommitted);
            // 
            // lblPart
            // 
            this.lblPart.AutoSize = true;
            this.lblPart.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPart.ForeColor = System.Drawing.Color.White;
            this.lblPart.Location = new System.Drawing.Point(491, 30);
            this.lblPart.Name = "lblPart";
            this.lblPart.Size = new System.Drawing.Size(191, 27);
            this.lblPart.TabIndex = 0;
            this.lblPart.Text = "Quel participant ?";
            this.lblPart.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quel évènement ?";
            // 
            // cboEvent
            // 
            this.cboEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cboEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvent.ForeColor = System.Drawing.Color.White;
            this.cboEvent.FormattingEnabled = true;
            this.cboEvent.Location = new System.Drawing.Point(221, 27);
            this.cboEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboEvent.Name = "cboEvent";
            this.cboEvent.Size = new System.Drawing.Size(249, 35);
            this.cboEvent.TabIndex = 1;
            this.cboEvent.SelectionChangeCommitted += new System.EventHandler(this.cboEvent_SelectionChangeCommitted);
            // 
            // lblTotalDepense
            // 
            this.lblTotalDepense.AutoSize = true;
            this.lblTotalDepense.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDepense.ForeColor = System.Drawing.Color.White;
            this.lblTotalDepense.Location = new System.Drawing.Point(411, 113);
            this.lblTotalDepense.Name = "lblTotalDepense";
            this.lblTotalDepense.Size = new System.Drawing.Size(82, 27);
            this.lblTotalDepense.TabIndex = 4;
            this.lblTotalDepense.Text = "Total = ";
            // 
            // dgvDepenseConcerme
            // 
            this.dgvDepenseConcerme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepenseConcerme.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDepenseConcerme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepenseConcerme.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvDepenseConcerme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepenseConcerme.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDepenseConcerme.Location = new System.Drawing.Point(24, 385);
            this.dgvDepenseConcerme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDepenseConcerme.Name = "dgvDepenseConcerme";
            this.dgvDepenseConcerme.ReadOnly = true;
            this.dgvDepenseConcerme.RowHeadersWidth = 51;
            this.dgvDepenseConcerme.RowTemplate.Height = 24;
            this.dgvDepenseConcerme.Size = new System.Drawing.Size(690, 198);
            this.dgvDepenseConcerme.TabIndex = 3;
            // 
            // dgvMesDepenses
            // 
            this.dgvMesDepenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMesDepenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMesDepenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMesDepenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvMesDepenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMesDepenses.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvMesDepenses.Location = new System.Drawing.Point(24, 157);
            this.dgvMesDepenses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMesDepenses.Name = "dgvMesDepenses";
            this.dgvMesDepenses.ReadOnly = true;
            this.dgvMesDepenses.RowHeadersWidth = 51;
            this.dgvMesDepenses.RowTemplate.Height = 24;
            this.dgvMesDepenses.Size = new System.Drawing.Size(690, 170);
            this.dgvMesDepenses.TabIndex = 3;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.ForeColor = System.Drawing.Color.Black;
            this.btnGenerate.Location = new System.Drawing.Point(777, 134);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(159, 50);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "PDF";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Visible = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGeneratePDF_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "- Ce que je dois rembourser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "- Ce que j\'ai dépensé";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPage2.Controls.Add(this.rtbRecap);
            this.tabPage2.Controls.Add(this.btnQuiDoitQuoiQui);
            this.tabPage2.Controls.Add(this.dgvBilanEvent);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1025, 620);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "     Bilan     ";
            // 
            // rtbRecap
            // 
            this.rtbRecap.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rtbRecap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbRecap.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbRecap.Location = new System.Drawing.Point(289, 285);
            this.rtbRecap.Name = "rtbRecap";
            this.rtbRecap.ReadOnly = true;
            this.rtbRecap.Size = new System.Drawing.Size(635, 279);
            this.rtbRecap.TabIndex = 3;
            this.rtbRecap.Text = "";
            this.rtbRecap.Visible = false;
            // 
            // btnQuiDoitQuoiQui
            // 
            this.btnQuiDoitQuoiQui.Location = new System.Drawing.Point(46, 393);
            this.btnQuiDoitQuoiQui.Name = "btnQuiDoitQuoiQui";
            this.btnQuiDoitQuoiQui.Size = new System.Drawing.Size(183, 40);
            this.btnQuiDoitQuoiQui.TabIndex = 2;
            this.btnQuiDoitQuoiQui.Text = "Qui doit quoi à qui";
            this.btnQuiDoitQuoiQui.UseVisualStyleBackColor = true;
            this.btnQuiDoitQuoiQui.Visible = false;
            this.btnQuiDoitQuoiQui.Click += new System.EventHandler(this.btnQuiDoitQuoiQui_Click);
            // 
            // dgvBilanEvent
            // 
            this.dgvBilanEvent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBilanEvent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBilanEvent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvBilanEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBilanEvent.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvBilanEvent.Location = new System.Drawing.Point(34, 33);
            this.dgvBilanEvent.Name = "dgvBilanEvent";
            this.dgvBilanEvent.ReadOnly = true;
            this.dgvBilanEvent.RowHeadersWidth = 51;
            this.dgvBilanEvent.RowTemplate.Height = 24;
            this.dgvBilanEvent.Size = new System.Drawing.Size(900, 224);
            this.dgvBilanEvent.TabIndex = 0;
            this.dgvBilanEvent.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Location = new System.Drawing.Point(177, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 51);
            this.panel1.TabIndex = 5;
            // 
            // formBilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(978, 656);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tpRefund);
            this.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formBilan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "formBilan";
            this.Load += new System.EventHandler(this.formBilan_Load);
            this.tpRefund.ResumeLayout(false);
            this.tpRecap.ResumeLayout(false);
            this.tpRecap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepenseConcerme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesDepenses)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilanEvent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tpRefund;
        private System.Windows.Forms.TabPage tpRecap;
        private System.Windows.Forms.Label lblDepenseConcerne;
        private System.Windows.Forms.Label lblTotalDepense;
        private System.Windows.Forms.DataGridView dgvDepenseConcerme;
        private System.Windows.Forms.DataGridView dgvMesDepenses;
        private System.Windows.Forms.ComboBox cboParticipant;
        private System.Windows.Forms.ComboBox cboEvent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtbRecap;
        private System.Windows.Forms.Button btnQuiDoitQuoiQui;
        private System.Windows.Forms.DataGridView dgvBilanEvent;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel panel1;
    }
}