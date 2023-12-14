using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rTADataSet.RtaCountByCar". При необходимости она может быть перемещена или удалена.
            this.rtaCountByCarTableAdapter.Fill(this.rTADataSet.RtaCountByCar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
