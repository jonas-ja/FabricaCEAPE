﻿namespace FabricaCEAPE.Vistas
{
    partial class FrmListaTipoProducto
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
            this.tipoProductoDataGridView = new System.Windows.Forms.DataGridView();
            this.tipoProductoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingNavigator)).BeginInit();
            this.tipoProductoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tipoProductoDataGridView
            // 
            this.tipoProductoDataGridView.AllowUserToAddRows = false;
            this.tipoProductoDataGridView.AllowUserToDeleteRows = false;
            this.tipoProductoDataGridView.AllowUserToResizeColumns = false;
            this.tipoProductoDataGridView.AllowUserToResizeRows = false;
            this.tipoProductoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tipoProductoDataGridView.AutoGenerateColumns = false;
            this.tipoProductoDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tipoProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tipoProductoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.tipoProductoDataGridView.DataSource = this.tipoProductoBindingSource;
            this.tipoProductoDataGridView.Location = new System.Drawing.Point(12, 28);
            this.tipoProductoDataGridView.MultiSelect = false;
            this.tipoProductoDataGridView.Name = "tipoProductoDataGridView";
            this.tipoProductoDataGridView.ReadOnly = true;
            this.tipoProductoDataGridView.RowHeadersVisible = false;
            this.tipoProductoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tipoProductoDataGridView.Size = new System.Drawing.Size(203, 319);
            this.tipoProductoDataGridView.StandardTab = true;
            this.tipoProductoDataGridView.TabIndex = 1;
            this.tipoProductoDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tipoProductoDataGridView_CellDoubleClick);
            // 
            // tipoProductoBindingNavigator
            // 
            this.tipoProductoBindingNavigator.AddNewItem = null;
            this.tipoProductoBindingNavigator.BindingSource = this.tipoProductoBindingSource;
            this.tipoProductoBindingNavigator.CountItem = null;
            this.tipoProductoBindingNavigator.DeleteItem = null;
            this.tipoProductoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.toolStripSeparator1,
            this.btnModificar,
            this.toolStripSeparator2,
            this.btnEliminar,
            this.btnSalir});
            this.tipoProductoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tipoProductoBindingNavigator.MoveFirstItem = null;
            this.tipoProductoBindingNavigator.MoveLastItem = null;
            this.tipoProductoBindingNavigator.MoveNextItem = null;
            this.tipoProductoBindingNavigator.MovePreviousItem = null;
            this.tipoProductoBindingNavigator.Name = "tipoProductoBindingNavigator";
            this.tipoProductoBindingNavigator.PositionItem = null;
            this.tipoProductoBindingNavigator.Size = new System.Drawing.Size(594, 25);
            this.tipoProductoBindingNavigator.TabIndex = 0;
            this.tipoProductoBindingNavigator.TabStop = true;
            this.tipoProductoBindingNavigator.Text = "bindingNavigator1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::FabricaCEAPE.Properties.Resources.add139;
            this.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.ToolTipText = "Nuevo tipo de producto";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::FabricaCEAPE.Properties.Resources.pencil43;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.ToolTipText = "Modificar tipo de producto";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::FabricaCEAPE.Properties.Resources.delete96;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.ToolTipText = "Eliminar tipo de producto";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalir.Image = global::FabricaCEAPE.Properties.Resources.next21;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // tipoProductoBindingSource
            // 
            this.tipoProductoBindingSource.DataSource = typeof(FabricaCEAPE.Clases.TipoProducto);
            // 
            // FrmListaTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 359);
            this.Controls.Add(this.tipoProductoDataGridView);
            this.Controls.Add(this.tipoProductoBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmListaTipoProducto";
            this.Text = "Tipos de producto";
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingNavigator)).EndInit();
            this.tipoProductoBindingNavigator.ResumeLayout(false);
            this.tipoProductoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tipoProductoBindingSource;
        private System.Windows.Forms.DataGridView tipoProductoDataGridView;
        private System.Windows.Forms.BindingNavigator tipoProductoBindingNavigator;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}