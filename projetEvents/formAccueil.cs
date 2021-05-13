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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public formMain(Point formLocation)
        {
            InitializeComponent();
            this.DesktopLocation = formLocation;
            //this.StartPosition = FormStartPosition.CenterParent;
        }

        // Déclaration de la chaine de connexion
        string chainconnec = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bdEvents.MDB";

        // Création d'un DataSet
        private DataSet ds = new DataSet();

        // Déclaration de la connexion active
        OleDbConnection connec = new OleDbConnection();

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

            // Liaison de données - ComboBox Evenement 
            surchageComboBox(cboEvenements, "Evenements","titreEvent", "codeEvent");

            // Surcharge ComboBox - ComboBox Participants avec deux colonnes
            surchageComboBoxV2(cboPayePar, "Participants", "prenomPart", "nomPart");

            // Affichage de tous les bénéficiaires dans la CheckedListBox
            affichageBeneficiaire();

            // On charge le UserControl
            userControlEvenementClick();
            userControlBarreActuelle(this, 1); // Comme on est sur le formAccueil, l'index btn du menu Accueil = 1

            // Design reglage
            designAffichage();
        }

        private void affichageBeneficiaire()
        {
            for(int i=0; i< ds.Tables["Participants"].Rows.Count; i++)
            {
                clbListeBeneficiaire.Items.Add(ds.Tables["Participants"].Rows[i]["prenomPart"] + " " + ds.Tables["Participants"].Rows[i]["nomPart"]);
            }
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
        }

        //
        // TOUTES LES METHODES UTILISER QUAND ON CLIQUE SUR LE BTN VALIDER
        //

        private Boolean verficationRemplissage()
        {
            Boolean remplissageCorrect;
            int nombreErreur = 6;

            // Vérification de la ComboBox Evènements
            if (String.IsNullOrEmpty(cboEvenements.Text))
            {
                errorProvider.SetError(cboEvenements, "Veuillez sélectionner un évènement.");
                nombreErreur++;
            }
            else
            {
                errorProvider.SetError(cboEvenements, "");
                nombreErreur--;
            }

            // Vérification de la TextBox "Quoi"
            if (String.IsNullOrEmpty(txtQuoi.Text))
            {
                errorProvider.SetError(txtQuoi, "Veuillez sélectionner un motif d'évènements.");
                nombreErreur++;
            }
            else
            {
                errorProvider.SetError(txtQuoi, "");
                nombreErreur--;
            }

            // Vérification de la TextBox "Combien"
            if (String.IsNullOrEmpty(txtCombien.Text))
            {
                errorProvider.SetError(txtCombien, "Veuillez sélectionner le montant de la dépense.");
                nombreErreur++;
            }
            else
            {
                errorProvider.SetError(txtCombien, "");
                nombreErreur--;
            }

            // Vérification de la ComboBox Payé Par
            if (String.IsNullOrEmpty(cboPayePar.Text))
            {
                errorProvider.SetError(cboPayePar, "Veuillez sélectionner un évènement.");
                nombreErreur++;
            }
            else
            {
                errorProvider.SetError(cboPayePar, "");
                nombreErreur--;
            }

            // Vérification de la CheckedListBox
            if (clbListeBeneficiaire.CheckedItems.Count < 1)
            {
                errorProvider.SetError(clbListeBeneficiaire, "Veuillez au moins sélectionner un bénéficiaire.");
                nombreErreur++;
            }
            else
            {
                errorProvider.SetError(clbListeBeneficiaire, "");
                nombreErreur--;
            }

            // Vérification de la RichTextBox "Commentaire"
            if (String.IsNullOrEmpty(rtbCommentaire.Text))
            {
                errorProvider.SetError(rtbCommentaire, "Veuillez écrire un commentaire concernant la dépense.");
                nombreErreur++;
            }
            else
            {
                errorProvider.SetError(rtbCommentaire, "");
                nombreErreur--;
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

        OleDbTransaction transacDepense;

        private void Valider_Click(object sender, EventArgs e)
        {
            // On va vérifier que l'utilisateur a bien tout remplit
            Boolean remplissageComplet = verficationRemplissage();
            saisieDepense();
            //if (remplissageComplet)
            //{
            //    saisieDepense();
            //}
        } 

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
                string requete = 
                    @"Insert into Depenses (numDepense, description, montant, dateDepense, commentaire, codeEvent, codePart) Values('"
                     + numeroDepense + "', '" + description + "', '" + montant  + "', '" + dateDepense + "', '"
                     + commentaire + "', '" + codeEvents + "', '" + codePart + "')";
                //MessageBox.Show(requete);
                OleDbCommand cmd = new OleDbCommand(requete, connec);
                int nbLigneInsert = cmd.ExecuteNonQuery();
                MessageBox.Show("Ajout d'une dépense : " + nbLigneInsert.ToString() + " ligne inséré.");
            }
            catch (OleDbException)
            {
                MessageBox.Show("Erreur dans la requete SQL");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Erreur d'acces à la base de donnée");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.GetType().ToString());
                transacDepense.Rollback();
                MessageBox.Show("Transaction annulée");
            }

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
                foreach (string codeBenef in codePartBenefciaire)
                {
                    connec.ConnectionString = chainconnec;
                    connec.Open();
                    string requete =
                    @"Insert into Beneficiaires (numDepense, codePart) Values('"
                     + numeroDepense + "', '" + codeBenef + "')";
                    //MessageBox.Show(requete);
                    OleDbCommand cmd = new OleDbCommand(requete, connec);
                    int nbLigneInsert = cmd.ExecuteNonQuery();
                    MessageBox.Show("Ajout d'un participant de la dépense : " + nbLigneInsert.ToString() + " ligne inséré.");
                }
            }
            catch (OleDbException)
            {
                MessageBox.Show("Erreur dans la requete SQL");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Erreur d'acces à la base de donnée");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.GetType().ToString());
            }
            finally
            {
                connec.Close();
            }
        }

        private string  numDepense()
        {
            connec.ConnectionString = chainconnec;
            connec.Open();

            // On affiche le nbr max de commande et ajoute + 1
            OleDbCommand cmd = new OleDbCommand("Select Max([numDepense]) from Depenses", connec);
            string numeroDepense = ((int)cmd.ExecuteScalar() + 1).ToString();
            connec.Close();
            return numeroDepense;
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            
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
                }
            }
        }

        // On va recuperer le userControl et mettre une barre sur le btn où on se trouve actuellement
        public static void userControlBarreActuelle(Form form,int numTagBouton)
        {
            foreach (Control a in form.Controls)
            {
                if (a is uControlMenu.userControlMenu)
                {
                    uControlMenu.userControlMenu a1 = (uControlMenu.userControlMenu)a; 
                    
                    // On va s'occuper de mettre une petite barre sur le form où on est actuellement
                    foreach(Control b in a1.Controls)
                    {
                        if (b is Panel)
                        {
                            Panel p = (Panel)b;
                            int indexPanel = Convert.ToInt32(p.Tag);
                            if (indexPanel == 1) // La petite barre a un Tag de 1, donc on le repère comme ca
                            {
                                foreach (Control c in a1.Controls)
                                {
                                    if (c is Button) // On va regarder les bouttons pour savoir sur les 5 btn sur lequel on doit mettre la barre
                                    {
                                        Button btn = (Button)c;
                                        int indexTag = Convert.ToInt32(btn.Tag);
                                        if (indexTag == numTagBouton)
                                        {
                                            p.Height = btn.Height;
                                            p.Top = btn.Top;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEvenements_Click(object sender, EventArgs e)
        {
            formEvenements formEvenements = new formEvenements(this.DesktopLocation);
            formEvenements.Show();
            this.Visible = false;
            this.Hide();
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
            formBilan formBilan = new formBilan();
            formBilan.ShowDialog();
            this.Hide();
        }

        private void designAffichage()
        {
            rtbCommentaire.SelectAll();
            rtbCommentaire.SelectionIndent += 15;//play with this values to match yours
            rtbCommentaire.SelectionRightIndent += 15;//this too
            rtbCommentaire.SelectionLength = 0;
        }

        // Accesseur permettant de transférer un DataSet aux autres formulaires
        //public static DataSet transfertDataSet
        //{
        //    get 
        //    {
        //        return ds;
        //    }
        //    set
        //    {
        //        ds = value;
        //    }
        //}

    }
}
