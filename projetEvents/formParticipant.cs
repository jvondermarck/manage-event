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
//systeme permettant l'envoi de mail
using System.Net.Mail;
using System.Net;

namespace projetEvents
{
    public partial class formParticipant : Form
    {
        /*
         * Réalisé par Gauthier LASSABLIERE
         * 
        */

        public formParticipant()
        {
            InitializeComponent();
        }

        //déclaration de l'objet connection
        private OleDbConnection connec = new OleDbConnection();

        //déclaration de la chaine de connection
        private string chainconnec = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\Debug\bdd\bdEvents.mdb";

        //déclaration des variables objets, mail et contenu du mail
        string sMail;
        string sObj;
        string sCont;

        //load du formulaire
        private void GdP_Load(object sender, EventArgs e)
        {
            Initialisation();
            lblevent.Focus(); // On met le titre comme focus au depart pour éviter que la cbo aie un background bleu vu qu'il le sélectionné en premier
        }

        //Liaison de données - A une colonne
        private void surchageComboBox(ComboBox cbo, String table, String column, String champCache)
        {
            cbo.DataSource = formMain.ds.Tables[table]; // On charge la table dans la cbo
            cbo.DisplayMember = column; // On dit quel colonne afficher de la table dans la cbo
            cbo.ValueMember = champCache; // Pour avoir le code de la destination (utile pour l'exo 4.a)
            cbo.Text = ""; // Pour ne pas afficher le 1er element de la cbo au demarage  
        }

        //initialisation du formulaire : gestion de l'affichage des composants, chargement du dataset local formMain.ds,
        //remplissage de la combo box evenement
        public void Initialisation()
        {
            lblajoutparticipant.Visible = false;
            cboajoutparticipant.Visible = false;
            btninviter.Visible = false;
            lblobj.Visible = false;
            RTBobj.Visible = false;
            lblcontenu.Visible = false;
            RTBcontenu.Visible = false;
            lblparticipant.Visible = false;
            dgvparticipant.Visible = false;
            lblInviter.Visible = false;
            surchageComboBox(cboevent, "Evenements", "titreEvent", "codeEvent");
            cboevent.SelectedIndex = -1;
        }

        //affichage des composants pour l'affichage des participants et le possible ajout d'un invité
        //remplissage de la data grid view
        //remplissage de la combobox des personnes non invités
        private void Cboevent_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Si l'event n'est pas soldé, on peut alors ajouter des invités
            if(!rechercheDejaSolde())
            {
                //apparition du label des participant à l'évenement
                lblparticipant.Visible = true;
                btnadd.Visible = true;
                //remplissage de la combobox des non invités
                RameneDatacbo();
                plusdinvit();
            } else
            {
                lblparticipant.Visible = false;
                btnadd.Visible = false;
                lblajoutparticipant.Visible = false;
                cboajoutparticipant.Visible = false;
                lblChooseModeInvit.Visible = false;
                btninviter.Visible = false;
                lblInviter.Visible = false;
                rdbMailAuto.Visible = false;
                rdbMailPersonnalise.Visible = false;
                RTBcontenu.Visible = false;
                RTBobj.Visible = false;
                lblobj.Visible = false;
                lblcontenu.Visible = false;
            }

            //apparition de la datagridview des participant à l'évenement
            dgvparticipant.Visible = true;
            //remplissage de la data grid view
            RameneDataDGV();
        }

        // On regarde si l'évenement est déja soldé
        private bool rechercheDejaSolde()
        {
            connec.ConnectionString = chainconnec;
            connec.Open();
            string requete = @"SELECT soldeON FROM Evenements WHERE codeEvent=" + cboevent.SelectedValue;
            OleDbCommand cd = new OleDbCommand(requete, connec);
            bool res = (bool)cd.ExecuteScalar();
            connec.Close();
            return res;
        }

