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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace firstProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        


        }

        private void btLogin_Click(object sender, RoutedEventArgs e)
        {
            if((boxSenha.Password == "123456")&& (txtUsuario.Text== "zeca"))
            {
                MessageBox.Show("acertou");

                var window = new RegrasdeNegocios.CalculadoraWindow();
                this.Close();
                window.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("se lascou");
            }
        }

        private void txtSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void mini_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
