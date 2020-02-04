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

namespace MyProject
{
    /// <summary>
    /// Логика взаимодействия для Вход.xaml
    /// </summary>
    public partial class Вход : UserControl
    {
        public Вход()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Начало_обучения n = new Начало_обучения();
            n.Block.Children.Clear();

            Profile p = new Profile();
            n.AnotherPages.Children.Clear();
            n.AnotherPages.Children.Add(p);
        }
    }
}
