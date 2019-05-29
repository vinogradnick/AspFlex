using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspFlex.PassiveView
{
    public partial class CodeGeneratorPage : Form,ICodeGeneratorView
    {
        public CodeGeneratorPage()
        {
            InitializeComponent();
        }

        public event EventHandler Request;
        public object SelectedObject { get; set; }
        public string Code => fastColoredTextBox1.Text;

        public void Bind(dynamic dataSource)
        {
            advancedDataGridView1.DataSource = dataSource;
        }
    }
}
