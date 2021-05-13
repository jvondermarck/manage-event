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
    public partial class formEvenements : Form
    {
        private DataSet ds;

        public formEvenements()
        {
            InitializeComponent();
            //ds = formMain.transfertDataSet;
        }

        public formEvenements(Point formLocation)
        {
            InitializeComponent();
            this.DesktopLocation = formLocation;
            //this.StartPosition = FormStartPosition.CenterParent;
        }

        private void formEvenements_Load(object sender, EventArgs e)
        {
            // On charge le UserControl
            userControlEvenementClick();
            //formMain.userControlBarreActuelle(this, 2);  // Comme on est sur le formAccueil, l'index btn du menu Accueil = 2
        }

        //
        // Gestion du Menu
        //


        private void btnAccueil_Click(object sender, EventArgs e)
        {
            
            formMain formMain = new formMain(this.DesktopLocation);
            formMain.Show();
            this.Visible = false;
            this.Hide();
        }

        private void btnEvenements_Click(object sender, EventArgs e)
        {
        }

        private void btnParticipant_Click(object sender, EventArgs e)
        {
            formParticipant formParticipant = new formParticipant();
            formParticipant.ShowDialog();
            this.Close();
        }

        private void btnDepenses_Click(object sender, EventArgs e)
        {
            formDepense formDepense = new formDepense();
            formDepense.ShowDialog();
            this.Close();
        }
        private void btnBilan_Click(object sender, EventArgs e)
        {
            formBilan formBilan = new formBilan();
            formBilan.ShowDialog();
            this.Hide();
        }

        // On va récuperer le UserControlMenu qui se trouve sur la page, pour lui indiquer d'implementer les deleguates.
        public void userControlEvenementClick()
        {
            foreach (Control a in this.Controls)
            {
                if (a is uControlMenu.userControlMenu)
                {
                    uControlMenu.userControlMenu a1 = (uControlMenu.userControlMenu)a; // On reprend l'élement checkBox 
                    a1.accueil = btnAccueil_Click;
                    a1.evenements = btnEvenements_Click;
                    a1.participant = btnParticipant_Click;
                    a1.depenses = btnDepenses_Click;
                }
            }
        }
    }
}
