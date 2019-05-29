using System;

namespace AspFlex.Controllers
{
    public class CustomEventArgs : EventArgs
    {
        public object DateModel { get;  }

        public CustomEventArgs(object model)
        {
            DateModel = model;
        }
    }
}