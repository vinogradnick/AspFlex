using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AspFlex.Controllers;
using AspFlex.PassiveView;
using AspFlex.RepositoryManager_;

namespace AspFlex
{
    public interface IMainForm :IView
    {
        event EventHandler CreateFider;
        event EventHandler CreateTp;
        event EventHandler CreateSection;
        event EventHandler CreateLine;
        event EventHandler CreateCustomer;

        event EventHandler Remove;
         event EventHandler CustomerInTp;
         event EventHandler WorkloadInTp;
         event EventHandler FiderInTp;
         event EventHandler CustomerLines;
         event EventHandler PhaseInLines;
         event EventHandler ChangeEvent;
         event EventHandler FillDatabase;
         event EventHandler TpListConnectedFider;
         event EventHandler CustomerBySelectedFider;
         event EventHandler CustomerBySelectedTp;
         void UpdateTable();
         object SelectedObject { get; }
    }
    public partial class Form1 : Form,IMainForm
    {
      
        public Form1()
        {
            InitializeComponent();
            
        }


      

      



        private void потребительToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "electricityDataSet5.CustomerSet". При необходимости она может быть перемещена или удалена.
            this.customerSetTableAdapter1.Fill(this.electricityDataSet5.CustomerSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "electricityDataSet4.CustomerSet". При необходимости она может быть перемещена или удалена.
            this.customerSetTableAdapter1.Fill(this.electricityDataSet5.CustomerSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "electricityDataSet3.CustomerSet". При необходимости она может быть перемещена или удалена.
            this.customerSetTableAdapter1.Fill(this.electricityDataSet5.CustomerSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "electricityDataSet2.LineSet". При необходимости она может быть перемещена или удалена.
            this.lineSetTableAdapter1.Fill(this.electricityDataSet2.LineSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "electricityDataSet1.CustomerSet". При необходимости она может быть перемещена или удалена.
            this.customerSetTableAdapter1.Fill(this.electricityDataSet5.CustomerSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "electricityDataSet1.LineSet". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "electricityDataSet1.TpSet". При необходимости она может быть перемещена или удалена.
            this.tpSetTableAdapter.Fill(this.electricityDataSet1.TpSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "electricityDataSet1.FiderSet". При необходимости она может быть перемещена или удалена.
            this.fiderSetTableAdapter.Fill(this.electricityDataSet1.FiderSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "electricityDataSet.CustomerSet". При необходимости она может быть перемещена или удалена.
           

        }


        public event EventHandler Remove;
        public event EventHandler CustomerInTp;
        public event EventHandler WorkloadInTp;
        public event EventHandler FiderInTp;
        public event EventHandler CustomerLines;
        public event EventHandler PhaseInLines;
        public event EventHandler ChangeEvent;
        public event EventHandler CustomerBySelectedTp;

        public void UpdateTable()
        {
           
            electricityDataSet1.Clear();
            fiderSetTableAdapter.Fill(electricityDataSet1.FiderSet);
            tpSetTableAdapter.Fill(electricityDataSet1.TpSet);
            lineSetTableAdapter1.Fill(electricityDataSet2.LineSet);
            customerSetTableAdapter1.Fill(electricityDataSet5.CustomerSet);
           
        }

        public object SelectedObject => _selected;
        private object _selected;
        public event EventHandler PhaseInTp;

        public event EventHandler CreateFider;
        public event EventHandler CreateTp;
        public event EventHandler CreateSection;
        public event EventHandler CreateLine;
        public event EventHandler CreateCustomer;
        public event EventHandler FillDatabase;
        public event EventHandler TpListConnectedFider;
        public event EventHandler CustomerBySelectedFider;

        private void фидерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateFider?.Invoke(this, e);

        }

        private void тпToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTp?.Invoke(this, e);
        }

        private void потребительToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCustomer?.Invoke(this, e);
        }

        private void секцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateSection?.Invoke(this, e);
        }

       
       

        private void тПККоторымПривязаныЭнергообъектыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerInTp?.Invoke(this, e);
        }

        private void фидерыККоторымПривязаныЭнергообъектыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiderInTp?.Invoke(sender, e);
        }

        private void получитьФазыПодключенныеКЛиниямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhaseInLines?.Invoke(this, e);
        }

        private void получитьЗамерыНагрузокНаТПToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkloadInTp?.Invoke(this, e);
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeEvent?.Invoke(this, e);
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            fiderSetBindingSource.Filter = advancedDataGridView1.FilterString;
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            fiderSetBindingSource.Sort = advancedDataGridView1.SortString;
        }

        private void advancedDataGridView2_FilterStringChanged(object sender, EventArgs e)
        {
            tpSetBindingSource.Filter = advancedDataGridView2.FilterString;
        }

        private void advancedDataGridView2_SortStringChanged(object sender, EventArgs e)
        {
            tpSetBindingSource.Sort = advancedDataGridView2.SortString;
        }

        private void advancedDataGridView4_FilterStringChanged(object sender, EventArgs e)
        {
            lineSetBindingSource1.Filter = advancedDataGridView3.FilterString;
        }

        private void advancedDataGridView4_SortStringChanged(object sender, EventArgs e)
        {
            lineSetBindingSource1.Sort = advancedDataGridView3.SortString;
        }

        private void advancedDataGridView3_FilterStringChanged(object sender, EventArgs e)
        {
            customerSetBindingSource1.Filter = advancedDataGridView4.FilterString;
        }

        private void advancedDataGridView3_SortStringChanged(object sender, EventArgs e)
        {
            customerSetBindingSource1.Sort = advancedDataGridView4.SortString;
        }

        private void заполнитьБазуДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillDatabase(this, e);
        }

        private void списокТППодключенныхКФидеруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TpListConnectedFider?.Invoke(this, e);
        }

        private void списокПотребителейПодключенныхКФидеруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerBySelectedFider?.Invoke(this, e);
        }

        private void списокПотребителейПодключенныхКТПToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerBySelectedTp?.Invoke(this, e);
        }

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (advancedDataGridView1.SelectedRows.Count > 0)
            {
                _selected = fiderSetBindingSource.List[advancedDataGridView1.SelectedRows[0].Index];
            }
        }

        private void advancedDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (advancedDataGridView2.SelectedRows.Count > 0)
            {
                _selected = tpSetBindingSource.List[advancedDataGridView2.SelectedRows[0].Index];
            }
        }

        private void advancedDataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (advancedDataGridView4.SelectedRows.Count > 0)
            {
                _selected = lineSetBindingSource1.List[advancedDataGridView4.SelectedRows[0].Index];
            }
        }

        private void advancedDataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (advancedDataGridView3.SelectedRows.Count > 0)
            {
                _selected = customerSetBindingSource1.List[advancedDataGridView3.SelectedRows[0].Index];
            }
        }

        private void advancedDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (advancedDataGridView1.SelectedRows.Count > 0)
            {
                _selected =RequestMN.GetFider(electricityDataSet1.FiderSet[advancedDataGridView1.SelectedRows[0].Index].Id);
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void advancedDataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (advancedDataGridView2.SelectedRows.Count > 0)
                _selected = RequestMN.GetTp(electricityDataSet1.TpSet[advancedDataGridView2.SelectedRows[0].Index].Id);
        }

        private void advancedDataGridView4_SelectionChanged(object sender, EventArgs e)
        {
            if (advancedDataGridView1.SelectedRows.Count > 0)
                _selected = RequestMN.GetLine(
                    electricityDataSet1.LineSet[advancedDataGridView4.SelectedRows[0].Index].Id);
        }

        private void advancedDataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (advancedDataGridView3.SelectedRows.Count > 0)
                _selected = RequestMN.GetCustomer(electricityDataSet5
                    .CustomerSet[advancedDataGridView3.SelectedRows[0].Index].Id);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove?.Invoke(this, e);
        }
    }
}
