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
    public partial class Form15 : Form
    {
        BindingSource Sbind = new BindingSource();
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rTADataSet2.CountWoundedAndDead". При необходимости она может быть перемещена или удалена.
            this.countWoundedAndDeadTableAdapter.Fill(this.rTADataSet2.CountWoundedAndDead);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "rTADataSet.CountWoundedAndDead". При необходимости она может быть перемещена или удалена.
            //this.countWoundedAndDeadTableAdapter.Fill(this.rTADataSet.CountWoundedAndDead);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "rTADataSet.CountWoundedAndDead". При необходимости она может быть перемещена или удалена.
            //this.countWoundedAndDeadTableAdapter.Fill(this.rTADataSet.CountWoundedAndDead);
            //DataTable dt = Autho();
            //Sbind.DataSource = dt;
            //dataGridView1.DataSource = Sbind;
            //{
            //    dataGridView1.Columns["Name"].HeaderText = "Обстоятельство ДТП";
            //    dataGridView1.Columns["Number_of_wounded"].HeaderText = "Количество раненных";
            //    dataGridView1.Columns["Number_of_dead"].HeaderText = "Количество погибших";
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //static DataTable Autho()
        //{
        //    DataTable dt = new DataTable();
        //    var constr = new SqlConnectionStringBuilder()
        //    {
        //        DataSource = "localhost,1433",
        //        InitialCatalog = "RTA",
        //        IntegratedSecurity = true,
        //        TrustServerCertificate = true,
        //    };

        //    using (var con = new SqlConnection(constr.ConnectionString))
        //    {
        //        string cmdstr = "select * from CountWoundedAndDead()";
        //        try
        //        {
        //            using (var cmd = new SqlCommand(cmdstr, con))
        //            {
        //                con.Open();
        //                SqlDataAdapter dataAdp = new SqlDataAdapter(cmd);
        //                using (var rdr = cmd.ExecuteReader())
        //                {
        //                    dt.Load(rdr);
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Ошибка: " + ex);
        //        }
        //    }
        //    return dt;
        //}
    }
}
