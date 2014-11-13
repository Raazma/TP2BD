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
            MessageBox.Show(nombreligne.ToString());
	       }
	
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
               
            }
            //OracleDataReader oracleread = oracleupdate.ExecuteReader();
        }

        private void lb_programmes_SelectedIndexChanged(object sender, EventArgs e)
        {
             string Commande = "Select NOM,PRENOM,CODEDEP FROM EMPLOYES WHERE CODEDEP =" + "'"+lb_programmes.SelectedItem.ToString()+ "'";
             try
             {
                 UnBindControls();
                 DGV_Emp.DataSource = null;
                 DGV_Emp.Columns.Clear();
                 lesINFoCoalis.Tables.Clear();
                 OracleDataAdapter orDataAdaptr = new OracleDataAdapter(Commande, oraconn);
                 orDataAdaptr.Fill(lesINFoCoalis, "resEmployes");
                 BindingSource TheSOUSSE = new BindingSource(lesINFoCoalis, "resEmployes");

                 DGV_Emp.DataSource = TheSOUSSE;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message.ToString());

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void fillControl(string table)
        {
            Tb_Numemp.Enabled = false;
            Tb_Numemp.DataBindings.Add(new Binding("TEXT", lesINFoCoalis, table+".empno"));
            Tb_Nom.DataBindings.Add(new Binding("TEXT", lesINFoCoalis, table + ".nom"));
            Tb_Prenom.DataBindings.Add(new Binding("TEXT", lesINFoCoalis, table + ".PRENOM"));
            Tb_salaire.DataBindings.Add(new Binding("TEXT", lesINFoCoalis, table + ".salaire"));
            Tb_Echelon.DataBindings.Add(new Binding("TEXT", lesINFoCoalis, table + ".echelon"));
            Tb_Adresse.DataBindings.Add(new Binding("TEXT", lesINFoCoalis, table + ".addresse"));
            TB_Code.DataBindings.Add(new Binding("TEXT", lesINFoCoalis, table + ".CODEDEP"));

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
        }
        private void CB_TypeRecherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (oraconn.State == ConnectionState.Open)
            {
                UnBindControls();
                lesINFoCoalis.Tables.Clear();
                ComboBox Choix = (ComboBox)sender;
                switch (Choix.SelectedIndex)
                {
                    case 1:
                        TB_RechercheNom.Visible = true;
                        LB_RechercheNom.Visible = true;
                        BT_Recherche.Visible = true;
                        RechercheParNom = true;
                        break;

                    case 2:
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

                            fillControl("resEmployes");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());

                        }
                        break;
                }
            }
        }
        private void Recherche()
        {
            if (!string.IsNullOrEmpty(TB_RechercheNom.Text))
            {
                UnBindControls();
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
                        fillControl("resEmployes");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());

                    }
                }
                else
                {
                    string Commande = "Select EMPLOYES.EMPNO, EMPLOYES.NOM, EMPLOYES.PRENOM, EMPLOYES.SALAIRE, EMPLOYES.ECHELON, EMPLOYES.ADDRESSE, EMPLOYES.CODEDEP, Departements.NomDepartement FROM EMPLOYES inner join Departements on EMPLOYES.CodeDep=Departements.CodeDep where Departements.NomDepartement like '" + TB_RechercheNom.Text + "%'";
                    try
                    {

                        OracleDataAdapter orDataAdaptr = new OracleDataAdapter(Commande, oraconn);
                        orDataAdaptr.Fill(lesINFoCoalis, "resEmployes");
                        BindingSource TheSOUSSE = new BindingSource(lesINFoCoalis, "resEmployes");

                        DGV_Emp.DataSource = TheSOUSSE;
                        fillControl("resEmployes");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());

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

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }
        private void BT_Suivant_Click(object sender, EventArgs e)
        {
            this.BindingContext[lesINFoCoalis, "resEmployes"].Position += 1;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Connect();
            CB_TypeRecherche.SelectedIndex = 0;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            oraconn.Close();
            MessageBox.Show(oraconn.State.ToString());
        }

        private void BT_Precedent_Click(object sender, EventArgs e)
        {
            this.BindingContext[lesINFoCoalis, "resEmployes"].Position -= 1;
        }

        private void TB_RechercheNom_TextChanged(object sender, EventArgs e)
        {
            Recherche();
            TB_RechercheNom.AutoCompleteMode = AutoCompleteMode.Suggest;
            if (RechercheParNom)
            {
                for (int i = 0; i < lesINFoCoalis.Tables[lesINFoCoalis.Tables.IndexOf("resEmployes")].Rows.Count; i++)
			{
			 TB_RechercheNom.AutoCompleteCustomSource.Add(lesINFoCoalis.Tables[lesINFoCoalis.Tables.IndexOf("resEmployes")].Rows[i]["nom"].ToString());
			}
                TB_RechercheNom.AutoCompleteSource = AutoCompleteSource.CustomSource;
                
                //Reste a faire la partie du departement
            }
        }
    }
}
