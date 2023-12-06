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
    public partial class Form6 : Form
    {
        BindingSource Sbind = new BindingSource();
        public Form6()
        {
            InitializeComponent();
        }

        static DataTable Autho()
        {
            DataTable dt = new DataTable();
            var constr = new SqlConnectionStringBuilder()
            {
                DataSource = "localhost,1433",
                InitialCatalog = "RTA",
                IntegratedSecurity = true,
                TrustServerCertificate = true,
            };

            using (var con = new SqlConnection(constr.ConnectionString))
            {
                string cmdstr = "select CONVERT(VARCHAR, R.RTA_id) AS RTA_id, V.Make, V.Model, V.Number_plate, V.VIN, V.Registration, O.Surname AS V_Surname, O.Name as V_Name, O.Patronymic as V_Patronymic, O.Address as V_Address, D.Surname, D.Name, D.Patronymic, D.Date_of_birth, D.Address, D.Phone_number, D.Driver_licence, D.Category, D.Date_of_birth, Ic.Name as Ic_Name, I.Insurance, R.City, R.Street, R.Building, R.Date_and_time, R.Number_of_wounded, R.Number_of_dead, R.by_an_GIBDD_officer from RTA R join RTA_Driver RD on R.RTA_id = RD.RTA_id join dbo.Vehicle V on V.Vehicle_id = RD.Vehicle_id join Driver O on O.Driver_id = V.Owner_id join Driver D on D.Driver_id = RD.Driver_id join Insurance I on V.Vehicle_id = I.Vehicle_id join Insurance_company Ic on Ic.Insurance_company_id = I.Insurance_company_id";
                try
                {
                    using (var cmd = new SqlCommand(cmdstr, con))
                    {

                        con.Open();
                        SqlDataAdapter dataAdp = new SqlDataAdapter(cmd);
                        using (var rdr = cmd.ExecuteReader())
                        {

                            dt.Load(rdr);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex);
                }
            }
            return dt;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            DataTable dt = Autho();
            Sbind.DataSource = dt;
            dataGridView1.DataSource = Sbind;
            {
                dataGridView1.Columns["RTA_id"].HeaderText = "Код ДТП";
                dataGridView1.Columns["Make"].HeaderText = "Марка";
                dataGridView1.Columns["Model"].HeaderText = "Модель";
                dataGridView1.Columns["Number_plate"].HeaderText = "Госномер";
                dataGridView1.Columns["VIN"].HeaderText = "VIN";
                dataGridView1.Columns["Registration"].HeaderText = "СТС";
                dataGridView1.Columns["V_Surname"].HeaderText = "Фамилия владельца";
                dataGridView1.Columns["V_Name"].HeaderText = "Имя владельца";
                dataGridView1.Columns["V_Patronymic"].HeaderText = "Отчество владельца";
                dataGridView1.Columns["V_Address"].HeaderText = "Адрес владельца";
                dataGridView1.Columns["Surname"].HeaderText = "Фамилия водителя";
                dataGridView1.Columns["Name"].HeaderText = "Имя водителя";
                dataGridView1.Columns["Patronymic"].HeaderText = "Отчество водителя";
                dataGridView1.Columns["Date_of_birth"].HeaderText = "Дата рождения водителяя";
                dataGridView1.Columns["Address"].HeaderText = "Адрес водителя";
                dataGridView1.Columns["Phone_number"].HeaderText = "Номер телефона водителя";
                dataGridView1.Columns["Driver_licence"].HeaderText = "ВУ";
                dataGridView1.Columns["Category"].HeaderText = "Категория";
                dataGridView1.Columns["Ic_Name"].HeaderText = "Название страховой организации";
                dataGridView1.Columns["Insurance"].HeaderText = "Серия и номер страховки";
                dataGridView1.Columns["City"].HeaderText = "Город";
                dataGridView1.Columns["Street"].HeaderText = "Улица";
                dataGridView1.Columns["Building"].HeaderText = "Дом";
                dataGridView1.Columns["Date_and_time"].HeaderText = "Дата и время";
                dataGridView1.Columns["Number_of_wounded"].HeaderText = "Кол-во раненых";
                dataGridView1.Columns["Number_of_dead"].HeaderText = "Кол-во погибших";
                dataGridView1.Columns["by_an_GIBDD_officer"].HeaderText = "Оформлялось ли сотрудником ГИБДД";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                Sbind.Filter = "";
            }
            else
            {
                string pole = "";
                switch (comboBox1.SelectedIndex)
                {
                    case 0: pole = "RTA_id"; break;
                    case 1: pole = "Make"; break;
                    case 2: pole = "Model"; break;
                    case 3: pole = "Number_plate"; break;
                    case 4: pole = "VIN"; break;
                    case 5: pole = "Registration"; break;
                    case 6: pole = "V_Surname"; break;
                    case 7: pole = "V_Name"; break;
                    case 8: pole = "V_Patronymic"; break;
                    case 9: pole = "V_Address"; break;
                    case 10: pole = "Surname"; break;
                    case 11: pole = "Name"; break;
                    case 12: pole = "Patronymic"; break;
                    case 13: pole = "Date_of_birth"; break;
                    case 14: pole = "Address"; break;
                    case 15: pole = "Phone_number"; break;
                    case 16: pole = "Driver_licence"; break;
                    case 17: pole = "Category"; break;
                    case 18: pole = "Ic_Name"; break;
                    case 19: pole = "Insurance"; break;
                    case 20: pole = "City"; break;
                    case 21: pole = "Street"; break;
                    case 22: pole = "Building"; break;
                    case 23: pole = "Date_and_time"; break;
                    case 24: pole = "Number_of_wounded"; break;
                    case 25: pole = "Number_of_dead"; break;
                    case 26: pole = "by_an_GIBDD_officer"; break;
                    default: pole = "RTA_id"; break;
                }

                Sbind.Filter = pole + " like '" + textBox1.Text.ToString() + "%'";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                for (int i = 0; i < dataGridView1.ColumnCount; ++i)
                {
                    for (int j = 0; j < dataGridView1.RowCount; ++j)
                    {
                        dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.White;
                        dataGridView1.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                    }
                }
            }
            else
            {
                for (int i = 0; i < dataGridView1.ColumnCount; ++i)
                {
                    for (int j = 0; j < dataGridView1.RowCount; ++j)
                    {
                        dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.White;
                        dataGridView1.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                    }
                }
                if (comboBox2.SelectedIndex == 0)
                {
                    for (int i = 0; i < dataGridView1.ColumnCount; ++i)
                    {
                        for (int j = 0; j < dataGridView1.RowCount; ++j)
                        {
                            var value = dataGridView1.Rows[j].Cells[i].Value;
                            if (value != null)
                            {
                                String baseStr = value.ToString();
                                if (baseStr.IndexOf(textBox2.Text) > -1)
                                {
                                    dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.Yellow;
                                    dataGridView1.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                                }
                            }
                        }
                    }
                }
                else
                {
                    int columnID = 0;
                    switch (comboBox2.SelectedIndex)
                    {
                        case 1: columnID = 0; break;
                        case 2: columnID = 1; break;
                        case 3: columnID = 2; break;
                        case 4: columnID = 3; break;
                        case 5: columnID = 4; break;
                        case 6: columnID = 5; break;
                        case 7: columnID = 6; break;
                        case 8: columnID = 7; break;
                        case 9: columnID = 8; break;
                        case 10: columnID = 9; break;
                        case 11: columnID = 10; break;
                        case 12: columnID = 11; break;
                        case 13: columnID = 12; break;
                        case 14: columnID = 13; break;
                        case 15: columnID = 14; break;
                        case 16: columnID = 15; break;
                        case 17: columnID = 16; break;
                        case 18: columnID = 17; break;
                        case 19: columnID = 18; break;
                        case 20: columnID = 19; break;
                        case 21: columnID = 20; break;
                        case 22: columnID = 21; break;
                        case 23: columnID = 22; break;
                        case 24: columnID = 23; break;
                        case 25: columnID = 24; break;
                        case 26: columnID = 25; break;
                        case 27: columnID = 26; break;
                        default: columnID = 0; break;
                    }

                    for (int j = 0; j < dataGridView1.RowCount; ++j)
                    {
                        var value = dataGridView1.Rows[j].Cells[columnID].Value;
                        if (value != null)
                        {
                            String baseStr = value.ToString();
                            if (baseStr.IndexOf(textBox2.Text) > -1)
                            {
                                dataGridView1.Rows[j].Cells[columnID].Style.BackColor = Color.Yellow;
                                dataGridView1.Rows[j].Cells[columnID].Style.ForeColor = Color.Black;
                            }
                        }
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
