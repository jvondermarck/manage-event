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

        // Quand on switch entre les formulaires, on met la dimension du form parent
        public formMain(Point formLocation)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.DesktopLocation = formLocation; // Sur ce formulaire, on dit que la position de ce form est égale au père
        }

        // Déclaration de la chaine de connexion
        string chainconnec = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bdEvents.MDB";

        // Création d'un DataSet
        static DataSet ds = new DataSet();

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

        //Liaison de données - A une colonne
        private void surchageComboBox(ComboBox cbo, String table, String column, String champCache)
        {
            cbo.DataSource = ds.Tables[table]; // On charge la table dans la cbo
            cbo.DisplayMember = column; // On dit quel colonne afficher de la table dans la cbo
            cbo.ValueMember = champCache; // Pour avoir le code de la destination (utile pour l'exo 4.a)
            cbo.Text = ""; // Pour ne pas afficher le 1er element de la cbo au demarage
        }

        //Surcharge - A deux colonnes
        public void surchageComboBoxV2(ComboBox cbo, String table, String column, String column2)
        {
            for (int i = 0; i < ds.Tables[table].Rows.Count; i++)
            {
                cbo.Items.Add(ds.Tables[table].Rows[i][column] + " " + ds.Tables[table].Rows[i][column2]);
            }
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            // On charge toutes les tables de la base
            ChargementDsLocal();

            // On charge le UserControl
            userControlEvenementClick();

            this.panelAllForm.Controls.Clear();
            FormAjoutDepense formAjoutDepense = new FormAjoutDepense() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formAjoutDepense.FormBorderStyle = FormBorderStyle.None;
            this.panelAllForm.Controls.Add(formAjoutDepense);
            formAjoutDepense.Show();
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
            userControlMenu.BarrePanel = 3;
            FormAjoutDepense formAjoutDepense = new FormAjoutDepense() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formAjoutDepense.FormBorderStyle = FormBorderStyle.None;
            this.panelAllForm.Controls.Add(formAjoutDepense);
            formAjoutDepense.Show();
        }

        private void btnEvenements_Click(object sender, EventArgs e)
        {
            //formEvenements formEvenements = new formEvenements(this.DesktopLocation);
            //formEvenements.Show();
            //this.Visible = false;
            //this.Hide();

            this.panelAllForm.Controls.Clear();
            formEvenements formEvenements = new formEvenements();
            formEvenements.FormBorderStyle = FormBorderStyle.None;
            this.panelAllForm.Controls.Add(formEvenements);
            formEvenements.Show();

        }

        private void btnParticipant_Click(object sender, EventArgs e)
        {
            formParticipant formParticipant = new formParticipant();
            formParticipant.ShowDialog();
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

        // Méthodes qui permettent de deplacer le form quand on clique sur la panel header
        bool drag = false;
        Point start_point = new Point(0, 0);
        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true; //drag is your variable flag.
            start_point = new Point(e.X, e.Y);
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
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