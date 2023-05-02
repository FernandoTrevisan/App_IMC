using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace imc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // entry a entrada do texto 
            // f2 = covertendo a string em duas  cassas decimais
            //duble tipo da variavel parsel e converter a variavel em double
            // label legenda da entrada de texto
            //button cliked ele cria o evento
            double altura = double.Parse(texto_altura.Text);    
            double peso = double.Parse(texto_peso.Text);        
                                                                
            double calculo_imc = peso / (altura * altura);

            string msg = "Seu IMC é de " + calculo_imc.ToString("f2");   

            if (calculo_imc < 18.5)
            {
                DisplayAlert("ABAIXO DO PESO", msg, "OK");
            }
            else if (calculo_imc < 25 && calculo_imc >= 18.5)
            {
                 DisplayAlert("PESO normal", msg, "OK");
            }
            else if (calculo_imc < 30 && calculo_imc >= 25)
            {
                DisplayAlert("SOBREPESO", msg, "OK");
            }
            else if (calculo_imc < 35 && calculo_imc >= 30)
            {
                DisplayAlert("OBESIDADE GRAU 1", msg, "OK");
            }
            else if (calculo_imc < 40 && calculo_imc >= 35)
            {
                DisplayAlert("OBESIDADE GRAU 2", msg, "OK");
            }
            else if (calculo_imc >= 40)
            {
                DisplayAlert("MORBIDA", msg, "OK");
            }

        }
    }
}
