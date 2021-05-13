using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uControlMenu
{
    // Déclaration de la signature du Deleguates pour les méthodes de Click (changementd de form)
    public delegate void btnAccueil(object sender, EventArgs e);
    public delegate void btnEvenements(object sender, EventArgs e);
    public delegate void btnParticipant(object sender, EventArgs e);
    public delegate void btnDepenses(object sender, EventArgs e);
    public delegate void btnBilan(object sender, EventArgs e);

    public partial class userControlMenu: UserControl
    {
        // Déclaration d'une instance du délégué
        public btnAccueil accueil;
        public btnEvenements evenements;
        public btnParticipant participant;
        public btnDepenses depenses;
        public btnBilan bilan;

        public int numPanel; // Numéro du btn qu'on doit inscrire dans la fenetre de propriete - GET/SET

        public userControlMenu()
        {
            InitializeComponent();
        }

        // En fonction du numéro de btn, on met une petite barre a gauche du btn pour situer où on est
        private void userControlMenu_Load(object sender, EventArgs e)
        {
            if (numPanel == 1)
            {
                sidePanel.Height = btnAccueil.Height;
                sidePanel.Top = btnAccueil.Top;
                btnAccueil.BackColor = Color.FromArgb(46, 51, 73);
            }
            if (numPanel == 2)
            {
                sidePanel.Height = btnEvenements.Height;
                sidePanel.Top = btnEvenements.Top;
                btnEvenements.BackColor = Color.FromArgb(46, 51, 73);
            }
            if (numPanel == 3)
            {
                sidePanel.Height = btnParticipant.Height;
                sidePanel.Top = btnParticipant.Top;
                btnParticipant.BackColor = Color.FromArgb(46, 51, 73);
            }
            if (numPanel == 4)
            {
                sidePanel.Height = btnDepense.Height;
                sidePanel.Top = btnDepense.Top;
                btnDepense.BackColor = Color.FromArgb(46, 51, 73);
            }
            if (numPanel == 5)
            {
                sidePanel.Height = btnBilan.Height;
                sidePanel.Top = btnBilan.Top;
                btnBilan.BackColor = Color.FromArgb(46, 51, 73);
            }
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            if (this.accueil != null) // = a1.accueil = btnAccueil_Click;
            {
                this.accueil(sender, e); // = private void btnAccueil_Click(object sender, EventArgs e)
            }
            sidePanel.Height = btnAccueil.Height;
            sidePanel.Top = btnAccueil.Top;
            btnAccueil.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnEvenements_Click(object sender, EventArgs e)
        {
            if (this.evenements != null) 
            {
                this.evenements(sender, e); 
            }
            sidePanel.Height = btnEvenements.Height;
            sidePanel.Top = btnEvenements.Top;
            btnEvenements.BackColor = Color.FromArgb(46,51,73);
        }

        private void btnParticipant_Click(object sender, EventArgs e)
        {
            if (this.participant != null) 
            {
                this.participant(sender, e); 
            }
            sidePanel.Height = btnParticipant.Height;
            sidePanel.Top = btnParticipant.Top;
            btnParticipant.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnDepense_Click(object sender, EventArgs e)
        {
            if (this.depenses != null) 
            {
                this.depenses(sender, e); 
            }
            sidePanel.Height = btnDepense.Height;
            sidePanel.Top = btnDepense.Top;
            btnDepense.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnBilan_Click(object sender, EventArgs e)
        {
            if (this.bilan != null)
            {
                this.bilan(sender, e);
            }
            sidePanel.Height = btnBilan.Height;
            sidePanel.Top = btnBilan.Top;
            btnBilan.BackColor = Color.FromArgb(46, 51, 73);
        }

        // Parametrage via la fenetre du User Control
        [Description("Le tag a mettre pour la barre")]
        public int BarrePanel
        {
            get
            {
                return numPanel;
            }
            set
            {
                this.numPanel = value;
            }
        }

        
        private void sidePanel_Paint(object sender, EventArgs e)
        {

        }

        private void btnAccueil_Leave(object sender, EventArgs e)
        {
            btnAccueil.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnEvenements_Leave(object sender, EventArgs e)
        {
            btnEvenements.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnParticipant_Leave(object sender, EventArgs e)
        {
            btnParticipant.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnDepense_Leave(object sender, EventArgs e)
        {
            btnParticipant.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnBilan_Leave(object sender, EventArgs e)
        {
            btnBilan.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
