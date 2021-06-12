using projetEvents.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetEvents
{
    public partial class formNotification : Form
    {
        /*
         * Réalisé par Julien VON DER MARCK
         * 
        */

        public formNotification()
        {
            InitializeComponent();
        }

        // Cette méthode pourra etre appellé par tous les autres formulaires, en indiquant le type de message, et le txt du message
        public static void Alert(string msg, formNotification.enmType type)
        {
            formNotification frm = new formNotification(); // On crée une instance du Formulaire de notification
            frm.showAlert(msg, type); // On appelle la méthode
        }

        // Enumeration pour fermer, ouvrir, ou faire patienter le form
        public enum enmAction
        {
            wait,
            start,
            close
        }

        // On crée la variable qui permettra de donner une action au formulaire, du genre faire un message d'erreur ou de réussite
        private formNotification.enmAction action;

        // Il y a plusieurs type de messages qu'on peut afficher
        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }

        public void showAlert(string msg, enmType type)
        {
            this.Opacity = 0.0; // On met une opacité de 0 donc on verra pas le forme
            this.StartPosition = FormStartPosition.Manual; // On s'occupe de placer soi-meme la popup
            string fname; // Servira pour savoir si c'est la 1er fois qu'on affiche le form, ce qui fait qu'on le met à un endroit particulier

            for (int i = 1; i < 5; i++) // Le nombre de popup qu'on peut avoir en bas a droite
            {
                fname = "alert" + i.ToString();
                formNotification frm = (formNotification)Application.OpenForms[fname]; // On appelle ce formulaire

                if (frm == null) // Si c'est la première popup qu'on affiche, on lui met la position de départ
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15; // Coordonné X en bas a droite
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i; // Coordonné Y en bas a droite
                    this.Location = new Point(this.x, this.y); // On lui dit au form où il doit se placer
                    break; // On sort de la boucle
                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5; // On commence a faire apparaitre le form

            // lES DIFFFÉRENTS TYPES DE MESSAGES
            switch (type)
            {
                case enmType.Success:
                    this.pictureBox1.Image = Resources.success; // On recherche dans le dossier Ressources, l'image en question
                    this.BackColor = Color.SeaGreen; // On lui attribue une couleur de fond
                    break;
                case enmType.Error:
                    this.pictureBox1.Image = Resources.error;
                    this.BackColor = Color.DarkRed;
                    break;
                //case enmType.Info:
                //    this.pictureBox1.Image = Resources.info;
                //    this.BackColor = Color.RoyalBlue;
                //    break;
                case enmType.Warning:
                    this.pictureBox1.Image = Resources.warning;
                    this.BackColor = Color.DarkOrange;
                    break;
            }


            this.lblMessage.Text = msg; // On met un message qu'on lui a passé en paramètre

            this.Show(); // On montre le formulaire
            this.action = enmAction.start; // On met l'état du form sur la partie start
            this.timer1.Interval = 1; // On initialise à 1 pour commencer a faire bouger le form sur le bureau
            this.timer1.Start(); // On commemce à afficher le form 
        }

        private int x, y;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // L'utilisateur peut fermer le formulaire si il veut
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 4000; // On laisse la popup pendant 4sec
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1; // On augmente petit à petit sont opacité
                    if (this.x < this.Location.X) // On fait venir en augmentant de 0 à 0.9 d'opacité
                    {
                        this.Left--; // On le fait aparaitre de plus en plus à gauche vu que le form apparait de la droite
                    }
                    else
                    {
                        if (this.Opacity == 1.0) // Dès qu'on a finit de le faire complètement apparaitre avec une opacité à 1 (normal)
                        {
                            action = enmAction.wait; // On va le laisser afficher pendant 4sec et on le ferme
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1; // On effectue une opacité en auigmantant le timer pour voir la fermeture

                    this.Left -= 3; // On le décale vers la droite pour le faire partir du formulaire
                    if (base.Opacity == 0.0) // On le cache
                    {
                        base.Close(); // Puis on le ferme completement
                    }
                    break;
            }
        }
    }
}
