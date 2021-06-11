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
using System.IO;

namespace projetEvents
{
    public partial class formBilan : Form
    {

        public formBilan()
        {
            InitializeComponent();
        }

        // Déclaration de la chaine de connexion
        private string chainconnec = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\Debug\bdd\bdEvents.mdb";

        // Déclaration de la connexion active
        OleDbConnection connec = new OleDbConnection();

        //Liaison de données - A une colonne
        private void surchageComboBox(ComboBox cbo, String table, String column, String champCache)
        {
            cbo.DataSource = formMain.ds.Tables[table]; // On charge la table dans la cbo
            cbo.DisplayMember = column; // On dit quel colonne afficher de la table dans la cbo
            cbo.ValueMember = champCache; // Pour avoir le code de la destination (utile pour l'exo 4.a)
            cbo.Text = ""; // Pour ne pas afficher le 1er element de la cbo au demarage
        }

        private void formBilan_Load(object sender, EventArgs e)
        {
            // Liaison de données - ComboBox Evenement 
            surchageComboBox(cboEvent, "Evenements", "titreEvent", "codeEvent");
            cboEvent.SelectedIndex = -1;
            lblMessageBilan.Visible = true;
            lblMessageBilan.Text = "Veuillez d'abord sélectionner un évènement.";
        }

        // Des qu'on change l'évènement dans la cbo, on change les participants de la combobocParticipants
        private void cboEvent_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pnlRecapPart.Visible = false;
            dgvBilanEvent.Visible = true;
            lblMessageBilan.Visible = false;
            lblTotalDepense.Text = "Total =";
            lblDepenseConcerne.Text = "Total =";

            connec.ConnectionString = chainconnec;
            connec.Open();

            // On cherche pour un évènement choisis, tous les participants qui ont était invité a cette evenements
            string requete = @"SELECT p.codeParticipant, p.prenomPart, p.nomPart, p.nbParts FROM Invites i INNER JOIN Participants p ON i.codePart=p.codeParticipant WHERE codeEvent=" + cboEvent.SelectedValue;
            OleDbCommand cd1 = new OleDbCommand(requete, connec);
            OleDbDataReader dr = cd1.ExecuteReader();

            // On ajoute une table
            if (!formMain.ds.Tables.Contains("participantsOnEvent"))
            {
                DataTable dt = new DataTable("participantsOnEvent");
                dt.Columns.Add("codeParticipant");
                dt.Columns.Add("nomPrenom");
                dt.Columns.Add("nbParts");
                formMain.ds.Tables.Add(dt);
            }
            else
            {
                formMain.ds.Tables["participantsOnEvent"].Clear();
            }

            // Pour chaque participant, on ajoute dans le DataSet les infos de la personnes
            while (dr.Read())
            {
                DataRow ligne = formMain.ds.Tables["participantsOnEvent"].NewRow();
                ligne[0] = dr.GetInt32(0).ToString();
                ligne[1] = dr.GetString(1) + " " + dr.GetString(2);
                ligne[2] = dr.GetInt32(3).ToString();
                formMain.ds.Tables["participantsOnEvent"].Rows.Add(ligne);
            }
            connec.Close();

            surchageComboBox(cboParticipant, "participantsOnEvent", "nomPrenom", "codeParticipant"); // On s'occupe de la liaison de données
            cboParticipant.Visible = true;
            lblPart.Visible = true;
            cboParticipant.SelectedIndex = -1;

            creationTableBilan(); // On dresse la table Bilan qui sert a s'occuper du Bilan avec le solde de chaque personne
            if (totalSoldeNull() == 0)
            {
                recapitulatifRTB();
                rtbRecap.Visible = true;
                lblSolderEvent.Visible = false;
                btnQuiDoitQuoiQui.Visible = false;
            } else
            {
                btnQuiDoitQuoiQui.Visible = true;
                rtbRecap.Visible = false;
                lblSolderEvent.Visible = true;
            }
        }

        // Pour dresser le bilan de ce qu'un participant à dépensé et ce qu'il doit remboruser
        private void cboParticipant_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pnlRecapPart.Visible = true;
            // On récupere les données des deux ComboBox
            string numEvent = cboEvent.SelectedValue.ToString();
            string codeParticipant = cboParticipant.SelectedValue.ToString();

            // Ce que j'ai dépensé - Procédures stockés MesDepenses
            dgvMesDepenses.DataSource = "";
            lblTotalDepense.Text = "Total = ";

