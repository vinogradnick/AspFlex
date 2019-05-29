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
    public partial class RequestPage : Form,IRequestPage
    {
        public object SelectedObject { get; set; }
        private dynamic dataSource;
        public RequestPage()
        {
            InitializeComponent();
        }

        public void Bind(dynamic dataSource)
        {
            this.dataSource = dataSource;
            advancedDataGridView1.DataSource =dataSource;
        }

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (advancedDataGridView1.SelectedRows.Count > 0)
                SelectedObject = dataSource[advancedDataGridView1.SelectedRows[0].Index];
        }
    }
}
