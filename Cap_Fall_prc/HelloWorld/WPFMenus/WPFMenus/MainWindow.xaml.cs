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

namespace WPFMenus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int x=3;
            SimpleBean[] beans = new SimpleBean[x];
            for (int i = 0; i < x; i++) {
                var bean = new SimpleBean();
                bean.Name = "New Object " + i;
                bean.IsActive = i % 2 == 0;
                beans[i] = bean;
            }
            var data = new RandomModel();
            data.Themes = beans;
            DataContext = data;
        }

        
    }
}
