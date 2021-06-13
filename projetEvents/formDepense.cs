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
    public partial class formDepense : Form
    {
        /*
         * Réalisé par Jad MACHKOUR
         * 
        */

        public formDepense()
        {
            InitializeComponent();
        }

        private void formDepense_Load(object sender, EventArgs e)
        {
            nbDepenses();
            surchageComboBox(cbEvenement, "Evenements", "titreEvent", "codeEvent");
            cbEvenement.SelectedIndex = -1;
            //surchageComboBoxV2(cbBeneficiaires, "Participants", "prenomPart", "nomPart");
            lblNbDepenses.Focus(); // On met le titre comme focus au depart pour éviter que la cbo aie un background bleu vu qu'il le sélectionné en premier
        }

        // Déclaration de la chaine de connexion
        private string chainconnec = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\Debug\bdd\bdEvents.mdb";


        // Déclaration de la connexion active
        OleDbConnection connec = new OleDbConnection();

        //Liaison de données - A une colonne
        private void surchageComboBox(ComboBox cbo, String table, String column, String champCache)
        {
            cbo.DataSource = formMain.ds.Tables[table]; //On charge la table dans la cbo
            cbo.DisplayMember = column; //On dit quel colonne afficher de la table dans la cbo
            cbo.ValueMember = champCache; //Pour avoir le code de la destination (utile pour l'exo 4.a)
            cbo.Text = ""; //Pour ne pas afficher le 1er element de la cbo au demarage
        }

        //Surcharge - A deux colonnes 
        public void surchageComboBoxV2(ComboBox cbo, String table, String column, String column2)
        {
            for (int i = 0; i < formMain.ds.Tables[table].Rows.Count; i++)
            {
                cbo.Items.Add(formMain.ds.Tables[table].Rows[i][column] + " " + formMain.ds.Tables[table].Rows[i][column2]);
            }
        }


        //Label qui permet de nous informer du nombre de dépense stocké dans la base
        private void nbDepenses()
        {
            lblNbDepenses.Text = "Il y a " + formMain.ds.Tables["Depenses"].Rows.Count.ToString() + " dépenses enregistrées.";
        }



        //lance le remplissage de la listeBox ave les dépenses rattaché à un évènement de la cbEvenement
        private void cbEvenement_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargementDepenses();
            lbDepenses.Visible = true;
        }


        //On va chercher les différentes dépenses liées à un évènement pour remplir la ListBox lbDepenses
        private void chargementDepenses()
        {
            lbDepenses.Items.Clear();

            for (int i = 0; i < formMain.ds.Tables["Depenses"].Rows.Count; i++)
            {
                if (cbEvenement.SelectedValue.ToString() == formMain.ds.Tables["Depenses"].Rows[i]["codeEvent"].ToString())
                {
                    lbDepenses.Items.Add(formMain.ds.Tables["Depenses"].Rows[i]["description"].ToString());
                }
            }
        }

        //procédure qui va afficher les infos d'une dépense
        private void chargementInfosDepense()
        {
            RAZinfosDepenses(); //on efface les infos d'une précédente dépense
            //connec.ConnectionString = chainconnec;
            //connec.Open();

            //string requete = "SELECT numDepense FROM Depenses WHERE codeEvent=" + cbEvenement.SelectedValue + " AND codePart=" + cbBeneficiaires.SelectedValue;
            //OleDbCommand cd = new OleDbCommand(requete, connec);
            //string numDep = (cd.ExecuteScalar()).ToString();


            for (int i = 0; i < formMain.ds.Tables["Depenses"].Rows.Count; i++)
            {
                if (formMain.ds.Tables["Depenses"].Rows[i]["description"].ToString() == lbDepenses.SelectedItem.ToString() && formMain.ds.Tables["Depenses"].Rows[i]["codeEvent"].ToString() == cbEvenement.SelectedValue.ToString())
                {
                    lblDescription.Text += formMain.ds.Tables["Depenses"].Rows[i]["description"].ToString();

                    lblMontant.Text += formMain.ds.Tables["Depenses"].Rows[i]["montant"].ToString() + "€";

                    string codePart = formMain.ds.Tables["Depenses"].Rows[i]["codePart"].ToString();
                    string nom = formMain.ds.Tables["Participants"].Rows[int.Parse(codePart) - 1]["nomPart"].ToString();
                    string prenom = formMain.ds.Tables["Participants"].Rows[int.Parse(codePart) - 1]["prenomPart"].ToString();
                    lblAcheteur.Text += prenom + " " + nom;

                    string numDepense = formMain.ds.Tables["Depenses"].Rows[i]["numDepense"].ToString();
                    string numPart = "";
                    for (int j = 0; j < formMain.ds.Tables["Beneficiaires"].Rows.Count; j++)
                    {
                        if (formMain.ds.Tables["Beneficiaires"].Rows[j]["numDepense"].ToString() == numDepense)
                        {
                            numPart = formMain.ds.Tables["Beneficiaires"].Rows[j]["codePart"].ToString();
                            lbBeneficiaires.Items.Add(formMain.ds.Tables["Participants"].Rows[int.Parse(numPart) - 1]["prenomPart"].ToString() + " " + formMain.ds.Tables["Participants"].Rows[int.Parse(numPart) - 1]["nomPart"].ToString());
                        }
                    }
                    break;
                }
            }
        }



        //procédure qui efface l'affichage des infos d'une dépense
        private void RAZinfosDepenses()
        {
            lblDescription.Text = "Description : ";
            lblMontant.Text = "Montant : ";
            lblAcheteur.Text = "Dépensé par : ";
            lbBeneficiaires.Items.Clear();
        }

        //Procédure qui met à jour les infos quand on clique sur une autre dépense
        private void lbDepenses_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbDepense.Visible = true;
            chargementInfosDepense();

            cbBeneficiaires.Visible = false;
            btnValider.Visible = false;
            btnAnnuler.Visible = false;
        }

        //Procédure qui va supprimer la dépense sélectionner
        private void btnSupprimerDep_Click(object sender, EventArgs e)
        {
            //Affichage d'un message pour confirmer ou non la suppression
            string message = "Etes-vous sûr de vouloir supprimer cette dépense ?";
            string caption = "";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);

            //On demande à l'utilisateur s'il est sûr de vouloir supprimer la dépense
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                string numDepense = "";
                for (int i = 0; i < formMain.ds.Tables["Depenses"].Rows.Count; i++)
                {
                    if (lbDepenses.SelectedItem.ToString() == formMain.ds.Tables["Depenses"].Rows[i]["description"].ToString())
                    {
                        numDepense = formMain.ds.Tables["Depenses"].Rows[i]["numDepense"].ToString();
                    }
                }

                try
                {
                    connec.ConnectionString = chainconnec;
                    connec.Open();
                    string requete = @"DELETE FROM Beneficiaires WHERE (numDepense = " + numDepense + ")";
                    OleDbCommand cd1 = new OleDbCommand(requete, connec);
                    int nbLigneDelete = cd1.ExecuteNonQuery();

                    requete = "SELECT * FROM Beneficiaires";
                    OleDbDataAdapter da = new OleDbDataAdapter(requete, connec);
                    formMain.ds.Tables["Beneficiaires"].Clear();
                    da.Fill(formMain.ds, "Beneficiaires");
                }
                catch (OleDbException ex) { MessageBox.Show("Erreur dans la requete SQL" + ex); }
                catch (InvalidOperationException) { MessageBox.Show("Erreur d'accès à la base de donnée"); }
                catch (Exception exp) { MessageBox.Show(exp.GetType().ToString()); }
                finally { connec.Close(); }

                try
                {
                    connec.ConnectionString = chainconnec;
                    connec.Open();
                    string requete = @"DELETE FROM Depenses WHERE numDepense = " + numDepense;
                    OleDbCommand cd1 = new OleDbCommand(requete, connec);
                    int nbLigneDelete = cd1.ExecuteNonQuery();

                    requete = "SELECT * FROM Depenses";
                    OleDbDataAdapter da = new OleDbDataAdapter(requete, connec);
                    formMain.ds.Tables["Depenses"].Clear();
                    da.Fill(formMain.ds, "Depenses");
                }
                catch (OleDbException ex) { MessageBox.Show("Erreur dans la requete SQL" + ex); }
                catch (InvalidOperationException) { MessageBox.Show("Erreur d'accès à la base de donnée"); }
                catch (Exception exp) { MessageBox.Show(exp.GetType().ToString()); }
                finally { connec.Close(); }

                chargementDepenses();
                if (lbDepenses.Items.Count != 0) { lbDepenses.SelectedIndex = 0; }
                else
                {
                    RAZinfosDepenses(); //On efface l'affichage des infos sur l'évènement fraichement supprimé
                }

                nbDepenses(); //On met à jour le total des dépenses stockées
            }
        }


        //Procédure qui rend visible la cbo avec les participants, et les boutons pour ajouter un bénéficiaire
        private void btnAjoutBeneficiaire_Click(object sender, EventArgs e)
        {
            if (lbBeneficiaires.Items.Count != 0)
            {
                cbBeneficiaires.Visible = true;
                btnValider.Visible = true;
                btnAnnuler.Visible = true;

                remplissagecbBeneficiaires();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            btnAnnuler.Visible = false;
            btnValider.Visible = false;
            cbBeneficiaires.Visible = false;
        }


        //Récupère le bénéficiare dans la cbo pour l'ajouter à la dépense
        private void btnValider_Click(object sender, EventArgs e)
        {
            string nom = cbBeneficiaires.Text;
            string codePart = "";
            string numDepense = "";


            for (int i = 0; i < formMain.ds.Tables["Participants"].Rows.Count; i++)
            {
                if (nom == formMain.ds.Tables["Participants"].Rows[i]["prenomPart"].ToString() + " " + formMain.ds.Tables["Participants"].Rows[i]["nomPart"].ToString())
                {
                    codePart = formMain.ds.Tables["Participants"].Rows[i]["codeParticipant"].ToString();
                }
            }

            for (int i = 0; i < formMain.ds.Tables["Depenses"].Rows.Count; i++)
            {
                if (lbDepenses.SelectedItem.ToString() == formMain.ds.Tables["Depenses"].Rows[i]["description"].ToString())
                {
                    numDepense = formMain.ds.Tables["Depenses"].Rows[i]["numDepense"].ToString();
                }
            }
            try
            {
                connec.ConnectionString = chainconnec;
                connec.Open();
                string requete = @"INSERT INTO [Beneficiaires] (numDepense, codePart)
                                    VALUES (" + numDepense + ", " + codePart + ")";
                OleDbCommand cd1 = new OleDbCommand(requete, connec);
                int nbLigneInsert = cd1.ExecuteNonQuery();

                requete = "SELECT * FROM Beneficiaires";
                OleDbDataAdapter da = new OleDbDataAdapter(requete, connec);
                formMain.ds.Tables["Beneficiaires"].Clear();
                da.Fill(formMain.ds, "Beneficiaires");
            }
            catch (OleDbException ex) { MessageBox.Show("Erreur dans la requete SQL" + ex); }
            catch (InvalidOperationException) { MessageBox.Show("Erreur d'accès à la base de donnée"); }
            catch (Exception exp) { MessageBox.Show(exp.GetType().ToString()); }
            finally { connec.Close(); }

            chargementInfosDepense(); //MAJ des infos de la dépense
            remplissagecbBeneficiaires(); //Maj de la listBox avec les bénéficiaires
            cbBeneficiaires.Text = "";
        }



        //On affiche les bénéficiaires d'une dépense dans la listBox lbBeneficiaires
        private void remplissagecbBeneficiaires()
        {
            connec.ConnectionString = chainconnec;
            connec.Open();
            //on récupère les infos des non participants à l'évènement sélectionnés
            //quand leur code ne fait pas parti de ceux qui participent à l'evenement
            string requete = @"SELECT DISTINCT codeParticipant, prenomPart, nomPart
                FROM Participants WHERE (codeParticipant IN 
                (SELECT codePart FROM Invites WHERE (codeEvent = " + cbEvenement.SelectedValue.ToString() + ")))";

            OleDbCommand cd1 = new OleDbCommand(requete, connec);
            OleDbDataReader dr = cd1.ExecuteReader();

            // On crée une table
            DataTable dt = new DataTable("datacbo");
            //on crée les colonnes
            dt.Columns.Add("codeParticipant");
            dt.Columns.Add("nomPrenom");
            //si la table existe déja on la supprime, sinon on l'ajoute au dataset
            if (!formMain.ds.Tables.Contains("datacbo"))
            {
                formMain.ds.Tables.Add(dt);
            }
            else
            {
                formMain.ds.Tables["datacbo"].Clear();
            }

            // Pour chaque participant, on ajoute dans le DataSet les infos de la personnes
            while (dr.Read())
            {
                DataRow ligne = formMain.ds.Tables["datacbo"].NewRow();

                ligne[0] = dr.GetInt32(0).ToString();
                ligne[1] = dr.GetString(1) + " " + dr.GetString(2);

                formMain.ds.Tables["datacbo"].Rows.Add(ligne);
            }

            connec.Close();
            //remplissage de la combobox par liaison de donnée
            cbBeneficiaires.DataSource = formMain.ds.Tables["datacbo"];
            cbBeneficiaires.DisplayMember = "nomPrenom";
            cbBeneficiaires.ValueMember = "codeParticipant";
            cbBeneficiaires.SelectedIndex = -1;
        }

        //Met à jour les dépenses dans listBox quand l'évènement de la cbo change
        private void cbEvenement_SelectionChangeCommitted(object sender, EventArgs e)
        {
            chargementDepenses();
            lbDepenses.Visible = true;
        }


        //On efface les infos dépenses quand on change d'évènement dans la comboBox cbEvenement 
        private void cbEvenement_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            RAZinfosDepenses();
        }
    }
}
