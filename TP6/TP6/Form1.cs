using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP6
{
    public partial class Form1 : Form
    {
        bool contieneOp = false, contienePunto = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            txtBox.Text = " ";
            contieneOp = false;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            txtBox.Text += "8";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            txtBox.Text += "7";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            txtBox.Text += "4";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            txtBox.Text += "9";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            txtBox.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            txtBox.Text += "6";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            txtBox.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            txtBox.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            txtBox.Text += "3";
        }
        private void Btn0_Click(object sender, EventArgs e)
        {
            txtBox.Text += "0";
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            if (txtBox.Text != "" && !contieneOp)
            {
                txtBox.Text += "+";
                contieneOp = true;
                contienePunto = false;
            }
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            if (txtBox.Text != "" && !contieneOp)
            {
                txtBox.Text += "-";
                contieneOp = true;
                contienePunto = false;
            }
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            if (txtBox.Text != "" && !contieneOp)
            {
                txtBox.Text += "*";
                contieneOp = true;
                contienePunto = false;
            }
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if (txtBox.Text != "" && !contieneOp)
            {
                txtBox.Text += "/";
                contieneOp = true;
                contienePunto = false;
            }
        }

        private void BtnPunto_Click(object sender, EventArgs e)
        {
            if (txtBox.Text != "" && !contieneOp)
            {
                txtBox.Text += ",";
                contienePunto = false;
            }
        }
        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                    Btn1.PerformClick();
                    break;
                case '2':
                    Btn2.PerformClick();
                    break;
                case '3':
                    Btn3.PerformClick();
                    break;
                case '4':
                    Btn4.PerformClick();
                    break;
                case '5':
                    Btn5.PerformClick();
                    break;
                case '6':
                    Btn6.PerformClick();
                    break;
                case '7':
                    Btn7.PerformClick();
                    break;
                case '8':
                    Btn8.PerformClick();
                    break;
                case '9':
                    Btn9.PerformClick();
                    break;
                case '0':
                    Btn0.PerformClick();
                    break;
                case '+':
                    BtnSuma.PerformClick();
                    break;
                case '-':
                    BtnResta.PerformClick();
                    break;
                case '/':
                    BtnDiv.PerformClick();
                    break;
                case '*':
                    BtnMult.PerformClick();
                    break;
                case '.':
                    BtnPunto.PerformClick();
                    break;
                default:
                    break;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BtnIgual.PerformClick();
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Delete))
            {
                BtnBorrar.PerformClick();
            }
        }


        private void BtnIgual_Click(object sender, EventArgs e)
        {
            calcularResultado();
        }


        public void calcularResultado()
        {
            string calculoFinal = txtBox.Text;
            Calculadora Resultado = new Calculadora();

            if (txtBox.Text.Contains('+'))
            {
                string[] arregloTexto = calculoFinal.Split('+');
                Resultado.Numero1 = Convert.ToSingle(arregloTexto[0]);
                Resultado.Numero2 = Convert.ToSingle(arregloTexto[1]);
                txtBox.Text = Resultado.suma().ToString();
            }
            else if (txtBox.Text.Contains('-'))
            {
                string[] arregloTexto = calculoFinal.Split('-');
                Resultado.Numero1 = Convert.ToSingle(arregloTexto[0]);
                Resultado.Numero2 = Convert.ToSingle(arregloTexto[1]);
                txtBox.Text = Resultado.resta().ToString();
            }
            else if (txtBox.Text.Contains('*'))
            {
                string[] arregloTexto = calculoFinal.Split('*');
                Resultado.Numero1 = Convert.ToSingle(arregloTexto[0]);
                Resultado.Numero2 = Convert.ToSingle(arregloTexto[1]);
                txtBox.Text = Resultado.multiplicacion().ToString();
            }
            else if (txtBox.Text.Contains('/'))
            {
                string[] arregloTexto = calculoFinal.Split('/');
                Resultado.Numero1 = Convert.ToSingle(arregloTexto[0]);
                Resultado.Numero2 = Convert.ToSingle(arregloTexto[1]);
                txtBox.Text = Resultado.division().ToString();
            }
        }

        


        
    }
}
