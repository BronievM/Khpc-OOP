namespace LR4_S
{
    partial class AllRoutes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typewag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacitywag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stpos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datedest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numb,
            this.typewag,
            this.capacitywag,
            this.stpos,
            this.dest,
            this.datest,
            this.datedest});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(815, 554);
            this.dataGridView1.TabIndex = 0;
            // 
            // numb
            // 
            this.numb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numb.HeaderText = "Номер";
            this.numb.Name = "numb";
            this.numb.Width = 66;
            // 
            // typewag
            // 
            this.typewag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.typewag.HeaderText = "Тип вагонів";
            this.typewag.Name = "typewag";
            this.typewag.Width = 91;
            // 
            // capacitywag
            // 
            this.capacitywag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.capacitywag.HeaderText = "Місткість вагонів";
            this.capacitywag.Name = "capacitywag";
            this.capacitywag.Width = 109;
            // 
            // stpos
            // 
            this.stpos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stpos.HeaderText = "Пункт відправлення";
            this.stpos.Name = "stpos";
            this.stpos.Width = 122;
            // 
            // dest
            // 
            this.dest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dest.HeaderText = "Пункт призначення";
            this.dest.Name = "dest";
            this.dest.Width = 119;
            // 
            // datest
            // 
            this.datest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datest.HeaderText = "Дата і час відправлення";
            this.datest.Name = "datest";
            this.datest.Width = 141;
            // 
            // datedest
            // 
            this.datedest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datedest.HeaderText = "Дата і час прибуття:";
            this.datedest.Name = "datedest";
            this.datedest.Width = 123;
            // 
            // AllRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 554);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AllRoutes";
            this.Text = "AllRoutes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numb;
        private System.Windows.Forms.DataGridViewTextBoxColumn typewag;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacitywag;
        private System.Windows.Forms.DataGridViewTextBoxColumn stpos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dest;
        private System.Windows.Forms.DataGridViewTextBoxColumn datest;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedest;
    }
}