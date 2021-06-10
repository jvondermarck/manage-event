
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBilan));
            this.tpRefund = new System.Windows.Forms.TabControl();
            this.tpRecap = new System.Windows.Forms.TabPage();
            this.pnlRecapPart = new System.Windows.Forms.Panel();
            this.dgvDepenseConcerme = new System.Windows.Forms.DataGridView();
            this.dgvMesDepenses = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPDF = new System.Windows.Forms.Label();
            this.lblTotalDepense = new System.Windows.Forms.Label();
            this.lblDepenseConcerne = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboParticipant = new System.Windows.Forms.ComboBox();
            this.lblPart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEvent = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblSolderEvent = new System.Windows.Forms.Label();
            this.lblMessageBilan = new System.Windows.Forms.Label();
            this.rtbRecap = new System.Windows.Forms.RichTextBox();
            this.dgvBilanEvent = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pcbGenerate = new System.Windows.Forms.PictureBox();
            this.btnQuiDoitQuoiQui = new System.Windows.Forms.Button();
            this.tpRefund.SuspendLayout();
            this.tpRecap.SuspendLayout();
            this.pnlRecapPart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepenseConcerme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesDepenses)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilanEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGenerate)).BeginInit();
            this.SuspendLayout();
            // 
            // tpRefund
            // 
            this.tpRefund.CausesValidation = false;
            this.tpRefund.Controls.Add(this.tpRecap);
            this.tpRefund.Controls.Add(this.tabPage2);
            this.tpRefund.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpRefund.Location = new System.Drawing.Point(-10, -3);
            this.tpRefund.Margin = new System.Windows.Forms.Padding(0);
            this.tpRefund.Multiline = true;
            this.tpRefund.Name = "tpRefund";
            this.tpRefund.Padding = new System.Drawing.Point(0, 0);
            this.tpRefund.SelectedIndex = 0;
            this.tpRefund.Size = new System.Drawing.Size(1033, 677);
            this.tpRefund.TabIndex = 1;
            // 
            // tpRecap
            // 
            this.tpRecap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tpRecap.Controls.Add(this.pnlRecapPart);
            this.tpRecap.Controls.Add(this.cboParticipant);
            this.tpRecap.Controls.Add(this.lblPart);
            this.tpRecap.Controls.Add(this.label1);
            this.tpRecap.Controls.Add(this.cboEvent);
            this.tpRecap.ForeColor = System.Drawing.Color.White;
            this.tpRecap.Location = new System.Drawing.Point(4, 36);
            this.tpRecap.Margin = new System.Windows.Forms.Padding(0);
            this.tpRecap.Name = "tpRecap";
            this.tpRecap.Size = new System.Drawing.Size(1025, 637);
            this.tpRecap.TabIndex = 0;
            this.tpRecap.Text = "   Recap     ";
            this.tpRecap.Click += new System.EventHandler(this.tpRecap_Click);
            // 
            // pnlRecapPart
            // 
            this.pnlRecapPart.Controls.Add(this.dgvDepenseConcerme);
            this.pnlRecapPart.Controls.Add(this.dgvMesDepenses);
            this.pnlRecapPart.Controls.Add(this.label3);
            this.pnlRecapPart.Controls.Add(this.pcbGenerate);
            this.pnlRecapPart.Controls.Add(this.lblPDF);
            this.pnlRecapPart.Controls.Add(this.lblTotalDepense);
            this.pnlRecapPart.Controls.Add(this.lblDepenseConcerne);
            this.pnlRecapPart.Controls.Add(this.label4);
            this.pnlRecapPart.Location = new System.Drawing.Point(23, 93);
            this.pnlRecapPart.Name = "pnlRecapPart";
            this.pnlRecapPart.Size = new System.Drawing.Size(952, 515);
            this.pnlRecapPart.TabIndex = 6;
            this.pnlRecapPart.Visible = false;
            // 
            // dgvDepenseConcerme
            // 
            this.dgvDepenseConcerme.AllowUserToAddRows = false;
            this.dgvDepenseConcerme.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDepenseConcerme.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvDepenseConcerme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepenseConcerme.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDepenseConcerme.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgvDepenseConcerme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepenseConcerme.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDepenseConcerme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepenseConcerme.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvDepenseConcerme.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDepenseConcerme.EnableHeadersVisualStyles = false;
            this.dgvDepenseConcerme.GridColor = System.Drawing.Color.White;
            this.dgvDepenseConcerme.Location = new System.Drawing.Point(17, 280);
            this.dgvDepenseConcerme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDepenseConcerme.Name = "dgvDepenseConcerme";
            this.dgvDepenseConcerme.ReadOnly = true;
            this.dgvDepenseConcerme.RowHeadersVisible = false;
            this.dgvDepenseConcerme.RowHeadersWidth = 51;
            this.dgvDepenseConcerme.RowTemplate.Height = 24;
            this.dgvDepenseConcerme.Size = new System.Drawing.Size(673, 209);
            this.dgvDepenseConcerme.TabIndex = 55;
            // 
            // dgvMesDepenses
            // 
            this.dgvMesDepenses.AllowUserToAddRows = false;
            this.dgvMesDepenses.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMesDepenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvMesDepenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMesDepenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMesDepenses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgvMesDepenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMesDepenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvMesDepenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMesDepenses.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvMesDepenses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMesDepenses.EnableHeadersVisualStyles = false;
            this.dgvMesDepenses.GridColor = System.Drawing.Color.White;
            this.dgvMesDepenses.Location = new System.Drawing.Point(17, 76);
            this.dgvMesDepenses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMesDepenses.Name = "dgvMesDepenses";
            this.dgvMesDepenses.ReadOnly = true;
            this.dgvMesDepenses.RowHeadersVisible = false;
            this.dgvMesDepenses.RowHeadersWidth = 51;
            this.dgvMesDepenses.RowTemplate.Height = 24;
            this.dgvMesDepenses.Size = new System.Drawing.Size(673, 156);
            this.dgvMesDepenses.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "- Ce que j\'ai dépensé";
            // 
            // lblPDF
            // 
            this.lblPDF.AutoSize = true;
            this.lblPDF.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDF.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPDF.Location = new System.Drawing.Point(727, 194);
            this.lblPDF.Name = "lblPDF";
            this.lblPDF.Size = new System.Drawing.Size(272, 33);
            this.lblPDF.TabIndex = 0;
            this.lblPDF.Text = "Générer votre bilan !";
            // 
            // lblTotalDepense
            // 
            this.lblTotalDepense.AutoSize = true;
            this.lblTotalDepense.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDepense.ForeColor = System.Drawing.Color.White;
            this.lblTotalDepense.Location = new System.Drawing.Point(373, 24);
            this.lblTotalDepense.Name = "lblTotalDepense";
            this.lblTotalDepense.Size = new System.Drawing.Size(82, 27);
            this.lblTotalDepense.TabIndex = 4;
            this.lblTotalDepense.Text = "Total = ";
            // 
            // lblDepenseConcerne
            // 
            this.lblDepenseConcerne.AutoSize = true;
            this.lblDepenseConcerne.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepenseConcerne.ForeColor = System.Drawing.Color.White;
            this.lblDepenseConcerne.Location = new System.Drawing.Point(373, 238);
            this.lblDepenseConcerne.Name = "lblDepenseConcerne";
            this.lblDepenseConcerne.Size = new System.Drawing.Size(82, 27);
            this.lblDepenseConcerne.TabIndex = 4;
            this.lblDepenseConcerne.Text = "Total = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "- Ce que je dois rembourser";
            // 
            // cboParticipant
            // 
            this.cboParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cboParticipant.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.lblPart.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPart.ForeColor = System.Drawing.Color.White;
            this.lblPart.Location = new System.Drawing.Point(491, 30);
            this.lblPart.Name = "lblPart";
            this.lblPart.Size = new System.Drawing.Size(229, 30);
            this.lblPart.TabIndex = 0;
            this.lblPart.Text = "Quel participant ?";
            this.lblPart.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quel évènement ?";
            // 
            // cboEvent
            // 
            this.cboEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cboEvent.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPage2.Controls.Add(this.btnQuiDoitQuoiQui);
            this.tabPage2.Controls.Add(this.lblSolderEvent);
            this.tabPage2.Controls.Add(this.lblMessageBilan);
            this.tabPage2.Controls.Add(this.rtbRecap);
            this.tabPage2.Controls.Add(this.dgvBilanEvent);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1025, 637);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "     Bilan     ";
            // 
            // lblSolderEvent
            // 
            this.lblSolderEvent.AutoSize = true;
            this.lblSolderEvent.Font = new System.Drawing.Font("Montserrat", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolderEvent.Location = new System.Drawing.Point(290, 266);
            this.lblSolderEvent.Name = "lblSolderEvent";
            this.lblSolderEvent.Size = new System.Drawing.Size(423, 52);
            this.lblSolderEvent.TabIndex = 5;
            this.lblSolderEvent.Text = "Solder l\'évènement ?";
            this.lblSolderEvent.Visible = false;
            // 
            // lblMessageBilan
            // 
            this.lblMessageBilan.AutoSize = true;
            this.lblMessageBilan.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageBilan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.lblMessageBilan.Location = new System.Drawing.Point(175, 108);
            this.lblMessageBilan.Name = "lblMessageBilan";
            this.lblMessageBilan.Size = new System.Drawing.Size(0, 46);
            this.lblMessageBilan.TabIndex = 4;
            this.lblMessageBilan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMessageBilan.Visible = false;
            // 
            // rtbRecap
            // 
            this.rtbRecap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.rtbRecap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbRecap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbRecap.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbRecap.ForeColor = System.Drawing.Color.White;
            this.rtbRecap.Location = new System.Drawing.Point(137, 280);
            this.rtbRecap.Name = "rtbRecap";
            this.rtbRecap.ReadOnly = true;
            this.rtbRecap.Size = new System.Drawing.Size(698, 273);
            this.rtbRecap.TabIndex = 3;
            this.rtbRecap.Text = "";
            this.rtbRecap.Visible = false;
            // 
            // dgvBilanEvent
            // 
            this.dgvBilanEvent.AllowUserToAddRows = false;
            this.dgvBilanEvent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBilanEvent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvBilanEvent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBilanEvent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBilanEvent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgvBilanEvent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBilanEvent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvBilanEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBilanEvent.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvBilanEvent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBilanEvent.EnableHeadersVisualStyles = false;
            this.dgvBilanEvent.GridColor = System.Drawing.Color.White;
            this.dgvBilanEvent.Location = new System.Drawing.Point(35, 26);
            this.dgvBilanEvent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBilanEvent.Name = "dgvBilanEvent";
            this.dgvBilanEvent.ReadOnly = true;
            this.dgvBilanEvent.RowHeadersVisible = false;
            this.dgvBilanEvent.RowHeadersWidth = 51;
            this.dgvBilanEvent.RowTemplate.Height = 24;
            this.dgvBilanEvent.Size = new System.Drawing.Size(921, 235);
            this.dgvBilanEvent.TabIndex = 53;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Location = new System.Drawing.Point(177, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 51);
            this.panel1.TabIndex = 5;
            // 
            // pcbGenerate
            // 
            this.pcbGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbGenerate.Image = global::projetEvents.Properties.Resources.generatepng;
            this.pcbGenerate.Location = new System.Drawing.Point(772, 235);
            this.pcbGenerate.Name = "pcbGenerate";
            this.pcbGenerate.Size = new System.Drawing.Size(131, 130);
            this.pcbGenerate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGenerate.TabIndex = 5;
            this.pcbGenerate.TabStop = false;
            this.pcbGenerate.Click += new System.EventHandler(this.btnGeneratePDF_Click);
            this.pcbGenerate.MouseEnter += new System.EventHandler(this.pcbGenerate_MouseEnter);
            this.pcbGenerate.MouseLeave += new System.EventHandler(this.pcbGenerate_MouseLeave);
            // 
            // btnQuiDoitQuoiQui
            // 
            this.btnQuiDoitQuoiQui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnQuiDoitQuoiQui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuiDoitQuoiQui.FlatAppearance.BorderSize = 0;
            this.btnQuiDoitQuoiQui.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnQuiDoitQuoiQui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuiDoitQuoiQui.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiDoitQuoiQui.ForeColor = System.Drawing.Color.Black;
            this.btnQuiDoitQuoiQui.Image = ((System.Drawing.Image)(resources.GetObject("btnQuiDoitQuoiQui.Image")));
            this.btnQuiDoitQuoiQui.Location = new System.Drawing.Point(261, 332);
            this.btnQuiDoitQuoiQui.Name = "btnQuiDoitQuoiQui";
            this.btnQuiDoitQuoiQui.Size = new System.Drawing.Size(397, 97);
            this.btnQuiDoitQuoiQui.TabIndex = 2;
            this.btnQuiDoitQuoiQui.Text = "Qui Doit Quoi à Qui";
            this.btnQuiDoitQuoiQui.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuiDoitQuoiQui.UseVisualStyleBackColor = false;
            this.btnQuiDoitQuoiQui.Visible = false;
            this.btnQuiDoitQuoiQui.Click += new System.EventHandler(this.btnQuiDoitQuoiQui_Click);
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
            this.pnlRecapPart.ResumeLayout(false);
            this.pnlRecapPart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepenseConcerme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesDepenses)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilanEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGenerate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tpRefund;
        private System.Windows.Forms.TabPage tpRecap;
        private System.Windows.Forms.Label lblDepenseConcerne;
        private System.Windows.Forms.Label lblTotalDepense;
        private System.Windows.Forms.ComboBox cboParticipant;
        private System.Windows.Forms.ComboBox cboEvent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtbRecap;
        private System.Windows.Forms.Button btnQuiDoitQuoiQui;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMessageBilan;
        private System.Windows.Forms.PictureBox pcbGenerate;
        private System.Windows.Forms.Label lblPDF;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblSolderEvent;
        private System.Windows.Forms.Panel pnlRecapPart;
        private System.Windows.Forms.DataGridView dgvDepenseConcerme;
        private System.Windows.Forms.DataGridView dgvMesDepenses;
        private System.Windows.Forms.DataGridView dgvBilanEvent;
    }
}