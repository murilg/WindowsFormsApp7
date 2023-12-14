using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public static int gid;
        public Form1()
        {
            InitializeComponent();
        }

        private void gIBDD_officerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIBDD_officerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rTADataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rTADataSet.GIBDD_officer". При необходимости она может быть перемещена или удалена.
            this.gIBDD_officerTableAdapter.Fill(this.rTADataSet.GIBDD_officer);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autho();
        }

        private void Autho()
        {
            var constr = new SqlConnectionStringBuilder()
            {
                DataSource = "localhost,1433",
                InitialCatalog = "RTA",
                IntegratedSecurity = true,
                TrustServerCertificate = true,
            };

            using (var con = new SqlConnection(constr.ConnectionString))
            {
                string cmdstr = "select GIBDD_officer_id from GIBDD_officer where Badge_number=@number and Password=@pass";
                using (var cmd = new SqlCommand(cmdstr, con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@number", badge_numberTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", passwordTextBox.Text.Trim());
                        con.Open();
                        gid = (int)cmd.ExecuteScalar();
                        {
                            Form2 f2 = new Form2();
                            f2.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка входа");
                    }
                }
            }
        }

  

   
    }
}

