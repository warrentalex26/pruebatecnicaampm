namespace PruebaTecnica.Views
{
    partial class Inicio
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
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBProductosDataSet = new PruebaTecnica.DBProductosDataSet();
            this.productosTableAdapter = new PruebaTecnica.DBProductosDataSetTableAdapters.ProductosTableAdapter();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nombreProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenProductoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.SubirImagen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MostrarOpciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AgregarOpcion = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProductosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.existenciaDataGridViewTextBoxColumn,
            this.estadoDataGridViewCheckBoxColumn,
            this.nombreProveedorDataGridViewTextBoxColumn,
            this.imagenProductoDataGridViewImageColumn,
            this.SubirImagen,
            this.MostrarOpciones,
            this.AgregarOpcion});
            this.dataGridView1.DataSource = this.productosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1225, 330);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.dBProductosDataSet;
            this.productosBindingSource.CurrentChanged += new System.EventHandler(this.productosBindingSource_CurrentChanged);
            // 
            // dBProductosDataSet
            // 
            this.dBProductosDataSet.DataSetName = "DBProductosDataSet";
            this.dBProductosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscar.Location = new System.Drawing.Point(582, 58);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(309, 22);
            this.TxtBuscar.TabIndex = 1;
            // 
            // CbEstado
            // 
            this.CbEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbEstado.FormattingEnabled = true;
            this.CbEstado.Items.AddRange(new object[] {
            "Inactivo",
            "Activo",
            "Todos"});
            this.CbEstado.Location = new System.Drawing.Point(913, 58);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(170, 24);
            this.CbEstado.TabIndex = 2;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscar.Location = new System.Drawing.Point(1110, 59);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(145, 23);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // existenciaDataGridViewTextBoxColumn
            // 
            this.existenciaDataGridViewTextBoxColumn.DataPropertyName = "existencia";
            this.existenciaDataGridViewTextBoxColumn.HeaderText = "existencia";
            this.existenciaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.existenciaDataGridViewTextBoxColumn.Name = "existenciaDataGridViewTextBoxColumn";
            this.existenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            this.estadoDataGridViewCheckBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewCheckBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            this.estadoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // nombreProveedorDataGridViewTextBoxColumn
            // 
            this.nombreProveedorDataGridViewTextBoxColumn.DataPropertyName = "nombreProveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.HeaderText = "nombreProveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreProveedorDataGridViewTextBoxColumn.Name = "nombreProveedorDataGridViewTextBoxColumn";
            this.nombreProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imagenProductoDataGridViewImageColumn
            // 
            this.imagenProductoDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.imagenProductoDataGridViewImageColumn.DataPropertyName = "imagenProducto";
            this.imagenProductoDataGridViewImageColumn.HeaderText = "imagenProducto";
            this.imagenProductoDataGridViewImageColumn.MinimumWidth = 6;
            this.imagenProductoDataGridViewImageColumn.Name = "imagenProductoDataGridViewImageColumn";
            this.imagenProductoDataGridViewImageColumn.ReadOnly = true;
            this.imagenProductoDataGridViewImageColumn.Width = 130;
            // 
            // SubirImagen
            // 
            this.SubirImagen.HeaderText = "Subir Imagen";
            this.SubirImagen.MinimumWidth = 6;
            this.SubirImagen.Name = "SubirImagen";
            this.SubirImagen.ReadOnly = true;
            this.SubirImagen.Text = "Subir Imagen";
            this.SubirImagen.UseColumnTextForButtonValue = true;
            // 
            // MostrarOpciones
            // 
            this.MostrarOpciones.HeaderText = "Mostrar Opciones";
            this.MostrarOpciones.MinimumWidth = 6;
            this.MostrarOpciones.Name = "MostrarOpciones";
            this.MostrarOpciones.ReadOnly = true;
            this.MostrarOpciones.Text = "Mostrar Opciones";
            this.MostrarOpciones.UseColumnTextForButtonValue = true;
            // 
            // AgregarOpcion
            // 
            this.AgregarOpcion.HeaderText = "Agregar Opcion";
            this.AgregarOpcion.MinimumWidth = 6;
            this.AgregarOpcion.Name = "AgregarOpcion";
            this.AgregarOpcion.ReadOnly = true;
            this.AgregarOpcion.Text = "Agregar Opcion";
            this.AgregarOpcion.UseColumnTextForButtonValue = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 594);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.CbEstado);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProductosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DBProductosDataSet dBProductosDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private DBProductosDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagenProductoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewButtonColumn SubirImagen;
        private System.Windows.Forms.DataGridViewButtonColumn MostrarOpciones;
        private System.Windows.Forms.DataGridViewButtonColumn AgregarOpcion;
    }
}