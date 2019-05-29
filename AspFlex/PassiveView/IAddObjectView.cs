using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspFlex.PassiveView
{
    public interface IAddObjectView:IView
    {
        void Bind<T>(T data);
        object Data { get; }
    }
}
