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

<<<<<<< HEAD
        private void ageButton_Click(object sender, EventArgs e)
=======
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            country = cmb.SelectedIndex;

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
>>>>>>> origin/master
        {

        }

<<<<<<< HEAD
        public String CheckAge21(int age, String country)
        {
            String result = "";
            if (age > 21)
            {
                result = "You are able to drink in USA!";
            }

            return result;
        }
=======
        private void ageButton_Click(object sender, EventArgs e)
        {
            String result = "";

            switch (country)
            {
                case 0 :
                    //result = CheckAge18();
                    break;
                case 2:
                    //result = CheckAge21();
                    break;
                case 3:
                    //result = CheckAge18();
                    break;
                case 4:
                    //result = CheckAge0();
                    break;
                default:
                    result = "Don't drink!";
                    break;
            }

            System.Windows.Forms.MessageBox.Show(result);
        }

        
>>>>>>> origin/master
    }
}
