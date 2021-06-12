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
        string chainconnec = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\Debug\bdd\bdEvents.mdb";

        // Déclaration de la connexion active
        OleDbConnection connec = new OleDbConnection();


        //Liaison de données - A une colonne - ComboBox
        private void surchageComboBox(ComboBox cbo, String table, String column, String champCache)
        {
            cbo.DataSource = formMain.ds.Tables[table]; // On charge la table dans la cbo
            cbo.DisplayMember = column; // On dit quel colonne afficher de la table dans la cbo
            cbo.ValueMember = champCache; // Pour avoir le code de la destination (utile pour l'exo 4.a)
            cbo.Text = ""; // Pour ne pas afficher le 1er element de la cbo au demarage
        }

        private void FormAjoutDepense_Load(object sender, EventArgs e)
        {
            // On supprime tous les évènements déja solé de la cbo
            cboSolde();

            designAffichage();

            cboEvenements.SelectedIndex = -1;
            txtCombien.ShortcutsEnabled = false;
        }

        // On supprime tous les évènements déja soldé dans la cbo
        public void cboSolde()
        {
            connec.ConnectionString = chainconnec;
            connec.Open();
            DataTable eventNonSolde = new DataTable();
            string requete = "SELECT * FROM Evenements WHERE soldeON=false";
            OleDbDataAdapter da = new OleDbDataAdapter(requete, connec);
            da.Fill(eventNonSolde);
            connec.Close();

            cboEvenements.DataSource = eventNonSolde;
            cboEvenements.DisplayMember = "titreEvent";
            cboEvenements.ValueMember = "codeEvent";
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

                // On crée une table pour pouvoir mettre le nom prenom de tous les participants invités à l'event (creation de table pour faire une liaison de données)
                if (!formMain.ds.Tables.Contains("participantsDepense"))
                {
                    DataTable dt = new DataTable("participantsDepense");
                    dt.Columns.Add("nomPrenom");
                    dt.Columns.Add("codeParticipant");
                    formMain.ds.Tables.Add(dt);
                }
                else
                {
                    formMain.ds.Tables["participantsDepense"].Clear();
                }

                while (dr.Read())
                {
                    DataRow ligne = formMain.ds.Tables["participantsDepense"].NewRow();
                    ligne[0] = dr.GetString(0) + " " + dr.GetString(1);
                    ligne[1] = dr.GetInt32(2).ToString();
                    formMain.ds.Tables["participantsDepense"].Rows.Add(ligne);
                }

                // On ajoute tous les participants dans la CheckedListBox
                for(int i=0; i< formMain.ds.Tables["participantsDepense"].Rows.Count; i++)
                {
                    clbListeBeneficiaire.Items.Add(formMain.ds.Tables["participantsDepense"].Rows[i]["nomPrenom"]);
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

        // On coche automatiquement celui qui a fait la dépense
        private void autoCheckCreateur()
        {
            if (clbListeBeneficiaire.Items.Count >= 1 && cboPayePar.SelectedIndex != -1)
            {
                for (int i = 0; i < clbListeBeneficiaire.Items.Count; i++)
                {
                    if (formMain.ds.Tables["participantsDepense"].Rows[i]["codeParticipant"].ToString() == cboPayePar.SelectedValue.ToString())
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
                for(int i=0; i<clbListeBeneficiaire.Items.Count; i++)
                {
                    if(clbListeBeneficiaire.GetItemCheckState(i) == CheckState.Checked)
                    {
                        clbListeBeneficiaire.SetItemChecked(i, false);
                    }
                    else
                    {
                        clbListeBeneficiaire.SetItemChecked(i, true);
                    }
                }
                autoCheckCreateur(); // On oublie pas de cocher celui qui fait la dépense
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
            int nombreErreur = 5; // Il y a 5 erreurs maximun que la personne peut commetre

            // Vérification de la ComboBox Evènements
            if (String.IsNullOrEmpty(cboEvenements.Text)) // Si la cbo est vide
            {
                errorProvider.SetError(cboEvenements, "Veuillez sélectionner un évènement.");
                nombreErreur++; // On augmente le nbr d'erreur
                lblErrorEvenement.Visible = true; // On affiche un messsage d'erreur
            }
            else // Si la cbo est rempli
            {
                errorProvider.SetError(cboEvenements, ""); // On enleve le error provider
                nombreErreur--; // On décremente le nbr d'erreur
                lblErrorEvenement.Visible = false; // On cache le message d'erreur
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

            if (nombreErreur <= 0) // Si le nbr d'erreur est nulle
            {
                remplissageCorrect = true; // On dit que tout est correcte
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
            // Si l'user a bien tout coché, on va commencer à insérer les données dans la BDD
            if (remplissageComplet)
            {
                saisieDepense();
            } else
            {
                formNotification.Alert("Veuillez saisir tous les champs.", formNotification.enmType.Error);
            }
        }

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

                string requete =
                    @"Insert into Depenses (numDepense, description, montant, dateDepense, commentaire, codeEvent, codePart) Values('"
                     + numeroDepense + "', '" + description + "', '" + montant + "', '" + dateDepense + "', '"
                     + commentaire + "', '" + codeEvents + "', '" + codePart + "')";

                OleDbCommand cmd = new OleDbCommand(requete, connec);
                int nbLigneInsert = cmd.ExecuteNonQuery();

                // On Update le DataSet
                requete = "SELECT * FROM Depenses";
                OleDbDataAdapter da = new OleDbDataAdapter(requete, connec);
                formMain.ds.Tables["Depenses"].Clear();
                da.Fill(formMain.ds, "Depenses");
            }
            catch (OleDbException) { MessageBox.Show("Erreur dans la requete SQL"); }
            catch (InvalidOperationException) { MessageBox.Show("Erreur d'acces à la base de donnée"); }
            catch (Exception exp) { MessageBox.Show(exp.GetType().ToString());}
            finally { connec.Close(); }

            //
            // On va insérer les différents béneficiaires de la dépenses dans la Table Bénéficiaires
            //

            List<string> codePartBenefciaire = new List<string>(); // Liste où figure tous les codes Participants de la dépense

            for (int i = 0; i < clbListeBeneficiaire.Items.Count; i++)
            {
                if (clbListeBeneficiaire.GetItemCheckState(i) == CheckState.Checked) // On regarde chaque element cochés
                {
                    codePartBenefciaire.Add(formMain.ds.Tables["participantsDepense"].Rows[i]["codeParticipant"].ToString()); // On prend son codeParticipant
                }
            }

            try
            {
                connec.ConnectionString = chainconnec;
                connec.Open();

                foreach (string codeBenef in codePartBenefciaire)
                {
                    string requete =
                    @"Insert into Beneficiaires (numDepense, codePart) Values('"
                     + numeroDepense + "', '" + codeBenef + "')";

                    OleDbCommand cmd = new OleDbCommand(requete, connec);
                    int nbLigneInsert = cmd.ExecuteNonQuery();
                }

                // On Update le DataSet
                string requete2 = "SELECT * FROM Beneficiaires";
                OleDbDataAdapter da = new OleDbDataAdapter(requete2, connec);
                formMain.ds.Tables["Beneficiaires"].Clear();
                da.Fill(formMain.ds, "Beneficiaires");

                pcbLoadingValidate.Visible = true;
                Timer Clock = new Timer();
                Clock.Interval = 1000;
                Clock.Tick += new EventHandler(MyTimer_Tick);
                Clock.Start();
                toutEffacerDepense();
                formNotification.Alert("Bravo ! Vous avez ajouté une dépense ! ", formNotification.enmType.Success);
            }
            catch (OleDbException) { formNotification.Alert("Erreur dans la requete SQL ! ", formNotification.enmType.Error); }
            catch (InvalidOperationException) { formNotification.Alert("Erreur d'acces à la base de donnée ! ", formNotification.enmType.Error); }
            catch (Exception exp) { MessageBox.Show(exp.GetType().ToString());}
            finally { connec.Close();}
        }

        // Quand on clique sur validé, un temps de chargement s'active, on veut désactiver le gif de chargemenent après ca
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

        // On efface tous les champs de saisie du formulaire quand il a inséré une nouvelle dépense ou qu'il appuie sur le btn annuler
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
        
        // On fait un petit design pour pas que le texte soit trop collé sur les bords de la rich text box
        private void designAffichage()
        {
            rtbCommentaire.SelectAll();
            rtbCommentaire.SelectionIndent += 15;// On augmente un peu la marge dans la RTB
            rtbCommentaire.SelectionRightIndent += 15;
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

        // Des qu'il sélectionner un participant, on coche direct celui-ci dans la checkedlistBox
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

        // On affiche le signe Euros quand l'user sors de la zone de texte
        private void txtCombien_Leave(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtCombien.Text)) // Si on va dans la txt et on resort sans rien mettre, on ne ve pas afficher le symbol euro tout seul
            {
                txtCombien.Text += "€";
            }
        }

        // Des qu'il reclique sur la zone de texte, on efface tout pour eviter qu'il se retrouve avec le symbol euros et provoque une erreur lors de l'insertion dans la BDD
        private void txtCombien_Enter(object sender, EventArgs e)
        {
            txtCombien.Text = "";
        }

        // Quand on passe la souris sur le txt combien on affiche un message d'aide
        private void txtCombien_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Entrez uniquement des chiffres", txtCombien);
        }

        // On efface le message tooltip quand il sort de la zone de texte
        private void txtCombien_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(txtCombien);
        }
    }
}
