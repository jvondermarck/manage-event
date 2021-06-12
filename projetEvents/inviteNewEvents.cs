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

namespace projetEvents
{
    public partial class inviteNewEvents : Form
    {
        /*
         * Réalisé par Jad MACHKOUR
         * 
        */

        // Déclaration de la chaine de connexion
        private string chainconnec = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\Debug\bdd\bdEvents.mdb";

        // Déclaration de la connexion active
        OleDbConnection connec = new OleDbConnection();

        public inviteNewEvents()
        {
            InitializeComponent();
        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            formMain form = (formMain)ActiveForm;
            form.panelAllForm.Controls.Clear();
            formEvenements formEvenements = new formEvenements() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formEvenements.FormBorderStyle = FormBorderStyle.None;
            form.panelAllForm.Controls.Add(formEvenements);
            formEvenements.tabControl1.SelectedIndex = 1; // On re-dirige la personne sur la tabPage numéro 2
            formEvenements.Show();
            form.lblNomForm.Text = "Créer de nouveaux évènements !";
            form.lblPresentationForm.Text = "";
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            formMain form = (formMain)ActiveForm;
            form.panelAllForm.Controls.Clear();
            formEvenements formEvenements = new formEvenements() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formEvenements.FormBorderStyle = FormBorderStyle.None;
            form.panelAllForm.Controls.Add(formEvenements);
            formEvenements.tabControl1.SelectedIndex = 1; // On re-dirige la personne sur la tabPage numéro 2
            formEvenements.Show();
            form.lblNomForm.Text = "Créer de nouveaux évènements !";
            form.lblPresentationForm.Text = "";
        }
    }
}
