
namespace projetEvents
{
    partial class formEvenements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEvenements));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPageFin = new System.Windows.Forms.Button();
            this.btnPageSuivante = new System.Windows.Forms.Button();
            this.btnPagePrecedente = new System.Windows.Forms.Button();
            this.btnPageDebut = new System.Windows.Forms.Button();
            this.bn = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbDescPage1 = new System.Windows.Forms.RichTextBox();
            this.lblNumEnregistrement = new System.Windows.Forms.Label();
            this.lblSolde = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblIntitule = new System.Windows.Forms.Label();
            this.lblCreateur = new System.Windows.Forms.Label();
            this.lblNumEvenement = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxSolde = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.btnLancerInvit = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.cbCreateur = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rtbDescPage2 = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTitreEvenement = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).BeginInit();
            this.bn.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-40, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1085, 693);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPage1.Controls.Add(this.btnPageFin);
            this.tabPage1.Controls.Add(this.btnPageSuivante);
            this.tabPage1.Controls.Add(this.btnPagePrecedente);
            this.tabPage1.Controls.Add(this.btnPageDebut);
            this.tabPage1.Controls.Add(this.bn);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.rtbDescPage1);
            this.tabPage1.Controls.Add(this.lblNumEnregistrement);
            this.tabPage1.Controls.Add(this.lblSolde);
            this.tabPage1.Controls.Add(this.lblDateFin);
            this.tabPage1.Controls.Add(this.lblDateDebut);
            this.tabPage1.Controls.Add(this.lblDescription);
            this.tabPage1.Controls.Add(this.lblIntitule);
            this.tabPage1.Controls.Add(this.lblCreateur);
            this.tabPage1.Controls.Add(this.lblNumEvenement);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1077, 657);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "          Parcours 1 à 1";
            // 
            // btnPageFin
            // 
            this.btnPageFin.Location = new System.Drawing.Point(652, 545);
            this.btnPageFin.Name = "btnPageFin";
            this.btnPageFin.Size = new System.Drawing.Size(75, 37);
            this.btnPageFin.TabIndex = 24;
            this.btnPageFin.Text = ">>";
            this.btnPageFin.UseVisualStyleBackColor = true;
            // 
            // btnPageSuivante
            // 
            this.btnPageSuivante.Location = new System.Drawing.Point(542, 545);
            this.btnPageSuivante.Name = "btnPageSuivante";
            this.btnPageSuivante.Size = new System.Drawing.Size(75, 36);
            this.btnPageSuivante.TabIndex = 23;
            this.btnPageSuivante.Text = ">";
            this.btnPageSuivante.UseVisualStyleBackColor = true;
            // 
            // btnPagePrecedente
            // 
            this.btnPagePrecedente.Location = new System.Drawing.Point(438, 545);
            this.btnPagePrecedente.Name = "btnPagePrecedente";
            this.btnPagePrecedente.Size = new System.Drawing.Size(75, 36);
            this.btnPagePrecedente.TabIndex = 22;
            this.btnPagePrecedente.Text = "<";
            this.btnPagePrecedente.UseVisualStyleBackColor = true;
            // 
            // btnPageDebut
            // 
            this.btnPageDebut.Location = new System.Drawing.Point(328, 545);
            this.btnPageDebut.Name = "btnPageDebut";
            this.btnPageDebut.Size = new System.Drawing.Size(75, 36);
            this.btnPageDebut.TabIndex = 21;
            this.btnPageDebut.Text = "<<";
            this.btnPageDebut.UseVisualStyleBackColor = true;
            // 
            // bn
            // 
            this.bn.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bn.CountItem = this.bindingNavigatorCountItem;
            this.bn.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bn.Location = new System.Drawing.Point(3, 627);
            this.bn.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn.Name = "bn";
            this.bn.PositionItem = this.bindingNavigatorPositionItem;
            this.bn.Size = new System.Drawing.Size(1071, 27);
            this.bn.TabIndex = 14;
            this.bn.Text = " ";
            this.bn.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(250, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "L\'évènement est soldé :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(446, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "au";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(250, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Du :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(250, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Intitulé :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(250, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Créé par :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(250, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Evènement n° : ";
            // 
            // rtbDescPage1
            // 
            this.rtbDescPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.rtbDescPage1.Enabled = false;
            this.rtbDescPage1.ForeColor = System.Drawing.Color.White;
            this.rtbDescPage1.Location = new System.Drawing.Point(412, 211);
            this.rtbDescPage1.Name = "rtbDescPage1";
            this.rtbDescPage1.Size = new System.Drawing.Size(339, 112);
            this.rtbDescPage1.TabIndex = 13;
            this.rtbDescPage1.Text = "";
            // 
            // lblNumEnregistrement
            // 
            this.lblNumEnregistrement.AutoSize = true;
            this.lblNumEnregistrement.ForeColor = System.Drawing.Color.White;
            this.lblNumEnregistrement.Location = new System.Drawing.Point(447, 492);
            this.lblNumEnregistrement.Name = "lblNumEnregistrement";
            this.lblNumEnregistrement.Size = new System.Drawing.Size(170, 23);
            this.lblNumEnregistrement.TabIndex = 8;
            this.lblNumEnregistrement.Text = "Enregistrement : ";
            // 
            // lblSolde
            // 
            this.lblSolde.AutoSize = true;
            this.lblSolde.ForeColor = System.Drawing.Color.White;
            this.lblSolde.Location = new System.Drawing.Point(498, 405);
            this.lblSolde.Name = "lblSolde";
            this.lblSolde.Size = new System.Drawing.Size(137, 23);
            this.lblSolde.TabIndex = 6;
            this.lblSolde.Text = "Soldé(O/N) : ";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.ForeColor = System.Drawing.Color.White;
            this.lblDateFin.Location = new System.Drawing.Point(528, 346);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(53, 23);
            this.lblDateFin.TabIndex = 5;
            this.lblDateFin.Text = "au : ";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.ForeColor = System.Drawing.Color.White;
            this.lblDateDebut.Location = new System.Drawing.Point(339, 346);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(54, 23);
            this.lblDateDebut.TabIndex = 4;
            this.lblDateDebut.Text = "Du : ";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(250, 214);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(134, 23);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description : ";
            // 
            // lblIntitule
            // 
            this.lblIntitule.AutoSize = true;
            this.lblIntitule.ForeColor = System.Drawing.Color.White;
            this.lblIntitule.Location = new System.Drawing.Point(422, 153);
            this.lblIntitule.Name = "lblIntitule";
            this.lblIntitule.Size = new System.Drawing.Size(91, 23);
            this.lblIntitule.TabIndex = 2;
            this.lblIntitule.Text = "Intitulé : ";
            // 
            // lblCreateur
            // 
            this.lblCreateur.AutoSize = true;
            this.lblCreateur.ForeColor = System.Drawing.Color.White;
            this.lblCreateur.Location = new System.Drawing.Point(422, 97);
            this.lblCreateur.Name = "lblCreateur";
            this.lblCreateur.Size = new System.Drawing.Size(115, 23);
            this.lblCreateur.TabIndex = 1;
            this.lblCreateur.Text = "Créé par : ";
            // 
            // lblNumEvenement
            // 
            this.lblNumEvenement.AutoSize = true;
            this.lblNumEvenement.ForeColor = System.Drawing.Color.White;
            this.lblNumEvenement.Location = new System.Drawing.Point(422, 45);
            this.lblNumEvenement.Name = "lblNumEvenement";
            this.lblNumEvenement.Size = new System.Drawing.Size(166, 23);
            this.lblNumEvenement.TabIndex = 0;
            this.lblNumEvenement.Text = "Evènement n° : ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.checkBoxSolde);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dtpDateFin);
            this.tabPage2.Controls.Add(this.dtpDateDebut);
            this.tabPage2.Controls.Add(this.btnLancerInvit);
            this.tabPage2.Controls.Add(this.btnEnregistrer);
            this.tabPage2.Controls.Add(this.cbCreateur);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.rtbDescPage2);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tbTitreEvenement);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1077, 657);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nouvel évènement";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(734, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxSolde
            // 
            this.checkBoxSolde.AutoSize = true;
            this.checkBoxSolde.Location = new System.Drawing.Point(316, 378);
            this.checkBoxSolde.Name = "checkBoxSolde";
            this.checkBoxSolde.Size = new System.Drawing.Size(18, 17);
            this.checkBoxSolde.TabIndex = 13;
            this.checkBoxSolde.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(221, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Soldé ?";
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Location = new System.Drawing.Point(316, 143);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(294, 32);
            this.dtpDateFin.TabIndex = 11;
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Location = new System.Drawing.Point(316, 95);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(294, 32);
            this.dtpDateDebut.TabIndex = 10;
            // 
            // btnLancerInvit
            // 
            this.btnLancerInvit.Location = new System.Drawing.Point(316, 521);
            this.btnLancerInvit.Name = "btnLancerInvit";
            this.btnLancerInvit.Size = new System.Drawing.Size(239, 38);
            this.btnLancerInvit.TabIndex = 9;
            this.btnLancerInvit.Text = "Lancer les invitations";
            this.btnLancerInvit.UseVisualStyleBackColor = true;
            this.btnLancerInvit.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.Transparent;
            this.btnEnregistrer.Location = new System.Drawing.Point(575, 521);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(186, 38);
            this.btnEnregistrer.TabIndex = 8;
            this.btnEnregistrer.Text = "Enrengistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            // 
            // cbCreateur
            // 
            this.cbCreateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.cbCreateur.ForeColor = System.Drawing.Color.White;
            this.cbCreateur.FormattingEnabled = true;
            this.cbCreateur.Location = new System.Drawing.Point(316, 428);
            this.cbCreateur.Name = "cbCreateur";
            this.cbCreateur.Size = new System.Drawing.Size(294, 31);
            this.cbCreateur.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(205, 428);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 27);
            this.label13.TabIndex = 6;
            this.label13.Text = "Créé par :";
            // 
            // rtbDescPage2
            // 
            this.rtbDescPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.rtbDescPage2.ForeColor = System.Drawing.Color.White;
            this.rtbDescPage2.Location = new System.Drawing.Point(316, 215);
            this.rtbDescPage2.Name = "rtbDescPage2";
            this.rtbDescPage2.Size = new System.Drawing.Size(472, 135);
            this.rtbDescPage2.TabIndex = 5;
            this.rtbDescPage2.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(183, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 27);
            this.label12.TabIndex = 4;
            this.label12.Text = "Description :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(202, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 27);
            this.label11.TabIndex = 3;
            this.label11.Text = "Date fin :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(180, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 27);
            this.label10.TabIndex = 2;
            this.label10.Text = "Date début :";
            // 
            // tbTitreEvenement
            // 
            this.tbTitreEvenement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.tbTitreEvenement.ForeColor = System.Drawing.Color.White;
            this.tbTitreEvenement.Location = new System.Drawing.Point(316, 43);
            this.tbTitreEvenement.Name = "tbTitreEvenement";
            this.tbTitreEvenement.Size = new System.Drawing.Size(294, 32);
            this.tbTitreEvenement.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(109, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 27);
            this.label9.TabIndex = 0;
            this.label9.Text = "Titre de l\'évènement :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Location = new System.Drawing.Point(280, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 51);
            this.panel1.TabIndex = 14;
            // 
            // formEvenements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(985, 665);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formEvenements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "formEvenements";
            this.Load += new System.EventHandler(this.formEvenements_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).EndInit();
            this.bn.ResumeLayout(false);
            this.bn.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnPageFin;
        private System.Windows.Forms.Button btnPageSuivante;
        private System.Windows.Forms.Button btnPagePrecedente;
        private System.Windows.Forms.Button btnPageDebut;
        private System.Windows.Forms.BindingNavigator bn;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbDescPage1;
        private System.Windows.Forms.Label lblNumEnregistrement;
        private System.Windows.Forms.Label lblSolde;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblIntitule;
        private System.Windows.Forms.Label lblCreateur;
        private System.Windows.Forms.Label lblNumEvenement;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBoxSolde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Button btnLancerInvit;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.ComboBox cbCreateur;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox rtbDescPage2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTitreEvenement;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}