using Microsoft.Reporting.WinForms;
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
    public partial class ForReport : Form
    {
        public ForReport()
        {
            InitializeComponent();
        }

        private void ForReport_Load(object sender, EventArgs e)
        {
            DataTable dt1 = GetData("gag @rtaid");
            DataTable dt2 = GetData("Car2 @rtaid");
            DataTable dt3 = GetData("Car1 @rtaid");
            DataTable dt4 = GetData("Witness1 @rtaid");
            DataTable dt5 = GetData("Witness2 @rtaid");
            ReportDataSource datasource1 = new ReportDataSource("DataSet1", dt1);
            ReportDataSource datasource2 = new ReportDataSource("DataSet2", dt2);
            ReportDataSource datasourсe3 = new ReportDataSource("DataSet3", dt3);
            ReportDataSource datasourсe4 = new ReportDataSource("DataSet4", dt4);
            ReportDataSource datasourсe5 = new ReportDataSource("DataSet5", dt5);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datasource1);
            reportViewer1.LocalReport.DataSources.Add(datasource2);
            reportViewer1.LocalReport.DataSources.Add(datasourсe3);
            reportViewer1.LocalReport.DataSources.Add(datasourсe4);
            reportViewer1.LocalReport.DataSources.Add(datasourсe5);
            reportViewer1.RefreshReport();
        }

        private DataTable GetData(string query)
        {
            var constr = new SqlConnectionStringBuilder()
            {
                DataSource = "localhost,1433",
                InitialCatalog = "RTA",
                IntegratedSecurity = true,
                TrustServerCertificate = true
            };
            using (SqlConnection con = new SqlConnection(constr.ConnectionString))
            {
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@rtaid", Form6.rtaid);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable ds = new DataTable();
                    sda.Fill(ds);
                    return ds;
                }
            }
        }
    }
}
