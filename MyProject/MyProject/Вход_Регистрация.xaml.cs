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

namespace MyProject
{
    /// <summary>
    /// Логика взаимодействия для Вход_Регистрация.xaml
    /// </summary>
    public partial class Вход_Регистрация : Window
    {
        public Вход_Регистрация()
        {
            InitializeComponent();
            
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            Вход sign = new Вход();
            SignIn.Children.Clear();
            SignIn.Children.Add(sign);sign.Focus();
        }
            private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            Регистрация sign = new Регистрация();
            Reg.Opacity = 1;
            In.Opacity = 0.7;
            SignIn.Children.Clear();
            SignIn.Children.Add(sign);
            
        }
        

        private void Sign_Click(object sender, RoutedEventArgs e)
        {
            Вход sign = new Вход();
            //In.Foreground =Brushes.White;
            In.Opacity = 1;
            Reg.Opacity = 0.7;
            SignIn.Children.Clear();
            SignIn.Children.Add(sign);
        }
    }
}
