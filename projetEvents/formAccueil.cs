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
    public partial class formMain : Form
    {
        /*
         * Réalisé par Julien VON DER MARCK
         * 
        */

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

        public formMain()
        {
            InitializeComponent();
            // Initialise un nouveau Region qui cherche la méthode CreateRoundRectRgn, en prenant le Gdi32.dll qui s'occupe de changer l'interface
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Déclaration de la chaine de connexion
        string chainconnec = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\Debug\bdd\bdEvents.mdb";

        // Création d'un DataSet
        public static DataSet ds = new DataSet();

        // Déclaration de la connexion active
        OleDbConnection connec = new OleDbConnection();

        //Accesseur permettant de transférer une DataSet d'un form à l'autre (Form Parent)
        public static DataSet transfertDataSet
        {
            get // this makes you to access value in form2
            {
                return ds;
            }
            set // this makes you to change value in form2
            {
                ds = value;
            }
        }

        // Ramener l'intégralité des tables voyages dans le dataSet .
        public void ChargementDsLocal()
        {
            connec.ConnectionString = chainconnec;
            connec.Open();
            DataTable schemaTable = connec.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
            new object[] { null, null, null, "TABLE" });
            for (int i = 0; i < schemaTable.Rows.Count; i++)
            {
                string requete = "SELECT * FROM " + schemaTable.Rows[i][2];
                OleDbCommand cmd = new OleDbCommand(requete, connec);
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
                string nomTable = schemaTable.Rows[i][2].ToString();
                dataAdapter.Fill(ds, nomTable);
            }
            connec.Close();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            // On charge toutes les tables de la base
            ChargementDsLocal();

            // On charge le UserControl
            userControlEvenementClick();

            // On affiche directement le formulaire de présentation
            btnAccueil_Click(sender, e);
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

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            this.panelAllForm.Controls.Clear();
            userControlMenu1.BarrePanel = 1; // Cela équivaut à avoir une couleur différente sur le menu où on se trouve
            formPresentation formPresentation = new formPresentation() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formPresentation.FormBorderStyle = FormBorderStyle.None;
            this.panelAllForm.Controls.Add(formPresentation);
            formPresentation.Show();
            lblNomForm.Text = "Bienvenue !";
            lblPresentationForm.Text = "Créez des évènements, invitez des gens, partagez l'addition";
        }

        private void btnEvenements_Click(object sender, EventArgs e)
        {
            userControlMenu1.BarrePanel = 2;
            formEvenements formEvenements = new formEvenements() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; ;
            formEvenements.FormBorderStyle = FormBorderStyle.None;
            this.panelAllForm.Controls.Clear();
            this.panelAllForm.Controls.Add(formEvenements);
            formEvenements.Show();
            lblNomForm.Text = "Créer de nouveaux évènements !";
            lblPresentationForm.Text = "";
        }

        private void btnParticipant_Click(object sender, EventArgs e)
        {
            this.panelAllForm.Controls.Clear();
            userControlMenu1.BarrePanel = 3;
            formParticipant formParticipant = new formParticipant() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; ;
            formParticipant.FormBorderStyle = FormBorderStyle.None;
            this.panelAllForm.Controls.Add(formParticipant);
            formParticipant.Show();
            lblNomForm.Text = "Visionner et inviter des participants !";
            lblPresentationForm.Text = "";
        }

        private void btnDepenses_Click(object sender, EventArgs e)
        {
            this.panelAllForm.Controls.Clear();
            userControlMenu1.BarrePanel = 4;
            formDepense formDepense = new formDepense() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; ;
            formDepense.FormBorderStyle = FormBorderStyle.None;
            this.panelAllForm.Controls.Add(formDepense);
            lblNomForm.Text = "Gérer vos dépenses !";
            lblPresentationForm.Text = "";
            formDepense.Show();
        }
        private void btnBilan_Click(object sender, EventArgs e)
        {
            this.panelAllForm.Controls.Clear();
            userControlMenu1.BarrePanel = 5;
            formBilan formBilan = new formBilan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formBilan.FormBorderStyle = FormBorderStyle.None;
            this.panelAllForm.Controls.Add(formBilan);
            formBilan.Show();
            lblNomForm.Text = "Bilan - Qui doit Quoi, à Qui ?";
            lblPresentationForm.Text = "";
        }

        // Méthodes qui permettent de deplacer le form quand on clique sur la panel header
        bool drag = false;
        Point start_point = new Point(0, 0);

        // Quand on clique sur le panel, on commence a prendre les coordonnées du formulaire X et Y
        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true; // On dit qu'on commence a bouger le form
            start_point = new Point(e.X, e.Y); // On prend cherche la coordonné X et Y du form
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag) // Si on est en train de bouger le formulaire
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y); // On change la localisation du form
            }
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false; // Quand on lache la souris, on arrete de cherche les coordonnées de localisation
        }

        private void pcbQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcbReduceScreen_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

/*
 * Couleur menu : 24; 30; 54
 * Couleur arriere plan form : 46; 51; 73
*/