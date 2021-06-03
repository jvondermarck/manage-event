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

            designAffichage();

            cboEvenements.SelectedIndex = -1;

            txtCombien.ShortcutsEnabled = false;
        }

        // Permet d'avoir les gens sur la CheckedListBox qui sont dans la table invités
        private void cboEvenements_SelectionChangeCommitted(object sender, EventArgs e)
        {
            clbListeBeneficiaire.Items.Clear();
            ckbToutLeMonde.Checked = false;
            try
            {
                connec.ConnectionString = chainconnec;
                connec.Open();
                string requete = @"SELECT prenomPart, nomPart, codeParticipant FROM Participants WHERE codeParticipant IN 
                                  (SELECT codePart FROM Invites WHERE codeEvent = " + cboEvenements.SelectedValue.ToString() + ")";
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

                // Liaison de données - ComboBox Evenement 
                surchageComboBox(cboPayePar, "participantsDepense", "nomPrenom", "codeParticipant");
                cboPayePar.SelectedIndex = -1;
            }
            catch (OleDbException) { MessageBox.Show("Erreur dans la requete SQL"); }
            catch (InvalidOperationException) { MessageBox.Show("Erreur d'acces à la base de donnée"); }
            catch (Exception exp) { MessageBox.Show(exp.GetType().ToString()); }
        }

        private void autoCheckCreateur()
        {
            if (clbListeBeneficiaire.Items.Count >= 1 && cboPayePar.SelectedIndex != -1)
            {
                for (int i = 0; i < clbListeBeneficiaire.Items.Count; i++)
                {
                    if (ds.Tables["participantsDepense"].Rows[i]["codeParticipant"].ToString() == cboPayePar.SelectedValue.ToString())
                    {
                        clbListeBeneficiaire.SetItemChecked(i, true);
                    }
                }
            }
        }

        // Quand on clique sur ckbToutLeMonde = Tout-Cocher ou Tout-Decocher
        private void ckbToutLeMonde_CheckedChanged(object sender, EventArgs e)
        {
            if(clbListeBeneficiaire.Items.Count > 0)
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
                autoCheckCreateur();
            } else
            {
                ckbToutLeMonde.Checked = false;
            }
    
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
            } else
            {
                formNotification.Alert("Une erreur est survenue", formNotification.enmType.Error);
            }
        }

        private OleDbTransaction transacDepense;
        private OleDbTransaction transacBenef;

        private void saisieDepense()
        {
            // On va récupérer toutes les informations que l'utilisateurs à rentrer
            string numeroDepense = numDepense();
            string description = txtQuoi.Text;
            string montant = txtCombien.Text.Substring(0, txtCombien.TextLength-1); // On enleve le € du montant
            dtpDepense.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            string dateDepense = dtpDepense.Value.ToString();
            string commentaire;
            if(rtbCommentaire.TextLength>0)
            {
                commentaire = rtbCommentaire.Text;
            } else
            {
                commentaire = " ";
            }
            string codeEvents = cboEvenements.SelectedValue.ToString();
            string codePart = cboPayePar.SelectedValue.ToString();

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

                    OleDbCommand cmd = new OleDbCommand(requete, connec, transacBenef);
                    int nbLigneInsert = cmd.ExecuteNonQuery();
                }

                transacBenef.Commit();
                pcbLoadingValidate.Visible = true;
                Timer Clock = new Timer();
                Clock.Interval = 1000;
                Clock.Tick += new EventHandler(MyTimer_Tick);
                Clock.Start();
                toutEffacerDepense();
            }
            catch (OleDbException) { formNotification.Alert("Erreur dans la requete SQL ! ", formNotification.enmType.Error); }
            catch (InvalidOperationException) { formNotification.Alert("Erreur d'acces à la base de donnée ! ", formNotification.enmType.Error); }
            catch (Exception exp)
            {
                MessageBox.Show(exp.GetType().ToString());
                transacBenef.Rollback();
            }
            finally
            {
                connec.Close();
                formNotification.Alert("Bravo ! Vous avez ajouté une dépense ! ", formNotification.enmType.Success);
            }
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

        // On efface tous les champs de saisie du formulaire ajout d'une dépense
        private void toutEffacerDepense()
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

        // Quand on clique sur annuler, on efface tout
        private void Annuler_Click(object sender, EventArgs e)
        {
            toutEffacerDepense();
            formNotification.Alert("Vous avez annulé la saisie de dépense", formNotification.enmType.Warning);
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

        private void cboPayePar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            autoCheckCreateur();
        }

        // Bloquer l'utilisateur sur la possibilité de mettre des lettres ou des symbols dans une zone de texte réservé qu'a des chiffres
        private void txtCombien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // On autorise tout, SAUF : (voir indo d’en bas)
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            if(char.IsLetter(e.KeyChar))
            {
                formNotification.Alert("Entrez seulement des chiffres", formNotification.enmType.Warning);
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            if (e.KeyChar == ',' && !txtCombien.Text.Contains(','))
            {
                e.Handled = false;
            }
            if (e.KeyChar == '.')
            {
                if(!txtCombien.Text.Contains(','))
                {
                    e.Handled = false;
                    e.KeyChar = ',';
                }     
            }
            if(e.KeyChar == ',' && txtCombien.Text.Contains(','))
            {
                formNotification.Alert("Entrez seulement une virgule.", formNotification.enmType.Warning);
            }
            if (char.IsSymbol(e.KeyChar))
            {
                formNotification.Alert("Ne pas saisir de symbole.", formNotification.enmType.Warning);
            }
        }

        private void txtCombien_Leave(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtCombien.Text)) // Si on va dans la txt et on resort sans rien mettre, on ne ve pas afficher le symbol euro tout seul
            {
                txtCombien.Text += "€";
            }
        }

        private void txtCombien_Enter(object sender, EventArgs e)
        {
            txtCombien.Text = "";
        }
    }
}
