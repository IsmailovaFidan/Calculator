using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Double value = 0;
        string operation = "";
        bool operation_click = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((txtbox_result.Text == "0")||(operation_click))
            {
                txtbox_result.Clear();
            }
            operation_click = false;
            Button b = (Button)sender;
            txtbox_result.Text = txtbox_result.Text + b.Text;
        }

      

        private void DeleteCE_Click(object sender, EventArgs e)
        {
            txtbox_result.Text = "0";
        }

        private void emeliyyat_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Convert.ToDouble(txtbox_result.Text);
            operation_click = true;
            equation.Text = value + " " + operation;


        }

        private void Button16_Click(object sender, EventArgs e)
        {

            equation.Text = "";
            switch (operation)
            {
                
                case "+":
                    txtbox_result.Text = (value + Convert.ToDouble(txtbox_result.Text)).ToString();
                    break;
                case "-":
                    txtbox_result.Text = (value - Convert.ToDouble(txtbox_result.Text)).ToString();
                    break;
                case "x":
                    txtbox_result.Text = (value * Convert.ToDouble(txtbox_result.Text)).ToString();
                    break;
                case "/":
                    txtbox_result.Text = (value / Convert.ToDouble(txtbox_result.Text)).ToString();
                    break;
                default:
                    break;

            }
           
        }

        private void DeleteC_Click(object sender, EventArgs e)
        {
            txtbox_result.Clear();
            value = 0;
        }

        private void Txtbox_result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
