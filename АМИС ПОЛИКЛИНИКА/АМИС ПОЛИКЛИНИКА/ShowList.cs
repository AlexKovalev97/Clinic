using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АМИС_ПОЛИКЛИНИКА
{
    public partial class ShowList : Form
    {
        public ShowList()
        {
            InitializeComponent();
        }


        private void ShowList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clinicDataSet.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.clinicDataSet.Patient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clinicDataSet.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.clinicDataSet.Patient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clinicDataSet.Card". При необходимости она может быть перемещена или удалена.
            this.cardTableAdapter.Fill(this.clinicDataSet.Card);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clinicDataSet.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter.Fill(this.clinicDataSet.Doctor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clinicDataSet.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.clinicDataSet.Patient);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cardTableAdapter.FillBy(this.clinicDataSet.Card);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void doctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
