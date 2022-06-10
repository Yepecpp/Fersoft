namespace FerSotf.Forms_Nom
{
    partial class Form_J
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
            this.Paleta = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.TB_ID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.L_ID = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.FL_Horario = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.FL_Nom = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.FechaO = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.FechaI = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.TB_S = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.B_Ins = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.NDataGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.iDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cJorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Paleta
            // 
            this.Paleta.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Paleta.BaseRenderMode = ComponentFactory.Krypton.Toolkit.RendererMode.Professional;
            this.Paleta.FormStyles.FormCommon.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Paleta.FormStyles.FormCommon.StateActive.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.TB_ID);
            this.kryptonPanel1.Controls.Add(this.L_ID);
            this.kryptonPanel1.Controls.Add(this.FL_Horario);
            this.kryptonPanel1.Controls.Add(this.FL_Nom);
            this.kryptonPanel1.Controls.Add(this.kryptonGroup1);
            this.kryptonPanel1.Controls.Add(this.B_Ins);
            this.kryptonPanel1.Controls.Add(this.NDataGrid);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 517);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // TB_ID
            // 
            this.TB_ID.Location = new System.Drawing.Point(86, 19);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(100, 23);
            this.TB_ID.TabIndex = 24;
            this.TB_ID.Tag = "Invalid";
            this.TB_ID.Text = "0";
            this.TB_ID.TextChanged += new System.EventHandler(this.TB_ID_TextChanged);
            // 
            // L_ID
            // 
            this.L_ID.Location = new System.Drawing.Point(48, 22);
            this.L_ID.Name = "L_ID";
            this.L_ID.Size = new System.Drawing.Size(25, 20);
            this.L_ID.TabIndex = 23;
            this.L_ID.Values.Text = "ID:";
            // 
            // FL_Horario
            // 
            this.FL_Horario.Location = new System.Drawing.Point(44, 78);
            this.FL_Horario.Name = "FL_Horario";
            this.FL_Horario.Size = new System.Drawing.Size(54, 20);
            this.FL_Horario.TabIndex = 22;
            this.FL_Horario.Values.Text = "Horario:";
            // 
            // FL_Nom
            // 
            this.FL_Nom.Location = new System.Drawing.Point(44, 52);
            this.FL_Nom.Name = "FL_Nom";
            this.FL_Nom.Size = new System.Drawing.Size(58, 20);
            this.FL_Nom.TabIndex = 20;
            this.FL_Nom.Values.Text = "Nombre:";
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(403, 23);
            this.kryptonGroup1.Name = "kryptonGroup1";
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.FechaO);
            this.kryptonGroup1.Panel.Controls.Add(this.FechaI);
            this.kryptonGroup1.Panel.Controls.Add(this.TB_S);
            this.kryptonGroup1.Size = new System.Drawing.Size(338, 150);
            this.kryptonGroup1.TabIndex = 19;
            // 
            // FechaO
            // 
            this.FechaO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaO.Location = new System.Drawing.Point(195, 89);
            this.FechaO.Name = "FechaO";
            this.FechaO.Size = new System.Drawing.Size(92, 21);
            this.FechaO.TabIndex = 2;
            // 
            // FechaI
            // 
            this.FechaI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaI.Location = new System.Drawing.Point(42, 89);
            this.FechaI.Name = "FechaI";
            this.FechaI.Size = new System.Drawing.Size(92, 21);
            this.FechaI.TabIndex = 1;
            // 
            // TB_S
            // 
            this.TB_S.Location = new System.Drawing.Point(164, 24);
            this.TB_S.Name = "TB_S";
            this.TB_S.Size = new System.Drawing.Size(100, 23);
            this.TB_S.TabIndex = 0;
            this.TB_S.Text = "0";
            this.TB_S.TextChanged += new System.EventHandler(this.TB_S_TextChanged);
            // 
            // B_Ins
            // 
            this.B_Ins.Location = new System.Drawing.Point(143, 231);
            this.B_Ins.Name = "B_Ins";
            this.B_Ins.Size = new System.Drawing.Size(90, 25);
            this.B_Ins.TabIndex = 18;
            this.B_Ins.Values.Text = "Ponchar";
            this.B_Ins.Click += new System.EventHandler(this.B_Ins_Click);
            // 
            // NDataGrid
            // 
            this.NDataGrid.AllowUserToAddRows = false;
            this.NDataGrid.AllowUserToDeleteRows = false;
            this.NDataGrid.AutoGenerateColumns = false;
            this.NDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.horarioDataGridViewTextBoxColumn,
            this.entradaDataGridViewTextBoxColumn,
            this.salidaDataGridViewTextBoxColumn});
            this.NDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NDataGrid.DataSource = this.cJorBindingSource;
            this.NDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NDataGrid.HideOuterBorders = true;
            this.NDataGrid.Location = new System.Drawing.Point(0, 288);
            this.NDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.NDataGrid.Name = "NDataGrid";
            this.NDataGrid.ReadOnly = true;
            this.NDataGrid.RowHeadersVisible = false;
            this.NDataGrid.Size = new System.Drawing.Size(800, 229);
            this.NDataGrid.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.NDataGrid.StateCommon.Background.Color2 = System.Drawing.Color.Transparent;
            this.NDataGrid.StateCommon.Background.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.NDataGrid.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.NDataGrid.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.Transparent;
            this.NDataGrid.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.Transparent;
            this.NDataGrid.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Lime;
            this.NDataGrid.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.White;
            this.NDataGrid.StateCommon.DataCell.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.NDataGrid.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.NDataGrid.StateCommon.DataCell.Border.Width = 3;
            this.NDataGrid.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.NDataGrid.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.Black;
            this.NDataGrid.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NDataGrid.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.LightGray;
            this.NDataGrid.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White;
            this.NDataGrid.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.NDataGrid.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.NDataGrid.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.Black;
            this.NDataGrid.StateCommon.HeaderColumn.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.NDataGrid.StateCommon.HeaderColumn.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.NDataGrid.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.NDataGrid.StateCommon.HeaderColumn.Border.Width = 2;
            this.NDataGrid.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.Lime;
            this.NDataGrid.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NDataGrid.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NDataGrid.StateCommon.HeaderColumn.Content.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.NDataGrid.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(5, -1, -1, -1);
            this.NDataGrid.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.Lime;
            this.NDataGrid.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NDataGrid.StateSelected.DataCell.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassFade;
            this.NDataGrid.TabIndex = 17;
            // 
            // iDEDataGridViewTextBoxColumn
            // 
            this.iDEDataGridViewTextBoxColumn.DataPropertyName = "ID_E";
            this.iDEDataGridViewTextBoxColumn.HeaderText = "ID_E";
            this.iDEDataGridViewTextBoxColumn.Name = "iDEDataGridViewTextBoxColumn";
            this.iDEDataGridViewTextBoxColumn.ReadOnly = true;
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
            // horarioDataGridViewTextBoxColumn
            // 
            this.horarioDataGridViewTextBoxColumn.DataPropertyName = "Horario";
            this.horarioDataGridViewTextBoxColumn.HeaderText = "Horario";
            this.horarioDataGridViewTextBoxColumn.Name = "horarioDataGridViewTextBoxColumn";
            this.horarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entradaDataGridViewTextBoxColumn
            // 
            this.entradaDataGridViewTextBoxColumn.DataPropertyName = "Entrada";
            this.entradaDataGridViewTextBoxColumn.HeaderText = "Entrada";
            this.entradaDataGridViewTextBoxColumn.Name = "entradaDataGridViewTextBoxColumn";
            this.entradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salidaDataGridViewTextBoxColumn
            // 
            this.salidaDataGridViewTextBoxColumn.DataPropertyName = "Salida";
            this.salidaDataGridViewTextBoxColumn.HeaderText = "Salida";
            this.salidaDataGridViewTextBoxColumn.Name = "salidaDataGridViewTextBoxColumn";
            this.salidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cJorBindingSource
            // 
            this.cJorBindingSource.DataSource = typeof(ClasesF.Clases_Nom.C_Jor);
            // 
            // Form_J
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_J";
            this.Palette = this.Paleta;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "Form_J";
            this.Load += new System.EventHandler(this.Form_J_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            this.kryptonGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette Paleta;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView NDataGrid;
        private ComponentFactory.Krypton.Toolkit.KryptonButton B_Ins;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker FechaO;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker FechaI;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TB_S;
        private System.Windows.Forms.BindingSource cJorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salidaDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TB_ID;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel L_ID;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel FL_Horario;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel FL_Nom;
    }
}