
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
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rNCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cClBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.KDataGrid.Location = new System.Drawing.Point(0, 285);
            this.KDataGrid.Name = "KDataGrid";
            this.KDataGrid.ReadOnly = true;
            this.KDataGrid.RowHeadersVisible = false;
            this.KDataGrid.Size = new System.Drawing.Size(800, 193);
            this.KDataGrid.TabIndex = 45;
            this.KDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KDataGrid_CellClick);
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
            this.Tb_Apellido.Location = new System.Drawing.Point(180, 100);
            this.Tb_Apellido.Name = "Tb_Apellido";
            this.Tb_Apellido.Size = new System.Drawing.Size(100, 23);
            this.Tb_Apellido.TabIndex = 51;
            this.Tb_Apellido.Text = "Apellido";
            // 
            // TB_Cedula
            // 
            this.TB_Cedula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TB_Cedula.Location = new System.Drawing.Point(33, 185);
            this.TB_Cedula.Name = "TB_Cedula";
            this.TB_Cedula.Size = new System.Drawing.Size(100, 23);
            this.TB_Cedula.TabIndex = 49;
            this.TB_Cedula.Text = "Cedula";
            // 
            // Tb_RNC
            // 
            this.Tb_RNC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Tb_RNC.Location = new System.Drawing.Point(180, 185);
            this.Tb_RNC.Name = "Tb_RNC";
            this.Tb_RNC.Size = new System.Drawing.Size(100, 23);
            this.Tb_RNC.TabIndex = 48;
            this.Tb_RNC.Text = "RNC";
            // 
            // TBNombre
            // 
            this.TBNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TBNombre.Location = new System.Drawing.Point(33, 100);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(100, 23);
            this.TBNombre.TabIndex = 47;
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
            this.MTextBox_Tel.Location = new System.Drawing.Point(329, 100);
            this.MTextBox_Tel.Name = "MTextBox_Tel";
            this.MTextBox_Tel.Size = new System.Drawing.Size(96, 23);
            this.MTextBox_Tel.TabIndex = 52;
            this.MTextBox_Tel.Tag = "Invalid";
            this.MTextBox_Tel.Text = "Telefono";
            // 
            // Tb_Ubi
            // 
            this.Tb_Ubi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Tb_Ubi.Location = new System.Drawing.Point(457, 110);
            this.Tb_Ubi.Multiline = true;
            this.Tb_Ubi.Name = "Tb_Ubi";
            this.Tb_Ubi.Size = new System.Drawing.Size(100, 81);
            this.Tb_Ubi.TabIndex = 53;
            this.Tb_Ubi.Text = "Ubicacion";
            // 
            // Tb_Email
            // 
            this.Tb_Email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Tb_Email.Location = new System.Drawing.Point(325, 185);
            this.Tb_Email.Name = "Tb_Email";
            this.Tb_Email.Size = new System.Drawing.Size(100, 23);
            this.Tb_Email.TabIndex = 54;
            this.Tb_Email.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Nombre";
            // 
            // Form_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}