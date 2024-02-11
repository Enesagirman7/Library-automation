namespace kutuphaneProje
{
    partial class EmanetTablo
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projeDataSet = new kutuphaneProje.projeDataSet();
            this.tblEmanetIslemleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_EmanetIslemleriTableAdapter = new kutuphaneProje.projeDataSetTableAdapters.Tbl_EmanetIslemleriTableAdapter();
            this.tCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rafNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verilmeTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmanetIslemleriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tCDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.telefonNoDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.barkodDataGridViewTextBoxColumn,
            this.kitapAdıDataGridViewTextBoxColumn,
            this.rafNoDataGridViewTextBoxColumn,
            this.verilmeTarihiDataGridViewTextBoxColumn,
            this.teslimTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblEmanetIslemleriBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1184, 436);
            this.dataGridView1.TabIndex = 0;
            // 
            // projeDataSet
            // 
            this.projeDataSet.DataSetName = "projeDataSet";
            this.projeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEmanetIslemleriBindingSource
            // 
            this.tblEmanetIslemleriBindingSource.DataMember = "Tbl_EmanetIslemleri";
            this.tblEmanetIslemleriBindingSource.DataSource = this.projeDataSet;
            // 
            // tbl_EmanetIslemleriTableAdapter
            // 
            this.tbl_EmanetIslemleriTableAdapter.ClearBeforeFill = true;
            // 
            // tCDataGridViewTextBoxColumn
            // 
            this.tCDataGridViewTextBoxColumn.DataPropertyName = "TC";
            this.tCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.tCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tCDataGridViewTextBoxColumn.Name = "tCDataGridViewTextBoxColumn";
            this.tCDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonNoDataGridViewTextBoxColumn
            // 
            this.telefonNoDataGridViewTextBoxColumn.DataPropertyName = "Telefon No";
            this.telefonNoDataGridViewTextBoxColumn.HeaderText = "Telefon No";
            this.telefonNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonNoDataGridViewTextBoxColumn.Name = "telefonNoDataGridViewTextBoxColumn";
            this.telefonNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 125;
            // 
            // barkodDataGridViewTextBoxColumn
            // 
            this.barkodDataGridViewTextBoxColumn.DataPropertyName = "Barkod";
            this.barkodDataGridViewTextBoxColumn.HeaderText = "Barkod";
            this.barkodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barkodDataGridViewTextBoxColumn.Name = "barkodDataGridViewTextBoxColumn";
            this.barkodDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapAdıDataGridViewTextBoxColumn
            // 
            this.kitapAdıDataGridViewTextBoxColumn.DataPropertyName = "KitapAdı";
            this.kitapAdıDataGridViewTextBoxColumn.HeaderText = "KitapAdı";
            this.kitapAdıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapAdıDataGridViewTextBoxColumn.Name = "kitapAdıDataGridViewTextBoxColumn";
            this.kitapAdıDataGridViewTextBoxColumn.Width = 125;
            // 
            // rafNoDataGridViewTextBoxColumn
            // 
            this.rafNoDataGridViewTextBoxColumn.DataPropertyName = "RafNo";
            this.rafNoDataGridViewTextBoxColumn.HeaderText = "RafNo";
            this.rafNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rafNoDataGridViewTextBoxColumn.Name = "rafNoDataGridViewTextBoxColumn";
            this.rafNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // verilmeTarihiDataGridViewTextBoxColumn
            // 
            this.verilmeTarihiDataGridViewTextBoxColumn.DataPropertyName = "VerilmeTarihi";
            this.verilmeTarihiDataGridViewTextBoxColumn.HeaderText = "VerilmeTarihi";
            this.verilmeTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.verilmeTarihiDataGridViewTextBoxColumn.Name = "verilmeTarihiDataGridViewTextBoxColumn";
            this.verilmeTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // teslimTarihiDataGridViewTextBoxColumn
            // 
            this.teslimTarihiDataGridViewTextBoxColumn.DataPropertyName = "TeslimTarihi";
            this.teslimTarihiDataGridViewTextBoxColumn.HeaderText = "TeslimTarihi";
            this.teslimTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teslimTarihiDataGridViewTextBoxColumn.Name = "teslimTarihiDataGridViewTextBoxColumn";
            this.teslimTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // EmanetTablo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 436);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmanetTablo";
            this.Text = "EmanetTablo";
            this.Load += new System.EventHandler(this.EmanetTablo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmanetIslemleriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private projeDataSet projeDataSet;
        private System.Windows.Forms.BindingSource tblEmanetIslemleriBindingSource;
        private projeDataSetTableAdapters.Tbl_EmanetIslemleriTableAdapter tbl_EmanetIslemleriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rafNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verilmeTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslimTarihiDataGridViewTextBoxColumn;
    }
}