        //récupération des données de la base de données dans un data table puis affichage dans un data grid view
        public void RameneDataDGV()
        {
            connec.ConnectionString = chainconnec;
            connec.Open();
            // On cherche pour un évènement choisi, tous les participants qui ont était invités à cette évènement
            string requete = @"SELECT p.codeParticipant, p.prenomPart, p.nomPart, p.mobile, p.nbParts, p.solde  FROM Invites i INNER JOIN Participants p ON i.codePart=p.codeParticipant WHERE codeEvent=" + cboevent.SelectedValue.ToString();

            OleDbCommand cd1 = new OleDbCommand(requete, connec);
            OleDbDataReader dr = cd1.ExecuteReader();

            // On crée une table
            DataTable dt = new DataTable("datadgv");
            //on crée les colonnes
            dt.Columns.Add("codeParticipant");
            dt.Columns.Add("nomPrenom");
            dt.Columns.Add("n° de mobile");
            dt.Columns.Add("Solde");
            dt.Columns.Add("nb de Parts");
            //si la table existe déja on la supprime, sinon on l'ajoute au dataset
            if (!formMain.ds.Tables.Contains("datadgv"))
            {
                formMain.ds.Tables.Add(dt);
            }
            else
            {
                formMain.ds.Tables["datadgv"].Clear();
            }
            //on remplit la table avec les données
            while (dr.Read())
            {
                DataRow ligne = formMain.ds.Tables["datadgv"].NewRow();
                ligne[0] = dr.GetInt32(0).ToString();
                ligne[1] = dr.GetString(1) + " " + dr.GetString(2);
                ligne[2] = dr.GetString(3);
                ligne[3] = 0;
                ligne[4] = String.Format("{0:0.00}", dr.GetInt32(4).ToString());

                formMain.ds.Tables["datadgv"].Rows.Add(ligne);
            }
            connec.Close();

            //pour chaque participant on calcule son solde
            for (int i = 0; i < formMain.ds.Tables["datadgv"].Rows.Count; i++)
            {
                string codeParticipant = formMain.ds.Tables["datadgv"].Rows[i]["codeParticipant"].ToString();
                // Solde : Credit-Débit
                double depCredit = rechercheDepensesCreditDebit(codeParticipant, "mesDepenses");
                double depDebit = rechercheDepensesCreditDebit(codeParticipant, "DepensesQuiMeConcernent");
                double solde = depCredit - depDebit;
                if (rechercheDejaSolde() == true) // Si c'est deja soldé, on met le solde à 0.
                {
                    formMain.ds.Tables["datadgv"].Rows[i]["Solde"] = 0;
                }
                else
                {
                    formMain.ds.Tables["datadgv"].Rows[i]["Solde"] = (Math.Round(solde, 2)).ToString();
                }
            }
            dgvparticipant.DataSource = formMain.ds.Tables["datadgv"];
            dgvparticipant.SelectAll();
        }

