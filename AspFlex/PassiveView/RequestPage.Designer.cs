namespace AspFlex.PassiveView
{
    partial class RequestPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RowTemplate.Height = 33;
            this.advancedDataGridView1.Size = new System.Drawing.Size(800, 450);
            this.advancedDataGridView1.TabIndex = 0;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView1_CellContentClick);
            // 
            // RequestPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.advancedDataGridView1);
            this.Name = "RequestPage";
            this.Text = "RequestPage";
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ADGV.AdvancedDataGridView advancedDataGridView1;
    }
}