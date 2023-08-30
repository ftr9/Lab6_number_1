using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void compare_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length ==0 || textBox2.Text.Length ==0)
            {
                Result.Text = "Please Fill out both fields";
                return;
            }

            try
            {
                var num1 = double.Parse(textBox1.Text);
                var num2 = double.Parse(textBox2.Text);
                if (num1 < num2)
                    Result.Text = "Number 1 is smaller.";
                else if (num1 > num2)
                    Result.Text = "Number 1 is greater.";
                else
                    Result.Text = "Both numbers are equal.";
            }catch(FormatException ex)
            {
                Result.Text = "Please Enter Number Value only!!!!";
            }
           
            
        }

        private void Result_Click(object sender, EventArgs e)
        {

        }
    }
}
