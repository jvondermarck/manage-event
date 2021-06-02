using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetEvents
{
    public partial class formStartup : Form
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

        public formStartup()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMain formMain = new formMain();
            formMain.Closed += (s, args) => this.Close();
            formMain.Show();
        }
    }
}
