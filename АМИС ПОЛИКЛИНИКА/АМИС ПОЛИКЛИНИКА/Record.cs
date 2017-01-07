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
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();

           

            toolTip1.SetToolTip(exit, "Не забудьте сохранить изменения!");
            toolTip1.IsBalloon = true;

            toolTip1.SetToolTip(getTicket, "Не забудьте сохранить изменения!");
            toolTip1.IsBalloon = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicDataSet);

        }

        private void Record_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clinicDataSet.AddrList". При необходимости она может быть перемещена или удалена.
            this.addrListTableAdapter.Fill(this.clinicDataSet.AddrList);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clinicDataSet.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter.Fill(this.clinicDataSet.Doctor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clinicDataSet.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.clinicDataSet.Patient);

        }

        
        private void getTicket_Click(object sender, EventArgs e)
        {
            Ticket f = new Ticket();
            f.Show();
            Close();
        }

        private void patientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void getTick_Click(object sender, EventArgs e)
        {
            Ticket f = new Ticket();
            f.Show();
            Close();
        }
    }
}
