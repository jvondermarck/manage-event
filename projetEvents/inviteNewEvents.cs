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
using System.Net;
using System.Net.Mail;

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
            Label titre = new Label();
            titre.Text = "Quels sont les invités à cet évènements ?";
            titre.Location = new System.Drawing.Point(19, 19);
        }

        private int codeEvent;
        private int codeCreateur;

        public inviteNewEvents(int codeEvenement, int codeCreateurEvent)
        {
            InitializeComponent();
            Label titre = new Label();
            titre.Text = "Quels sont les invités à cet évènements ?";
            titre.Location = new System.Drawing.Point(19, 19);
            codeEvent = codeEvenement;
            codeCreateur = codeCreateurEvent;
        }

        private void inviteNewEvents_Load(object sender, EventArgs e)
        {
            affichageParticipants();
        }

        private void affichageParticipants()
        {
            if (!formMain.ds.Tables.Contains("allInvite"))
            {
                DataTable dt = new DataTable("allInvite");
                dt.Columns.Add("nomPrenom");
                dt.Columns.Add("codeParticipant");
                formMain.ds.Tables.Add(dt);
            }
            else
            {
                formMain.ds.Tables["allInvite"].Clear();
            }

            for (int i = 0; i < formMain.ds.Tables["Participants"].Rows.Count; i++)
            {
                // On veut pas que la personne qui crée l'évènement puisse s'inviter lui-meme
                if (formMain.ds.Tables["Participants"].Rows[i]["codeParticipant"].ToString() != codeCreateur.ToString())
                {
                    DataRow ligne = formMain.ds.Tables["allInvite"].NewRow();
                    ligne[0] = formMain.ds.Tables["Participants"].Rows[i]["prenomPart"] + " " + formMain.ds.Tables["Participants"].Rows[i]["nomPart"];
                    ligne[1] = formMain.ds.Tables["Participants"].Rows[i]["codeParticipant"];
                    formMain.ds.Tables["allInvite"].Rows.Add(ligne);
                }
            }

            // On ajoute tous les participants dans la CheckedListBox
            for (int i = 0; i < formMain.ds.Tables["allInvite"].Rows.Count; i++)
            {
                clbParticipants.Items.Add(formMain.ds.Tables["allInvite"].Rows[i]["nomPrenom"]);
            }
        }



        private void clbParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            //client SMTP
        }

        //Procédure qui permet de tout cocher grâce à la checkBox "tout cocher"
        private void cbToutCocher_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control a in this.Controls)
            {
                if (a is CheckedListBox)
                {
                    CheckedListBox a1 = (CheckedListBox)a; // On reprend l'élement checkBox 

                    if (a1.GetItemCheckState(0) == CheckState.Checked)
                    {
                        for (int i = 0; i < a1.Items.Count; i++)
                        {
                            a1.SetItemChecked(i, false);
                        }
                    }
                    else if (a1.GetItemCheckState(0) == CheckState.Unchecked)
                    {
                        for (int i = 0; i < a1.Items.Count; i++)
                        {
                            a1.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }


        /* lancerInvitations() : procédure : envoie les mails d'invitations au destinataires
         * 
         * Paramètres :
         * 
         * objetMail : string : objet du mail
         * contenuMail : string : rédaction de l'invitation
         * adrMail : List<string> : liste des adresses mails des destinataires
         */
        private static void lancerInvitations(string objetMail, string contenuMail, List<string> adrMail)
        {
            foreach (string adr in adrMail)
            {
                try
                {
                    SmtpClient client = new SmtpClient("partage.unistra.fr", 587);
                    MailMessage msg = new MailMessage();

                    client.EnableSsl = true;
                    client.Timeout = 1000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("jad.machkour@etu.unistra.fr", "jadMACH2709+$");
                    msg.To.Add(adr);
                    msg.From = new MailAddress("jad.machkour@etu.unistra.fr");
                    msg.Subject = objetMail;
                    msg.Body = contenuMail;

                    client.Send(msg);
                    //MessageBox.Show("success");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        /* btnEnvoyer_Click() : procédure : 
         * Récupère les adresses mails des invités, envoi des mails
         */
        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            int nbrPartChecked = 0;
            for (int i = 0; i < clbParticipants.Items.Count; i++)
            {
                if (clbParticipants.GetItemCheckState(i) == CheckState.Checked) // On regarde chaque element cochés
                {
                    nbrPartChecked++; // On prend son codeParticipant
                }
            }

            if (nbrPartChecked >= 1)
            {
                // On s'occupe d'inserer tous les participants de la base
                InsertAllInvite();

                // On s'occupe d'envoyer des mails
                List<string> adrMail = new List<string>();
                //
                // On va insérer les différents béneficiaires de la dépenses dans la Table Bénéficiaires
                //

                List<string> codeParticipants = new List<string>(); // Liste où figure tous les codes Participants de la dépense

                for (int i = 0; i < clbParticipants.Items.Count; i++)
                {
                    if (clbParticipants.GetItemCheckState(i) == CheckState.Checked) // On regarde chaque element cochés
                    {
                        codeParticipants.Add(formMain.ds.Tables["allInvite"].Rows[i]["codeParticipant"].ToString()); // On prend son codeParticipant
                    }
                }

                foreach (string code in codeParticipants)
                {
                    adrMail.Add(formMain.ds.Tables["Participants"].Rows[int.Parse(code) - 1]["adresseMail"].ToString());
                }

                int derniereLigne = formMain.ds.Tables["Evenements"].Rows.Count - 1;
                string titre = formMain.ds.Tables["Evenements"].Rows[derniereLigne]["titreEvent"].ToString();
                string dateDebut = formMain.ds.Tables["Evenements"].Rows[derniereLigne]["dateDebut"].ToString();
                string dateFin = formMain.ds.Tables["Evenements"].Rows[derniereLigne]["dateFin"].ToString();
                string description = formMain.ds.Tables["Evenements"].Rows[derniereLigne]["description"].ToString();

                string codeCreateur = formMain.ds.Tables["Evenements"].Rows[derniereLigne]["codeCreateur"].ToString();
                string nom = formMain.ds.Tables["Participants"].Rows[int.Parse(codeCreateur) - 1]["prenomPart"].ToString() + " " + formMain.ds.Tables["Participants"].Rows[int.Parse(codeCreateur) - 1]["nomPart"].ToString();

                string contenuMail = "Salut ! \n" +
                    nom + " t'a invité(e) à un nouvel évènement : " + titre + " \n" +
                    " \n" +
                    "Du " + dateDebut.Substring(0, 8) + " au " + dateFin.Substring(0, 8) +
                    " \n" +
                    "Description : " + description;

                lancerInvitations("Invitations à un nouvel évènements !", contenuMail, adrMail);
                quitterApplication();
            }

            else
            {
                formNotification.Alert("Veuillez choisir au moins 1 invité ! ", formNotification.enmType.Error);
            }

        }

        //insertion des nouveaux invités à la base
        private void InsertAllInvite()
        {
            int codeevent = codeEvent;
            int codepart;
            string login;
            string mdp;

            connec.ConnectionString = chainconnec;
            connec.Open();
            try
            {
                for (int i = 0; i < formMain.ds.Tables["allInvite"].Rows.Count; i++)
                {
                    if (clbParticipants.GetItemCheckState(i) == CheckState.Checked) // On regarde chaque element cochés
                    {
                        codepart = int.Parse(formMain.ds.Tables["allInvite"].Rows[i]["codeParticipant"].ToString()); // On prend son codeParticipant
                        login = Createlogin(codeevent, codepart);
                        mdp = login;

                        string rqt = @"INSERT into Invites (codeEvent, codePart, login, mdp) VALUES (" + codeevent + "," + codepart + ",'" + login + "', '" + mdp + "')";
                        //MessageBox.Show(rqt);
                        OleDbCommand cd2 = new OleDbCommand(rqt, connec);

                        int nbLigneInsert = cd2.ExecuteNonQuery();
                        //MessageBox.Show("L'invité à bien été ajouté");
                    }
                }

                string requete = "SELECT * FROM Invites";
                OleDbDataAdapter da = new OleDbDataAdapter(requete, connec);
                formMain.ds.Tables["Invites"].Clear();
                da.Fill(formMain.ds, "Invites");
                connec.Close();
            }
            catch (OleDbException) { MessageBox.Show("Erreur dans la requete SQL"); }
            catch (InvalidOperationException) { MessageBox.Show("Erreur d'acces à la base de donnée"); }
            catch (Exception ep) { MessageBox.Show(ep.GetType().ToString()); }
            finally
            {
                connec.Close();
            }
        }

        //création du login avec la première lettre du nom, 2e lettre du prenom et le code event et code part
        private string Createlogin(int codeevent, int codepart)
        {
            string nom = formMain.ds.Tables["Participants"].Rows[codepart - 1]["nomPart"].ToString();
            string prenom = formMain.ds.Tables["Participants"].Rows[codepart - 1]["prenomPart"].ToString();
            string login = "";
            login += nom[0];
            login += prenom[1];
            login += codeevent;
            login += codepart;
            return login;
        }

        //Procédure qui vérifie si au moins un invité est coché
        private bool verifCheck()
        {
            bool correct = true;
            if (clbParticipants.CheckedItems.Count < 1)
            {
                correct = false;
            }

            return correct;
        }

        private void quitterApplication()
        {
            formMain form = (formMain)ActiveForm;
            form.panelAllForm.Controls.Clear();
            formEvenements formEvenements = new formEvenements() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formEvenements.FormBorderStyle = FormBorderStyle.None;
            form.panelAllForm.Controls.Add(formEvenements);
            formEvenements.Show();
            form.lblNomForm.Text = "Créer de nouveaux évènements !";
            form.lblPresentationForm.Text = "";
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            quitterApplication();
        }


    }
}
