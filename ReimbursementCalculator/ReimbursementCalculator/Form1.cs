using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReimbursementCalculator
{
    public partial class form1 : Form
    {
        int starting;
        int ending;
        double miles;
        double reimbursementRate = .39;
        double amount;


        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            starting = (int)numericUpDown1.Value;
            ending = (int)numericUpDown2.Value;
            if (starting < ending)
            {
                miles = ending - starting;
                amount = miles * reimbursementRate;
                label4.Text = "$" + amount;

            }
            else
            {
                MessageBox.Show("The starting mileage must be less than the ending mileage", 
                                       "Cannot Calculate Mileage");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(miles + " miles", "Miles Traveled");
        }
    }
}
