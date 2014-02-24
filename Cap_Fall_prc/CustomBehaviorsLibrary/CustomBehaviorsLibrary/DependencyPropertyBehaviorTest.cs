using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interactivity;

namespace CustomBehaviorsLibrary
{
    public class DependencyPropertyBehaviorTest : Behavior<UIElement>
    {
        public static readonly DependencyProperty StartAsYellowProperty =
            DependencyProperty.Register("StartAsYellow", typeof(bool), typeof(DependencyPropertyBehaviorTest));

        public bool StartAsYellow
        {
            get { return (bool)GetValue(StartAsYellowProperty); }
            set { SetValue(StartAsYellowProperty, value); }
        }
    }
}
