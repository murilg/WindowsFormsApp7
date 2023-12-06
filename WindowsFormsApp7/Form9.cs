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
    public partial class Form9 : Form
    {
        BindingSource Sbind = new BindingSource();
        public Form9()
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
                string cmdstr = "select Surname, Name, Patronymic, Badge_number, Post, Special_rank, Division from GIBDD_officer";
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
                    case 0: pole = "Surname"; break;
                    case 1: pole = "Name"; break;
                    case 2: pole = "Patronymic"; break;
                    case 3: pole = "Badge_number"; break;
                    case 4: pole = "Post"; break;
                    case 5: pole = "Special_rank"; break;
                    case 6: pole = "Division"; break;
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

        private void Form9_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            DataTable dt = Autho();
            Sbind.DataSource = dt;
            dataGridView1.DataSource = Sbind;
            {
                dataGridView1.Columns["Surname"].HeaderText = "Фамилия";
                dataGridView1.Columns["Name"].HeaderText = "Имя";
                dataGridView1.Columns["Patronymic"].HeaderText = "Отчество";
                dataGridView1.Columns["Badge_number"].HeaderText = "Номер нагрудного знака";
                dataGridView1.Columns["Post"].HeaderText = "Должность";
                dataGridView1.Columns["Special_rank"].HeaderText = "Специальное звание";
                dataGridView1.Columns["Division"].HeaderText = "Подразделение";
            }
        }
    }
}
