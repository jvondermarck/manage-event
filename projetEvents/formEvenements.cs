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
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        // gdi32.dll contient des fonctions pour Windows GDI (Interface de périphérique graphique)
        // qui aide les fenêtres en créant les objets à deux dimensions simples.

        //La fonction CreateRoundRectRgn crée une région rectangulaire avec des coins arrondis.
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // coordonnée x du coin supérieur gauche
            int nTopRect, // coordonnée y du coin supérieur gauche
            int nRightRect, // coordonnée x du coin inférieur droit
            int nBottomRect, // coordonnée y du coin inférieur droit
            int nWidthEllipse, // hauteur de l'ellipse
            int nHeightEllipse // largeur de l'ellipse
        );

        private DataSet ds;

        public formEvenements()
        {
            InitializeComponent();
            // Initialise un nouveau Region qui cherche la méthode CreateRoundRectRgn, en prenant le Gdi32.dll qui s'occupe de changer l'interface
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
            //ds = formMain.transfertDataSet;
        }

        // Quand on switch entre les formulaires, on met la dimension du form parent
        public formEvenements(Point formLocation)
        {
            InitializeComponent();
            // Initialise un nouveau Region qui cherche la méthode CreateRoundRectRgn, en prenant le Gdi32.dll qui s'occupe de changer l'interface
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
            this.DesktopLocation = formLocation; // Sur ce formulaire, on dit que la position de ce form est égale au père
        }

        private void formEvenements_Load(object sender, EventArgs e)
        {
            // On charge le UserControl
            userControlEvenementClick();
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
            formBilan formBilan = new formBilan(this.DesktopLocation);
            formBilan.Show();
            this.Visible = false;
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
                    a1.bilan = btnBilan_Click;
                }
            }
        }
    }
}
