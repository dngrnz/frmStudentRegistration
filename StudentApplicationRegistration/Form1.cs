using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApplicationRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {

                comboBox1.Items.Add(i);
            }
            for (int i = 1; i <= 12; i++)
            {
                comboBox2.Items.Add(i);
            }
            int currentYear = DateTime.Now.Year;
            for (int i = 1900; i <= currentYear; i++)
            {
                comboBox3.Items.Add(i);
            }
            
        }
    }


        }


