using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1: Form
    {
        private decimal val1;
        private decimal val2;
        private decimal res;
        private int operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //boton 8
            resultado.Text = resultado.Text + 8;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //boton 9
            resultado.Text = resultado.Text + 9;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //boton 0
            resultado.Text = resultado.Text + 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //boton 7
            resultado.Text = resultado.Text + 7;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //boton puntt decimal
            resultado.Text = resultado.Text + ",";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            //boton suma
            operacion = 1;
            val1 = Convert.ToDecimal(resultado.Text);
            resultado.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //boton 1
            resultado.Text = resultado.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //boton 2
            resultado.Text = resultado.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //boton 3
            resultado.Text = resultado.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //boton 4
            resultado.Text = resultado.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //boton 5
            resultado.Text = resultado.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //boton 6
            resultado.Text = resultado.Text + 6;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //boton igual resultado
            val2 = Convert.ToDecimal(resultado.Text);
  
            switch (operacion) {
                case 1:
                    res = val1 + val2;
                    break;
                case 2:
                    res = val1 - val2;
                    break;
                case 3:
                    res = val1 * val2;
                    break;
                case 4:
                    res = val1 / val2;
                    break;

            }

            resultado.Text = res.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //boton resta
            operacion = 2;
            val1 = Convert.ToDecimal(resultado.Text);
            resultado.Text = "";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //boton multiplicar
            operacion = 3;
            val1 = Convert.ToDecimal(resultado.Text);
            resultado.Text = "";

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //boton dividir
            operacion = 4;
            val1 = Convert.ToDecimal(resultado.Text);
            resultado.Text = "";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //boton borrar
            resultado.Text = " ";
        }
    }
}
