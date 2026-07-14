using Microsoft.Maui.Controls;

namespace Calculadora_6133261
{
    public partial class MainPage : ContentPage
    {
        string numero1 = "";
        string numero2 = "";
        string operador = "";
        bool esnuevo = true;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            string texto = boton.Text;

            if (texto == "0" || texto == "1" || texto == "2" || texto == "3" || texto == "4" ||
                texto == "5" || texto == "6" || texto == "7" || texto == "8" || texto == "9")
            {
                if (esnuevo)
                {
                    ResultLabel.Text = "";
                    esnuevo = false;
                }

                if (operador == "")
                {
                    numero1 = numero1 + texto;
                    ResultLabel.Text = ResultLabel.Text + texto;
                }
                else
                {
                    numero2 = numero2 + texto;
                    ResultLabel.Text = ResultLabel.Text + texto;
                }
            }
            else if (texto == ".")
            {
                if (operador == "")
                {
                    if (!numero1.Contains("."))
                    {
                        if (numero1 == "")
                        {
                            numero1 = "0";
                            ResultLabel.Text = "0";
                        }
                        numero1 = numero1 + ".";
                        ResultLabel.Text = ResultLabel.Text + ".";
                    }
                }
                else
                {
                    if (!numero2.Contains("."))
                    {
                        if (numero2 == "")
                        {
                            numero2 = "0";
                            ResultLabel.Text = ResultLabel.Text + "0";
                        }
                        numero2 = numero2 + ".";
                        ResultLabel.Text = ResultLabel.Text + ".";
                    }
                }
            }
            else if (texto == "+" || texto == "-" || texto == "*" || texto == "/")
            {
                if (numero1 != "")
                {
                    operador = texto;
                    esnuevo = true;
                    ResultLabel.Text = ResultLabel.Text + " " + texto + " ";
                }
            }
            else if (texto == "=")
            {
                if (numero1 != "" && numero2 != "" && operador != "")
                {
                    double num1 = Convert.ToDouble(numero1);
                    double num2 = Convert.ToDouble(numero2);
                    double resultado = 0;

                    if (operador == "+")
                    {
                        resultado = num1 + num2;
                    }
                    else if (operador == "-")
                    {
                        resultado = num1 - num2;
                    }
                    else if (operador == "*")
                    {
                        resultado = num1 * num2;
                    }
                    else if (operador == "/")
                    {
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                        }
                        else
                        {
                            ResultLabel.Text = "Error";
                            numero1 = "";
                            numero2 = "";
                            operador = "";
                            esnuevo = true;
                            return;
                        }
                    }
            else if (texto == "C")
                    {
                        ResultLabel.Text = "0";
                    }
                    ResultLabel.Text = resultado.ToString();
                    numero1 = resultado.ToString();
                    numero2 = "";
                    operador = "";
                    esnuevo = true;
                }
            }
        }
    }
}