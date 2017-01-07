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
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();

            toolTip1.SetToolTip(exit, "Не забудьте сохранить изменения!");
            toolTip1.IsBalloon = true;

            
        }

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicDataSet);

        }

        private void Book_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clinicDataSet.Book". При необходимости она может быть перемещена или удалена.
            this.bookTableAdapter.Fill(this.clinicDataSet.Book);

        }

        private void bookDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

       

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
