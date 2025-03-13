using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNum1.Text);
            int num2 = Convert.ToInt32(txtNum2.Text);

        }

        private static double Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        private static double Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        private static double Vezes(int num1, int num2)
        {
            return num1 * num2;
        }

        private static double Dividir(int num1, int num2)
        {
            return num1 / num2;
        }


        private void lblVoltar_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void SelectAdd_CheckedChanged(object sender, EventArgs e)
        {


            lblCalculo.Text = "+";
        }

        private void SelectSub_CheckedChanged(object sender, EventArgs e)
        {

            lblCalculo.Text = "-";
        }

        private void SelectMulti_CheckedChanged(object sender, EventArgs e)
        {

            lblCalculo.Text = "x";
        }

        private void SelectDiv_CheckedChanged(object sender, EventArgs e)
        {

            lblCalculo.Text = "/";
        }
    }
}