        // On recherche pour la colonne "plus" et "moins" de la table Bilan, en surchargant le constructeur
        // soit le débit ou le crédit de tous les dépenses éffectués
        private double rechercheDepensesCreditDebit(string codeParticipant, string nomProcedureStock)
        {
            double totalDepense = 0;
            try
            {
                if (formMain.ds.Tables.Contains("mesDepensesTotal"))
                {
                    formMain.ds.Tables.Remove("mesDepensesTotal");
                }

                // On cherche la procédure stockée
                connec.Open();

                OleDbCommand cd1 = new OleDbCommand();
                cd1.Connection = connec;
                cd1.CommandType = CommandType.StoredProcedure;
                cd1.CommandText = nomProcedureStock;

                // Créations des paramètres - pEvent : n° de l’événement
                OleDbParameter paramValeur = new OleDbParameter();
                paramValeur.ParameterName = "@val";
                paramValeur.OleDbType = OleDbType.VarChar;
                paramValeur.Direction = ParameterDirection.Input;
                paramValeur.Value = cboevent.SelectedValue;

                // Créations des paramètres - pPart : code du participant
                OleDbParameter paramValeur2 = new OleDbParameter();
                paramValeur2.ParameterName = "@val";
                paramValeur2.OleDbType = OleDbType.VarChar;
                paramValeur2.Direction = ParameterDirection.Input;
                paramValeur2.Value = codeParticipant;

                // Ajout des parametres à l'objet Command
                cd1.Parameters.Add(paramValeur);
                cd1.Parameters.Add(paramValeur2);
                OleDbDataAdapter da = new OleDbDataAdapter(cd1);
                da.Fill(formMain.ds, "mesDepensesTotal");

                connec.Close();

                if (nomProcedureStock == "mesDepenses")
                {
                    // On va calculer le montant que la personne a dépensé dans l'évenements au total
                    totalDepense = 0;
                    for (int i = 0; i < formMain.ds.Tables["mesDepensesTotal"].Rows.Count; i++)
                    {
                        totalDepense += double.Parse(formMain.ds.Tables["mesDepensesTotal"].Rows[i]["montant"].ToString());
                    }
                }

                if (nomProcedureStock == "DepensesQuiMeConcernent")
                {
                    int codeParti = int.Parse(codeParticipant) - 1;
                    int nbPart = int.Parse(formMain.ds.Tables["Participants"].Rows[codeParti]["nbParts"].ToString());

                    totalDepense = 0;
                    for (int i = 0; i < formMain.ds.Tables["mesDepensesTotal"].Rows.Count; i++)
                    {
                        double montant = double.Parse(formMain.ds.Tables["mesDepensesTotal"].Rows[i]["montant"].ToString());
                        int somme = int.Parse(formMain.ds.Tables["mesDepensesTotal"].Rows[i]["SommeDenbParts"].ToString());
                        totalDepense += (montant / somme) * nbPart;
                    }
                }

            }
            catch (OleDbException) { MessageBox.Show("Erreur dans la requete SQL"); }

            return totalDepense;
        }

        //----------------------------------------------------------------------------------------------------------------------------------------

        //remplissage de la combobox des non participants
        public void RameneDatacbo()
        {
            connec.Open();
            //on récupère les infos des non participants à l'évènement sélectionnés
            //quand leur code ne fait pas parti de ceux qui participent à l'evenement
            string requete = @"SELECT DISTINCT codeParticipant, prenomPart, nomPart, adresseMail 
                FROM Participants WHERE (codeParticipant NOT IN 
                (SELECT codePart FROM Invites WHERE (codeEvent = " + cboevent.SelectedValue.ToString() + ")))";

            OleDbCommand cd1 = new OleDbCommand(requete, connec);
            OleDbDataReader dr = cd1.ExecuteReader();

            // On crée une table
            DataTable dt = new DataTable("cboAddInvite");
            //on crée les colonnes
            dt.Columns.Add("codeParticipant");
            dt.Columns.Add("nomPrenom");
            dt.Columns.Add("adresseMail");
            //si la table existe déja on la supprime, sinon on l'ajoute au dataset
            if (!formMain.ds.Tables.Contains("cboAddInvite"))
            {
                formMain.ds.Tables.Add(dt);
            }
            else
            {
                formMain.ds.Tables["cboAddInvite"].Clear();
            }

            for (int i = 0; i < formMain.ds.Tables["cboAddInvite"].Rows.Count; i++)
            {
                if (formMain.ds.Tables["cboAddInvite"].Rows[i]["codeParticipant"] == formMain.ds.Tables["cboAddInvite"].Rows[i]["codeParticipant"])
                {
                    formMain.ds.Tables["cboAddInvite"].Rows[i].Delete();
                }
            }
            // Pour chaque participant, on ajoute dans le DataSet les infos de la personnes
            while (dr.Read())
            {
                DataRow ligne = formMain.ds.Tables["cboAddInvite"].NewRow();

                ligne[0] = dr.GetInt32(0).ToString();
                ligne[1] = dr.GetString(1) + " " + dr.GetString(2);
                ligne[2] = dr.GetString(3);

                formMain.ds.Tables["cboAddInvite"].Rows.Add(ligne);
            }
            connec.Close();
            //remplissage de la combobox par liaison de donnée
            cboajoutparticipant.DataSource = formMain.ds.Tables["cboAddInvite"];
            cboajoutparticipant.DisplayMember = "nomPrenom";
            cboajoutparticipant.ValueMember = "codeParticipant";
            cboajoutparticipant.SelectedIndex = -1;
            //on vérifie si il y a encore une personne qui peut etre un potentiel invité dans la combobox,
            //si non on désactive le bouton d'ajout
            plusdinvit();
        }

