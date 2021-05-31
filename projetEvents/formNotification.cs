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
        public formNotification()
        {
            InitializeComponent();
        }

        public static void Alert(string msg, formNotification.enmType type)
        {
            formNotification frm = new formNotification();
            frm.showAlert(msg, type);
        }

        public enum enmAction
        {
            wait,
            start,
            close
        }

        private formNotification.enmAction action;

        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }

        public void showAlert(string msg, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual; // On s'occupe de placer soi-meme la popup
            string fname;

            for (int i = 1; i < 5; i++) // Le nombre de popup qu'on peut avoir en bas a droite
            {
                fname = "alert" + i.ToString();
                formNotification frm = (formNotification)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;

                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case enmType.Success:
                    this.pictureBox1.Image = Resources.success;
                    this.BackColor = Color.SeaGreen;
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


            this.lblMessage.Text = msg;

            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }

        private int x, y;

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 4000;
                    action = enmAction.close;
                    break;
                case formNotification.enmAction.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = formNotification.enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }


    }
}
