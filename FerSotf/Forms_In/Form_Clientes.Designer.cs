
namespace FerSotf.Forms_In
{
    partial class Form_Clientes
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
            this.TextBox_Select = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.KDataGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ButtonUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ButtonInsert = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Tb_Apellido = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TB_Cedula = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Tb_RNC = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TBNombre = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Label_ID = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.MTextBox_Tel = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.Tb_Ubi = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Tb_Email = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rNCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cClBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.KDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cClBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_Select
            // 
            this.TextBox_Select.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Select.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextBox_Select.Location = new System.Drawing.Point(516, 21);
            this.TextBox_Select.Name = "TextBox_Select";
            this.TextBox_Select.Size = new System.Drawing.Size(287, 23);
            this.TextBox_Select.TabIndex = 42;
            this.TextBox_Select.Text = "Find";
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
            this.cedulaDataGridViewTextBoxColumn,
            this.rNCDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.ubicacionDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.KDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KDataGrid.DataSource = this.cClBindingSource;
            this.KDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.KDataGrid.HideOuterBorders = true;
            this.KDataGrid.Location = new System.Drawing.Point(0, 302);
            this.KDataGrid.Name = "KDataGrid";
            this.KDataGrid.ReadOnly = true;
            this.KDataGrid.RowHeadersVisible = false;
            this.KDataGrid.Size = new System.Drawing.Size(800, 176);
            this.KDataGrid.TabIndex = 45;
            this.KDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KDataGrid_CellClick);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonUpdate.Location = new System.Drawing.Point(85, 254);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(90, 25);
            this.ButtonUpdate.TabIndex = 44;
            this.ButtonUpdate.Values.Text = "Update";
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonInsert
            // 
            this.ButtonInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonInsert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonInsert.Location = new System.Drawing.Point(655, 245);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(90, 25);
            this.ButtonInsert.TabIndex = 43;
            this.ButtonInsert.Values.Text = "Insert";
            this.ButtonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // Tb_Apellido
            // 
            this.Tb_Apellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Tb_Apellido.Location = new System.Drawing.Point(295, 103);
            this.Tb_Apellido.Name = "Tb_Apellido";
            this.Tb_Apellido.Size = new System.Drawing.Size(100, 23);
            this.Tb_Apellido.TabIndex = 51;
            this.Tb_Apellido.Text = "Apellido";
            // 
            // TB_Cedula
            // 
            this.TB_Cedula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TB_Cedula.Location = new System.Drawing.Point(60, 188);
            this.TB_Cedula.Name = "TB_Cedula";
            this.TB_Cedula.Size = new System.Drawing.Size(100, 23);
            this.TB_Cedula.TabIndex = 49;
            this.TB_Cedula.Text = "Cedula";
            // 
            // Tb_RNC
            // 
            this.Tb_RNC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Tb_RNC.Location = new System.Drawing.Point(295, 188);
            this.Tb_RNC.Name = "Tb_RNC";
            this.Tb_RNC.Size = new System.Drawing.Size(100, 23);
            this.Tb_RNC.TabIndex = 48;
            this.Tb_RNC.Text = "RNC";
            // 
            // TBNombre
            // 
            this.TBNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TBNombre.Location = new System.Drawing.Point(60, 103);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(100, 23);
            this.TBNombre.TabIndex = 47;
            this.TBNombre.Text = "Nombre";
            // 
            // Label_ID
            // 
            this.Label_ID.Location = new System.Drawing.Point(60, 35);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(25, 20);
            this.Label_ID.TabIndex = 46;
            this.Label_ID.Values.Text = "ID:";
            // 
            // MTextBox_Tel
            // 
            this.MTextBox_Tel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MTextBox_Tel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MTextBox_Tel.Location = new System.Drawing.Point(540, 103);
            this.MTextBox_Tel.Name = "MTextBox_Tel";
            this.MTextBox_Tel.Size = new System.Drawing.Size(96, 23);
            this.MTextBox_Tel.TabIndex = 52;
            this.MTextBox_Tel.Tag = "Invalid";
            this.MTextBox_Tel.Text = "Telefono";
            // 
            // Tb_Ubi
            // 
            this.Tb_Ubi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Tb_Ubi.Location = new System.Drawing.Point(671, 116);
            this.Tb_Ubi.Multiline = true;
            this.Tb_Ubi.Name = "Tb_Ubi";
            this.Tb_Ubi.Size = new System.Drawing.Size(100, 81);
            this.Tb_Ubi.TabIndex = 53;
            this.Tb_Ubi.Text = "Ubicacion";
            // 
            // Tb_Email
            // 
            this.Tb_Email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Tb_Email.Location = new System.Drawing.Point(536, 188);
            this.Tb_Email.Name = "Tb_Email";
            this.Tb_Email.Size = new System.Drawing.Size(100, 23);
            this.Tb_Email.TabIndex = 54;
            this.Tb_Email.Text = "Email";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rNCDataGridViewTextBoxColumn
            // 
            this.rNCDataGridViewTextBoxColumn.DataPropertyName = "RNC";
            this.rNCDataGridViewTextBoxColumn.HeaderText = "RNC";
            this.rNCDataGridViewTextBoxColumn.Name = "rNCDataGridViewTextBoxColumn";
            this.rNCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ubicacionDataGridViewTextBoxColumn
            // 
            this.ubicacionDataGridViewTextBoxColumn.DataPropertyName = "Ubicacion";
            this.ubicacionDataGridViewTextBoxColumn.HeaderText = "Ubicacion";
            this.ubicacionDataGridViewTextBoxColumn.Name = "ubicacionDataGridViewTextBoxColumn";
            this.ubicacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cClBindingSource
            // 
            this.cClBindingSource.DataSource = typeof(ClasesF.Clases_Inv.C_Cl);
            // 
            // Form_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.Tb_Email);
            this.Controls.Add(this.Tb_Ubi);
            this.Controls.Add(this.MTextBox_Tel);
            this.Controls.Add(this.Tb_Apellido);
            this.Controls.Add(this.TB_Cedula);
            this.Controls.Add(this.Tb_RNC);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.Label_ID);
            this.Controls.Add(this.KDataGrid);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonInsert);
            this.Controls.Add(this.TextBox_Select);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Form_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cClBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBox_Select;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView KDataGrid;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonInsert;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Tb_Apellido;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TB_Cedula;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Tb_RNC;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TBNombre;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Label_ID;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox MTextBox_Tel;
        private System.Windows.Forms.BindingSource cClBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rNCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Tb_Ubi;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Tb_Email;
    }
}