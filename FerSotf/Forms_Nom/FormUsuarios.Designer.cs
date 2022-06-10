namespace FerSotf.Forms_Nom
{
    partial class FormUsuarios
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
            this.CBRol = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.TBPass = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Label_ID = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.KDataGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ButtonUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.B_UP = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ButtonInsert = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.TB_ID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TB_S = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.B_C = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.iDempDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CBRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CBRol
            // 
            this.CBRol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CBRol.DropDownWidth = 121;
            this.CBRol.Location = new System.Drawing.Point(807, 88);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(121, 21);
            this.CBRol.TabIndex = 25;
            this.CBRol.Text = "Rol";
            // 
            // TBPass
            // 
            this.TBPass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TBPass.Location = new System.Drawing.Point(390, 71);
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(100, 23);
            this.TBPass.TabIndex = 24;
            this.TBPass.Text = "Password";
            this.TBPass.Visible = false;
            // 
            // Label_ID
            // 
            this.Label_ID.Location = new System.Drawing.Point(77, 42);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(25, 20);
            this.Label_ID.TabIndex = 26;
            this.Label_ID.Values.Text = "ID:";
            // 
            // KDataGrid
            // 
            this.KDataGrid.AllowUserToAddRows = false;
            this.KDataGrid.AllowUserToDeleteRows = false;
            this.KDataGrid.AllowUserToOrderColumns = true;
            this.KDataGrid.AutoGenerateColumns = false;
            this.KDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDempDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.puestoDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.depDataGridViewTextBoxColumn,
            this.rolDataGridViewTextBoxColumn});
            this.KDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KDataGrid.DataSource = this.cUsuarioBindingSource;
            this.KDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.KDataGrid.HideOuterBorders = true;
            this.KDataGrid.Location = new System.Drawing.Point(0, 254);
            this.KDataGrid.Name = "KDataGrid";
            this.KDataGrid.ReadOnly = true;
            this.KDataGrid.RowHeadersVisible = false;
            this.KDataGrid.Size = new System.Drawing.Size(1091, 170);
            this.KDataGrid.TabIndex = 27;
            this.KDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KDataGrid_CellClick);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonUpdate.Location = new System.Drawing.Point(820, 135);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(90, 25);
            this.ButtonUpdate.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ButtonUpdate.StateDisabled.Border.Rounding = 15;
            this.ButtonUpdate.TabIndex = 30;
            this.ButtonUpdate.Values.Text = "Cambiar Rol";
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // B_UP
            // 
            this.B_UP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.B_UP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_UP.Location = new System.Drawing.Point(390, 113);
            this.B_UP.Name = "B_UP";
            this.B_UP.Size = new System.Drawing.Size(130, 25);
            this.B_UP.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.B_UP.StateDisabled.Border.Rounding = 15;
            this.B_UP.TabIndex = 29;
            this.B_UP.Values.Text = "Cambiar Contraseña";
            this.B_UP.Click += new System.EventHandler(this.B_UP_Click);
            // 
            // ButtonInsert
            // 
            this.ButtonInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonInsert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonInsert.Location = new System.Drawing.Point(129, 113);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(123, 25);
            this.ButtonInsert.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ButtonInsert.StateDisabled.Border.Rounding = 15;
            this.ButtonInsert.TabIndex = 28;
            this.ButtonInsert.Values.Text = "Agregar Usuario";
            this.ButtonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // TB_ID
            // 
            this.TB_ID.Location = new System.Drawing.Point(129, 42);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(100, 23);
            this.TB_ID.TabIndex = 31;
            this.TB_ID.Tag = "NotValid";
            this.TB_ID.Text = "ID";
            this.TB_ID.TextChanged += new System.EventHandler(this.TB_ID_TextChanged);
            // 
            // TB_S
            // 
            this.TB_S.Location = new System.Drawing.Point(807, 13);
            this.TB_S.Name = "TB_S";
            this.TB_S.Size = new System.Drawing.Size(100, 23);
            this.TB_S.TabIndex = 32;
            this.TB_S.Text = "Buscar";
            this.TB_S.TextChanged += new System.EventHandler(this.TB_S_TextChanged);
            // 
            // B_C
            // 
            this.B_C.Location = new System.Drawing.Point(747, 205);
            this.B_C.Name = "B_C";
            this.B_C.Size = new System.Drawing.Size(90, 25);
            this.B_C.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.B_C.StateDisabled.Border.Rounding = 15;
            this.B_C.TabIndex = 33;
            this.B_C.Values.Text = "Cancelar";
            this.B_C.Visible = false;
            this.B_C.Click += new System.EventHandler(this.B_C_Click);
            // 
            // iDempDataGridViewTextBoxColumn
            // 
            this.iDempDataGridViewTextBoxColumn.DataPropertyName = "ID_emp";
            this.iDempDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDempDataGridViewTextBoxColumn.Name = "iDempDataGridViewTextBoxColumn";
            this.iDempDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDempDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDempDataGridViewTextBoxColumn.Width = 182;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // puestoDataGridViewTextBoxColumn
            // 
            this.puestoDataGridViewTextBoxColumn.DataPropertyName = "Puesto";
            this.puestoDataGridViewTextBoxColumn.HeaderText = "Puesto";
            this.puestoDataGridViewTextBoxColumn.Name = "puestoDataGridViewTextBoxColumn";
            this.puestoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // depDataGridViewTextBoxColumn
            // 
            this.depDataGridViewTextBoxColumn.DataPropertyName = "Dep";
            this.depDataGridViewTextBoxColumn.HeaderText = "Departamento";
            this.depDataGridViewTextBoxColumn.Name = "depDataGridViewTextBoxColumn";
            this.depDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rolDataGridViewTextBoxColumn
            // 
            this.rolDataGridViewTextBoxColumn.DataPropertyName = "Rol";
            this.rolDataGridViewTextBoxColumn.HeaderText = "Rol";
            this.rolDataGridViewTextBoxColumn.Name = "rolDataGridViewTextBoxColumn";
            this.rolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cUsuarioBindingSource
            // 
            this.cUsuarioBindingSource.DataSource = typeof(ClasesF.Clases_Nom.C_Usuario);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 424);
            this.Controls.Add(this.B_C);
            this.Controls.Add(this.TB_S);
            this.Controls.Add(this.TB_ID);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.B_UP);
            this.Controls.Add(this.ButtonInsert);
            this.Controls.Add(this.KDataGrid);
            this.Controls.Add(this.Label_ID);
            this.Controls.Add(this.CBRol);
            this.Controls.Add(this.TBPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CBRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonComboBox CBRol;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TBPass;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Label_ID;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView KDataGrid;
        private System.Windows.Forms.BindingSource cUsuarioBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn iDempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton B_UP;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonInsert;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TB_ID;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TB_S;
        private ComponentFactory.Krypton.Toolkit.KryptonButton B_C;
    }
}