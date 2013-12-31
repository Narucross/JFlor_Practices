using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabbedPane_Excercise_1.ScreenUtils
{
    class ScreenBean
    {
        private double _height, _width;
        private int _screenNumber;

        #region exposedProperties And LinkedToPropertyChangedEvents Because That Design Paradigm Is Stupid And Counter Intuitive But we are stuck with it because people cannot guage just how impractical it is
        public double Height { get { return _height; } set { _height = value; } }
        public double Width { get { return _width; } set { _width = value; } }
        public int ScreenNumber { get { return _screenNumber; } set { _screenNumber = value; } }
        #endregion

        public static ScreenBean NewRandomScreenBean(ref Random randy, int sc) {
            var bean = new ScreenBean();
            bean._height = randy.Next(0, 1080);
            bean._width = randy.Next(0, 1920);
            bean._screenNumber = sc;
            return bean;
        }

    }
}
