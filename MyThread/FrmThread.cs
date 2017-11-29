using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_06
{
    public partial class FrmThread : Form
    {
        public FrmThread()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long sum = LongTask();
            MessageBox.Show("sum =" + sum);
        }

         long LongTask()
        {
            long sum = 0;

            for(long i=1; i<=int.MaxValue;i++)
            {
                sum += i;
            }
            return sum;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //
            this.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
