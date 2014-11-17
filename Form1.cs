using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TP2BD
{
    public partial class Form1 : Form

    {
        public OracleConnection oraconn = new OracleConnection();
        DataSet lesINFoCoalis = new DataSet();
        
        public Form1()
        {
            InitializeComponent();
        }

        private bool RechercheParNom;

                            
                            
        private void Btn_Conec_Click(object sender, EventArgs e)
        {
          
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            oraconn.Close();
            MessageBox.Show(oraconn.State.ToString());
           
        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            string Commande = "INSERT INTO EMPLOYES VALUES (" + Tb_Numemp.Text + ",'" + Tb_Prenom.Text + "', '" + Tb_Nom.Text + "'," +
                                      Tb_salaire.Text + "," + Tb_Echelon.Text + ",'" + Tb_Adresse.Text + "', '" + TB_Code.Text + "')";
            try 
     	   {	        
		
            OracleCommand oracleupdate = new OracleCommand(Commande, oraconn);
            oracleupdate.CommandType = CommandType.Text;
            int nombreligne = oracleupdate.ExecuteNonQuery();
            fillDepart();
            MessageBox.Show(nombreligne.ToString());
	       }

            catch (OracleException ex)
            {
                GestionErreur(ex);
            }
            fillDepart();
            //OracleDataReader oracleread = oracleupdate.ExecuteReader();
        }

        private void lb_programmes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Commande = "Select * FROM EMPLOYES  WHERE EMPLOYES.CODEDEP = (SELECT CODEDEP FROM DEPARTEMENTS WHERE NOMDEPARTEMENT = "+ "'" + lb_programmes.SelectedItem.ToString().Substring(0,lb_programmes.SelectedItem.ToString().LastIndexOf('-')-1) + "')";
             try
             {
                 UnBindControls();
                 DGV_Emp.DataSource = null;
                 DGV_Emp.Columns.Clear();
                 lesINFoCoalis.Clear();
                 OracleDataAdapter orDataAdaptr = new OracleDataAdapter(Commande, oraconn);
                 orDataAdaptr.Fill(lesINFoCoalis, "resEmployes");
                 BindingSource TheSOUSSE = new BindingSource(lesINFoCoalis, "resEmployes");

                 DGV_Emp.DataSource = TheSOUSSE;
                 fillControl("resEmployes");
                 bt_debut.Enabled = false;
                 BT_Precedent.Enabled = false;
                 if (this.BindingContext[lesINFoCoalis, "resEmployes"].Count <= 1)
                 {
                     bt_fin.Enabled = false;
                     BT_Suivant.Enabled = false;
                 }
                 else
                 {
                     bt_fin.Enabled = true;
                     BT_Suivant.Enabled = true;
                 }
             }
             catch (OracleException ex)
             {
                 GestionErreur(ex);
             }
        }

        private void Connect()
        {
            string Dsource = "(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
            "(HOST=205.237.244.251)(PORT=1521)))" + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";

            string chainedeconnexion = "DATA SOURCE =" + Dsource + ";USER ID =  PAQUETTE;PASSWORD = ORACLE1";
            try
            {
                oraconn.ConnectionString = chainedeconnexion;
                oraconn.Open();
                MessageBox.Show(oraconn.State.ToString());
            }
            catch (OracleException ex)
            {
                GestionErreur(ex);
            }
        }

        private void fillControl(string table)
        {
            Tb_Numemp.Enabled = false;
            Tb_Numemp.DataBindings.Add("TEXT", lesINFoCoalis, table+".empno");
            Tb_Nom.DataBindings.Add("TEXT", lesINFoCoalis, table + ".nom");
            Tb_Prenom.DataBindings.Add("TEXT", lesINFoCoalis, table + ".PRENOM");
            Tb_salaire.DataBindings.Add("TEXT", lesINFoCoalis, table + ".salaire");
            Tb_Echelon.DataBindings.Add("TEXT", lesINFoCoalis, table + ".echelon");
            Tb_Adresse.DataBindings.Add("TEXT", lesINFoCoalis, table + ".addresse");
            TB_Code.DataBindings.Add("TEXT", lesINFoCoalis, table + ".CODEDEP");
        }
        private void UnBindControls()
        {
            Tb_Numemp.Enabled = true;
            Tb_Numemp.DataBindings.Clear();
            Tb_Nom.DataBindings.Clear();
            Tb_Prenom.DataBindings.Clear();
            Tb_salaire.DataBindings.Clear();
            Tb_Echelon.DataBindings.Clear();
            Tb_Adresse.DataBindings.Clear();
            TB_Code.DataBindings.Clear();
            Tb_Adresse.Clear();
            TB_Code.Clear();
            Tb_Echelon.Clear();
            Tb_Nom.Clear();
            Tb_Prenom.Clear();
            Tb_Numemp.Clear();
            Tb_salaire.Clear();
            
        }
        private void CB_TypeRecherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (oraconn.State == ConnectionState.Open)
            {
                UnBindControls();
                lesINFoCoalis.Clear();
                
                ComboBox Choix = (ComboBox)sender;
                switch (Choix.SelectedIndex)
                {
                    case 1:
                        TB_RechercheNom.Visible = true;
                        LB_RechercheNom.Visible = true;
                        BT_Recherche.Visible = true;
                        RechercheParNom = true;
                        break;

                    case 2: //Par Departement
                        TB_RechercheNom.Visible = true;
                        LB_RechercheNom.Visible = true;
                        BT_Recherche.Visible = true;
                        RechercheParNom = false;
                        break;

                    default:
                        TB_RechercheNom.Visible = false;
                        LB_RechercheNom.Visible = false;
                        BT_Recherche.Visible = false;
                        string Commande = "Select * FROM EMPLOYES";
                        try
                        {
                            OracleDataAdapter orDataAdaptr = new OracleDataAdapter(Commande, oraconn);
                            orDataAdaptr.Fill(lesINFoCoalis, "resEmployes");
                         
                            BindingSource TheSOUSSE = new BindingSource(lesINFoCoalis, "resEmployes");

                            DGV_Emp.DataSource = TheSOUSSE;
                            UnBindControls();
                            fillControl("resEmployes");
                            bt_debut.Enabled = false;
                            BT_Precedent.Enabled = false;
                            if (this.BindingContext[lesINFoCoalis, "resEmployes"].Count <= 1)
                            {
                                bt_fin.Enabled = false;
                                BT_Suivant.Enabled = false;
                            }
                            else
                            {
                                bt_fin.Enabled = true;
                                BT_Suivant.Enabled = true;
                            }

                        }
                        catch (OracleException ex)
                        {
                            GestionErreur(ex);
                        }
                        break;
                }
            }
        }
        private void Recherche()
        {
            if (!string.IsNullOrEmpty(TB_RechercheNom.Text))
            {

                lesINFoCoalis.Clear();
                if (RechercheParNom)
                {
                    string Commande = "Select * FROM EMPLOYES where Nom like '" + TB_RechercheNom.Text + "%'";
                    try
                    {
                       
                        OracleDataAdapter orDataAdaptr = new OracleDataAdapter(Commande, oraconn);
                        orDataAdaptr.Fill(lesINFoCoalis, "resEmployes");
                        BindingSource TheSOUSSE = new BindingSource(lesINFoCoalis, "resEmployes");
                       DGV_Emp.DataSource = TheSOUSSE;
                       UnBindControls();
                       fillControl("resEmployes");
                       bt_debut.Enabled = false;
                       BT_Precedent.Enabled = false;
                       if (this.BindingContext[lesINFoCoalis, "resEmployes"].Count <= 1)
                       {
                           bt_fin.Enabled = false;
                           BT_Suivant.Enabled = false;
                       }
                       else
                       {
                           bt_fin.Enabled = true;
                           BT_Suivant.Enabled = true;
                       }

                    }
                    catch (OracleException ex)
                    {
                        GestionErreur(ex);
                    }
                }
                else
                {
                    string Commande = "Select EMPLOYES.*,Departements.NomDepartement FROM EMPLOYES inner join Departements on EMPLOYES.CodeDep=Departements.CodeDep where Departements.NomDepartement like '" + TB_RechercheNom.Text + "%'";
                    try
                    {

                        OracleDataAdapter orDataAdaptr = new OracleDataAdapter(Commande, oraconn);
                        orDataAdaptr.Fill(lesINFoCoalis, "resEmployes");
                        BindingSource TheSOUSSE = new BindingSource(lesINFoCoalis, "resEmployes");

                        DGV_Emp.DataSource = TheSOUSSE;
                        UnBindControls();
                        fillControl("resEmployes");
                        bt_debut.Enabled = false;
                        BT_Precedent.Enabled = false;
                        if(this.BindingContext[lesINFoCoalis, "resEmployes"].Count<=1)
                        {
                            bt_fin.Enabled = false;
                            BT_Suivant.Enabled = false;
                        }
                        else
                        {
                            bt_fin.Enabled = true;
                            BT_Suivant.Enabled = true;
                        }
                    }
                    catch (OracleException ex)
                    {
                        GestionErreur(ex);
                    }
                }
            }
        }

        private void BT_Recherche_Click(object sender, EventArgs e)
        {
            Recherche();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Tb_Numemp.Text))
            {
                try
                {
                    string commande = "UPDATE EMPLOYES SET NOM = '" + Tb_Nom.Text +
                             "' , PRENOM = '" + Tb_Prenom.Text + "'" +
                             ", SALAIRE = " + Tb_salaire.Text +
                             ", ECHELON = " + Tb_Echelon.Text +
                            ", ADDRESSE = '" + Tb_Nom.Text + "'" +
                           ",CODEDEP = '" + TB_Code.Text + "' WHERE EMPNO = " + Tb_Numemp.Text;


                    OracleCommand oracleupdate = new OracleCommand(commande, oraconn);
                    oracleupdate.CommandType = CommandType.Text;
                    int nombreligne = oracleupdate.ExecuteNonQuery();
                    MessageBox.Show(nombreligne.ToString());
                }

                catch (OracleException ex)
                {
                    GestionErreur(ex);
                }
            }
        }
        private void BT_Suivant_Click(object sender, EventArgs e)
        {
            if (this.BindingContext[lesINFoCoalis, "resEmployes"].Position + 1 < DGV_Emp.Rows.Count)
            {
                DGV_Emp.CurrentCell = DGV_Emp.Rows[this.BindingContext[lesINFoCoalis, "resEmployes"].Position + 1].Cells[0];
            }
            if (this.BindingContext[lesINFoCoalis, "resEmployes"].Position + 1 < DGV_Emp.Rows.Count - 1)
            {
                BT_Precedent.Enabled = true;
                bt_debut.Enabled = true;
            }
            else
            {
                bt_fin.Enabled = false;
                BT_Suivant.Enabled = false;
                BT_Precedent.Enabled = true;
                bt_debut.Enabled = true;
            }
            this.BindingContext[lesINFoCoalis, "resEmployes"].Position += 1;
           
                
            
        }

        private void fillDepart()
        {
            string commande = "SELECT Departements.NomDepartement,COUNT(EMPNO) FROM EMPLOYES inner join Departements on EMPLOYES.CodeDep=Departements.CodeDep GROUP BY Departements.NomDepartement";
            lb_programmes.Items.Clear();
            OracleCommand oraclecomm = new OracleCommand(commande, oraconn);
            oraclecomm.CommandType = CommandType.Text;
            int nombreligne = oraclecomm.ExecuteNonQuery();
            OracleDataReader oraread = oraclecomm.ExecuteReader();
            while (oraread.Read())
            {
                string ligne = oraread.GetString(0) + " - " + oraread.GetInt32(1).ToString();
                lb_programmes.Items.Add(ligne);
            }
            oraread.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Connect();
            CB_TypeRecherche.SelectedIndex = 0;

            fillDepart();

            

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            oraconn.Close();
            MessageBox.Show(oraconn.State.ToString());
        }

        private void BT_Precedent_Click(object sender, EventArgs e)
        {
            if (this.BindingContext[lesINFoCoalis, "resEmployes"].Position - 1 >= 0)
            {
                DGV_Emp.CurrentCell = DGV_Emp.Rows[this.BindingContext[lesINFoCoalis, "resEmployes"].Position - 1].Cells[0];
            }
            if (this.BindingContext[lesINFoCoalis, "resEmployes"].Position - 1 > 0)
            {
                BT_Suivant.Enabled = true;
                bt_fin.Enabled = true;
            }
            else
            {

                bt_debut.Enabled = false;
                BT_Precedent.Enabled = false;
                bt_fin.Enabled = true;
                BT_Suivant.Enabled = true;
            }
            this.BindingContext[lesINFoCoalis, "resEmployes"].Position -= 1;
            
           

        }

        private void TB_RechercheNom_TextChanged(object sender, EventArgs e)
        {

            //if (!string.IsNullOrEmpty(TB_RechercheNom.Text))
            //    Recherche();
            //if (!string.IsNullOrEmpty(TB_RechercheNom.Text))
            //TB_RechercheNom.AutoCompleteMode = AutoCompleteMode.Suggest;
            //if (RechercheParNom)
            //{
            //    for (int i = 0; i < lesINFoCoalis.Tables[lesINFoCoalis.Tables.IndexOf("resEmployes")].Rows.Count; i++)
            //    {
            //        TB_RechercheNom.AutoCompleteCustomSource.Add(lesINFoCoalis.Tables[lesINFoCoalis.Tables.IndexOf("resEmployes")].Rows[i]["nom"].ToString());
            //    }
            //    TB_RechercheNom.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //    //Reste a faire la partie du departement
            //}
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Tb_Numemp.Text))
            {
                try
                {
                    string commande = "DELETE FROM EMPLOYES  WHERE EMPNO = " + Tb_Numemp.Text;

                    OracleCommand oracleupdate = new OracleCommand(commande, oraconn);
                    oracleupdate.CommandType = CommandType.Text;
                    int nombreligne = oracleupdate.ExecuteNonQuery();
                    MessageBox.Show(nombreligne.ToString());
                    string Commande = "Select * FROM EMPLOYES";                    
                }

                catch (OracleException ex)
                {
                    GestionErreur(ex);
                }
                fillDepart();
            }
        }

        private void DGV_Emp_SelectionChanged(object sender, EventArgs e)
        {
           //met a jour les textbox avec les info selectioner dans le datagridview
            if( DGV_Emp.Rows.Count > 0 )
                this.BindingContext[lesINFoCoalis, "resEmployes"].Position = DGV_Emp.CurrentCell.RowIndex;
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            Tb_Numemp.Enabled = true;

            UnBindControls();
        }

        private string GestionErreur(OracleException ex)
        {
            string msgException = "";

            switch (ex.Number)
            {
                case 2292:
                    MessageBox.Show("Tentative de suppression d'une clé lié à une clé étrangère ", "Erreur 1407", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1407:
                    MessageBox.Show("Vous ne pouvez pas mettre a jour une colonne avec une valeur null", "Erreur 1407", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1400:
                    MessageBox.Show("Vous ne pouvez pas ajouter une colonne avec une valeur null", "Erreur 1400", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1:
                    MessageBox.Show("Le numero d'employé doit être unique", "Erreur 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1410:
                    MessageBox.Show("Vous ne pouvez pas mettre de valeur null", "Erreur 1410", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1017:
                    MessageBox.Show("Mot de passe ou nom d'utilisateur invalide", "Erreur 1017", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 12170:
                    MessageBox.Show("La base de données est indisponible,réessayer plus tard", "Erreur 12170", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 12543:
                    MessageBox.Show("Connexion impossible,Vérifiez votre connection internet", "Erreur 12543", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2291:
                    MessageBox.Show("Code Departement invalide", "Erreur 2291", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2290:
                    MessageBox.Show("Salaire ou echelon invalide", "Erreur 2290", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show("Une erreur non-gerée est survenue : " + ex.Number.ToString() + ":" + ex.Message.ToString(), ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            return msgException;
        }

        private void bt_debut_Click(object sender, EventArgs e)
        {
            if (this.BindingContext[lesINFoCoalis, "resEmployes"].Count > 0)
            {
                DGV_Emp.CurrentCell = DGV_Emp.Rows[0].Cells[0];
                this.BindingContext[lesINFoCoalis, "resEmployes"].Position = 0;

                    bt_debut.Enabled = false;
                    BT_Precedent.Enabled = false;
                    bt_fin.Enabled = true;
                    BT_Suivant.Enabled = true;

                
            }
        }

        private void bt_fin_Click(object sender, EventArgs e)
        {
            if (this.BindingContext[lesINFoCoalis, "resEmployes"].Count > 0)
            {
                DGV_Emp.CurrentCell = DGV_Emp.Rows[this.BindingContext[lesINFoCoalis, "resEmployes"].Count - 1].Cells[0];
                this.BindingContext[lesINFoCoalis, "resEmployes"].Position = this.BindingContext[lesINFoCoalis, "resEmployes"].Count - 1;
                
                    bt_fin.Enabled = false;
                    BT_Suivant.Enabled = false;
                    BT_Precedent.Enabled = true;
                    bt_debut.Enabled = true;
                
            }
        }

        private void Tb_Numemp_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(Tb_Numemp.Text))
            {
                Btn_Delete.Enabled = false;
                Btn_Insert.Enabled = false;
                Btn_Update.Enabled = false;
            }
            else
            {
                Btn_Delete.Enabled = true;
                Btn_Insert.Enabled = true;
                Btn_Update.Enabled = true;
            }
        }
      
       
    }
}
