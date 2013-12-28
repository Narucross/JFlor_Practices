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

namespace MoveExcercise
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

        Point startingPoint;
        Rectangle toCreateRectangle;

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HitTestResult result = VisualTreeHelper.HitTest(DrawingArea, e.GetPosition(DrawingArea));
            if (result != null)
            {
                if (result.VisualHit is Rectangle)
                {
                    toCreateRectangle = (Rectangle)result.VisualHit;

                    double offSetX = startingPoint.X - Canvas.GetLeft(toCreateRectangle);

                    double offSetY = startingPoint.Y - Canvas.GetTop(toCreateRectangle);
                    startingPoint = new Point(offSetX, offSetY);
                    // Make it an offset;
                }
            }
        }


        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {

            Point mousePositionRDrawingArea = e.GetPosition(DrawingArea);
            if (toCreateRectangle != null)
            {
                Point offset = startingPoint;
                double diffX = (mousePositionRDrawingArea.X - offset.X);
                double diffY = (mousePositionRDrawingArea.Y - offset.Y);
                Canvas.SetLeft(toCreateRectangle, (mousePositionRDrawingArea.X - offset.X));
                Canvas.SetRight(toCreateRectangle, (mousePositionRDrawingArea.Y - offset.Y));
            }
        }


        private void Canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
        }

    }
}
