using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspFlex.PassiveView
{
    interface ICodeGeneratorView:IView
    {
        event EventHandler Request;
        object SelectedObject { get;  }
        string Code { get; }
        void Bind(dynamic dataSource);
    }
}
