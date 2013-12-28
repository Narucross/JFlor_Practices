using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BorderTesting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        UIElement toCreateRectangle;
        Point startingPoint;
        private void ToTestBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            startingPoint = e.GetPosition(DrawingArea);
            HitTestResult result = VisualTreeHelper.HitTest(DrawingArea, startingPoint);
            if (result != null)
            {
                toCreateRectangle = (UIElement)result.VisualHit;
                double offSetX = Canvas.GetLeft(toCreateRectangle) - startingPoint.X;
                double offSetY = Canvas.GetTop(toCreateRectangle) - startingPoint.Y;
                startingPoint = new Point(offSetX, offSetY);

            }
        }

        private void ToTestBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (toCreateRectangle != null)
            {
                Point mousePositionRDrawingArea = e.GetPosition(DrawingArea);
                Point offset = startingPoint; // assuming panview is not the default
                double diffX = mousePositionRDrawingArea.X + offset.X;
                double diffY = mousePositionRDrawingArea.Y + offset.Y;
                Canvas.SetLeft(toCreateRectangle, diffX);
                Canvas.SetTop(toCreateRectangle, diffY);
            }
        }

        private void ToTestBorder_MouseUp(object sender, MouseButtonEventArgs e)
        {
            startingPoint = new Point();
            toCreateRectangle = null;
        }

    }
}
