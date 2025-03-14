using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculoTriangulo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcularPerimetro_Click(object sender, EventArgs e)
        {
            {
                double lado1Ret = Convert.ToDouble(txtLado1Retangulo.Text);
                double lado2Ret = Convert.ToDouble(txtLado2Retangulo.Text);
                double lado3Ret = Convert.ToDouble(txtLado3Retangulo.Text);
                double lado4Ret = Convert.ToDouble(txtLado4Retangulo.Text);

                //Validação retangulo
                if (lado1Ret == lado2Ret && lado3Ret == lado4Ret)
                {
                    //Operação perimetro retãngulo
                    double resultadoPerimetroRetangulo = lado1Ret + lado2Ret + lado3Ret + lado4Ret;
                    lblResultadoPerimetroRet.Text = resultadoPerimetroRetangulo.ToString();

                }

                if(lado1Ret && lado2Ret == lado3Ret && lado4Ret)
                { lblResultadoPerimetroRet.Text = "Isso é um quadrado".ToString(); }

                else
                {
                    lblResultadoPerimetroRet.Text = "Não é um retãngulo".ToString();
                    lblResultadoPerimetroRet.ForeColor = Color.Red;

                }
            }
        }

        private void linkVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
