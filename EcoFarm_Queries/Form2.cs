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
    public partial class Form2 : Form
    {
        OdbcConnection OdbcConnect;
        SqlConnection SqlConnect;

        string connectionStringODBC = "Dsn=Eco_ODBC;trusted_connection=Yes;app=Microsoft® Visual Studio®;wsid=DESKTOP-5TQ1HVS;database=EcoFarm";
        string connectionStringSQL = "Data Source=DESKTOP-5TQ1HVS;Initial Catalog=EcoFarm;Integrated Security=True";

        public Form2()
        {
            InitializeComponent();
        }

        private void select_odbc_Click(object sender, EventArgs e)
        {
            int param;
            var data = new DataTable();
            OdbcParameter odbc_Parm = new OdbcParameter();
            bool ParamType = int.TryParse(paramming.Text, out param);

            if (ParamType == true)
            {
                odbc_Parm.DbType = DbType.Int32;
                odbc_Parm.Value = param;
            }

            else
            {
                odbc_Parm.DbType = DbType.String;
                odbc_Parm.Value = paramming.Text;
            }

            string command = "SELECT * FROM[" + table_comb.SelectedItem + "] WHERE [" + field_comb.SelectedItem + "]=?";

            using (OdbcConnect = new OdbcConnection(connectionStringODBC))
            {
                if (OdbcConnect.State == ConnectionState.Open)
                {
                    OdbcConnect.Close();
                }

                OdbcConnect.Open();

                try
                {
                    OdbcCommand select = new OdbcCommand(command, OdbcConnect);
                    select.Parameters.Add(odbc_Parm);
                    data.Load(select.ExecuteReader());
                    param_grid.DataSource = data;
                }

                catch (OdbcException ex)
                {
                    MessageBox.Show("ODBC connection error" + ex.Message);
                }

                finally
                {
                    OdbcConnect.Close();
                }
            }


        }

        private void table_comb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Position_List = new List<string>()
            {
                "Position_Code", "Position", "Department_Code", "Activity"
            };

            var Employees_List = new List<string>()
            {
                "Employee_Number", "Full_Name", "Phone_Number", "Adress", "Position_Code", "Passport_Number", "Passport_Series", "Birth_Date"
            };

            if (table_comb.SelectedIndex == 0)
            {
                field_comb.Items.Clear();
                field_comb.Items.AddRange(Position_List.ToArray());
            }
            else
            {
                field_comb.Items.Clear();
                field_comb.Items.AddRange(Employees_List.ToArray());
            }
        }

        private void odbc_select_scalar_Click(object sender, EventArgs e)
        {
            int param;
            var data = new DataTable();
            OdbcParameter odbc_Parm = new OdbcParameter();
            bool ParamType = int.TryParse(paramming.Text, out param);

            if (ParamType == true)
            {
                odbc_Parm.DbType = DbType.Int32;
                odbc_Parm.Value = param;
            }

            else
            {
                odbc_Parm.DbType = DbType.String;
                odbc_Parm.Value = paramming.Text;
            }

            string command = "SELECT * FROM[" + table_comb.SelectedItem + "] WHERE [" + field_comb.SelectedItem + "]=?";

            using (OdbcConnect = new OdbcConnection(connectionStringODBC))
            {
                if (OdbcConnect.State == ConnectionState.Open)
                {
                    OdbcConnect.Close();
                }

                OdbcConnect.Open();

                try
                {
                    OdbcCommand select = new OdbcCommand(command, OdbcConnect);
                    select.Parameters.Add(odbc_Parm);
                    ScalTB.Text = select.ExecuteScalar().ToString();
                }

                catch (OdbcException ex)
                {
                    MessageBox.Show("ODBC connection error" + ex.Message);
                }

                finally
                {
                    OdbcConnect.Close();
                }
            }


        }

        private void odbc_insert_Pos_Click(object sender, EventArgs e)
        {
            var data = new DataTable();
            OdbcParameter position_code = new OdbcParameter();
            OdbcParameter position = new OdbcParameter();
            OdbcParameter department_code = new OdbcParameter();
            OdbcParameter activity = new OdbcParameter();

            try
            {
                position_code.Value = int.Parse(Pos_codeTB.Text);
                position.Value = Pos_nameTB.Text;
                department_code.Value = int.Parse(Depart_codeTB.Text);
                activity.Value = ActivityTB.Text;

                string command = "INSERT INTO Position(Position_Code, Position, Department_Code, Activity) VALUES(?,?,?,?)";

                using (OdbcConnect = new OdbcConnection(connectionStringODBC))
                {
                    if (OdbcConnect.State == ConnectionState.Open)
                    {
                        OdbcConnect.Close();
                    }
                    OdbcConnect.Open();

                    try
                    {
                        OdbcCommand insert = new OdbcCommand(command, OdbcConnect);
                        insert.Parameters.Add(position_code);
                        insert.Parameters.Add(position);
                        insert.Parameters.Add(department_code);
                        insert.Parameters.Add(activity);
                        int results = insert.ExecuteNonQuery();
                        MessageBox.Show("Done and Done!");
                    }

                    catch (OdbcException ex)
                    {
                        MessageBox.Show("Something went wrong" + ex);
                    }

                    finally
                    {
                        OdbcConnect.Close();
                    }
                }
            }

            catch (OdbcException ex)
            {
                MessageBox.Show(ex + "");
            }

        }

        private void sql_select_Click(object sender, EventArgs e)
        {
            int param;
            var data = new DataTable();
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@Parameter";
            bool ParamType = int.TryParse(paramming.Text, out param);
            if (ParamType == true)
            {
                parameter.DbType = DbType.Int32;
                parameter.Value = paramming.Text;
            }
            else
            {
                parameter.DbType = DbType.String;
                parameter.Value = paramming.Text;
            }

            string command = "SELECT * FROM[" + table_comb.SelectedItem + "] WHERE [" + field_comb.SelectedItem + "]=@Parameter";

            using(SqlConnect=new SqlConnection(connectionStringSQL))
            {
                if(SqlConnect.State== ConnectionState.Open)
                {
                    SqlConnect.Close();
                }
                SqlConnect.Open();

                try
                {
                    SqlCommand select = new SqlCommand(command, SqlConnect);
                    select.Parameters.Add(parameter);
                    data.Load(select.ExecuteReader());
                    param_grid.DataSource = data;
                }

                catch(SqlException ex)
                {
                    MessageBox.Show("Something went wrong" + ex);
                }
                finally
                {
                    SqlConnect.Close();
                }

            }
        }

        private void sql_scalar_Click(object sender, EventArgs e)
        {
            int param;
            var data = new DataTable();
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@Parameter";
            bool ParamType = int.TryParse(paramming.Text, out param);
            if (ParamType == true)
            {
                parameter.DbType = DbType.Int32;
                parameter.Value = paramming.Text;
            }
            else
            {
                parameter.DbType = DbType.String;
                parameter.Value = paramming.Text;
            }

            string command = "SELECT * FROM[" + table_comb.SelectedItem + "] WHERE [" + field_comb.SelectedItem + "]=@Parameter";

            using (SqlConnect = new SqlConnection(connectionStringSQL))
            {
                if (SqlConnect.State == ConnectionState.Open)
                {
                    SqlConnect.Close();
                }
                SqlConnect.Open();

                try
                {
                    SqlCommand select = new SqlCommand(command, SqlConnect);
                    select.Parameters.Add(parameter);
                    scalar_sqlTB.Text = select.ExecuteScalar().ToString();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show("Something went wrong" + ex);
                }
                finally
                {
                    SqlConnect.Close();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void sql_insert_Click(object sender, EventArgs e)
        {
            var data = new DataTable();
            SqlParameter Emp_Numb = new SqlParameter("@Numb", SqlDbType.Int);
            SqlParameter Emp_Name = new SqlParameter("@Name",SqlDbType.VarChar);
            SqlParameter Emp_Phone = new SqlParameter("@Phone",SqlDbType.Int);
            SqlParameter Emp_Addr = new SqlParameter("@Address", SqlDbType.VarChar);
            SqlParameter Emp_Pos_Code = new SqlParameter("@Position",SqlDbType.Int);
            SqlParameter Emp_Passp_Numb = new SqlParameter("@PassportN", SqlDbType.Int);
            SqlParameter Emp_Passp_Ser = new SqlParameter("@PassportS", SqlDbType.VarChar);
            SqlParameter Emp_Birth = new SqlParameter("@Birth",SqlDbType.DateTime);

            try
            {
                Emp_Numb.Value = int.Parse(emp_numTB.Text);
                Emp_Name.Value = emp_nameTB.Text;
                Emp_Phone.Value = int.Parse(emp_phoneTB.Text);
                Emp_Addr.Value = emp_adrTB.Text;
                Emp_Pos_Code.Value = int.Parse(emp_pos_codeTB.Text);
                Emp_Passp_Numb.Value = int.Parse(emp_passp_numbTB.Text);
                Emp_Passp_Ser.Value = emp_passp_serTB.Text;
                Emp_Birth.Value = DateTime.Parse(emp_birthTB.Text);

                string command = "INSERT INTO Employees(Employee_Number,Full_Name,Phone_Number,Adress,Position_Code,Passport_Number,Passport_Series,Birth_Date) VALUES(@Numb, @Name, @Phone, @Address, @Position, @PassportN, @PassportS, @Birth)";
                using (SqlConnect = new SqlConnection(connectionStringSQL))
                {
                    if (SqlConnect.State == ConnectionState.Open)
                    {
                        SqlConnect.Close();
                    }
                    SqlConnect.Open();

                    try
                    {
                        SqlCommand insert = new SqlCommand(command, SqlConnect);
                        insert.Parameters.Add(Emp_Numb);
                        insert.Parameters.Add(Emp_Name);
                        insert.Parameters.Add(Emp_Phone);
                        insert.Parameters.Add(Emp_Addr );
                        insert.Parameters.Add(Emp_Pos_Code);
                        insert.Parameters.Add(Emp_Passp_Numb);
                        insert.Parameters.Add(Emp_Passp_Ser);
                        insert.Parameters.Add(Emp_Birth);
                        var result = insert.ExecuteNonQuery();
                    }

                    catch (SqlException ex)
                    {
                        MessageBox.Show("Something went wrong" + ex);
                    }
                    finally
                    {
                        SqlConnect.Close();
                    }
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Something went wrong" + ex);
            }

        }
    }
}
