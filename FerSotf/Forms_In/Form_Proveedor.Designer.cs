
namespace FerSotf.Forms_In
{
    partial class Form_Proveedor
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
            this.ButtonUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ButtonInsert = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Label_ID = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.TextBox_Select = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.MTextBox_Tel = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.TBNombre = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Tb_Email = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TB_Ag = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.KDataGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.KDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cProvBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonUpdate.Location = new System.Drawing.Point(36, 345);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(90, 25);
            this.ButtonUpdate.TabIndex = 13;
            this.ButtonUpdate.Values.Text = "Update";
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonInsert
            // 
            this.ButtonInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonInsert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonInsert.Location = new System.Drawing.Point(473, 345);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(90, 25);
            this.ButtonInsert.TabIndex = 12;
            this.ButtonInsert.Values.Text = "Insert";
            this.ButtonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // Label_ID
            // 
            this.Label_ID.Location = new System.Drawing.Point(112, 41);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(25, 20);
            this.Label_ID.TabIndex = 22;
            this.Label_ID.Values.Text = "ID:";
            // 
            // TextBox_Select
            // 
            this.TextBox_Select.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Select.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextBox_Select.Location = new System.Drawing.Point(525, 38);
            this.TextBox_Select.Name = "TextBox_Select";
            this.TextBox_Select.Size = new System.Drawing.Size(416, 23);
            this.TextBox_Select.TabIndex = 21;
            this.TextBox_Select.Text = "Find";
            this.TextBox_Select.TextChanged += new System.EventHandler(this.TextBox_Select_TextChanged);
            // 
            // MTextBox_Tel
            // 
            this.MTextBox_Tel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MTextBox_Tel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MTextBox_Tel.Location = new System.Drawing.Point(535, 195);
            this.MTextBox_Tel.Name = "MTextBox_Tel";
            this.MTextBox_Tel.Size = new System.Drawing.Size(96, 23);
            this.MTextBox_Tel.TabIndex = 28;
            this.MTextBox_Tel.Tag = "Invalid";
            this.MTextBox_Tel.Text = "Telefono";
            // 
            // TBNombre
            // 
            this.TBNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TBNombre.Location = new System.Drawing.Point(215, 178);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(100, 23);
            this.TBNombre.TabIndex = 27;
            this.TBNombre.Text = "Nombre";
            // 
            // Tb_Email
            // 
            this.Tb_Email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Tb_Email.Location = new System.Drawing.Point(374, 216);
            this.Tb_Email.Name = "Tb_Email";
            this.Tb_Email.Size = new System.Drawing.Size(100, 23);
            this.Tb_Email.TabIndex = 29;
            this.Tb_Email.Text = "Email";
            // 
            // TB_Ag
            // 
            this.TB_Ag.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TB_Ag.Location = new System.Drawing.Point(102, 216);
            this.TB_Ag.Name = "TB_Ag";
            this.TB_Ag.Size = new System.Drawing.Size(100, 23);
            this.TB_Ag.TabIndex = 30;
            this.TB_Ag.Text = "Agente";
            // 
            // KDataGrid
            // 
            this.KDataGrid.AllowUserToAddRows = false;
            this.KDataGrid.AllowUserToDeleteRows = false;
            this.KDataGrid.AutoGenerateColumns = false;
            this.KDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.agenteDataGridViewTextBoxColumn});
            this.KDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KDataGrid.DataSource = this.cProvBindingSource;
            this.KDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.KDataGrid.HideOuterBorders = true;
            this.KDataGrid.Location = new System.Drawing.Point(0, 397);
            this.KDataGrid.Name = "KDataGrid";
            this.KDataGrid.ReadOnly = true;
            this.KDataGrid.RowHeadersVisible = false;
            this.KDataGrid.Size = new System.Drawing.Size(1386, 176);
            this.KDataGrid.TabIndex = 31;
            this.KDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KDataGrid_CellClick);
            this.KDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KDataGrid_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // agenteDataGridViewTextBoxColumn
            // 
            this.agenteDataGridViewTextBoxColumn.DataPropertyName = "Agente";
            this.agenteDataGridViewTextBoxColumn.HeaderText = "Agente";
            this.agenteDataGridViewTextBoxColumn.Name = "agenteDataGridViewTextBoxColumn";
            this.agenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cProvBindingSource
            // 
            this.cProvBindingSource.DataSource = typeof(ClasesF.Clases_Inv.C_Prov);
            // 
            // Form_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 573);
            this.Controls.Add(this.KDataGrid);
            this.Controls.Add(this.TB_Ag);
            this.Controls.Add(this.Tb_Email);
            this.Controls.Add(this.MTextBox_Tel);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.Label_ID);
            this.Controls.Add(this.TextBox_Select);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Proveedor";
            this.Text = "Form_Proveedor";
            this.Load += new System.EventHandler(this.Form_Proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cProvBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonInsert;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Label_ID;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBox_Select;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox MTextBox_Tel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TBNombre;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Tb_Email;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TB_Ag;
        private System.Windows.Forms.BindingSource cProvBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView KDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agenteDataGridViewTextBoxColumn;
    }
}