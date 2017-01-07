using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace АМИС_ПОЛИКЛИНИКА
{
    public partial class RegPatient : Form
    {
        public RegPatient()
        {
            InitializeComponent();

            toolTip1.SetToolTip(exit, "Не забудьте сохранить изменения!");
            toolTip1.IsBalloon = true;
        }
        
        private void RegPatient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clinicDataSet.AddrList". При необходимости она может быть перемещена или удалена.
            this.addrListTableAdapter.Fill(this.clinicDataSet.AddrList);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clinicDataSet.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.clinicDataSet.Patient);
            
        }


        
        

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicDataSet);

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
