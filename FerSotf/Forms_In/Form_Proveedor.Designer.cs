
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
            this.ButtonUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ButtonInsert = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Label_ID = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.TextBox_Select = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.KDataGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.MTextBox_Tel = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.TBNombre = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Tb_Email = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TB_Ag = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.KDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonUpdate.Location = new System.Drawing.Point(646, 231);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(90, 25);
            this.ButtonUpdate.TabIndex = 13;
            this.ButtonUpdate.Values.Text = "Update";
            this.ButtonUpdate.Visible = false;
            // 
            // ButtonInsert
            // 
            this.ButtonInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonInsert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonInsert.Location = new System.Drawing.Point(235, 222);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(90, 25);
            this.ButtonInsert.TabIndex = 12;
            this.ButtonInsert.Values.Text = "Insert";
            // 
            // Label_ID
            // 
            this.Label_ID.Location = new System.Drawing.Point(-141, 229);
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
            this.TextBox_Select.Location = new System.Drawing.Point(536, 24);
            this.TextBox_Select.Name = "TextBox_Select";
            this.TextBox_Select.Size = new System.Drawing.Size(376, 23);
            this.TextBox_Select.TabIndex = 21;
            this.TextBox_Select.Text = "Find";
            // 
            // KDataGrid
            // 
            this.KDataGrid.AllowUserToAddRows = false;
            this.KDataGrid.AllowUserToDeleteRows = false;
            this.KDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.KDataGrid.HideOuterBorders = true;
            this.KDataGrid.Location = new System.Drawing.Point(0, 262);
            this.KDataGrid.Name = "KDataGrid";
            this.KDataGrid.ReadOnly = true;
            this.KDataGrid.RowHeadersVisible = false;
            this.KDataGrid.Size = new System.Drawing.Size(910, 188);
            this.KDataGrid.TabIndex = 25;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(102, 27);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(25, 20);
            this.kryptonLabel1.TabIndex = 24;
            this.kryptonLabel1.Values.Text = "ID:";
            // 
            // MTextBox_Tel
            // 
            this.MTextBox_Tel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MTextBox_Tel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MTextBox_Tel.Location = new System.Drawing.Point(536, 85);
            this.MTextBox_Tel.Name = "MTextBox_Tel";
            this.MTextBox_Tel.Size = new System.Drawing.Size(96, 23);
            this.MTextBox_Tel.TabIndex = 28;
            this.MTextBox_Tel.Tag = "Invalid";
            this.MTextBox_Tel.Text = "Telefono";
            // 
            // TBNombre
            // 
            this.TBNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TBNombre.Location = new System.Drawing.Point(102, 85);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(100, 23);
            this.TBNombre.TabIndex = 27;
            this.TBNombre.Text = "Nombre";
            // 
            // Tb_Email
            // 
            this.Tb_Email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Tb_Email.Location = new System.Drawing.Point(374, 155);
            this.Tb_Email.Name = "Tb_Email";
            this.Tb_Email.Size = new System.Drawing.Size(100, 23);
            this.Tb_Email.TabIndex = 29;
            this.Tb_Email.Text = "Email";
            // 
            // TB_Ag
            // 
            this.TB_Ag.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TB_Ag.Location = new System.Drawing.Point(102, 155);
            this.TB_Ag.Name = "TB_Ag";
            this.TB_Ag.Size = new System.Drawing.Size(100, 23);
            this.TB_Ag.TabIndex = 30;
            this.TB_Ag.Text = "Agente";
            // 
            // Form_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.TB_Ag);
            this.Controls.Add(this.Tb_Email);
            this.Controls.Add(this.MTextBox_Tel);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.KDataGrid);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.Label_ID);
            this.Controls.Add(this.TextBox_Select);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Proveedor";
            this.Text = "Form_Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.KDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonInsert;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Label_ID;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBox_Select;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView KDataGrid;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox MTextBox_Tel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TBNombre;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Tb_Email;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TB_Ag;
    }
}