using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace firstProject.RegrasdeNegocios
{
    /// <summary>
    /// Lógica interna para CalculadoraWindow.xaml
    /// </summary>
    public partial class CalculadoraWindow : Window
    {
        public CalculadoraWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double peso = Convert.ToDouble(TxtBoxPeso.Text);
            double altura = Convert.ToDouble(TxtBoxAltura.Text);
            double calculo;
            calculo = peso / (altura * altura);
            if (calculo < 18.5)
            {
                MessageBox.Show("o resultado do IMC é " + calculo +" Abaixo do peso ideal");

            }else if ((calculo >= 18.5) && (calculo <=24.9))
            {
                MessageBox.Show("o resultado do IMC é " + calculo + " peso ideal(normal)");
            }
            else if ((calculo >= 25) && (calculo <= 29.9))
            {
                MessageBox.Show("o resultado do IMC é " + calculo + " sobre peso");
            }
            else if ((calculo >= 30) && (calculo <= 34.9))
            {
                MessageBox.Show("o resultado do IMC é " + calculo + " Obesidade Grau 1");
            }
            else if ((calculo >= 35) && (calculo <= 39.9))
            { 
                MessageBox.Show("o resultado do IMC é " + calculo + " Obesidade Grau 2");
            }
            else if (calculo>40)
            {
                MessageBox.Show("o resultado do IMC é " + calculo + " Obesidade Grau 3 ou Mórbida");
            }
            


        }
    }
}
