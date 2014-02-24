using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interactivity;
using System.Windows.Shapes;

namespace CustomBehaviorsLibrary
{
    public class DroppedStealColorBehavior : Behavior<Shape>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.Drop += StealColorOnDropped;
        }

        private void StealColorOnDropped(object sender, DragEventArgs e)
        {
            // Where the dropped data is the shape sent from
            // Sender is this object...
            if (AssociatedObject.Equals(sender))
            {
                MessageBox.Show("Yes the sender of a drop event is the associated object of the behavior");
            }
            if (e.Data.GetDataPresent(typeof(Shape)))
            {
                var daShape = e.Data.GetData(typeof (Shape));
                if (daShape!=null)
                {
                    var shape = daShape as Shape;
                    if (shape != null) AssociatedObject.Fill = shape.Fill;
                }
            }

        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.Drop -= StealColorOnDropped;
        }
    }//end of class
}//end of namespace