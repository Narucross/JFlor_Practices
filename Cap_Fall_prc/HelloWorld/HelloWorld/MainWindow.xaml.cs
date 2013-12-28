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

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void HelloButton_OnClick(object sender, RoutedEventArgs e)
        //{
        //    String value = "Hello World!!!";
        //    String s = TextBox_1.Text;
        //    if (s.Equals(value, StringComparison.InvariantCultureIgnoreCase))
        //    {
        //        TextBox_1.Text = "Resetted";
        //    }
        //    else
        //    { TextBox_1.Text = "Hello World!!!"; }
        //}
    }
}
