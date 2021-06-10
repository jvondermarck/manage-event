using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.InteropServices;

namespace projetEvents
{
    public partial class formEvenements : Form
    {

        public formEvenements()
        {
            InitializeComponent();
            //ds = formMain.transfertDataSet;
        }

        private void formEvenements_Load(object sender, EventArgs e)
        {
            //dtpDateDebut.DefaultMonthBackColor = Color.FromArgb(37, 42, 64);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            formMain form = (formMain)ActiveForm;
            form.panelAllForm.Controls.Clear();
            inviteNewEvents inviteNewEvents = new inviteNewEvents() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            inviteNewEvents.FormBorderStyle = FormBorderStyle.None;
            form.panelAllForm.Controls.Add(inviteNewEvents);
            inviteNewEvents.Show();
            form.lblNomForm.Text = "Inviter des participants à l'évènement";
            form.lblPresentationForm.Text = "";
        }
    }
}
