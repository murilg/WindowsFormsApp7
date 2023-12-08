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
        private static DateTime time;
        int[] A = new int[3];
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
            //date = date_and_timeDateTimePicker.Value.Date + dateTimePicker1.Value.TimeOfDay;
            var yy = new DateTime(2023, 12, 07, 18, 22, 55);

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
            time = new DateTime(date_and_timeDateTimePicker.Value.Year, date_and_timeDateTimePicker.Value.Month, date_and_timeDateTimePicker.Value.Day, dateTimePicker1.Value.Hour, dateTimePicker1.Value.Minute, 0, 0);
        
            date = date_and_timeDateTimePicker.Value.Date + dateTimePicker1.Value.TimeOfDay;
            bool drunk = false;
            bool property = false;
            bool move = false;
            if (the_driver_is_drunkCheckBox.Checked)
                drunk = true;
            if (damage_to_other_propertyCheckBox.Checked)
                property = true;
            if (can_the_vehicle_moveCheckBox.Checked)
                move = true;
            // byte g = (byte)number_of_woundedTextBox.Text;
            //var t1 = number_of_woundedTextBox.Text;
           // var t3 = (byte)t1;
            //var t2 = Convert.ToInt16(number_of_deadTextBox.Text);

            var date1 = new DateTime(2008, 3, 1, 7, 0, 0);
            try
            {
                da();
                //this.Validate();
                //this.rTABindingSource.EndEdit();
                //this.rtaTableAdapter1.Insert(cityTextBox.Text, streetTextBox.Text, buildingTextBox.Text, date, number_of_woundedTextBox.Text, number_of_deadTextBox.Text, true, Form1.gid);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed " + ex);
            }

            rura();
            try
            {
                this.rTA_DriverBindingSource.EndEdit();
                this.rTA_DriverTableAdapter.Insert(A[0], A[1], A[2], drunk, true, true, vehicle_damageTextBox.Text, property, damaged_property_nameTextBox.Text, damaged_property_ownerTextBox.Text, move, vehicle_parking_addressTextBox.Text);
                this.rTA_DriverBindingSource.EndEdit();
                this.rTA_DriverTableAdapter.Insert(A[0], A[1], A[2], drunk, true, true, vehicle_damageTextBox.Text, property, damaged_property_nameTextBox.Text, damaged_property_ownerTextBox.Text, move, vehicle_parking_addressTextBox.Text);
                this.witnessBindingSource.EndEdit();
                this.witnessTableAdapter.Insert(2, surnameTextBox.Text, nameTextBox.Text, patronymicTextBox.Text, date1, addressTextBox.Text, phone_numberTextBox.Text);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed " + ex);
            }
        }

        private void rura()
        {
            //int rtaid = 0;
            var constr = new SqlConnectionStringBuilder()
            {
                DataSource = "localhost,1433",
                InitialCatalog = "RTA",
                IntegratedSecurity = true,
                TrustServerCertificate = true,
            };
           // var yy = new DateTime(2023, 12, 07, 18, 22, 55);
            using (var con = new SqlConnection(constr.ConnectionString))
            {
                string cmdstr = "select rta_id, driver_id, vehicle_id from RTA, driver, Vehicle where city = @city and street = @street and building = @b and date_and_time = @date and Number_plate = @plate and Driver_licence = @dl";
                using (var cmd = new SqlCommand(cmdstr, con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@city", cityTextBox.Text);
                        cmd.Parameters.AddWithValue("@street", streetTextBox.Text);
                        cmd.Parameters.AddWithValue("@b", buildingTextBox.Text);
                        cmd.Parameters.AddWithValue("@date", time);
                        cmd.Parameters.AddWithValue("@plate", number_plateTextBox.Text);
                        cmd.Parameters.AddWithValue("@dl", driver_licenceTextBox.Text);
                        con.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    A[0] = (int)reader.GetValue(0);
                                    A[1] = (int)reader.GetValue(1);
                                    A[2] = (int)reader.GetValue(2);
                                }
                            }
                        }
                        MessageBox.Show("Update successful");


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка входа");
                    }
                }
            }
        }

        private void da()
        {
            int rtaid = 0;
            var constr = new SqlConnectionStringBuilder()
            {
                DataSource = "localhost,1433",
                InitialCatalog = "RTA",
                IntegratedSecurity = true,
                TrustServerCertificate = true,
            };
            using (var con = new SqlConnection(constr.ConnectionString))
            {
                string cmdstr = "insert into RTA (City, Street, Building, Date_and_time, Number_of_wounded, Number_of_dead, by_an_GIBDD_officer, GIBDD_officer_id) values (@city, @street, @b, @date, @wound, @dead, 1, @gid)";
                using (var cmd = new SqlCommand(cmdstr, con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@city", cityTextBox.Text);
                        cmd.Parameters.AddWithValue("@street", streetTextBox.Text);
                        cmd.Parameters.AddWithValue("@b", buildingTextBox.Text);
                        cmd.Parameters.AddWithValue("@date", time);
                        cmd.Parameters.AddWithValue("@wound", number_of_woundedTextBox.Text);
                        cmd.Parameters.AddWithValue("@dead", number_of_deadTextBox.Text);
                        cmd.Parameters.AddWithValue("@gid", Form1.gid);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Update successful");
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
