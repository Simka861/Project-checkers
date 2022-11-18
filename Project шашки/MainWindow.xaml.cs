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
using System.Drawing;


namespace Project_checkers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Init(new object(), new RoutedEventArgs());
        }

        public void Init(object sender, RoutedEventArgs e)
        {
            Step_1(sender, e);
        }

        public void Step_1(object sender, RoutedEventArgs e)
        {

            Button button = sender as Button;
            if (button == null) //в случае, если в функцию передан не Button, то _button будет равен null
            { return; }
            if (button.Content != null)
            {


                button.Background = new SolidColorBrush(Colors.Red);// new ОБЯЗАТЕЛЬНО, иначе всё в тартарары летит с ошибками


            }
            else { return; }

        }
        public void Step_2(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            var FirstBackgroundButton = button.Background;
            string str = (string)button.Content;


        }



    }
}
