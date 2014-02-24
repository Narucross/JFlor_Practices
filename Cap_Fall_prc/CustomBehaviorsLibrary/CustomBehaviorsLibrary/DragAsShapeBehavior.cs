using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Shapes;

namespace CustomBehaviorsLibrary
{
    public class DragAsShapeBehavior : Behavior<Shape>
    {
        #region attaching
        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.MouseLeftButtonDown -= PossibleDragInitEventHandler;
            AssociatedObject.MouseLeftButtonUp -= CancelAllPossibleDragInit;
            AssociatedObject.MouseLeave -= InsightDragEvents;
        }
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.AllowDrop = true;
            AssociatedObject.MouseLeftButtonDown += PossibleDragInitEventHandler;
            AssociatedObject.MouseLeftButtonUp += CancelAllPossibleDragInit;
            AssociatedObject.MouseLeave += InsightDragEvents;
        }
        #endregion
        
        private void PossibleDragInitEventHandler(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void InsightDragEvents(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CancelAllPossibleDragInit(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }

    }//end of class
}//end of namespace