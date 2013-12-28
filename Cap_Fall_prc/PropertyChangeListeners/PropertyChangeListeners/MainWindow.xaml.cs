using PropertyChangeListeners.Data.ViewModels;
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
using PropertyChangeListeners.Data.Models;

namespace PropertyChangeListeners
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DropBoxOfApplications.DataContext = getItems();
        }

        public PersonPublicKnowledgeViewModel[] getItems()
        {
            var persons = new PersonPublicKnowledgeViewModel[20];
            for (int i = 0; i < 20; i++)
            {
                persons[i] = new PersonPublicKnowledgeViewModel(Person.generateRandomPerson());
            }
            return persons;
        }
       
    }
}
