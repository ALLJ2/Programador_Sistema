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
                int lado1Ret = Convert.ToInt32(txtLado1Retangulo.Text);
                int lado2Ret = Convert.ToInt32(txtLado2Retangulo.Text);
                int lado3Ret = Convert.ToInt32(txtLado3Retangulo.Text);
                int lado4Ret = Convert.ToInt32(txtLado4Retangulo.Text);

                //Validação retangulo
                if (lado1Ret == lado2Ret && lado3Ret == lado4Ret)
                {
                    //Operação perimetro retãngulo
                    int resultadoPerimetroRetangulo = lado1Ret + lado2Ret + lado3Ret + lado4Ret;
                    lblResultadoPerimetroRet.Text = resultadoPerimetroRetangulo.ToString();

                }
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
