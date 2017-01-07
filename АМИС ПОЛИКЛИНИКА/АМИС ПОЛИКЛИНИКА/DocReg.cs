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
    public partial class DocReg : Form
    {
        public DocReg()
        {
            InitializeComponent();
            toolTip1.SetToolTip(exit, "Не забудьте сохранить изменения!");
            toolTip1.IsBalloon = true;
        }

        private void doctorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicDataSet);

        }

        private void DocReg_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clinicDataSet.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter.Fill(this.clinicDataSet.Doctor);

        }

       

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
