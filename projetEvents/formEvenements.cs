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
        /*
         * Réalisé par Jad MACHKOUR
         * 
        */

        // Déclaration de la chaine de connexion
        private string chainconnec = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\Debug\bdd\bdEvents.mdb";

        // Déclaration de la connexion active
        OleDbConnection connec = new OleDbConnection();

        //Déclaration du Binding Source
        private BindingSource bs = new BindingSource();

        private int enregistrement = 1;
        private int codeEvent;


        public formEvenements()
        {
            InitializeComponent();
        }

        private void formEvenements_Load(object sender, EventArgs e)
        {
            bs.DataSource = formMain.ds.Tables["Evenements"];
            bindingsNavigator(); //Codage des boutons pour naviguer et récupérer les infos de la table
            chargementNumPage(); //Chargement des infos des événements pour le parcours 1 à 1
            chargement_cbCreateur();
            btnPageFin_Click(sender, e);
            btnPageDebut_Click(sender, e);
        }

        //////////////////////////////////////////////////////////////////////////////////
        ///////      Parcours 1 à 1
        //////////////////////////////////////////////////////////////////////////////////

        /* chargementPage() : procédure
         * Affichage des informations pour chaque évènements, selon le numéro de la page (donc de l'enregistrement)
         */
        private void bindingsNavigator()
        {
            lblNumEvenement.DataBindings.Add("Text", bs, "codeEvent");
            lblCreateur.DataBindings.Add("Text", bs, "codeCreateur");
            lblDateDebut.DataBindings.Add("Text", bs, "dateDebut");
            lblDateFin.DataBindings.Add("Text", bs, "dateFin");
            lblIntitule.DataBindings.Add("Text", bs, "titreEvent");
            rtbDescPage1.DataBindings.Add("Text", bs, "description");
            lblSolde.DataBindings.Add("Text", bs, "soldeON");

            modificationsNavigator(); //procédure qui modifie certaines infos recueilli 
        }


        /* modificationsNavigator() : procédure
         * Affiche le prénom et nom du créateur, modifie le format de la date
         */
        private string nomPrenom;
        private void modificationsNavigator()
        {
            //On va chercher le prenom et nom du createur grâce au codeCreateur dans la table Participants
            nomPrenom = formMain.ds.Tables["Participants"].Rows[int.Parse(lblCreateur.Text) - 1]["prenomPart"].ToString() + " " + formMain.ds.Tables["Participants"].Rows[int.Parse(lblCreateur.Text) - 1]["nomPart"].ToString();
            lblCreateur.Text = nomPrenom;
            if (lblSolde.Text == "True") { lblSolde.Text = " soldé"; } //évènement soldé oui ou non
            else { lblSolde.Text = " non soldé"; }
            lblDateDebut.Text = lblDateDebut.Text.Substring(0, 8); //date sous la forme "DD/MM/YYYY"
            lblDateFin.Text = lblDateFin.Text.Substring(0, 8); //date sous la forme "DD/MM/YYYY"
        }


        /* chargementNumPage() : procédure
         * Affiche le numero de la page/enregistrement sur lequel on se trouve
         */
        private void chargementNumPage()
        {
            lblNumEnregistrement.Text = "Enregistrement : ";
            lblNumEnregistrement.Text += lblNumEvenement.Text + " sur " + formMain.ds.Tables["Evenements"].Rows.Count.ToString();

            if (enregistrement == formMain.ds.Tables["Evenements"].Rows.Count) { btnPageSuivante.Visible = false; btnPageFin.Visible = false; }
            else { btnPageSuivante.Visible = true; btnPageFin.Visible = true; }
            if (enregistrement == 1) { btnPagePrecedente.Visible = false; btnPageDebut.Visible = false; }
            else { btnPagePrecedente.Visible = true; btnPageDebut.Visible = true; }
        }

        //Codage des 4 boutons qui vont nous permettre de naviguer dans le parcours 1 à 1
        private void btnPageDebut_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
            enregistrement = 1;
            chargementNumPage(); //maj du numéro de l'enregistrement/page
            modificationsNavigator();
        }

        private void btnPagePrecedente_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
            enregistrement--;
            chargementNumPage();//maj du numéro de l'enregistrement/page
            modificationsNavigator();
        }

        private void btnPageSuivante_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
            enregistrement++;
            chargementNumPage();//maj du numéro de l'enregistrement/page
            modificationsNavigator();
        }

        private void btnPageFin_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
            enregistrement = formMain.ds.Tables["Evenements"].Rows.Count;
            chargementNumPage();//maj du numéro de l'enregistrement/page
            modificationsNavigator();
        }


        //////////////////////////////////////////////////////////////////////////////////
        ///////      Création Evènement
        //////////////////////////////////////////////////////////////////////////////////



        /* nouvelleLigne() : procédure : Insère une nouvelle ligne dans la base Evenements
         * 
         * Paramètres :
         * 
         * codeEvent : int : code du nouvel évènement
         * titreEvent : string : titre de l'évènement
         * dateDebut : DateTime : date début évènement
         * dateFin : DateTime : date fin évènement
         * description : string : description de l'évènement
         * soldeON : bool : true si l'évènement est soldé
         * codeCreateur : int : code du créateur de l'évènement
         */
        private void nouvelleLigne(int codeEvent, string titreEvent, DateTime dateDebut, DateTime dateFin, string description, bool soldeON, int codeCreateur)
        {
            try
            {
                connec.ConnectionString = chainconnec;
                connec.Open();
                string requete = @"INSERT INTO [Evenements] (codeEvent, titreEvent, dateDebut, dateFin, description, soldeON, codeCreateur)
                                    VALUES (" + codeEvent + ", '" + titreEvent + "', '" + dateDebut + "', '" + dateFin + "', \"" + description + "\", " + soldeON + ", " + codeCreateur + ")";
                OleDbCommand cd1 = new OleDbCommand(requete, connec);
                int nbLigneDelete = cd1.ExecuteNonQuery();

                // On Update la BDD
                requete = "SELECT * FROM Evenements";
                OleDbDataAdapter da = new OleDbDataAdapter(requete, connec);
                formMain.ds.Tables["Evenements"].Clear();
                da.Fill(formMain.ds, "Evenements");


                // On va ajouter dans la table invité la personne qui a crée l'évènement
                string login = Createlogin(codeEvent, codeCreateur);
                string mdp = login;

                string rqt = @"INSERT into Invites (codeEvent, codePart, login, mdp) VALUES (" + codeEvent + "," + codeCreateur + ",'" + login + "', '" + mdp + "')";
                OleDbCommand cd2 = new OleDbCommand(rqt, connec);
                int nbLigneInsert = cd2.ExecuteNonQuery();

                // On Update la BDD
                requete = "SELECT * FROM Invites";
                da = new OleDbDataAdapter(requete, connec);
                formMain.ds.Tables["Invites"].Clear();
                da.Fill(formMain.ds, "Invites");
            }
            catch (OleDbException ex) { MessageBox.Show("Erreur dans la requete SQL" + ex); }
            catch (InvalidOperationException) { MessageBox.Show("Erreur d'accès à la base de donnée"); }
            catch (Exception exp) { MessageBox.Show(exp.GetType().ToString()); }
            finally { connec.Close(); }
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

        // btnEnregistrer_Click() : procédure : quand on clique sur btnEnregistrer, processus d'insertion dans la base Evenements
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            //Tout d'abord on vérifie qu'il n'y a pas d'erreurs dans la saisie des infos
            Boolean remplissageCorrect = verficationRemplissage();

            if (remplissageCorrect)
            {
                //Affichage d'un message pour confirmer ou non la suppression
                string message = "Etes-vous sûr de vouloir enregistrer l'évènement ?";
                string caption = "";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    codeEvent = formMain.ds.Tables["Evenements"].Rows.Count + 1;

                    nouvelleLigne(codeEvent, tbTitreEvenement.Text, dtpDateDebut.Value, dtpDateFin.Value, rtbDescPage2.Text, checkBoxSolde.Checked, int.Parse(cbCreateur.SelectedValue.ToString()));
                    btnPageDebut_Click(sender, e); // On reload la page 1 à 1 pour éviter les problemes d'affichages lors de l'insertion
                }

                if (codeEvent >= 1)
                {
                    //recuperationData();
                    affichageFormInvite(codeEvent, int.Parse(cbCreateur.SelectedValue.ToString()));
                    razCreationEvenement(); //on efface les infos pour faciliter la saisi d'autres évènements plus tard
                }
            }

            else { formNotification.Alert("Veuillez saisir tous les champs.", formNotification.enmType.Error); }

        }


        /* chargement_cbCreateur() : procédure : 
         * Chargement des noms et prénoms participants dans cbo createur
         */
        private void chargement_cbCreateur()
        {
            connec.ConnectionString = chainconnec;
            connec.Open();
            string requete = @"SELECT prenomPart, nomPart, codeParticipant FROM Participants";
            OleDbCommand cmd = new OleDbCommand(requete, connec);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (!formMain.ds.Tables.Contains("participantsCreateur"))
            {
                DataTable dt = new DataTable("participantsCreateur");
                dt.Columns.Add("nomPrenom");
                dt.Columns.Add("codeParticipant");
                formMain.ds.Tables.Add(dt);
            }
            else
            {
                formMain.ds.Tables["participantsCreateur"].Clear();
            }

            while (dr.Read())
            {
                DataRow ligne = formMain.ds.Tables["participantsCreateur"].NewRow();
                ligne[0] = dr.GetString(0) + " " + dr.GetString(1);
                ligne[1] = dr.GetInt32(2).ToString();
                formMain.ds.Tables["participantsCreateur"].Rows.Add(ligne);
            }
            connec.Close();

            surchageComboBox(cbCreateur, "participantsCreateur", "nomPrenom", "codeParticipant");

            cbCreateur.SelectedIndex = -1; //Pour ne pas avoir de texte dans la comboBox
        }



        /* chargement_cbCreateur() : fonction : Boolean :
         * Vérifie si chaque élément du tabControl "nouvel évènement" est bien remplie sans erreurs
         */
        private Boolean verficationRemplissage()
        {
            Boolean remplissageCorrect = true;
            //int nombreErreur = 1;

            //On vérifie si le titre de l'évènement est entré
            if (String.IsNullOrEmpty(tbTitreEvenement.Text))
            {
                errorProvider.SetError(tbTitreEvenement, "Veuillez sélectionner un titre.");
                remplissageCorrect = false;
                //nombreErreur++;
                lblErrorTitre.Visible = true;
            }
            else
            {
                errorProvider.SetError(tbTitreEvenement, "");
                //nombreErreur--;
                lblErrorTitre.Visible = false;
            }

            //On vérifie si la date début de l'évènement est supérieur ou égale à la date du système
            DateTime dt = (DateTime)dtpDateDebut.Value.Date;
            DateTime dt2 = (DateTime)dtpDateFin.Value.Date;
            if (DateTime.Compare(dt, dt2) > 0)
            {
                errorProvider.SetError(dtpDateDebut, "Veuillez sélectionner une date supérieur à la date du jour.");
                //nombreErreur++;
                remplissageCorrect = false;
                lblErrorDateDebut.Visible = true;
            }
            else
            {
                errorProvider.SetError(dtpDateDebut, "");
                //nombreErreur--;
                lblErrorDateDebut.Visible = false;
            }

            if (DateTime.Compare(dt, dt2) == 0)
            {
                errorProvider.SetError(dtpDateDebut, "");
                //nombreErreur--;
                lblErrorDateDebut.Visible = false;
            }

            //On vérifie si l'utilisateur entre une description de l'évènement
            if (String.IsNullOrEmpty(rtbDescPage2.Text))
            {
                errorProvider.SetError(rtbDescPage2, "Veuillez saisir une déscription de l'évènement.");
                //nombreErreur++;
                remplissageCorrect = false;
                lblErrorDescription.Visible = true;
            }
            else
            {
                errorProvider.SetError(rtbDescPage2, "");
                //nombreErreur--;
                lblErrorDescription.Visible = false;
            }

            // Vérification que la ComboBox Créateurs est non vide
            if (String.IsNullOrEmpty(cbCreateur.Text))
            {
                errorProvider.SetError(cbCreateur, "Veuillez sélectionner un créateur.");
                //nombreErreur++;
                remplissageCorrect = false;
                cbErrorCreateur.Visible = true;
            }
            else
            {
                errorProvider.SetError(cbCreateur, "");
                //nombreErreur--;
                cbErrorCreateur.Visible = false;
            }

            return remplissageCorrect;
        }

        //procédure qui éfface les infos d'un nouvel évènement dans le tabControl "Nouvel évènement"
        private void razCreationEvenement()
        {
            tbTitreEvenement.Text = "";
            rtbDescPage2.Text = "";
            checkBoxSolde.Checked = false;
            cbCreateur.SelectedIndex = -1;
        }

        //Liaison de données - A une colonne
        private void surchageComboBox(ComboBox cbo, String table, String column, String champCache)
        {
            cbo.DataSource = formMain.ds.Tables[table]; //On charge la table dans la cbo
            cbo.DisplayMember = column; //On dit quel colonne afficher de la table dans la cbo
            cbo.ValueMember = champCache; //Pour avoir le code de la destination (utile pour l'exo 4.a)
            cbo.Text = ""; //Pour ne pas afficher le 1er element de la cbo au demarage 
        }

        private void affichageFormInvite(int codeEvent, int codeCreateur)
        {
            formMain form = (formMain)ActiveForm;
            form.panelAllForm.Controls.Clear();
            inviteNewEvents inviteNewEvents = new inviteNewEvents(codeEvent, codeCreateur) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            inviteNewEvents.FormBorderStyle = FormBorderStyle.None;
            form.panelAllForm.Controls.Add(inviteNewEvents);
            inviteNewEvents.Show();
            form.lblNomForm.Text = "Inviter des participants à l'évènement";
            form.lblPresentationForm.Text = "";
        }
    }
}
