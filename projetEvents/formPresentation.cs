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
    public partial class formPresentation : Form
    {
        /*
         * Réalisé par Julien VON DER MARCK
         * 
        */

        public formPresentation()
        {
            InitializeComponent();

        }


        // Déclaration de la chaine de connexion
        private static string chainconnec = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\Debug\bdd\bdEvents.mdb";

        // Création d'un DataSet
        DataSet ds = formMain.transfertDataSet;

        // Déclaration de la connexion active
        OleDbConnection connec = new OleDbConnection(chainconnec);

        private void formPresentation_Load(object sender, EventArgs e)
        {
            string eventEnrengistre = chercheDonnee("Evenements");
            string partEnrengistre = chercheDonnee("Participants");
            string depEnrengistre = chercheDonnee("Depenses");

            lblEvenemts.Text = eventEnrengistre;
            lblParticipant.Text = partEnrengistre; 
            lblDepenses.Text = depEnrengistre;
        }

        private string chercheDonnee(String table)
        {
            string nb = "";
            try
            {
                connec.Open();
                string requete = "SELECT COUNT(*) FROM " + table;
                OleDbCommand cmd = new OleDbCommand(requete, connec);
                nb = cmd.ExecuteScalar().ToString();
            }
            catch (OleDbException) { MessageBox.Show("Erreur dans la requete SQL"); }
            catch (InvalidOperationException) { MessageBox.Show("Erreur d'acces à la base de donnée"); }
            finally { connec.Close(); }
            return nb;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formMain form = (formMain)ActiveForm;
            form.panelAllForm.Controls.Clear();
            FormAjoutDepense formAjoutDepense = new FormAjoutDepense() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formAjoutDepense.FormBorderStyle = FormBorderStyle.None;
            form.panelAllForm.Controls.Add(formAjoutDepense);
            formAjoutDepense.Show();
            form.lblNomForm.Text = "Ajouter une nouvelle dépense !";
            form.lblPresentationForm.Text = "";
        }

        private void pcbAddDepense_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show("Cliquez sur l'image", pcbAddDepense);
        }

        private void pcbAddDepense_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Hide(pcbAddDepense);
        }
    }
}
