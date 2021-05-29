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

namespace projetEvents
{
    public partial class FormAjoutDepense : Form
    {
        public FormAjoutDepense()
        {
            InitializeComponent();
        }

        // Déclaration de la chaine de connexion
        string chainconnec = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bdEvents.MDB";

        // Création d'un DataSet
        DataSet ds = formMain.transfertDataSet;

        // Déclaration de la connexion active
        OleDbConnection connec = new OleDbConnection();


        //Liaison de données - A une colonne - ComboBox
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


        private void FormAjoutDepense_Load(object sender, EventArgs e)
        {
            // Liaison de données - ComboBox Evenement 
            surchageComboBox(cboEvenements, "Evenements", "titreEvent", "codeEvent");

            // Surcharge ComboBox - ComboBox Participants avec deux colonnes
            surchageComboBoxV2(cboPayePar, "Participants", "prenomPart", "nomPart");

            designAffichage();

            // On appelle cette méthode pour directement afficher les bénéficiaires du 1er évenement sélectionner dans la CBO
            cboEvenements_SelectionChangeCommitted(sender, e); 
        }

        // Permet d'avoir les gens sur la CheckedListBox qui sont dans la table invités
        private void cboEvenements_SelectionChangeCommitted(object sender, EventArgs e)
        {
            clbListeBeneficiaire.Items.Clear();
            try
            {
                connec.ConnectionString = chainconnec;
                connec.Open();
                string requete = @"SELECT prenomPart, nomPart, codeParticipant FROM Participants WHERE codeParticipant IN 
                                  (SELECT codePart FROM Invites WHERE codeEvent = " + ds.Tables["Evenements"].Rows[cboEvenements.SelectedIndex]["codeEvent"] + ")";
                OleDbCommand cmd = new OleDbCommand(requete, connec);
                OleDbDataReader dr = cmd.ExecuteReader();

                if (!ds.Tables.Contains("participantsDepense"))
                {
                    DataTable dt = new DataTable("participantsDepense");
                    dt.Columns.Add("nomPrenom");
                    dt.Columns.Add("codeParticipant");
                    ds.Tables.Add(dt);
                }
                else
                {
                    ds.Tables["participantsDepense"].Clear();
                }

                while (dr.Read())
                {
                    DataRow ligne = ds.Tables["participantsDepense"].NewRow();
                    ligne[0] = dr.GetString(0) + " " + dr.GetString(1);
                    ligne[1] = dr.GetInt32(2).ToString();
                    ds.Tables["participantsDepense"].Rows.Add(ligne);
                }

                for(int i=0; i< ds.Tables["participantsDepense"].Rows.Count; i++)
                {
                    clbListeBeneficiaire.Items.Add(ds.Tables["participantsDepense"].Rows[i]["nomPrenom"]);
                }
                connec.Close();
                autoCheckCreateur();
            }
            catch (OleDbException) { MessageBox.Show("Erreur dans la requete SQL"); }
            catch (InvalidOperationException) { MessageBox.Show("Erreur d'acces à la base de donnée"); }
            catch (Exception exp) { MessageBox.Show(exp.GetType().ToString()); }
        }

        private void autoCheckCreateur()
        {
            try
            {
                connec.ConnectionString = chainconnec;
                connec.Open();
                string requete = @"SELECT codeCreateur FROM Evenements WHERE codeEvent=" + ds.Tables["Evenements"].Rows[cboEvenements.SelectedIndex]["codeEvent"];
                OleDbCommand cmd = new OleDbCommand(requete, connec);
                string codeCreateur = cmd.ExecuteScalar().ToString();

                for (int i = 0; i < clbListeBeneficiaire.Items.Count; i++)
                {
                    if (ds.Tables["participantsDepense"].Rows[i]["codeParticipant"].ToString() == codeCreateur)
                    {
                        clbListeBeneficiaire.SetItemChecked(i, true);
                    }
                }
            }
            catch (OleDbException) { MessageBox.Show("Erreur dans la requete SQL"); }
            catch (InvalidOperationException) { MessageBox.Show("Erreur d'acces à la base de donnée"); }
            catch (Exception exp) { MessageBox.Show(exp.GetType().ToString()); }
            finally { connec.Close(); }
        }

        // Quand on clique sur ckbToutLeMonde = Tout-Cocher ou Tout-Decocher
        private void ckbToutLeMonde_CheckedChanged(object sender, EventArgs e)
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
            autoCheckCreateur(); // Rendre impossible de désélectionner le code Createur de l'évenement
        }

        //
        // TOUTES LES METHODES UTILISER QUAND ON CLIQUE SUR LE BTN VALIDER
        //

