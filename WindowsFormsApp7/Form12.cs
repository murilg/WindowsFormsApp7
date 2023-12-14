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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.getRtaWitnessesTableAdapter.Fill(this.rTADataSet2.GetRtaWitnesses, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(rTADateAndTimeToolStripTextBox.Text, typeof(System.DateTime))))), rTACityToolStripTextBox.Text, rTAStreetToolStripTextBox.Text, rTABuildingToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
