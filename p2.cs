using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        double pantalla;
        double valor1;
        double valor2;
        int operacion;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int digito;
            digito=Convert.ToInt32(((Button)sender).Text);
            pantalla = pantalla * 10 + digito;
            textBox1.Text = pantalla.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pantalla = 0;
            textBox1.Text = pantalla.ToString();
        }

        private void Suma(object sender, EventArgs e)
        {
            operacion = 1;
            valor1 = Convert.ToDouble(textBox1.Text);

            textBox1.Text = "";
            pantalla = 0;
         
        }

        private void igual(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(textBox1.Text);
            
            switch (operacion)
            {
                case 1:
                    pantalla = valor1 + valor2;
                    break;
                case 2:
                    pantalla = valor1 - valor2;
                    break;
                case 3:
                    pantalla = valor1 * valor2;
                    break;
                case 4:
                    pantalla = valor1 / valor2;
                    break;

            }
            textBox1.Text = pantalla.ToString();
            pantalla = 0;

        }

        private void resta(object sender, EventArgs e)
        {
            operacion=2;
            valor1 = Convert.ToDouble(textBox1.Text);

            textBox1.Text = "";
            pantalla = 0;

        }

        private void multiplicacion(object sender, EventArgs e)
        {
            operacion = 3;
            valor1 = Convert.ToDouble(textBox1.Text);

            textBox1.Text = "";
            pantalla = 0;
        }

        private void division(object sender, EventArgs e)
        {
            operacion = 4;
            valor1 = Convert.ToDouble(textBox1.Text);

            textBox1.Text = "";
            pantalla = 0;
        }

        private void clear(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }
    }
}
