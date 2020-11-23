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

namespace Задание_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
 
        {
            int x = Convert.ToInt32(stroka.Text);
            string text = Convert.ToString(dannie.Text);

            if (text.Length == x)
            {
                text = text.Replace("ogogo", "***");
                text = text.Replace("ogo", "***");
                text = text.Replace("*go", "*");
                text = text.Replace("*g*", "**");



            }
        } 
    }
}
