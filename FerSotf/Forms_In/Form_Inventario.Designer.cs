
namespace FerSotf.Forms_In
{
    partial class Form_Inventario
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
            this.KDataGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nProvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ButtonInsert = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.TB_Marca = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Tb_Precio = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TBNombre = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Label_ID = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.CB_Prov = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.Tb_Categoria = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TextBox_Select = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.KDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cProdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CB_Prov)).BeginInit();
            this.SuspendLayout();
            // 
            // KDataGrid
            // 
            this.KDataGrid.AllowUserToAddRows = false;
            this.KDataGrid.AllowUserToDeleteRows = false;
            this.KDataGrid.AutoGenerateColumns = false;
            this.KDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.nProvDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn});
            this.KDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KDataGrid.DataSource = this.cProdBindingSource;
            this.KDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.KDataGrid.HideOuterBorders = true;
            this.KDataGrid.Location = new System.Drawing.Point(0, 380);
            this.KDataGrid.Name = "KDataGrid";
            this.KDataGrid.ReadOnly = true;
            this.KDataGrid.RowHeadersVisible = false;
            this.KDataGrid.Size = new System.Drawing.Size(956, 176);
            this.KDataGrid.TabIndex = 34;
            this.KDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KDataGrid_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nProvDataGridViewTextBoxColumn
            // 
            this.nProvDataGridViewTextBoxColumn.DataPropertyName = "NProv";
            this.nProvDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.nProvDataGridViewTextBoxColumn.Name = "nProvDataGridViewTextBoxColumn";
            this.nProvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cProdBindingSource
            // 
            this.cProdBindingSource.DataSource = typeof(ClasesF.Clases_Inv.C_Prod);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonUpdate.Location = new System.Drawing.Point(130, 319);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(90, 25);
            this.ButtonUpdate.TabIndex = 33;
            this.ButtonUpdate.Values.Text = "Update";
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonInsert
            // 
            this.ButtonInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonInsert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonInsert.Location = new System.Drawing.Point(700, 310);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(90, 25);
            this.ButtonInsert.TabIndex = 32;
            this.ButtonInsert.Values.Text = "Insert";
            this.ButtonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // TB_Marca
            // 
            this.TB_Marca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TB_Marca.Location = new System.Drawing.Point(96, 205);
            this.TB_Marca.Name = "TB_Marca";
            this.TB_Marca.Size = new System.Drawing.Size(100, 23);
            this.TB_Marca.TabIndex = 38;
            this.TB_Marca.Text = "Marca";
            this.TB_Marca.TextChanged += new System.EventHandler(this.TB_Ag_TextChanged);
            // 
            // Tb_Precio
            // 
            this.Tb_Precio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Tb_Precio.Location = new System.Drawing.Point(310, 205);
            this.Tb_Precio.Name = "Tb_Precio";
            this.Tb_Precio.Size = new System.Drawing.Size(100, 23);
            this.Tb_Precio.TabIndex = 37;
            this.Tb_Precio.Text = "Precio";
            this.Tb_Precio.TextChanged += new System.EventHandler(this.Tb_Email_TextChanged);
            // 
            // TBNombre
            // 
            this.TBNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TBNombre.Location = new System.Drawing.Point(96, 120);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(100, 23);
            this.TBNombre.TabIndex = 36;
            this.TBNombre.Text = "Nombre";
            this.TBNombre.TextChanged += new System.EventHandler(this.TBNombre_TextChanged);
            // 
            // Label_ID
            // 
            this.Label_ID.Location = new System.Drawing.Point(96, 56);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(25, 20);
            this.Label_ID.TabIndex = 35;
            this.Label_ID.Values.Text = "ID:";
            this.Label_ID.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_ID_Paint);
            // 
            // CB_Prov
            // 
            this.CB_Prov.DropDownWidth = 121;
            this.CB_Prov.Location = new System.Drawing.Point(544, 207);
            this.CB_Prov.Name = "CB_Prov";
            this.CB_Prov.Size = new System.Drawing.Size(121, 21);
            this.CB_Prov.TabIndex = 39;
            this.CB_Prov.Text = "Proveedor";
            // 
            // Tb_Categoria
            // 
            this.Tb_Categoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Tb_Categoria.Location = new System.Drawing.Point(310, 120);
            this.Tb_Categoria.Name = "Tb_Categoria";
            this.Tb_Categoria.Size = new System.Drawing.Size(100, 23);
            this.Tb_Categoria.TabIndex = 40;
            this.Tb_Categoria.Text = "Categoria";
            // 
            // TextBox_Select
            // 
            this.TextBox_Select.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Select.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextBox_Select.Location = new System.Drawing.Point(669, 12);
            this.TextBox_Select.Name = "TextBox_Select";
            this.TextBox_Select.Size = new System.Drawing.Size(287, 23);
            this.TextBox_Select.TabIndex = 41;
            this.TextBox_Select.Text = "Find";
            this.TextBox_Select.TextChanged += new System.EventHandler(this.TextBox_Select_TextChanged);
            // 
            // Form_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 556);
            this.Controls.Add(this.TextBox_Select);
            this.Controls.Add(this.Tb_Categoria);
            this.Controls.Add(this.CB_Prov);
            this.Controls.Add(this.TB_Marca);
            this.Controls.Add(this.Tb_Precio);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.Label_ID);
            this.Controls.Add(this.KDataGrid);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Form_Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cProdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CB_Prov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView KDataGrid;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonInsert;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TB_Marca;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Tb_Precio;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TBNombre;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Label_ID;
        private System.Windows.Forms.BindingSource cProdBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox CB_Prov;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Tb_Categoria;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBox_Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nProvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
    }
}