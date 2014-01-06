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
using WPFMenus.BindingPractice;

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
            var reviews = new List<Review>
            {
                new Review(){Critic = "Wesley Morris" ,LetterGrade="B",ReviewSnippet="For better and worse, it weights nothing, which is not the same as saying it means nothing."},
                new Review(){Critic ="Roger Ebert" ,LetterGrade="A-",ReviewSnippet="Like the hero of that film, the viewer of Inception is adrift in time and experience"},
                new Review(){Critic ="Michael Phillips" ,LetterGrade="B",ReviewSnippet="Nolan conjures up a fever dream."},
                //new Review(){Critic ="Joshua Flores" ,LetterGrade="B-",ReviewSnippet="Not great, interesting idea, and although the possibilities seem endless, Nolan had only proven he make use the same characters to be in 3 different action scenes at once."},
            };

            var reviews2 = new List<Review>
            {
                new Review(){Critic ="Michael Phillips" ,LetterGrade="B",ReviewSnippet="Nolan conjures up a fever dream."},
                new Review(){Critic ="Roger Ebert" ,LetterGrade="A-",ReviewSnippet="Like the hero of that film, the viewer of Inception is adrift in time and experience"},
                new Review(){Critic = "Wesley Morris" ,LetterGrade="B",ReviewSnippet="For better and worse, it weights nothing, which is not the same as saying it means nothing."},
                new Review(){Critic ="Joshua Flores" ,LetterGrade="B-",ReviewSnippet="Not great, interesting idea, and although the possibilities seem endless, Nolan had only proven he make use the same characters to be in 3 different action scenes at once."},
            };
            
            var templates = new ScreenSavers[] { 
                new ScreenSavers(){TemplateName = "Default", Screens = reviews.ToArray()},
                new ScreenSavers(){TemplateName = "Ragnarock", Screens = reviews2.ToArray()}
            };

            Code_Flextion_TPanel.ItemsSource = templates;
        }

        
    }
}