        //-----------------------------------------------------------------------------------------------------------------------

        //fait apparaitre les composants de selection du futur invité
        private void btnadd_Click(object sender, EventArgs e)
        {
            lblajoutparticipant.Visible = true;
            cboajoutparticipant.Visible = true;
        }

        //fait apparaitre les boutons de création du mail et d'invitation
        private void Cboajoutparticipant_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblChooseModeInvit.Visible = true;
            rdbMailAuto.Visible = true;
            rdbMailPersonnalise.Visible = true;
            btninviter.Visible = true;
            rdbMailAuto.Checked = true;
            lblInviter.Visible = true;
        }

        //nouvelle invitation
        //paramètres
        // renvoie l'objet du mail, automatique ou personnalisé
        public string ChxObj(RichTextBox RTBobj)
        {
            string selected = this.cboevent.GetItemText(this.cboevent.SelectedItem);

            if (RTBobj.TextLength == 0)
            {
                return "Invitation à l'évènement : " + selected;
            }
            else
            {
                return RTBobj.Text;
            }
        }

        // renvoie le contenu du mail, automatique ou personnalisé
        public string ChxCont(RichTextBox RTBcontenu)
        {
            string selected = this.cboevent.GetItemText(this.cboevent.SelectedItem);
            string datedebut = formMain.ds.Tables["Evenements"].Rows[cboevent.SelectedIndex]["dateDebut"].ToString();
            string datefin = formMain.ds.Tables["Evenements"].Rows[cboevent.SelectedIndex]["dateFin"].ToString();
            if (RTBcontenu.TextLength == 0)
            {
                string txt = @"Salut, " + cboajoutparticipant.Text +
                "!\n\n" + "Tu as était invité(e) à un nouvel évènement : " + selected + " \n" +
                " \n" +
                "\tDu " + datedebut.Substring(0, 8) + " au " + datefin.Substring(0, 8) +
                " \n" +
                "\tDescription : " + formMain.ds.Tables["Evenements"].Rows[cboevent.SelectedIndex]["description"].ToString() +
                "\n\nÀ bientôt !";
                return txt;
            }
            else
            {
                return RTBcontenu.Text;
            }
        }

        //renvoie l'addresse mail
        public string Mail()
        {
            return formMain.ds.Tables["cboAddInvite"].Rows[cboajoutparticipant.SelectedIndex]["adresseMail"].ToString();
        }

        //envoi du mail

        //procédure de création du mail avec les bons paramètres et envoi du mail
        public static void CreateTestMessage(string sObj, string sCont, string sMail)
        {
            try
            {
                SmtpClient client = new SmtpClient("partage.unistra.fr", 587);
                MailMessage msg = new MailMessage();

                client.EnableSsl = true;
                client.Timeout = 1000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;

                client.Credentials = new NetworkCredential("gautier.lassabliere@etu.unistra.fr", "GautierUnistra1?");
                msg.From = new MailAddress("gautier.lassabliere@etu.unistra.fr");
                msg.Subject = sObj;
                msg.Body = sCont;
                msg.To.Add(sMail);

                client.Send(msg);
                //MessageBox.Show("Le mail à bien été envoyé");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //mise en place des composants pour le paramétrage du mail personnalisé
        private void Btnmail_Click(object sender, EventArgs e)
        {
            lblobj.Visible = true;
            RTBobj.Visible = true;
            lblcontenu.Visible = true;
            RTBcontenu.Visible = true;
        }

        //récupération des informations du mail et envoi
        //insertion dans la base du nouvel invité
        //verification de si il reste une personne qui serait invitable
        private void Btninv_Click(object sender, EventArgs e)
        {
            sObj = ChxObj(RTBobj);
            sCont = ChxCont(RTBcontenu);
            sMail = Mail();
            CreateTestMessage(sObj, sCont, sMail);
  
            //insertion dans la base du nouvel invité
            Insert();
            //verification de si il reste une personne qui serait invitable
            plusdinvit();

            // On affiche un message en bas à droite de l'écram
            formNotification.Alert("L'invitation a été envoyé !", formNotification.enmType.Success);

            cboajoutparticipant.SelectedIndex = -1;
            btninviter.Visible = false;
            lblChooseModeInvit.Visible = false;
            rdbMailAuto.Visible = false;
            rdbMailPersonnalise.Visible = false;
            lblobj.Visible = false;
            RTBobj.Visible = false;
            lblcontenu.Visible = false;
            RTBcontenu.Visible = false;
            lblInviter.Visible = false;
        }

        //insertion du nouvel invité à la base
        public void Insert()
        {
            int codeevent = int.Parse(cboevent.SelectedValue.ToString());
            int codepart = int.Parse(cboajoutparticipant.SelectedValue.ToString());
            string login = Createlogin(codeevent, codepart);
            string mdp = login;

            connec.Open();
            try
            {
                string rqt = @"INSERT into Invites (codeEvent, codePart, login, mdp) VALUES (" + codeevent + "," + codepart + ",'" + login + "', '" + mdp + "')";

                OleDbCommand cd2 = new OleDbCommand(rqt, connec);

                int nbLigneInsert = cd2.ExecuteNonQuery();
                //MessageBox.Show("L'invité à bien été ajouté");

                // On Update la BDD
                string requete = "SELECT * FROM Invites";
                OleDbDataAdapter da = new OleDbDataAdapter(requete, connec);
                formMain.ds.Tables["Invites"].Clear();
                da.Fill(formMain.ds, "Invites");
            }

            catch (OleDbException) { MessageBox.Show("Erreur dans la requete SQL"); }
            catch (InvalidOperationException) { MessageBox.Show("Erreur d'acces à la base de donnée"); }
            catch (Exception ep) { MessageBox.Show(ep.GetType().ToString()); }
            finally
            {
                connec.Close();
            }

            RameneDataDGV();
            RameneDatacbo();
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

        //verification de si il y a encore un participant potentiellement invitable à l'evenement
        //si non on retire les composants d'ajout d'un invité
        private void plusdinvit()
        {
            if (cboajoutparticipant.Items.Count == 0)
            {
                btnadd.Visible = false;
                lblajoutparticipant.Visible = false;
                cboajoutparticipant.Visible = false;
                lblChooseModeInvit.Visible = false;
                btninviter.Visible = false;
                lblInviter.Visible = false;
            }
        }

        private void dgvparticipant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvparticipant.SelectAll();
        }

        private void rdbMailPersonnalise_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbMailPersonnalise.Checked == true)
            {
                lblobj.Visible = true;
                RTBobj.Visible = true;
                lblcontenu.Visible = true;
                RTBcontenu.Visible = true;
            }
        }

        private void rdbMailAuto_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbMailAuto.Checked == true)
            {
                lblobj.Visible = false;
                RTBobj.Visible = false;
                lblcontenu.Visible = false;
                RTBcontenu.Visible = false;
            }
        }

        private void rdbMailAuto_Click(object sender, EventArgs e)
        {

        }

        private void btninviter_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show("Cliquez pour inviter le participant", btninviter);
        }

        private void btninviter_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Hide(btninviter);
        }
    }    //--------------------------------------------------------------------------------------------------------------------------
}
