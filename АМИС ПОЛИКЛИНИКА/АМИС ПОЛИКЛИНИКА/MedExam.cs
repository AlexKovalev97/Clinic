using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АМИС_ПОЛИКЛИНИКА
{
    public partial class MedExam : Form
    {
        public MedExam()
        {
            InitializeComponent();


            toolTip1.SetToolTip(doctorComboBox, "Пройдите регистрацию, если вы впервые в системе!");
            toolTip1.IsBalloon = true;

            toolTip1.SetToolTip(exit, "Не забудьте сохранить изменения!");
            toolTip1.IsBalloon = true;

        }

        private void MedExam_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clinicDataSet.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.clinicDataSet.Patient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clinicDataSet.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter.Fill(this.clinicDataSet.Doctor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clinicDataSet.Card". При необходимости она может быть перемещена или удалена.
            this.cardTableAdapter.Fill(this.clinicDataSet.Card);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clinicDataSet.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter.Fill(this.clinicDataSet.Doctor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clinicDataSet.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.clinicDataSet.Patient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clinicDataSet.Card". При необходимости она может быть перемещена или удалена.
            this.cardTableAdapter.Fill(this.clinicDataSet.Card);

        }

       

        private void cardBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cardBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicDataSet);

        }

       
        private void doctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void account_Click(object sender, EventArgs e)
        {

            int d = 0;
            int s = -1;
            for (int counter = 0; counter < (patientDataGridView.Rows.Count); counter++)
            {

                if (patientDataGridView.Rows[counter].Cells["Column1"].Value != null)
                {
                    d = d + 1;
                }
                else { s = s + 1; }

            }

            MessageBox.Show("Кол-во явившихся на прием пациентов: " + d + "\r\n" + "Кол-во не явивщихся на прием пациентов: " + s);

        }
    }
}
