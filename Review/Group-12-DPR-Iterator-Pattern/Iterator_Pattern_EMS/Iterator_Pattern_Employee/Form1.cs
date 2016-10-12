using Iterator_Pattern_Employee.Aggregate;
using Iterator_Pattern_Employee.Iterator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iterator_Pattern_Employee
{
    public partial class Form1 : Form
    {
        IEmployee hr;
        IEmployee it;
        IEmployee mn;

        IIterator hrIterator;
        IIterator itIterator;
        IIterator mnIterator;



        public Form1()
        {
            InitializeComponent();
            hr = new HR();
            it = new ICT();
            mn = new Management();

            hrIterator = hr.CreateIterator();
            itIterator = it.CreateIterator();
            mnIterator = mn.CreateIterator();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                while (!hrIterator.IsDone())
                {
                    listBox1.Items.Add(hrIterator.Next());


                }
            }
            else if (radioButton2.Checked)
            {
                while (!itIterator.IsDone())
                {
                    listBox1.Items.Add(itIterator.Next());

                }
            }
            else if(radioButton3.Checked)
            {
                while (!mnIterator.IsDone())
                {
                    listBox1.Items.Add(mnIterator.Next());

                }
            }
        }

         

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
