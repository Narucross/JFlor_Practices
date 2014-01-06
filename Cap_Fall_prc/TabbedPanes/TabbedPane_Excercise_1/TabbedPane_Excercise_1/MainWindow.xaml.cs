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
using TabbedPane_Excercise_1.BindingPractice;
using TabbedPane_Excercise_1.ScreenUtils;

namespace TabbedPane_Excercise_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); 
            fillTabbedDynamic();
        }

        private void fillTabbedDynamic()
        {
            // Code_Flextion_TPanel.Items
            // Write down the intention of this code...
            // 
            var detector = new ScreenDetector();
            var beans = ScreenDetector.getRandomScreens(3);
            Code_Flextion_TPanel.ItemsSource = beans;
        }

        #region Practice from website
        public List<Review> getReviews()
        {
            var reviews = new List<Review>
            {
                new Review(){Critic = "Wesley Morris" ,LetterGrade="B",ReviewSnippet="For better and worse, it weights nothing, which is not the same as saying it means nothing."},
                new Review(){Critic ="Roger Ebert" ,LetterGrade="A-",ReviewSnippet="Like the hero of that film, the viewer of Inception is adrift in time and experience"},
                new Review(){Critic ="Michael Phillips" ,LetterGrade="B",ReviewSnippet="Nolan conjures up a fever dream."},
                //new Review(){Critic ="Joshua Flores" ,LetterGrade="B-",ReviewSnippet="Not great, interesting idea, and although the possibilities seem endless, Nolan had only proven he make use the same characters to be in 3 different action scenes at once."},
            };
            return reviews;
        }
        #endregion
    }
}
