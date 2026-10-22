using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string texto;
        public Form1()
        {
            InitializeComponent();
            txtb1.ReadOnly = true;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            txtb1.Text += "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            txtb1.Text += "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            txtb1.Text += "9";
        }

        private void btmulti_Click(object sender, EventArgs e)
        {
            txtb1.Text += "x";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            txtb1.Text += "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            txtb1.Text += "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            txtb1.Text += "6";
        }

        private void btresta_Click(object sender, EventArgs e)
        {
            txtb1.Text += "-";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            txtb1.Text += "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            txtb1.Text += "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            txtb1.Text += "3";
        }

        private void btsum_Click(object sender, EventArgs e)
        {
            txtb1.Text += "+";
        }

        private void btpow_Click(object sender, EventArgs e)
        {

        }

        private void btnulo_Click(object sender, EventArgs e)
        {
            txtb1.Text += 0;
        }

        private void btcoma_Click(object sender, EventArgs e)
        {
            txtb1.Text += ".";
        }

        private void btdiv_Click(Object sender, EventArgs e)
        {
            txtb1.Text += "/";
        }

        private void IGUAL_Click(object sender, EventArgs e)
        {
            texto = txtb1.Text;
            try
            {
                /*Patrón que contiene todos los símbolos matemáticos que se pueden escribir en la calculadora.
                  \- porque el - por sí solo indica rango. En general, \ para añadir caracteres con otros usos.*/
                string patron = @"([+\-x/\^])";
                string[] elementos = Regex.Split(texto, patron); //Lista con todos los elementos. Dígitos y símbolos por separado.

                if (elementos.Length > 0)
                {
                    double resultado = Convert.ToDouble(elementos[0]); //Convierte el primer elemento en un decimal porque siempre es un número.

                    for (int i = 1; i < elementos.Length; i += 2) //Va en dos en dos porque partiendo desde 0 los índices pares son números y los impares signos.
                    {
                        string operador = elementos[i]; //La variable operador recoge el valor de la lista, que tiene que ser un signo.
                        double siguienteNumero = Convert.ToDouble(elementos[i + 1]); //Convierte en decimal el siguiente número.
                    
                        switch (operador) //switch con  las distintas operaciones.
                        {
                            case "+": resultado += siguienteNumero;
                                break;
                            case "-": resultado -= siguienteNumero;
                                break;
                            case "x": resultado *= siguienteNumero; 
                                break;
                            case "/": resultado /= siguienteNumero;
                                break;
                            case "^": Math.Pow(resultado, siguienteNumero);
                                break;
                            default:
                                return;
                        }
                    }

                    txtb1.Text = resultado.ToString();

                    texto = resultado.ToString();
                }

            } catch (Exception) //El error si algo se hace mal.
            {
                txtb1.Text = "ERROR";
                texto = "";
            }

        }
    }
}