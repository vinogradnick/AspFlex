using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AspFlex.PassiveView;
using Microsoft.CSharp;

namespace AspFlex.Controllers
{
    class CodeGeneratorController:BaseController<ICodeGeneratorView>
    {
        public CodeGeneratorController(ICodeGeneratorView view) : base(view)
        {
        }

        private void Subscribe()
        {
            View.Request += OnRequest;
        }

        private void OnRequest(object sender, EventArgs e)
        {
            
           
        }
    }
}