            // On vérifie que la table n'existe pas déjà
            if (formMain.ds.Tables.Contains("mesDepenses"))
            {
                formMain.ds.Tables.Remove("mesDepenses");
            }

            // On cherche la procédure stockée
            connec.Open();
            OleDbCommand cd1 = new OleDbCommand();
            cd1.Connection = connec;
            cd1.CommandType = CommandType.StoredProcedure;
            cd1.CommandText = "MesDepenses";

            // Créations des paramètres - pEvent : n° de l’événement
            OleDbParameter paramValeur = new OleDbParameter();
            paramValeur.ParameterName = "@val";
            paramValeur.OleDbType = OleDbType.VarChar;
            paramValeur.Direction = ParameterDirection.Input;
            paramValeur.Value = numEvent;

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
            da.Fill(formMain.ds, "mesDepenses");

            // On change le nom des tables pour un meilleure affichage
            formMain.ds.Tables["mesDepenses"].Columns[0].ColumnName = "Numéro dépense";
            formMain.ds.Tables["mesDepenses"].Columns[1].ColumnName = "Date de la dépense";
            formMain.ds.Tables["mesDepenses"].Columns[2].ColumnName = "Description";
            formMain.ds.Tables["mesDepenses"].Columns[3].ColumnName = "Montant";

            dgvMesDepenses.DataSource = formMain.ds.Tables["mesDepenses"];

            // On additione tout les montants de chaque dépense pour faire une somme total de ce qu'il a dépensé
            double totalDepense = 0;
            for (int i = 0; i < formMain.ds.Tables["mesDepenses"].Rows.Count; i++)
            {
                totalDepense += double.Parse(formMain.ds.Tables["mesDepenses"].Rows[i]["Montant"].ToString());
            }

            lblTotalDepense.Text += String.Format("{0:0.00}", totalDepense) + "€";


            // Ce que je dois rembourser - Procédures stockés DepensesQuiMeConcernent
            dgvDepenseConcerme.DataSource = "";
            lblDepenseConcerne.Text = "Total = ";

            // On vérifie que la table n'existe pas déjà
            if (formMain.ds.Tables.Contains("mesDepensesConcerne"))
            {
                formMain.ds.Tables.Remove("mesDepensesConcerne");
            }

            // On cherche la procédure stockée
            OleDbCommand cd2 = new OleDbCommand();
            cd2.Connection = connec;
            cd2.CommandType = CommandType.StoredProcedure;
            cd2.CommandText = "DepensesQuiMeConcernent";

            // Créations des paramètres - pEvent : n° de l’événement
            OleDbParameter paramValeur3 = new OleDbParameter();
            paramValeur3.ParameterName = "@val";
            paramValeur3.OleDbType = OleDbType.VarChar;
            paramValeur3.Direction = ParameterDirection.Input;
            paramValeur3.Value = numEvent;

            // Créations des paramètres - pPart : code du participant
            OleDbParameter paramValeur4 = new OleDbParameter();
            paramValeur4.ParameterName = "@val";
            paramValeur4.OleDbType = OleDbType.VarChar;
            paramValeur4.Direction = ParameterDirection.Input;
            paramValeur4.Value = codeParticipant;

            // Ajout des parametres à l'objet Command
            cd2.Parameters.Add(paramValeur3);
            cd2.Parameters.Add(paramValeur4);

            OleDbDataAdapter da2 = new OleDbDataAdapter(cd2);
            da2.Fill(formMain.ds, "mesDepensesConcerne");

            // On va ajouter dans la table la description de la dépense
            formMain.ds.Tables["mesDepensesConcerne"].Columns.Add("Description", typeof(string));
            for (int i = 0; i < formMain.ds.Tables["mesDepensesConcerne"].Rows.Count; i++)
            {
                string requete = "SELECT description FROM Depenses " +
                    " WHERE numDepense=" + formMain.ds.Tables["mesDepensesConcerne"].Rows[i]["numDepense"];
                OleDbCommand cd3 = new OleDbCommand(requete, connec);
                string res = cd3.ExecuteScalar().ToString();
                formMain.ds.Tables["mesDepensesConcerne"].Rows[i]["Description"] = res;
            }
            connec.Close();


            // On change le nom des tables pour un meilleure affichage
            formMain.ds.Tables["mesDepensesConcerne"].Columns[0].ColumnName = "Numéro dépense";
            formMain.ds.Tables["mesDepensesConcerne"].Columns[1].ColumnName = "Montant";
            formMain.ds.Tables["mesDepensesConcerne"].Columns[2].ColumnName = "Nombre de parts";
            formMain.ds.Tables["mesDepensesConcerne"].Columns[3].ColumnName = "Description";