        // On cherche les erreurs quand on clique sur validé
        private Boolean verficationRemplissage()
        {
            Boolean remplissageCorrect;
            int nombreErreur = 5;

            // Vérification de la ComboBox Evènements
            if (String.IsNullOrEmpty(cboEvenements.Text))
            {
                errorProvider.SetError(cboEvenements, "Veuillez sélectionner un évènement.");
                nombreErreur++;
                lblErrorEvenement.Visible = true;
            }
            else
            {
                errorProvider.SetError(cboEvenements, "");
                nombreErreur--;
                lblErrorEvenement.Visible = false;
            }

            // Vérification de la TextBox "Quoi"
            if (String.IsNullOrEmpty(txtQuoi.Text))
            {
                errorProvider.SetError(txtQuoi, "Veuillez sélectionner un motif d'évènements.");
                nombreErreur++;
                lblErrorQuoi.Visible = true;
            }
            else
            {
                errorProvider.SetError(txtQuoi, "");
                nombreErreur--;
                lblErrorQuoi.Visible = false;
            }

            // Vérification de la TextBox "Combien"
            if (String.IsNullOrEmpty(txtCombien.Text))
            {
                errorProvider.SetError(txtCombien, "Veuillez sélectionner le montant de la dépense.");
                nombreErreur++;
                lblErrorCombien.Visible = true;
            }
            else
            {
                errorProvider.SetError(txtCombien, "");
                nombreErreur--;
                lblErrorCombien.Visible = false;
            }

            // Vérification de la ComboBox Payé Par
            if (String.IsNullOrEmpty(cboPayePar.Text))
            {
                errorProvider.SetError(cboPayePar, "Veuillez sélectionner un évènement.");
                nombreErreur++;
                lblErrorPayePar.Visible = true;
            }
            else
            {
                errorProvider.SetError(cboPayePar, "");
                nombreErreur--;
                lblErrorPayePar.Visible = false;
            }

            //Vérification de la CheckedListBox
            if (clbListeBeneficiaire.CheckedItems.Count < 1)
            {
                errorProvider.SetError(clbListeBeneficiaire, "Veuillez au moins sélectionner un bénéficiaire.");
                nombreErreur++;
                lblErrorBeneficiaire.Visible = true;
            }
            else
            {
                errorProvider.SetError(clbListeBeneficiaire, "");
                nombreErreur--;
                lblErrorBeneficiaire.Visible = false;
            }

            // Vérification de la RichTextBox "Commentaire"
            //if (String.IsNullOrEmpty(rtbCommentaire.Text))
            //{
            //    errorProvider.SetError(rtbCommentaire, "Veuillez écrire un commentaire concernant la dépense.");
            //    nombreErreur++;
            //}
            //else
            //{
            //    errorProvider.SetError(rtbCommentaire, "");
            //    nombreErreur--;
            //}

            if (nombreErreur <= 0)
            {
                remplissageCorrect = true;
            }
            else
            {
                remplissageCorrect = false;
            }

            return remplissageCorrect;
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            // On va vérifier que l'utilisateur a bien tout remplit
            Boolean remplissageComplet = verficationRemplissage();
            //saisieDepense();
            if (remplissageComplet)
            {
                saisieDepense();
            }
        }

        private OleDbTransaction transacDepense;
        private OleDbTransaction transacBenef;

