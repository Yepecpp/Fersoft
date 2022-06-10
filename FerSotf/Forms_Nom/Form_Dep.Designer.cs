namespace FerSotf.Forms_Nom
{
    partial class Form_Dep
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
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.KDataGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.iDDepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Label_ID = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.TextBox_Nom = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TextBox_Dir = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.MTextBox_Tel = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.TextBox_Select = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ButtonInsert = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ButtonUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.KDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDepBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = global::FerSotf.Properties.Resources.Close;
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = global::FerSotf.Properties.Resources.maximize;
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = global::FerSotf.Properties.Resources.Minimize;
            this.kryptonPalette1.ButtonSpecs.FormRestore.Image = global::FerSotf.Properties.Resources.Restore;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Color1 = System.Drawing.Color.DarkGray;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Color1 = System.Drawing.Color.DimGray;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Color2 = System.Drawing.Color.DimGray;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(79)))), ((int)(((byte)(95)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(79)))), ((int)(((byte)(95)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 0;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 20;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(20, 3, -1, -1);
            // 
            // KDataGrid
            // 
            this.KDataGrid.AllowUserToAddRows = false;
            this.KDataGrid.AllowUserToDeleteRows = false;
            this.KDataGrid.AutoGenerateColumns = false;
            this.KDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDepDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.ubicacionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn});
            this.KDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KDataGrid.DataSource = this.cDepBindingSource;
            this.KDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.KDataGrid.HideOuterBorders = true;
            this.KDataGrid.Location = new System.Drawing.Point(0, 414);
            this.KDataGrid.Name = "KDataGrid";
            this.KDataGrid.Palette = this.kryptonPalette1;
            this.KDataGrid.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.KDataGrid.ReadOnly = true;
            this.KDataGrid.RowHeadersVisible = false;
            this.KDataGrid.Size = new System.Drawing.Size(1003, 300);
            this.KDataGrid.TabIndex = 0;
            this.KDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KDataGrid_CellClick);
            // 
            // iDDepDataGridViewTextBoxColumn
            // 
            this.iDDepDataGridViewTextBoxColumn.DataPropertyName = "ID_Dep";
            this.iDDepDataGridViewTextBoxColumn.HeaderText = "ID_Dep";
            this.iDDepDataGridViewTextBoxColumn.Name = "iDDepDataGridViewTextBoxColumn";
            this.iDDepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ubicacionDataGridViewTextBoxColumn
            // 
            this.ubicacionDataGridViewTextBoxColumn.DataPropertyName = "Ubicacion";
            this.ubicacionDataGridViewTextBoxColumn.HeaderText = "Ubicacion";
            this.ubicacionDataGridViewTextBoxColumn.Name = "ubicacionDataGridViewTextBoxColumn";
            this.ubicacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cDepBindingSource
            // 
            this.cDepBindingSource.DataSource = typeof(ClasesF.Clases_Nom.C_Dep);
            // 
            // Label_ID
            // 
            this.Label_ID.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_ID.Location = new System.Drawing.Point(103, 109);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(25, 20);
            this.Label_ID.TabIndex = 1;
            this.Label_ID.Values.Text = "ID: ";
            this.Label_ID.TextChanged += new System.EventHandler(this.Label_ID_TextChanged);
            // 
            // TextBox_Nom
            // 
            this.TextBox_Nom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBox_Nom.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextBox_Nom.Location = new System.Drawing.Point(267, 154);
            this.TextBox_Nom.Name = "TextBox_Nom";
            this.TextBox_Nom.Size = new System.Drawing.Size(100, 23);
            this.TextBox_Nom.TabIndex = 2;
            this.TextBox_Nom.Text = "Nombre";
            // 
            // TextBox_Dir
            // 
            this.TextBox_Dir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBox_Dir.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextBox_Dir.Location = new System.Drawing.Point(267, 205);
            this.TextBox_Dir.Name = "TextBox_Dir";
            this.TextBox_Dir.Size = new System.Drawing.Size(100, 23);
            this.TextBox_Dir.TabIndex = 3;
            this.TextBox_Dir.Text = "Dirrecion";
            // 
            // MTextBox_Tel
            // 
            this.MTextBox_Tel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MTextBox_Tel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MTextBox_Tel.Location = new System.Drawing.Point(497, 154);
            this.MTextBox_Tel.Name = "MTextBox_Tel";
            this.MTextBox_Tel.Palette = this.kryptonPalette1;
            this.MTextBox_Tel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.MTextBox_Tel.Size = new System.Drawing.Size(96, 23);
            this.MTextBox_Tel.TabIndex = 4;
            this.MTextBox_Tel.Tag = "Invalid";
            this.MTextBox_Tel.Text = "Telefono";
            this.MTextBox_Tel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MTextBox_Tel_MaskInputRejected);
            this.MTextBox_Tel.TextChanged += new System.EventHandler(this.MTextBox_Tel_TextChanged);
            this.MTextBox_Tel.Enter += new System.EventHandler(this.MTextBox_Tel_Enter);
            this.MTextBox_Tel.Leave += new System.EventHandler(this.MTextBox_Tel_Leave);
            // 
            // TextBox_Select
            // 
            this.TextBox_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Select.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextBox_Select.Location = new System.Drawing.Point(778, 29);
            this.TextBox_Select.Name = "TextBox_Select";
            this.TextBox_Select.Size = new System.Drawing.Size(213, 23);
            this.TextBox_Select.TabIndex = 5;
            this.TextBox_Select.Text = "Find";
            this.TextBox_Select.TextChanged += new System.EventHandler(this.TextBox_Select_TextChanged);
            // 
            // ButtonInsert
            // 
            this.ButtonInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonInsert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonInsert.Location = new System.Drawing.Point(251, 345);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(90, 25);
            this.ButtonInsert.TabIndex = 6;
            this.ButtonInsert.Values.Text = "Insert";
            this.ButtonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonUpdate.Location = new System.Drawing.Point(590, 345);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(90, 25);
            this.ButtonUpdate.TabIndex = 8;
            this.ButtonUpdate.Values.Text = "Update";
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // Form_Dep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 714);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonInsert);
            this.Controls.Add(this.TextBox_Select);
            this.Controls.Add(this.MTextBox_Tel);
            this.Controls.Add(this.TextBox_Dir);
            this.Controls.Add(this.TextBox_Nom);
            this.Controls.Add(this.Label_ID);
            this.Controls.Add(this.KDataGrid);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Dep";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "Form_Dep";
            this.Load += new System.EventHandler(this.Form_Dep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDepBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView KDataGrid;
        private System.Windows.Forms.BindingSource cDepBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Label_ID;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBox_Nom;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBox_Dir;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox MTextBox_Tel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBox_Select;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonInsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonUpdate;
    }
}