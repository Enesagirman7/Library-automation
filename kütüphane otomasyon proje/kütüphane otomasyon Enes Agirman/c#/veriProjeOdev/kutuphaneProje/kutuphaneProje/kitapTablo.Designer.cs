namespace kutuphaneProje
{
    partial class kitapTablo
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
            this.barkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basımYılıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayınEviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rafNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblKitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeDataSet = new kutuphaneProje.projeDataSet();
            this.tbl_KitapTableAdapter = new kutuphaneProje.projeDataSetTableAdapters.Tbl_KitapTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barkodDataGridViewTextBoxColumn,
            this.kitapAdıDataGridViewTextBoxColumn,
            this.yazarDataGridViewTextBoxColumn,
            this.sayfaDataGridViewTextBoxColumn,
            this.basımYılıDataGridViewTextBoxColumn,
            this.yayınEviDataGridViewTextBoxColumn,
            this.rafNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblKitapBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(934, 461);
            this.dataGridView1.TabIndex = 0;
//            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // barkodDataGridViewTextBoxColumn
            // 
            this.barkodDataGridViewTextBoxColumn.DataPropertyName = "Barkod";
            this.barkodDataGridViewTextBoxColumn.HeaderText = "Barkod";
            this.barkodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barkodDataGridViewTextBoxColumn.Name = "barkodDataGridViewTextBoxColumn";
            this.barkodDataGridViewTextBoxColumn.ReadOnly = true;
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
            // yazarDataGridViewTextBoxColumn
            // 
            this.yazarDataGridViewTextBoxColumn.DataPropertyName = "Yazar";
            this.yazarDataGridViewTextBoxColumn.HeaderText = "Yazar";
            this.yazarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yazarDataGridViewTextBoxColumn.Name = "yazarDataGridViewTextBoxColumn";
            this.yazarDataGridViewTextBoxColumn.Width = 125;
            // 
            // sayfaDataGridViewTextBoxColumn
            // 
            this.sayfaDataGridViewTextBoxColumn.DataPropertyName = "Sayfa";
            this.sayfaDataGridViewTextBoxColumn.HeaderText = "Sayfa";
            this.sayfaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sayfaDataGridViewTextBoxColumn.Name = "sayfaDataGridViewTextBoxColumn";
            this.sayfaDataGridViewTextBoxColumn.Width = 125;
            // 
            // basımYılıDataGridViewTextBoxColumn
            // 
            this.basımYılıDataGridViewTextBoxColumn.DataPropertyName = "BasımYılı";
            this.basımYılıDataGridViewTextBoxColumn.HeaderText = "BasımYılı";
            this.basımYılıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.basımYılıDataGridViewTextBoxColumn.Name = "basımYılıDataGridViewTextBoxColumn";
            this.basımYılıDataGridViewTextBoxColumn.Width = 125;
            // 
            // yayınEviDataGridViewTextBoxColumn
            // 
            this.yayınEviDataGridViewTextBoxColumn.DataPropertyName = "YayınEvi";
            this.yayınEviDataGridViewTextBoxColumn.HeaderText = "YayınEvi";
            this.yayınEviDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yayınEviDataGridViewTextBoxColumn.Name = "yayınEviDataGridViewTextBoxColumn";
            this.yayınEviDataGridViewTextBoxColumn.Width = 125;
            // 
            // rafNoDataGridViewTextBoxColumn
            // 
            this.rafNoDataGridViewTextBoxColumn.DataPropertyName = "RafNo";
            this.rafNoDataGridViewTextBoxColumn.HeaderText = "RafNo";
            this.rafNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rafNoDataGridViewTextBoxColumn.Name = "rafNoDataGridViewTextBoxColumn";
            this.rafNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblKitapBindingSource
            // 
            this.tblKitapBindingSource.DataMember = "Tbl_Kitap";
            this.tblKitapBindingSource.DataSource = this.projeDataSet;
            // 
            // projeDataSet
            // 
            this.projeDataSet.DataSetName = "projeDataSet";
            this.projeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_KitapTableAdapter
            // 
            this.tbl_KitapTableAdapter.ClearBeforeFill = true;
            // 
            // kitapTablo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kitapTablo";
            this.Text = "kitapTablo";
            this.Load += new System.EventHandler(this.kitapTablo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private projeDataSet projeDataSet;
        private System.Windows.Forms.BindingSource tblKitapBindingSource;
        private projeDataSetTableAdapters.Tbl_KitapTableAdapter tbl_KitapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basımYılıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayınEviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rafNoDataGridViewTextBoxColumn;
    }
}