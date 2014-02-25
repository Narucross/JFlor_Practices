using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CustomBehaviorsLibrary
{
    /// <summary>
    /// Basically Panning
    /// </summary>
    public class DragInCanvasBehavior : Behavior<UIElement>
    {
        #region Dependency Properties

        public static readonly DependencyProperty IsPansWithinBoundsDependencyProperty =
            DependencyProperty.Register("IsPanWithinBounds", typeof(bool), typeof(DragInCanvasBehavior));

        public bool IsPanWithinBounds
        {
            get
            {
                return (bool)GetValue(IsPansWithinBoundsDependencyProperty);
            }
            set
            {
                SetValue(IsPansWithinBoundsDependencyProperty, value);
            }
        }

        #endregion

        protected override void OnAttached()
        {
            base.OnAttached();
            // Hooked up events
            AssociatedObject.MouseLeftButtonDown += AssociatedObject_MouseLefButtonDown_Handler;
            AssociatedObject.MouseMove += AssociatedObject_MouseMove_Handler;
            AssociatedObject.MouseLeftButtonUp += AssociatedObject_MouseLeftButtonUp_Handler;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            // Hooked up events
            AssociatedObject.MouseLeftButtonDown -= AssociatedObject_MouseLefButtonDown_Handler;
            AssociatedObject.MouseMove -= AssociatedObject_MouseMove_Handler;
            AssociatedObject.MouseLeftButtonUp -= AssociatedObject_MouseLeftButtonUp_Handler;
        }

        // THe canvas this element is placed in
        private Canvas _canvas;
        // Keeps track of whenever this item is currently in a drag
        private bool _isDragging;
        //When the element is clicked, record the exact position where the click was made.
        private Point _mouseOffset;

        private void AssociatedObject_MouseLefButtonDown_Handler(object sender, MouseButtonEventArgs e)
        {
            if (_canvas == null)
            {
                //Finds Canvas enviroment
                _canvas = (Canvas)VisualTreeHelper.GetParent(AssociatedObject);
            }

            //Dragging begins
            _isDragging = true;

            _mouseOffset = e.GetPosition(AssociatedObject);

            AssociatedObject.CaptureMouse();
        }

        private void AssociatedObject_MouseMove_Handler(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                Point point = e.GetPosition(_canvas);
                // how to pin it to the bounds of the canvas?
                AssociatedObject.SetValue(Canvas.TopProperty, point.Y - _mouseOffset.Y);
                AssociatedObject.SetValue(Canvas.LeftProperty, point.X - _mouseOffset.X);
            }
            if (IsPanWithinBounds)
            {
                // Change a color?
                _canvas.Width
                if (AssociatedObject is Shape)
                {
                    var darko = AssociatedObject as Shape;
                    darko.Fill = Brushes.Red;
                }
            }
        }

        private void AssociatedObject_MouseLeftButtonUp_Handler(object sender, MouseButtonEventArgs e)
        {
            if (_isDragging)
            {
                AssociatedObject.ReleaseMouseCapture();
                _isDragging = false;
            }
        }

    }//end of class
}//end of namespace