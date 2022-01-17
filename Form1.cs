using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtActual = Math.PI.ToString();
            
            

            double pi_over_4 = 0;
            int num_terms = int.Parse(textBox1.Text);
            double sign = 1;
            for (int term = 0; term < num_terms; term++)
            {
                //couldn't get it to work without writing to console
               Console.WriteLine(sign + " / " + (term * 2 + 1) + " = " +
                    (1.0 / (term * 2 + 1)));
                pi_over_4 += sign / (term * 2 + 1);
                sign *= -1;
            }

            
            double pi = 4 * pi_over_4;
            string txtCalculated  = pi.ToString();

            textBox2.AppendText("Approximate Value of pi after " +textBox1.Text+ " terms is "+ txtCalculated);
        }
    }
}
