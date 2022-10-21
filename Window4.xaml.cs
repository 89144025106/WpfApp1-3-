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

namespace WpfApp1_Уп_Пр_3
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }
        private void mnuNew_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Гуляева Кристина");
        }
        private void mnuNew1_Click(object sender, RoutedEventArgs e)
        {
            Grid1.Background = Brushes.Red;
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();


        }

    }
}