            // On affiche la table dans la GDV
            dgvDepenseConcerme.DataSource = formMain.ds.Tables["mesDepensesConcerne"];

            // On additione tout les montants de chaque dépense pour faire une somme total de ce qu'il doit rembourser
            int nbPart = 0;
            // On va cherche dans la BDD son nombre de parts
            for(int i=0; i< formMain.ds.Tables["Participants"].Rows.Count; i++)
            {
                if(formMain.ds.Tables["Participants"].Rows[i]["codeParticipant"].ToString() == cboParticipant.SelectedValue.ToString())
                {
                    nbPart = int.Parse(formMain.ds.Tables["Participants"].Rows[i]["nbParts"].ToString());
                }
            }

            double calculRefund = 0;
            for (int i = 0; i < formMain.ds.Tables["mesDepensesConcerne"].Rows.Count; i++)
            {
                double montant = double.Parse(formMain.ds.Tables["mesDepensesConcerne"].Rows[i]["Montant"].ToString());
                int somme = int.Parse(formMain.ds.Tables["mesDepensesConcerne"].Rows[i]["Nombre de parts"].ToString());
                calculRefund += (montant / somme) * nbPart;
            }

            lblDepenseConcerne.Text += String.Format("{0:0.00}", calculRefund)  + "€";
        }

        // On crée la table Bilan de l'évènement avec tous les participants qui y figurent
        private void creationTableBilan()
        {
            // On crée une nouvelle table dans le DataSet
            if (!formMain.ds.Tables.Contains("dtBilan"))
            {
                DataTable dt = new DataTable("dtBilan");
                dt.Columns.Add("CodeParticipant");
                dt.Columns.Add("Personne");
                dt.Columns.Add("Plus");
                dt.Columns.Add("Moins");
                dt.Columns.Add("Solde");
                formMain.ds.Tables.Add(dt);
            }
            else
            {
                formMain.ds.Tables["dtBilan"].Clear();
            }

            // Pour chaque participant, on ajoute les différentes lignes avec le solde, le + et - en fonction des dépenses
            for (int i = 0; i < formMain.ds.Tables["participantsOnEvent"].Rows.Count; i++)
            {
                connec.ConnectionString = chainconnec;
                connec.Open();
                DataRow ligne = formMain.ds.Tables["dtBilan"].NewRow();

                // Ligne 0 - CodeParticipant
                string codeParticipant = formMain.ds.Tables["participantsOnEvent"].Rows[i]["codeParticipant"].ToString();
                ligne[0] = codeParticipant;

                // Ligne 1 - Personne
                ligne[1] = formMain.ds.Tables["participantsOnEvent"].Rows[i]["nomPrenom"].ToString();

                // Ligne 2 - Plus - Procédure stockés dépenses crédit
                // On cherche la procédure stockée DepensesCredit
                connec.Close();
                double depCredit = rechercheDepensesCreditDebit(codeParticipant, "mesDepenses");
                ligne[2] = depCredit.ToString();

                // Ligne 3 - Moins - Procédures stockés dépenses débit 
                double depDebit = rechercheDepensesCreditDebit(codeParticipant, "DepensesQuiMeConcernent");
                depDebit = Convert.ToDouble(String.Format("{0:0.00}", depDebit)); // On met 2 chiffres après la virgule
                ligne[3] = depDebit.ToString();

                // Ligne 4 - Solde : Credit-Débit
                double solde = depCredit - depDebit;
                if (rechercheDejaSolde() == true) // Si c'est deja soldé, on met le solde à 0.
                {
                    ligne[4] = 0;
                }
                else
                {
                    ligne[4] = solde.ToString();
                }

                formMain.ds.Tables["dtBilan"].Rows.Add(ligne);
            }

            dgvBilanEvent.DataSource = formMain.ds.Tables["dtBilan"];
        }

        // On recherche pour la colonne "plus" et "moins" de la table Bilan, en surchargant le constructeur
        // soit le débit ou le crédit de tous les dépenses éfféctués
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
                paramValeur.Value = cboEvent.SelectedValue;

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

        // On regarde si l'évenement est déja soldé
        private bool rechercheDejaSolde()
        {
            connec.ConnectionString = chainconnec;
            connec.Open();
            string requete = @"SELECT soldeON FROM Evenements WHERE codeEvent=" + cboEvent.SelectedValue;
            OleDbCommand cd = new OleDbCommand(requete, connec);
            bool res = (bool)cd.ExecuteScalar();
            connec.Close();
            return res;
        }

        // Quand on clique sur Qui-doit-Quoi, on va mettre tous les soldes à 0.
        private void btnQuiDoitQuoiQui_Click(object sender, EventArgs e)
        {
            int codeEvent = 0;
            if (rechercheDejaSolde() == false)
            {
                double totalSolde = totalSoldeNull(); // On regarde la somme total des soldes de chaque participant
                int partDonneur;
                int partReceveur;
                double minSolde;
                double maxSolde;
                double resultat;

                while (totalSolde != 0) // Tant que les soldes de chaque participant n'est pas égale à 0, on continue la boucle
                {
                    partDonneur = chercheDonneur(); // On cherche le code Participant du donneur
                    partReceveur = chercheReceveur(); // On cherche le code Participant du receveur

                    minSolde = chercheDonneurSolde(partDonneur); // On récupere le solde du donneur
                    maxSolde = chercheReceveurSolde(partReceveur); // On récupere le solde du receveur

                    minSolde = Convert.ToDouble(String.Format("{0:0.00}", minSolde));
                    maxSolde = Convert.ToDouble(String.Format("{0:0.00}", maxSolde));

                    resultat = (minSolde) + (maxSolde);
                    resultat = Convert.ToDouble(String.Format("{0:0.0}", resultat));
                    codeEvent = (int)cboEvent.SelectedValue;

                    // Si le solde du donneur est supérieur en valeur absolue à celui du receveur
                    if (Math.Abs(minSolde) > Math.Abs(maxSolde)) // donneur>receveur (valeur absolue)
                    {
                        for (int i = 0; i < formMain.ds.Tables["dtBilan"].Rows.Count; i++)
                        {
                            if (partDonneur == int.Parse(formMain.ds.Tables["dtBilan"].Rows[i]["CodeParticipant"].ToString()))
                            {
                                // Donneur = argent receveur + donneur
                                formMain.ds.Tables["dtBilan"].Rows[i]["Solde"] = resultat;
                            }
                            if (partReceveur == int.Parse(formMain.ds.Tables["dtBilan"].Rows[i]["CodeParticipant"].ToString()))
                            {
                                // Receveur = 0
                                formMain.ds.Tables["dtBilan"].Rows[i]["Solde"] = 0;
                            }
                        }

                        // On va mettre a jour la table BilanPart
                        ajoutNewRowBilan(codeEvent, partDonneur, partReceveur, Math.Abs(maxSolde));
                    }
                    else
                    {
                        for (int i = 0; i < formMain.ds.Tables["dtBilan"].Rows.Count; i++)
                        {
                            if (partDonneur == int.Parse(formMain.ds.Tables["dtBilan"].Rows[i]["CodeParticipant"].ToString()))
                            {
                                // Donneur = 0
                                formMain.ds.Tables["dtBilan"].Rows[i]["Solde"] = 0;
                            }
                            if (partReceveur == int.Parse(formMain.ds.Tables["dtBilan"].Rows[i]["CodeParticipant"].ToString()))
                            {
                                // Receveur = argent receveur + donneur
                                formMain.ds.Tables["dtBilan"].Rows[i]["Solde"] = resultat;
                            }
                        }

                        ajoutNewRowBilan(codeEvent, partDonneur, partReceveur, Math.Abs(minSolde));
                    }

                    totalSolde = totalSoldeNull(); // Si le totalSolde != 0, on continue la boucle, sinon on arrete
                    totalSolde = Convert.ToDouble(String.Format("{0:0.00}", totalSolde));
                }
                // Si tous les soldes sont nulle, on va mettre l'évènement en question comme Soldé, donc on n'y touchera plus
                if (totalSoldeNull() == 0)
                {
                    // On affiche dans une rich text box, le récapitulatif du bilan Qui Doit Quoi à Qui
                    recapitulatifRTB();

                    // On récupère les élements sélectionner dans la cbo car en actualisant le DS, la liaison de donnés va se re-actualiser donc on l'user va perdre l'event qu'il a selec
                    int indexEvent = cboEvent.SelectedIndex;
                    int indexPart = -1;
                    if(cboParticipant.SelectedIndex>=0)
                    {
                        indexPart = cboParticipant.SelectedIndex;
                    }

                    connec.ConnectionString = chainconnec;
                    connec.Open();
                    string requete = @"UPDATE Evenements SET soldeON = true WHERE codeEvent=" + codeEvent.ToString();
                    OleDbCommand cd = new OleDbCommand(requete, connec);
                    cd.ExecuteNonQuery();

                    // On Update le DataSet après la modif
                    string rqt = "SELECT * FROM Evenements";
                    OleDbDataAdapter da = new OleDbDataAdapter(rqt, connec);
                    formMain.ds.Tables["Evenements"].Clear();
                    da.Fill(formMain.ds, "Evenements");
                    connec.Close();

                    // On remet la sélection initial de l'utilisateur vu qu'on a re-start la liaison de données.
                    cboEvent.SelectedIndex = indexEvent;
                    cboParticipant.SelectedIndex = indexPart;

                    lblSolderEvent.Visible = false;
                    btnQuiDoitQuoiQui.Visible = false;
                    rtbRecap.Visible = true;
                }
            } else
            {
                // On affiche dans une rich text box, le récapitulatif du bilan Qui Doit Quoi à Qui
                rtbRecap.Visible = true;
                recapitulatifRTB();
            }
        }

        // On calcul la somme total des soldes de tous les participants, pour voir si continue de calculer le solde donneur et receveur
        private double totalSoldeNull()
        {
            double soldeTotal = 0;
            double soldeCourant;
            for (int i = 0; i < formMain.ds.Tables["dtBilan"].Rows.Count; i++)
            {
                soldeCourant = double.Parse(formMain.ds.Tables["dtBilan"].Rows[i]["Solde"].ToString());
                soldeCourant = Math.Abs(soldeCourant); // On prend sa valeur absolue
                soldeCourant = Convert.ToDouble(String.Format("{0:0.00}", soldeCourant));
                soldeTotal += soldeCourant;
                soldeTotal = Convert.ToDouble(String.Format("{0:0.00}", soldeTotal));
            }
            return soldeTotal;
        }

        // On recherche le Code Participant du donneur en fonction du solde le plus petit
        private int chercheDonneur()
        {
            double minSolde = double.Parse(formMain.ds.Tables["dtBilan"].Rows[0]["Solde"].ToString());
            int codePartcipant = int.Parse(formMain.ds.Tables["dtBilan"].Rows[0]["CodeParticipant"].ToString());
            double soldeCourant;

            for (int i = 0; i < formMain.ds.Tables["dtBilan"].Rows.Count; i++)
            {
                soldeCourant = double.Parse(formMain.ds.Tables["dtBilan"].Rows[i]["Solde"].ToString());
                if (soldeCourant < minSolde && soldeCourant != 0)
                {
                    minSolde = soldeCourant;
                    codePartcipant = int.Parse(formMain.ds.Tables["dtBilan"].Rows[i]["CodeParticipant"].ToString());
                }
            }
            return codePartcipant;
        }

        // On recherche le solde du donneur en question
        private double chercheDonneurSolde(int codeDonneur)
        {
            double soldeCourant = 0;

            for (int i = 0; i < formMain.ds.Tables["dtBilan"].Rows.Count; i++)
            {
                if (codeDonneur == int.Parse(formMain.ds.Tables["dtBilan"].Rows[i]["CodeParticipant"].ToString()))
                {
                    soldeCourant = double.Parse(formMain.ds.Tables["dtBilan"].Rows[i]["Solde"].ToString());
                }
            }
            return soldeCourant;
        }

        // On recherche le Code Participant du receveur en fonction du solde le plus grand
        private int chercheReceveur()
        {
            double maxSolde = double.Parse(formMain.ds.Tables["dtBilan"].Rows[0]["Solde"].ToString());
            int codePartcipant = int.Parse(formMain.ds.Tables["dtBilan"].Rows[0]["CodeParticipant"].ToString());
            double soldeCourant;

            for (int i = 0; i < formMain.ds.Tables["dtBilan"].Rows.Count; i++)
            {
                soldeCourant = double.Parse(formMain.ds.Tables["dtBilan"].Rows[i]["Solde"].ToString());
                if (soldeCourant > maxSolde && soldeCourant != 0)
                {
                    maxSolde = soldeCourant;
                    codePartcipant = int.Parse(formMain.ds.Tables["dtBilan"].Rows[i]["CodeParticipant"].ToString());
                }
            }
            return codePartcipant;
        }

        // On recherche le solde du receveur en question
        private double chercheReceveurSolde(int codeReceveur)
        {
            double soldeCourant = 0;

            for (int i = 0; i < formMain.ds.Tables["dtBilan"].Rows.Count; i++)
            {
                if (codeReceveur == int.Parse(formMain.ds.Tables["dtBilan"].Rows[i]["CodeParticipant"].ToString()))
                {
                    soldeCourant = double.Parse(formMain.ds.Tables["dtBilan"].Rows[i]["Solde"].ToString());
                }
            }
            return soldeCourant;
        }

        // On va écrire qui doit quoi à qui dans une rich text box
        private void recapitulatifRTB()
        {
            rtbRecap.Text = "";
            string donneurCode;
            string receveurCode;
            string montant;
            string donneurName;
            string receveurName;

            rtbRecap.Text = "\n-------------------------- QUI DOIT QUOI - À QUI --------------------------\n";

            connec.ConnectionString = chainconnec;
            connec.Open();
            for (int i = 0; i < formMain.ds.Tables["BilanPart"].Rows.Count; i++)
            {
                // On affiche seulement les résultats dans la RTB qui doit quoi à qui de l'évenement en question
                if(formMain.ds.Tables["BilanPart"].Rows[i]["codeEvent"].ToString() == cboEvent.SelectedValue.ToString())
                {
                    // On prend le Prénom et Nom du donneur
                    donneurCode = formMain.ds.Tables["BilanPart"].Rows[i]["codeDonneur"].ToString();
                    donneurName = "SELECT prenomPart, nomPart FROM Participants WHERE codeParticipant = " + donneurCode;

                    OleDbCommand cd1 = new OleDbCommand(donneurName, connec);
                    OleDbDataReader dr1 = cd1.ExecuteReader();
                    while (dr1.Read())
                    {
                        donneurName = dr1.GetString(0) + " " + dr1.GetString(1);
                    }

                    // On prend le Prénom et Nom du receveur
                    receveurCode = formMain.ds.Tables["BilanPart"].Rows[i]["codeReceveur"].ToString();
                    receveurName = "SELECT prenomPart, nomPart FROM Participants WHERE codeParticipant = " + receveurCode;

                    OleDbCommand cd2 = new OleDbCommand(receveurName, connec);
                    OleDbDataReader dr2 = cd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        receveurName = dr2.GetString(0) + " " + dr2.GetString(1);
                    }

                    // On prend le montant que le donneur doit au receveur
                    montant = formMain.ds.Tables["BilanPart"].Rows[i]["Montant"].ToString();

                    rtbRecap.Text += "\n" + donneurName + " doit " + montant + "€ à " + receveurName;
                }
            }
            rtbRecap.Text += "\n\n-----------------------------------------------------------------------------------\n";
            connec.Close();

            // On aligne tout au milieu
            rtbRecap.SelectAll();
            rtbRecap.SelectionAlignment = HorizontalAlignment.Center;
            rtbRecap.DeselectAll();
        }

        private void ajoutNewRowBilan(int codeEvent, int codeDonneur, int codeReceveur, double montant)
        {
            if (!verificationDoublon(codeEvent.ToString(), codeDonneur.ToString(), codeReceveur.ToString()) && montant != 0)
            {
                try
                {
                    connec.ConnectionString = chainconnec;
                    connec.Open();
                    string requete = @"INSERT INTO [BilanPart] (codeEvent, codeDonneur, codeReceveur, montant) VALUES(" +
                       codeEvent + ", " + codeDonneur + ", " + codeReceveur + ", '" + montant + "')";
                    OleDbCommand cd1 = new OleDbCommand(requete, connec);
                    int nbLigneInsert = cd1.ExecuteNonQuery();

                    requete = "SELECT * FROM BilanPart";
                    OleDbDataAdapter da = new OleDbDataAdapter(requete, connec);
                    formMain.ds.Tables["BilanPart"].Clear();
                    da.Fill(formMain.ds, "BilanPart");
                }
                catch (OleDbException ex) { MessageBox.Show("Erreur dans la requete SQL" + ex); }
                catch (InvalidOperationException) { MessageBox.Show("Erreur d'acces à la base de donnée"); }
                catch (Exception exp) { MessageBox.Show(exp.GetType().ToString()); }
                finally { connec.Close(); }
            }
        }

        // On s'assure qu'on n'insert pas de doublons dans la BDD
        public bool verificationDoublon(string codeEvent, string codeDonneur, string codeReceveur)
        {
            for (int i = 0; i < formMain.ds.Tables["BilanPart"].Rows.Count; i++)
            {
                bool un = formMain.ds.Tables["BilanPart"].Rows[i]["codeEvent"].ToString() == codeEvent;
                bool deux = formMain.ds.Tables["BilanPart"].Rows[i]["codeDonneur"].ToString() == codeDonneur;
                bool trois = formMain.ds.Tables["BilanPart"].Rows[i]["codeReceveur"].ToString() == codeReceveur;
                if (un && deux && trois)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnGeneratePDF_Click(object sender, EventArgs e)
        {
            // Demander à l'utilisateur de choisir l'endroit où il veut créer son document
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Save file as...";
            dialog.Filter = "PDF files (*.pdf)|*.pdf";
            dialog.FileName = "Bilan_" + formMain.ds.Tables["Evenements"].Rows[cboEvent.SelectedIndex]["titreEvent"].ToString() + "_" + formMain.ds.Tables["participantsOnEvent"].Rows[cboParticipant.SelectedIndex]["nomPrenom"].ToString();
            dialog.RestoreDirectory = true;
            string path = "";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path = Path.GetFullPath(dialog.FileName);
            }

            var htmlContent = new StringBuilder();

            htmlContent.Append(
                @"<!DOCTYPE html>
                <html lang=""fr"">
                <head> 
                    <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8""/>
                    <style>
                        table, th, td {
                        padding: 10px;
                        border: 1px solid black;
                        border-collapse: collapse;
                        margin: auto;
                        }
                     *{
                       font-family: Montserrat, sans-serif;
                     .tableCenter {
                          margin: auto;
                        }
                    td {
                      text-align: center;
                      vertical-align: middle;
                    }
                    table {
                      margin: auto;
                      width: 90%;
                    }
                   </style>
                </head>
                <body>");

            htmlContent.Append(
                @"<h1>Récapitulatif de l'évènement : " + formMain.ds.Tables["Evenements"].Rows[cboEvent.SelectedIndex]["titreEvent"] + " </h1>" +
                " <p> Date de début: " + formMain.ds.Tables["Evenements"].Rows[cboEvent.SelectedIndex]["dateDebut"] + " </p>" +
                " <p> Date de fin: " + formMain.ds.Tables["Evenements"].Rows[cboEvent.SelectedIndex]["dateFin"] + " </p>"
                );

            htmlContent.Append(
                @"<h2>Récapitulatif du participant </h2>" +
                " <p> Nom - Prénom : " + formMain.ds.Tables["participantsOnEvent"].Rows[cboParticipant.SelectedIndex]["nomPrenom"] + " </p>" +
                " <p> Nombre de parts : " + formMain.ds.Tables["participantsOnEvent"].Rows[cboEvent.SelectedIndex]["nbParts"] + " </p>"
                );

            // Dépenses effectuées par RICHARD

            htmlContent.Append(
                @"<ul><li><h3>Les dépenses effectuées par : " + formMain.ds.Tables["participantsOnEvent"].Rows[cboParticipant.SelectedIndex]["nomPrenom"] + @" </h3></ul></li>
                 <table class=""tableCenter"" style=""text-align:center;"">
                       <thead>
                        <tr>
                            <th>Description</th>
                            <th>Montant</th>
                        </tr>
                    </thead>
                    <tbody>");

            for (int i = 0; i < formMain.ds.Tables["mesDepenses"].Rows.Count; i++)
            {
                htmlContent.Append(
                @"<tr>
                    <td>" + formMain.ds.Tables["mesDepenses"].Rows[i]["description"] + @"</td>
                    <td>" + formMain.ds.Tables["mesDepenses"].Rows[i]["montant"] + @"€</td>
                 </tr>"
                );
            }

            htmlContent.Append(
             @"</tbody>
                </table><br>"
             );

            // Dépenses dont a bénéficier RICHARD

            htmlContent.Append(
                @"<ul><li><h3>Les dépenses dont a bénéficiées : " + formMain.ds.Tables["participantsOnEvent"].Rows[cboParticipant.SelectedIndex]["nomPrenom"] + @" </h3></li></ul>
                 <table class=""tableCenter"" style=""text-align:center;"">
                    <thead>
                        <tr>
                            <th>Description</th>
                            <th>Montant</th>
                        </tr>
                    </thead>
                    <tbody>");

            for (int i = 0; i < formMain.ds.Tables["mesDepensesConcerne"].Rows.Count; i++)
            {
                htmlContent.Append(
                @"<tr>
                    <td>" + formMain.ds.Tables["mesDepensesConcerne"].Rows[i]["description"] + @"</td>
                    <td>" + formMain.ds.Tables["mesDepensesConcerne"].Rows[i]["montant"] + @"€</td>
                 </tr>"
                );
            }

            htmlContent.Append(
             @"</tbody>
                </table>"
             );

            // RICHARD doit payer à : 

            htmlContent.Append(
                @"<ul><li><h3>" + formMain.ds.Tables["participantsOnEvent"].Rows[cboParticipant.SelectedIndex]["nomPrenom"] + @" doit payer à : </h3></li></ul>
                 <table class=""tableCenter"" style=""text-align:center;"">
                    <thead>
                        <tr>
                            <th>Nom</th>
                            <th>Montant</th>
                        </tr>
                    </thead>
                    <tbody>");

            connec.ConnectionString = chainconnec;
            connec.Open();
            for (int i = 0; i < formMain.ds.Tables["BilanPart"].Rows.Count; i++)
            {
                if (formMain.ds.Tables["BilanPart"].Rows[i]["codeDonneur"].ToString() == cboParticipant.SelectedValue.ToString())
                {
                    // On prend le Prénom et Nom du receveur
                    string receveurCode = formMain.ds.Tables["BilanPart"].Rows[i]["codeReceveur"].ToString();
                    string receveurName = "SELECT prenomPart, nomPart FROM Participants WHERE codeParticipant = " + receveurCode;

                    OleDbCommand cd2 = new OleDbCommand(receveurName, connec);
                    OleDbDataReader dr2 = cd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        receveurName = dr2.GetString(0) + " " + dr2.GetString(1);
                    }

                    htmlContent.Append(
                    @"<tr>
                        <td>" + receveurName + @"</td>
                        <td>" + formMain.ds.Tables["BilanPart"].Rows[i]["montant"] + @"€</td>
                     </tr>"
                    );
                }
            }

            htmlContent.Append(
             @"</tbody>
                </table><br>"
             );

            // RICHARD doit recevoir de : 

            htmlContent.Append(
                @"<ul><li><h3>" + formMain.ds.Tables["participantsOnEvent"].Rows[cboParticipant.SelectedIndex]["nomPrenom"] + @" doit recevoir de : </h3></li></ul>
                 <table class=""tableCenter"" style=""text-align:center;"">
                    <thead>
                        <tr>
                            <th>Nom</th>
                            <th>Montant</th>
                        </tr>
                    </thead>
                    <tbody>");

            for (int i = 0; i < formMain.ds.Tables["BilanPart"].Rows.Count; i++)
            {
                if (formMain.ds.Tables["BilanPart"].Rows[i]["codeReceveur"].ToString() == cboParticipant.SelectedValue.ToString())
                {
                    // On prend le Prénom et Nom du donneur
                    string donneurCode = formMain.ds.Tables["BilanPart"].Rows[i]["codeDonneur"].ToString();
                    string donneurName = "SELECT prenomPart, nomPart FROM Participants WHERE codeParticipant = " + donneurCode;

                    OleDbCommand cd1 = new OleDbCommand(donneurName, connec);
                    OleDbDataReader dr1 = cd1.ExecuteReader();
                    while (dr1.Read())
                    {
                        donneurName = dr1.GetString(0) + " " + dr1.GetString(1);
                    }

                    htmlContent.Append(
                    @"<tr>
                        <td>" + donneurName + @"</td>
                        <td>" + formMain.ds.Tables["BilanPart"].Rows[i]["montant"] + @"€</td>
                     </tr>"
                    );
                }
            }
            connec.Close();

            htmlContent.Append(
             @"</tbody>
                </table><br>"
             );


            htmlContent.AppendLine(@"
            </body>
            </html>");

            var pdfBytes = new NReco.PdfGenerator.HtmlToPdfConverter().GeneratePdf(htmlContent.ToString());
            File.WriteAllBytes(Path.GetFullPath(path), pdfBytes);
            formNotification.Alert("Bravo ! Votre PDF à été généré ! ", formNotification.enmType.Success);
            System.Diagnostics.Process.Start(path); // Ouvrir le PDF quand on la crée.
        }

        private void pcbGenerate_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show("Cliquer sur l'image", pcbGenerate);
        }

        private void pcbGenerate_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Hide(pcbGenerate);
        }

        private void tpRecap_Click(object sender, EventArgs e)
        {

        }
    }
}
