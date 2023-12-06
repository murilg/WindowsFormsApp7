using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form10 : Form
    {
        private static DateTime date;
        public Form10()
        {
            InitializeComponent();
        }

        private void rTABindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.rTABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rTADataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "HH:mm";

            dateTimePicker1.ShowUpDown = true;
            date = date_and_timeDateTimePicker.Value.Date + dateTimePicker1.Value.TimeOfDay;

            // TODO: данная строка кода позволяет загрузить данные в таблицу "rTADataSet.Tag". При необходимости она может быть перемещена или удалена.
            this.tagTableAdapter.Fill(this.rTADataSet.Tag);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rTADataSet.Tag". При необходимости она может быть перемещена или удалена.
            this.tagTableAdapter.Fill(this.rTADataSet.Tag);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rTADataSet.Insurance". При необходимости она может быть перемещена или удалена.
            this.insuranceTableAdapter.Fill(this.rTADataSet.Insurance);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rTADataSet.Vehicle". При необходимости она может быть перемещена или удалена.
            this.vehicleTableAdapter.Fill(this.rTADataSet.Vehicle);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rTADataSet.DriversInDUIRta". При необходимости она может быть перемещена или удалена.
            this.driversInDUIRtaTableAdapter.Fill(this.rTADataSet.DriversInDUIRta);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rTADataSet.RTA_Driver". При необходимости она может быть перемещена или удалена.
            this.rTA_DriverTableAdapter.Fill(this.rTADataSet.RTA_Driver);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rTADataSet.Driver". При необходимости она может быть перемещена или удалена.
            this.driverTableAdapter.Fill(this.rTADataSet.Driver);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rTADataSet.Witness". При необходимости она может быть перемещена или удалена.
            this.witnessTableAdapter.Fill(this.rTADataSet.Witness);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //rura();
            var date1 = new DateTime(2008, 3, 1, 7, 0, 0);
            try
            {
                this.Validate();
                this.insuranceBindingSource.EndEdit();
                this.insuranceTableAdapter.Insert(1, "ОСАГО", "ЩЩЩВВВ", date1, 1);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed "+ ex);
            }
        }

        private int rura()
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
                string cmdstr = "select RTA_id\r\nfrom RTA\r\nwhere city = @city and Street = @street and building = @b and date_and_time = @date  ";
                using (var cmd = new SqlCommand(cmdstr, con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@city", cityTextBox);
                        cmd.Parameters.AddWithValue("@street", streetTextBox);
                        cmd.Parameters.AddWithValue("@b", buildingTextBox);
                        cmd.Parameters.AddWithValue("@date", date);
                        con.Open();
                        
                        MessageBox.Show("Update successful");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка входа");
                    }
                }
            }
            return 
        }
    }
}
