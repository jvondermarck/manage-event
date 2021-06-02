
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
            this.tpRefund = new System.Windows.Forms.TabControl();
            this.tpRecap = new System.Windows.Forms.TabPage();
            this.lblDepenseConcerne = new System.Windows.Forms.Label();
            this.lblTotalDepense = new System.Windows.Forms.Label();
            this.dgvDepenseConcerme = new System.Windows.Forms.DataGridView();
            this.dgvMesDepenses = new System.Windows.Forms.DataGridView();
            this.btnBilanGlobal = new System.Windows.Forms.Button();
            this.cboParticipant = new System.Windows.Forms.ComboBox();
            this.cboEvent = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtbRecap = new System.Windows.Forms.RichTextBox();
            this.btnQuiDoitQuoiQui = new System.Windows.Forms.Button();
            this.dgvLook = new System.Windows.Forms.DataGridView();
            this.dgvBilanEvent = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tpRefund.SuspendLayout();
            this.tpRecap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepenseConcerme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesDepenses)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilanEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // tpRefund
            // 
            this.tpRefund.CausesValidation = false;
            this.tpRefund.Controls.Add(this.tpRecap);
            this.tpRefund.Controls.Add(this.tabPage2);
            this.tpRefund.Controls.Add(this.tabPage1);
            this.tpRefund.Location = new System.Drawing.Point(9, 9);
            this.tpRefund.Margin = new System.Windows.Forms.Padding(0);
            this.tpRefund.Multiline = true;
            this.tpRefund.Name = "tpRefund";
            this.tpRefund.Padding = new System.Drawing.Point(0, 0);
            this.tpRefund.SelectedIndex = 0;
            this.tpRefund.Size = new System.Drawing.Size(960, 638);
            this.tpRefund.TabIndex = 1;
            // 
            // tpRecap
            // 
            this.tpRecap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tpRecap.Controls.Add(this.lblDepenseConcerne);
            this.tpRecap.Controls.Add(this.lblTotalDepense);
            this.tpRecap.Controls.Add(this.dgvDepenseConcerme);
            this.tpRecap.Controls.Add(this.dgvMesDepenses);
            this.tpRecap.Controls.Add(this.btnBilanGlobal);
            this.tpRecap.Controls.Add(this.cboParticipant);
            this.tpRecap.Controls.Add(this.cboEvent);
            this.tpRecap.Controls.Add(this.label4);
            this.tpRecap.Controls.Add(this.label3);
            this.tpRecap.Controls.Add(this.label2);
            this.tpRecap.Controls.Add(this.label1);
            this.tpRecap.ForeColor = System.Drawing.Color.White;
            this.tpRecap.Location = new System.Drawing.Point(4, 33);
            this.tpRecap.Margin = new System.Windows.Forms.Padding(0);
            this.tpRecap.Name = "tpRecap";
            this.tpRecap.Size = new System.Drawing.Size(952, 601);
            this.tpRecap.TabIndex = 0;
            this.tpRecap.Text = "Recap";
            // 
            // lblDepenseConcerne
            // 
            this.lblDepenseConcerne.AutoSize = true;
            this.lblDepenseConcerne.ForeColor = System.Drawing.Color.White;
            this.lblDepenseConcerne.Location = new System.Drawing.Point(587, 367);
            this.lblDepenseConcerne.Name = "lblDepenseConcerne";
            this.lblDepenseConcerne.Size = new System.Drawing.Size(70, 24);
            this.lblDepenseConcerne.TabIndex = 4;
            this.lblDepenseConcerne.Text = "Total = ";
            // 
            // lblTotalDepense
            // 
            this.lblTotalDepense.AutoSize = true;
            this.lblTotalDepense.ForeColor = System.Drawing.Color.White;
            this.lblTotalDepense.Location = new System.Drawing.Point(587, 187);
            this.lblTotalDepense.Name = "lblTotalDepense";
            this.lblTotalDepense.Size = new System.Drawing.Size(70, 24);
            this.lblTotalDepense.TabIndex = 4;
            this.lblTotalDepense.Text = "Total = ";
            // 
            // dgvDepenseConcerme
            // 
            this.dgvDepenseConcerme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepenseConcerme.Location = new System.Drawing.Point(21, 367);
            this.dgvDepenseConcerme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDepenseConcerme.Name = "dgvDepenseConcerme";
            this.dgvDepenseConcerme.RowHeadersWidth = 51;
            this.dgvDepenseConcerme.RowTemplate.Height = 24;
            this.dgvDepenseConcerme.Size = new System.Drawing.Size(536, 109);
            this.dgvDepenseConcerme.TabIndex = 3;
            // 
            // dgvMesDepenses
            // 
            this.dgvMesDepenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesDepenses.Location = new System.Drawing.Point(24, 170);
            this.dgvMesDepenses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMesDepenses.Name = "dgvMesDepenses";
            this.dgvMesDepenses.RowHeadersWidth = 51;
            this.dgvMesDepenses.RowTemplate.Height = 24;
            this.dgvMesDepenses.Size = new System.Drawing.Size(535, 133);
            this.dgvMesDepenses.TabIndex = 3;
            // 
            // btnBilanGlobal
            // 
            this.btnBilanGlobal.ForeColor = System.Drawing.Color.Black;
            this.btnBilanGlobal.Location = new System.Drawing.Point(480, 30);
            this.btnBilanGlobal.Name = "btnBilanGlobal";
            this.btnBilanGlobal.Size = new System.Drawing.Size(104, 33);
            this.btnBilanGlobal.TabIndex = 2;
            this.btnBilanGlobal.Text = "Bilan global";
            this.btnBilanGlobal.UseVisualStyleBackColor = true;
            // 
            // cboParticipant
            // 
            this.cboParticipant.ForeColor = System.Drawing.Color.White;
            this.cboParticipant.FormattingEnabled = true;
            this.cboParticipant.Location = new System.Drawing.Point(201, 55);
            this.cboParticipant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboParticipant.Name = "cboParticipant";
            this.cboParticipant.Size = new System.Drawing.Size(249, 32);
            this.cboParticipant.TabIndex = 1;
            // 
            // cboEvent
            // 
            this.cboEvent.ForeColor = System.Drawing.Color.White;
            this.cboEvent.FormattingEnabled = true;
            this.cboEvent.Location = new System.Drawing.Point(201, 15);
            this.cboEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboEvent.Name = "cboEvent";
            this.cboEvent.Size = new System.Drawing.Size(249, 32);
            this.cboEvent.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ce que je dois rembourser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ce que j\'ai dépensé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quel participant ?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quel évènement ?";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPage2.Controls.Add(this.rtbRecap);
            this.tabPage2.Controls.Add(this.btnQuiDoitQuoiQui);
            this.tabPage2.Controls.Add(this.dgvLook);
            this.tabPage2.Controls.Add(this.dgvBilanEvent);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(952, 601);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bilan";
            // 
            // rtbRecap
            // 
            this.rtbRecap.Location = new System.Drawing.Point(251, 352);
            this.rtbRecap.Name = "rtbRecap";
            this.rtbRecap.Size = new System.Drawing.Size(586, 184);
            this.rtbRecap.TabIndex = 3;
            this.rtbRecap.Text = "";
            // 
            // btnQuiDoitQuoiQui
            // 
            this.btnQuiDoitQuoiQui.Location = new System.Drawing.Point(654, 281);
            this.btnQuiDoitQuoiQui.Name = "btnQuiDoitQuoiQui";
            this.btnQuiDoitQuoiQui.Size = new System.Drawing.Size(183, 40);
            this.btnQuiDoitQuoiQui.TabIndex = 2;
            this.btnQuiDoitQuoiQui.Text = "Qui doit quoi à qui";
            this.btnQuiDoitQuoiQui.UseVisualStyleBackColor = true;
            // 
            // dgvLook
            // 
            this.dgvLook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLook.Location = new System.Drawing.Point(49, 311);
            this.dgvLook.Name = "dgvLook";
            this.dgvLook.RowHeadersWidth = 51;
            this.dgvLook.RowTemplate.Height = 24;
            this.dgvLook.Size = new System.Drawing.Size(150, 200);
            this.dgvLook.TabIndex = 1;
            // 
            // dgvBilanEvent
            // 
            this.dgvBilanEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilanEvent.Location = new System.Drawing.Point(34, 33);
            this.dgvBilanEvent.Name = "dgvBilanEvent";
            this.dgvBilanEvent.RowHeadersWidth = 51;
            this.dgvBilanEvent.RowTemplate.Height = 24;
            this.dgvBilanEvent.Size = new System.Drawing.Size(900, 224);
            this.dgvBilanEvent.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(952, 601);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "PDF Generate";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // formBilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(978, 656);
            this.Controls.Add(this.tpRefund);
            this.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formBilan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "formBilan";
            this.tpRefund.ResumeLayout(false);
            this.tpRecap.ResumeLayout(false);
            this.tpRecap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepenseConcerme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesDepenses)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLook)).EndInit();
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
        private System.Windows.Forms.Button btnBilanGlobal;
        private System.Windows.Forms.ComboBox cboParticipant;
        private System.Windows.Forms.ComboBox cboEvent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtbRecap;
        private System.Windows.Forms.Button btnQuiDoitQuoiQui;
        private System.Windows.Forms.DataGridView dgvLook;
        private System.Windows.Forms.DataGridView dgvBilanEvent;
        private System.Windows.Forms.TabPage tabPage1;
    }
}