        private void saisieDepense()
        {
            // On va récupérer toutes les informations que l'utilisateurs à rentrer
            string numeroDepense = numDepense();
            string description = txtQuoi.Text;
            string montant = txtCombien.Text;
            dtpDepense.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            string dateDepense = dtpDepense.Value.ToString();
            string commentaire = rtbCommentaire.Text;
            string codeEvents = cboEvenements.SelectedValue.ToString();
            string codePart = ds.Tables["Participants"].Rows[cboPayePar.SelectedIndex]["codeParticipant"].ToString();

            //
            // On va insérer la dépense dans la Table Evenements
            //

            try
            {
                connec.ConnectionString = chainconnec;
                connec.Open();
                // Démarrage d'une transaction
                transacDepense = connec.BeginTransaction();

                string requete =
                    @"Insert into Depenses (numDepense, description, montant, dateDepense, commentaire, codeEvent, codePart) Values('"
                     + numeroDepense + "', '" + description + "', '" + montant + "', '" + dateDepense + "', '"
                     + commentaire + "', '" + codeEvents + "', '" + codePart + "')";

                //MessageBox.Show(requete);
                OleDbCommand cmd = new OleDbCommand(requete, connec, transacDepense);
                int nbLigneInsert = cmd.ExecuteNonQuery();
                transacDepense.Commit();
                OleDbDataAdapter da1 = new OleDbDataAdapter(cmd);
                da1.Update(ds, "Depenses");

                //MessageBox.Show("Ajout d'une dépense : " + nbLigneInsert.ToString() + " ligne inséré.");
            }
            catch (OleDbException) { MessageBox.Show("Erreur dans la requete SQL"); }
            catch (InvalidOperationException) { MessageBox.Show("Erreur d'acces à la base de donnée"); }
            catch (Exception exp)
            {
                MessageBox.Show(exp.GetType().ToString());
                transacDepense.Rollback();
                MessageBox.Show("Erreur : Transaction annulée");
            }
            finally { connec.Close(); }

            //
            // On va insérer les différents béneficiaires de la dépenses dans la Table Bénéficiaires
            //

            List<string> codePartBenefciaire = new List<string>(); // Liste où figure tous les codes Participants de la dépense

            for (int i = 0; i < clbListeBeneficiaire.Items.Count; i++)
            {
                if (clbListeBeneficiaire.GetItemCheckState(i) == CheckState.Checked) // On regarde chaque element cochés
                {
                    codePartBenefciaire.Add(ds.Tables["Participants"].Rows[i]["codeParticipant"].ToString()); // On prend son codeParticipant
                }
            }

            try
            {
                connec.ConnectionString = chainconnec;
                connec.Open();
                transacBenef = connec.BeginTransaction();

                foreach (string codeBenef in codePartBenefciaire)
                {
                    string requete =
                    @"Insert into Beneficiaires (numDepense, codePart) Values('"
                     + numeroDepense + "', '" + codeBenef + "')";

                    //MessageBox.Show(requete);
                    OleDbCommand cmd = new OleDbCommand(requete, connec, transacBenef);
                    int nbLigneInsert = cmd.ExecuteNonQuery();

                    //MessageBox.Show("Ajout d'un participant de la dépense : " + nbLigneInsert.ToString() + " ligne inséré.");
                }

                transacBenef.Commit();
            }
            catch (OleDbException) { MessageBox.Show("Erreur dans la requete SQL"); }
            catch (InvalidOperationException) { MessageBox.Show("Erreur d'acces à la base de donnée"); }
            catch (Exception exp)
            {
                MessageBox.Show(exp.GetType().ToString());
                transacBenef.Rollback();
                MessageBox.Show("Erreur : Transaction annulée");
            }
            finally
            {
                connec.Close();
            }

            pcbLoadingValidate.Visible = true;
            Timer Clock = new Timer();
            Clock.Interval = 2000;
            Clock.Tick += new EventHandler(MyTimer_Tick);
            Clock.Start();
        }

        // Quand on clique sur validé, un temps de chargement s'active, on veut désactiver le gif de chargemenebt après ca
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            pcbLoadingValidate.Visible = false;
        }

        // On cherche le numéro de dépense et on l'augmente de +1 pour une nouvelle dépense dans la BDD
        private string numDepense()
        {
            connec.ConnectionString = chainconnec;
            connec.Open();

            // On affiche le nbr max de commande et ajoute + 1
            OleDbCommand cmd = new OleDbCommand("Select Max([numDepense]) from Depenses", connec);
            string numeroDepense = ((int)cmd.ExecuteScalar() + 1).ToString();
            connec.Close();
            return numeroDepense;
        }

        // Quand on clique sur annuler, on efface tout
        private void Annuler_Click(object sender, EventArgs e)
        {
            cboEvenements.SelectedIndex = -1;
            cboPayePar.SelectedIndex = -1;
            txtCombien.Clear();
            txtQuoi.Clear();
            rtbCommentaire.Clear();
            ckbToutLeMonde.Checked = false;
            dtpDepense.Value = DateTime.Now;
            errorProvider.Clear();
            clbListeBeneficiaire.Items.Clear();

            // On enlève les messages erreurs
            lblErrorCombien.Visible = false;
            lblErrorEvenement.Visible = false;
            lblErrorPayePar.Visible = false;
            lblErrorQuoi.Visible = false;
            lblErrorBeneficiaire.Visible = false;
        }

        private void designAffichage()
        {
            rtbCommentaire.SelectAll();
            rtbCommentaire.SelectionIndent += 15;//play with this values to match yours
            rtbCommentaire.SelectionRightIndent += 15;//this too
            rtbCommentaire.SelectionLength = 0;
        }

        // Rendre impossible de déselectionner le code Createur de l'évenement
        private void clbListeBeneficiaire_SelectedValueChanged(object sender, EventArgs e)
        {
            autoCheckCreateur();
        }

        // Rendre impossible de déselectionner le code Createur de l'évenement
        private void clbListeBeneficiaire_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            autoCheckCreateur();
        }
    }
}
