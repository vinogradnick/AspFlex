using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AspFlex.PassiveView;

namespace AspFlex
{
    public partial class AddObject : Form, IAddObjectView
    {
        private object _model;
        private Dictionary<string, object> _dictionary;
        public AddObject()
        {
            InitializeComponent();
        }

        public void Bind(object model)
        {
            _model = model;
            _dictionary=new Dictionary<string, object>();
            BindGrid();
        }

        public void BindGrid()
        {
            dataGridView1.Rows.Clear();
            _dictionary.Clear();
            
            if (_model != null)
            {
                var props = _model.GetType().GetProperties();
                foreach (var prop in props)
                {
                    if (prop.PropertyType.Name.Equals("String") || prop.PropertyType.Name.Equals("Int32") || prop.PropertyType.Name.Equals("Boolean"))
                    {
                        _dictionary.Add(prop.Name,prop.GetValue(_model));
                        DataGridViewRow row = new DataGridViewRow();

                        DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell() { Value = prop.Name };
                        DataGridViewTextBoxCell values = new DataGridViewTextBoxCell()
                            { Value = prop.GetValue(_model), ValueType = prop.PropertyType };
                        row.Cells.Add(cell);
                        row.Cells.Add(values);
                        dataGridView1.Rows.Add(row);
                    }
                    
                }
            }
        }

        private object DataOfObject(string name) => _model.GetType().GetProperty(name)?.GetValue(_model);

        private void WriteInProperty(object data, string name) =>
            _model.GetType().GetProperty(name)?.SetValue(_model, data);
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        public object GetData()
        {
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
               WriteInProperty(dataGridView1.Rows[i].Cells[1].Value,(string)dataGridView1.Rows[i].Cells[0].Value);
            return _model;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void Bind<T>(T data) => Bind((object)data);

        public object Data => GetData();
    }
}
