using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoFarm_Queries
{
    public partial class Form1 : Form
    {
        OdbcConnection OdbcConnect;
        SqlConnection SqlConnect;

        string connectionStringODBC = "Dsn=Eco_ODBC;trusted_connection=Yes;app=Microsoft® Visual Studio®;wsid=DESKTOP-5TQ1HVS;database=EcoFarm";
        string connectionStringSQL = "Data Source=DESKTOP-5TQ1HVS;Initial Catalog=EcoFarm;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            Form2 Param_form = new Form2();
            Param_form.Show();
        }

        private void Select_odbc_Click(object sender, EventArgs e)
        {
            var data = new DataTable();
            string command = "SELECT * FROM Employees WHERE Position_Code=2";
            using(OdbcConnect=new OdbcConnection(connectionStringODBC))
            {
                if (OdbcConnect.State == ConnectionState.Open)
                {
                    OdbcConnect.Close();
                }

                OdbcConnect.Open();

                try
                {
                    OdbcCommand select = new OdbcCommand(command, OdbcConnect);
                    data.Load(select.ExecuteReader());
                    data1.DataSource = data;
                }

                catch(OdbcException ex)
                {
                    MessageBox.Show("ODBC connection error"+ ex.Message);
                }

                finally
                {
                    OdbcConnect.Close();
                }
            }
        }

        private void Upd_Odbc_Click(object sender, EventArgs e)
        {
            var data = new DataTable();
            string command = "UPDATE Employees SET Passport_Series='КК' WHERE Position_Code=2";

            using (OdbcConnect = new OdbcConnection(connectionStringODBC))
            {
                if (OdbcConnect.State == ConnectionState.Open)
                {
                    OdbcConnect.Close();
                }

                OdbcConnect.Open();

                try
                {
                    OdbcCommand update = new OdbcCommand(command, OdbcConnect);
                    var result = update.ExecuteNonQuery();
                }

                catch(OdbcException ex)
                {
                    MessageBox.Show("ODBC connection error" + ex.Message);
                }

                finally
                {
                    OdbcConnect.Close();
                }
            }
        }

        private void sql_select_Click(object sender, EventArgs e)
        {
            var data = new DataTable();
            var command = "SELECT * FROM Position WHERE Department_Code=112";

            using(SqlConnect=new SqlConnection(connectionStringSQL))
            {
                if (SqlConnect.State == ConnectionState.Open)
                {
                    SqlConnect.Close();
                }

                SqlConnect.Open();

                try
                {
                    SqlCommand select = new SqlCommand(command, SqlConnect);
                    data.Load(select.ExecuteReader());
                    data1.DataSource = data;
                }

                catch(SqlException ex)
                {
                    MessageBox.Show("SQL connection error" + ex.Message);
                }

                finally
                {
                    SqlConnect.Close();
                }
            }
        }

        private void upd_sql_Click(object sender, EventArgs e)
        {
            var data = new DataTable();
            var command = "UPDATE Position SET Activity='Охрана и оборона' WHERE Activity='Охрана'";

            using (SqlConnect = new SqlConnection(connectionStringSQL))
            {
                if (SqlConnect.State == ConnectionState.Open)
                {
                    SqlConnect.Close();
                }

                SqlConnect.Open();

                try
                {
                    SqlCommand update = new SqlCommand(command, SqlConnect);
                    var results = update.ExecuteNonQuery();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show("SQL connection error" + ex.Message);
                }

                finally
                {
                    SqlConnect.Close();
                }
            }
        }

       //private void button1_Click(object sender, EventArgs e)
       //{
       //    Form2 Param_form = new Form2();
       //    Param_form.Show();
       //}
    }
}
