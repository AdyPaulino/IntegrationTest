using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegrationTest
{
    public partial class Form1 : Form
    {

        private int country;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {



        }

        private void label2_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            country = cmb.SelectedIndex;

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ageButton_Click(object sender, EventArgs e)
        {
            switch (country)
            {
                case 0 :
                    //CheckAge18();
                    break;
                case 2:
                    //CheckAge21();
                    break;
                case 3:
                    //CheckAge18();
                    break;
                case 4:
                    //CheckAge0();
                    break;
                default:
                    break;
            }
        }

        
    }
}
