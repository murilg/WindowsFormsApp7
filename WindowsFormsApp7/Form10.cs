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
        private static DateTime time;
        int[] A = new int[5];
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
        
            bool drunk = false;
            bool property = false;
            bool move = false;
            bool drunk2 = false;
            bool property2 = false;
            bool move2 = false;
            if (the_driver_is_drunkCheckBox.Checked)
                drunk = true;
            if (damage_to_other_propertyCheckBox.Checked)
                property = true;
            if (can_the_vehicle_moveCheckBox.Checked)
                move = true;
            if (checkBox1.Checked)
                drunk2 = true;
            if (checkBox3.Checked)
                property2 = true;
            if (checkBox2.Checked)
                move2 = true;
          
            try
            {
                da();
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
                this.rTA_DriverTableAdapter.Insert(A[0], A[3], A[4], drunk2, true, true, textBox5.Text, property2, textBox4.Text, textBox3.Text, move2, textBox2.Text);
                this.witnessBindingSource.EndEdit();
                this.witnessTableAdapter.Insert(A[0], surnameTextBox.Text, nameTextBox.Text, patronymicTextBox.Text, date_of_birthDateTimePicker.Value.Date, addressTextBox.Text, phone_numberTextBox.Text);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed " + ex);
            }
        }

        //private int truba()
        //{
        //    int i;
        //    switch (comboBox1.SelectedIndex)
        //    {
        //        case 0: pole = "Surname"; break;
        //        case 1: pole = "Name"; break;
        //        case 2: pole = "Patronymic"; break;
        //        case 3: pole = "Date_of_birth"; break;
        //        case 4: pole = "Address"; break;
        //        case 5: pole = "Phone_number"; break;
        //        default: pole = "Surname"; break;
        //    }
        //    return i;
        //}

            private void rura()
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
                string cmdstr = "select rta_id, d1.driver_id as notdriver, v1.vehicle_id as notvehicle, d2.Driver_id, v2.Vehicle_id from RTA, driver d1, driver d2, Vehicle v1, Vehicle v2 where city = @city and street = @street and building = @b and date_and_time = @date and v1.Number_plate = @plate1 and v2.Number_plate = @plate2 and d1.Driver_licence = @dl1 and d2.Driver_licence = @dl2";
                using (var cmd = new SqlCommand(cmdstr, con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@city", cityTextBox.Text);
                        cmd.Parameters.AddWithValue("@street", streetTextBox.Text);
                        cmd.Parameters.AddWithValue("@b", buildingTextBox.Text);
                        cmd.Parameters.AddWithValue("@date", time);
                        cmd.Parameters.AddWithValue("@plate1", number_plateTextBox.Text);
                        cmd.Parameters.AddWithValue("@plate2", textBox7.Text);
                        cmd.Parameters.AddWithValue("@dl1", driver_licenceTextBox.Text);
                        cmd.Parameters.AddWithValue("@dl2", textBox1.Text);
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
                                    A[3] = (int)reader.GetValue(3);
                                    A[4] = (int)reader.GetValue(4);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
