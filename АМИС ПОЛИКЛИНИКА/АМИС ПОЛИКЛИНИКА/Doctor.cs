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
    public partial class Doctor : Form
    {
        ToolStripLabel timeLabel;
        ToolStripLabel infoLabel;
        DateTime date;

        public Doctor()
        {
            InitializeComponent();

            infoLabel = new ToolStripLabel();
            infoLabel.Text = "Время в системе:";

            timeLabel = new ToolStripLabel();

            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(timeLabel);

            date = DateTime.Now;
            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();




        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {

                case 0:
                   ShowList f1 = new ShowList();
                    f1.Show();
                    
                    break;
                case 1:
                    MedExam f2 = new MedExam();
                    f2.Show();
                    
                    break;

                case 2:
                    Book f3 = new Book();
                    f3.Show();
                  
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            long tick = DateTime.Now.Ticks - date.Ticks;
            DateTime StopWatch = new DateTime();
            StopWatch = StopWatch.AddTicks(tick);

            timeLabel.Text = String.Format("{0:HH:mm:ss}", StopWatch);
        }
    }
}
