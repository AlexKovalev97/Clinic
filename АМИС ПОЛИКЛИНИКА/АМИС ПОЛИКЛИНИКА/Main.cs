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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void registrator_Click(object sender, EventArgs e)
        {
            Registr f = new Registr();
            f.Show();
            //Hide();
        }

        private void doctor_Click(object sender, EventArgs e)
        {
            Doctor f = new Doctor();
            f.Show();
            //Hide();
        }
    }
}
