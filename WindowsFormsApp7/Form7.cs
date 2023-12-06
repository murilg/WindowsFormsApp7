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
    public partial class Form7 : Form
    {
        BindingSource Sbind = new BindingSource();
        public Form7()
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
                string cmdstr = "select I.Insurance, I.Type, convert(varchar(10), I.Date_of_issue, 104) AS Date_of_issue, Ic.Name, V.Make, V.Model, V.Number_plate, V.VIN, D.Surname, D.Name AS N_Name, D.Patronymic, D.Driver_licence, D.Category, convert(varchar(10), D.Date_of_issue, 104) AS D_Date_of_issue from Insurance I join Driver_Insurance DI on I.Insurance_id = DI.Insurance_id join Insurance_company Ic on Ic.Insurance_company_id = I.Insurance_company_id join Vehicle V on V.Vehicle_id = I.Vehicle_id join Driver D on D.Driver_id = DI.Driver_id";
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

        private void Form7_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            DataTable dt = Autho();
            Sbind.DataSource = dt;
            dataGridView1.DataSource = Sbind;
            {
                dataGridView1.Columns["Insurance"].HeaderText = "Номер страховки";
                dataGridView1.Columns["Type"].HeaderText = "Тип";
                dataGridView1.Columns["Date_of_issue"].HeaderText = "Дата начала страховки";
                dataGridView1.Columns["Name"].HeaderText = "Название страховой компании";
                dataGridView1.Columns["Make"].HeaderText = "Марка";
                dataGridView1.Columns["Model"].HeaderText = "Модель";
                dataGridView1.Columns["Number_plate"].HeaderText = "Госномер";
                dataGridView1.Columns["VIN"].HeaderText = "VIN";
                dataGridView1.Columns["Surname"].HeaderText = "Фамилия водителя";
                dataGridView1.Columns["N_Name"].HeaderText = "Имя";
                dataGridView1.Columns["Patronymic"].HeaderText = "Отчество";
                dataGridView1.Columns["Driver_licence"].HeaderText = "ВУ";
                dataGridView1.Columns["Category"].HeaderText = "Категория";
                dataGridView1.Columns["D_Date_of_issue"].HeaderText = "Дата выдачи ВУ";
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
                    case 0: pole = "Insurance"; break;
                    case 1: pole = "Type"; break;
                    case 2: pole = "Date_of_issue"; break;
                    case 3: pole = "Name"; break;
                    case 4: pole = "Make"; break;
                    case 5: pole = "Model"; break;
                    case 6: pole = "Number_plate"; break;
                    case 7: pole = "VIN"; break;
                    case 8: pole = "Surname"; break;
                    case 9: pole = "N_Name"; break;
                    case 10: pole = "Patronymic"; break;
                    case 11: pole = "Driver_licence"; break;
                    case 12: pole = "Category"; break;
                    case 13: pole = "D_Date_of_issue"; break;
                    default: pole = "Surname"; break;
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
