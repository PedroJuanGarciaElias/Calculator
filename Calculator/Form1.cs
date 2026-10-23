using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string texto;
        private bool ES = false;
        private bool error = false;
        private Timer parpadear;
        private int contador = 0;
        public Form1()
        {
            InitializeComponent();
            txtb1.ReadOnly = true; //El cuadro de texto es de solo lectura.
            CambiarIdioma();
            txtb1.GotFocus += Txtb1_GotFocus; //Se le asigna al Form.

            parpadear = new Timer();
            parpadear.Interval = 250;
            parpadear.Tick += parpadear_Tick;
        }

        private void parpadear_Tick(object sender, EventArgs e)
        {
            if (contador < 4)
            {
                if (contador % 2 == 0)
                {
                    txtb1.BackColor = System.Drawing.Color.Red;
                    txtb1.ForeColor = System.Drawing.Color.White;
                } else
                {
                    txtb1.BackColor = System.Drawing.Color.White;
                    txtb1.ForeColor = System.Drawing.Color.Black;
                }

                contador++;
                txtb1.Refresh(); //Refresca el cuadro de texto.
            } else
            {
                parpadear.Stop();
                txtb1.BackColor = System.Drawing.Color.Red;
                txtb1.ForeColor = System.Drawing.Color.White;
                txtb1.Refresh();
            }
        }

        private void Txtb1_GotFocus(object sender, EventArgs e)
        {
            ActiveControl = null; //Evita que el cursor se pueda poner dentro del cuadro de texto.
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (error) return; //De esta manera se bloquea el botón para que no escriba en el cuadro de texto cuando dé un error.
            txtb1.Text += "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (error) return;
            {
                
            }
            txtb1.Text += "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (error) return;
            txtb1.Text += "9";
        }

        private void btmulti_Click(object sender, EventArgs e)
        {
            if (error) return;
            txtb1.Text += "x";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (error) return;
            txtb1.Text += "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (error) return;
            txtb1.Text += "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (error) return;
            txtb1.Text += "6";
        }

        private void btresta_Click(object sender, EventArgs e)
        {
            if (error) return;
            txtb1.Text += "-";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (error) return;
            txtb1.Text += "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (error) return;
            txtb1.Text += "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (error) return;
            txtb1.Text += "3";
        }

        private void btsum_Click(object sender, EventArgs e)
        {
            if (error) return;
            txtb1.Text += "+";
        }

        private void btpow_Click(object sender, EventArgs e)
        {
            if (error) return;
            txtb1.Text += "^";
        }

        private void btnulo_Click(object sender, EventArgs e)
        {
            if (error) return;
            txtb1.Text += 0;
        }

        private void btcoma_Click(object sender, EventArgs e)
        {
            if (error) return;
            txtb1.Text += ES ? "," : "."; //Alterna entre coma y punto según el idioma.
        }

        private void btdiv_Click(Object sender, EventArgs e)
        {
            if (error) return;
            txtb1.Text += "/";
        }

        private void btidioma_Click(object sender, EventArgs e)
        {
            if (error) return;
            ES = !ES;
            CambiarIdioma();
            txtb1.Clear();
            texto = "";
        }

        private void CambiarIdioma()
        {
            if (ES)
            {
                btidioma.Text = "ES";
                btcoma.Text = ",";
                this.Text = "Calculadora";
                btdelete.Text = "Borrar";
            } else
            {
                btidioma.Text = "EN";
                btcoma.Text = ".";
                this.Text = "Calculator";
                btdelete.Text = "Delete";
            }
        }

        private void btraiz_Click(object sender, EventArgs e)
        {
            if (error) return;
            txtb1.Text += "√";
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            if (error) return;

            if (txtb1.Text.Length > 0)
            {
                txtb1.Text = txtb1.Text.Substring(0, txtb1.Text.Length - 1);
            }
        }

        private void IGUAL_Click(object sender, EventArgs e)
        {
            if (error) return;

            texto = txtb1.Text;
            try
            {
                //Sustituir las comas por puntos para tratarlos por igual.
                string textoSustituirDecimal = texto.Replace(",", ".");

                /*Patrón que contiene todos los símbolos matemáticos que se pueden escribir en la calculadora.
                  \- porque el - por sí solo indica rango. En general, \ para añadir caracteres con otros usos.*/
                string patron = @"([+\-x/√\^])";
                string[] elementos = Regex.Split(textoSustituirDecimal, patron); //Lista con todos los elementos. Dígitos y símbolos por separado.

                if (elementos.Length > 0)
                {
                    /*Convierte el primer elemento en un decimal en caso de no ser 0.
                      En el caso contrario no se añade al arreglo. CultureInfo sirve para gestionar el idioma del programa.*/
                    double resultado = string.IsNullOrEmpty(elementos[0]) ? 0 : double.Parse(elementos[0], CultureInfo.InvariantCulture);

                    //Ahora se recorre el arreglo al revés para poder tratar las raíces cuadradas.
                    for (int i = elementos.Length - 2; i >= 1; i -= 2) 
                    {
                        if (elementos[i] == "√")
                        {
                            double n = double.Parse(elementos[i + 1], CultureInfo.InvariantCulture);
                            double raiz = Math.Sqrt(n);

                            elementos[i + 1] = raiz.ToString(CultureInfo.InvariantCulture);

                            elementos[i] = "+";

                            if (string.IsNullOrEmpty(elementos[i - 1]))
                            {
                                elementos[i - 1] = "0";
                            }
                        }
                    }

                    //Salta de dos en dos.
                    for (int i = 1; i < elementos.Length; i += 2)
                    {
                        string operador = elementos[i]; //La variable operador recoge el valor de la lista, que tiene que ser un signo.
                        double siguienteNumero = Convert.ToDouble(elementos[i + 1], CultureInfo.InvariantCulture); //Convierte en decimal el siguiente número.
                    
                        switch (operador) //switch con las distintas operaciones.
                        {
                            case "+": resultado += siguienteNumero;
                                break;
                            case "-": resultado -= siguienteNumero;
                                break;
                            case "x": resultado *= siguienteNumero; 
                                break;
                            case "/":
                                if (siguienteNumero == 0) throw new DivideByZeroException(); //DivideByZeroException es la excepción concreta de dividir entre 0.
                                resultado /= siguienteNumero;
                                break;
                            case "^": resultado = Math.Pow(resultado, siguienteNumero);
                                break;
                            default:
                                return;
                        }
                    }

                    if (ES)
                    {
                        txtb1.Text = resultado.ToString(CultureInfo.GetCultureInfo("es-ES")); //Idioma español.
                    } else
                    {
                        txtb1.Text = resultado.ToString(CultureInfo.GetCultureInfo("en-US")); //Idioma inglés.
                    }

                    texto = resultado.ToString();
                }

            } catch (Exception) //El error si algo se hace mal.
            {
                txtb1.Text = "ERROR";
                texto = "";

                error = true;
                contador = 0;

                parpadear.Start();
            }

        }
    }
}