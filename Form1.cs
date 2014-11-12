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

  

    public partial class Tb_CodeDep : Form

    {
        public OracleConnection oraconn = new OracleConnection();
        public Tb_CodeDep()
        {
            InitializeComponent();
        }

        private void Btn_Conec_Click(object sender, EventArgs e)
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

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            oraconn.Close();
            MessageBox.Show(oraconn.State.ToString());
           
        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            string Commande = "INSERT INTO EMPLOYES VALUES (" + Tb_Numemp.Text + ",'" + Tb_Prenom.Text + "', '" + Tn_Nom.Text + "'," +
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

        private void Btn_liste_Click(object sender, EventArgs e)
        {
            string Commande = "Select NOM,PRENOM,CODEDEP FROM EMPLOYES";
            try{
                OracleDataAdapter Data = new OracleDataAdapter(Commande , oraconn);
                DataSet lesINFoCoalis = new DataSet();        
                Data.Fill(lesINFoCoalis, "Employes");
                Data.Dispose();
                BindingSource TheSOUSSE = new BindingSource(lesINFoCoalis, "Employes");

                DGV_Emp.DataSource = TheSOUSSE;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
               
            }
        }

        private void lb_programmes_SelectedIndexChanged(object sender, EventArgs e)
        {
             string Commande = "Select NOM,PRENOM,CODEDEP FROM EMPLOYES WHERE CODEDEP =" + "'"+lb_programmes.SelectedItem.ToString()+ "'";
             try
             {
                 OracleDataAdapter Data = new OracleDataAdapter(Commande, oraconn);
                 DataSet lesINFoCoalis = new DataSet();
                 Data.Fill(lesINFoCoalis, "Employes");
                 Data.Dispose();
                 BindingSource TheSOUSSE = new BindingSource(lesINFoCoalis, "Employes");

                 DGV_Emp.DataSource = TheSOUSSE;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message.ToString());

             }
        }
    }
}
