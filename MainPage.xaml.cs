using System;
using Xamarin.Forms;

namespace IMCCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Altura.Text) && !string.IsNullOrEmpty(Peso.Text))
            {
                var altura = double.Parse(Altura.Text);
                var peso = double.Parse(Peso.Text);
                var imc = peso / (altura * altura); // PESO EN KILOGRAMOS Y ALTURA EN METROS

                IMC.Text = imc.ToString();

                string resultado = "";
                if (imc < 16)
                {
                    resultado = "Desnutrición Severa";
                }
                else if (imc >= 16.1 && imc <= 18.4)
                {
                    resultado = "Desnutrición Moderada";
                }
                else if (imc >= 18.5 && imc <= 22)
                {
                    resultado = "Bajo Peso";
                }
                else if (imc >= 22.1 && imc < 25)
                {
                    resultado = "Peso Normal";
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    resultado = "Sobre Peso";
                }
                else if (imc >= 30 && imc <= 34.9)
                {
                    resultado = "Obesidad Tipo I";
                }
                else if (imc >= 35 && imc <= 39.9)
                {
                    resultado = "Obesidad Tipo II";
                }
                else if (imc > 40)
                {
                    resultado = "Obesidad Tipo III";
                }

                DisplayAlert("Resultado", resultado, "OK");
            }
            else
            {
                DisplayAlert("Datos Erróneos", "Rellena los Campos", "OK");
            }
        }
    }
}
