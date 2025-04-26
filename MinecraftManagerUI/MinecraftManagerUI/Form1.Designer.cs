namespace MinecraftManagerUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreJugador = new System.Windows.Forms.TextBox();
            this.txtNivelJugador = new System.Windows.Forms.TextBox();
            this.btnAgregarJugador = new System.Windows.Forms.Button();
            this.btnEliminarJugador = new System.Windows.Forms.Button();
            this.btnModificarJugador = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jugadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbparcial2DataSet = new MinecraftManagerUI.dbparcial2DataSet();
            this.jugadoresTableAdapter = new MinecraftManagerUI.dbparcial2DataSetTableAdapters.JugadoresTableAdapter();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dbparcial2DataSet1 = new MinecraftManagerUI.dbparcial2DataSet1();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioTableAdapter = new MinecraftManagerUI.dbparcial2DataSet1TableAdapters.InventarioTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jugadorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloqueIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExportarInventario = new System.Windows.Forms.Button();
            this.chartEstadisticas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbparcial2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbparcial2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEstadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Jugador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nivel de Jugador";
            // 
            // txtNombreJugador
            // 
            this.txtNombreJugador.Location = new System.Drawing.Point(119, 1);
            this.txtNombreJugador.Name = "txtNombreJugador";
            this.txtNombreJugador.Size = new System.Drawing.Size(100, 20);
            this.txtNombreJugador.TabIndex = 2;
            // 
            // txtNivelJugador
            // 
            this.txtNivelJugador.Location = new System.Drawing.Point(332, 4);
            this.txtNivelJugador.Name = "txtNivelJugador";
            this.txtNivelJugador.Size = new System.Drawing.Size(100, 20);
            this.txtNivelJugador.TabIndex = 3;
            // 
            // btnAgregarJugador
            // 
            this.btnAgregarJugador.Location = new System.Drawing.Point(454, 0);
            this.btnAgregarJugador.Name = "btnAgregarJugador";
            this.btnAgregarJugador.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarJugador.TabIndex = 4;
            this.btnAgregarJugador.Text = "Alta";
            this.btnAgregarJugador.UseVisualStyleBackColor = true;
            this.btnAgregarJugador.Click += new System.EventHandler(this.btnAgregarJugador_Click);
            // 
            // btnEliminarJugador
            // 
            this.btnEliminarJugador.Location = new System.Drawing.Point(535, 1);
            this.btnEliminarJugador.Name = "btnEliminarJugador";
            this.btnEliminarJugador.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarJugador.TabIndex = 5;
            this.btnEliminarJugador.Text = "Baja";
            this.btnEliminarJugador.UseVisualStyleBackColor = true;
            // 
            // btnModificarJugador
            // 
            this.btnModificarJugador.Location = new System.Drawing.Point(616, 2);
            this.btnModificarJugador.Name = "btnModificarJugador";
            this.btnModificarJugador.Size = new System.Drawing.Size(75, 23);
            this.btnModificarJugador.TabIndex = 6;
            this.btnModificarJugador.Text = "Modificar";
            this.btnModificarJugador.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.nivelDataGridViewTextBoxColumn,
            this.fechaCreacionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jugadoresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(439, 61);
            this.dataGridView1.TabIndex = 7;
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
            // 
            // nivelDataGridViewTextBoxColumn
            // 
            this.nivelDataGridViewTextBoxColumn.DataPropertyName = "Nivel";
            this.nivelDataGridViewTextBoxColumn.HeaderText = "Nivel";
            this.nivelDataGridViewTextBoxColumn.Name = "nivelDataGridViewTextBoxColumn";
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            this.fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.HeaderText = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            // 
            // jugadoresBindingSource
            // 
            this.jugadoresBindingSource.DataMember = "Jugadores";
            this.jugadoresBindingSource.DataSource = this.dbparcial2DataSet;
            // 
            // dbparcial2DataSet
            // 
            this.dbparcial2DataSet.DataSetName = "dbparcial2DataSet";
            this.dbparcial2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jugadoresTableAdapter
            // 
            this.jugadoresTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Location = new System.Drawing.Point(332, 101);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltro.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.jugadorIdDataGridViewTextBoxColumn,
            this.bloqueIdDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.inventarioBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(16, 143);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(443, 45);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dbparcial2DataSet1
            // 
            this.dbparcial2DataSet1.DataSetName = "dbparcial2DataSet1";
            this.dbparcial2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "Inventario";
            this.inventarioBindingSource.DataSource = this.dbparcial2DataSet1;
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // jugadorIdDataGridViewTextBoxColumn
            // 
            this.jugadorIdDataGridViewTextBoxColumn.DataPropertyName = "JugadorId";
            this.jugadorIdDataGridViewTextBoxColumn.HeaderText = "JugadorId";
            this.jugadorIdDataGridViewTextBoxColumn.Name = "jugadorIdDataGridViewTextBoxColumn";
            // 
            // bloqueIdDataGridViewTextBoxColumn
            // 
            this.bloqueIdDataGridViewTextBoxColumn.DataPropertyName = "BloqueId";
            this.bloqueIdDataGridViewTextBoxColumn.HeaderText = "BloqueId";
            this.bloqueIdDataGridViewTextBoxColumn.Name = "bloqueIdDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Filtro bloques";
            // 
            // btnExportarInventario
            // 
            this.btnExportarInventario.Location = new System.Drawing.Point(488, 164);
            this.btnExportarInventario.Name = "btnExportarInventario";
            this.btnExportarInventario.Size = new System.Drawing.Size(122, 23);
            this.btnExportarInventario.TabIndex = 11;
            this.btnExportarInventario.Text = "Exportar Inventario";
            this.btnExportarInventario.UseVisualStyleBackColor = true;
            // 
            // chartEstadisticas
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEstadisticas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEstadisticas.Legends.Add(legend1);
            this.chartEstadisticas.Location = new System.Drawing.Point(251, 223);
            this.chartEstadisticas.Name = "chartEstadisticas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartEstadisticas.Series.Add(series1);
            this.chartEstadisticas.Size = new System.Drawing.Size(300, 300);
            this.chartEstadisticas.TabIndex = 12;
            this.chartEstadisticas.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartEstadisticas);
            this.Controls.Add(this.btnExportarInventario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnModificarJugador);
            this.Controls.Add(this.btnEliminarJugador);
            this.Controls.Add(this.btnAgregarJugador);
            this.Controls.Add(this.txtNivelJugador);
            this.Controls.Add(this.txtNombreJugador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbparcial2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbparcial2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEstadisticas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreJugador;
        private System.Windows.Forms.TextBox txtNivelJugador;
        private System.Windows.Forms.Button btnAgregarJugador;
        private System.Windows.Forms.Button btnEliminarJugador;
        private System.Windows.Forms.Button btnModificarJugador;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbparcial2DataSet dbparcial2DataSet;
        private System.Windows.Forms.BindingSource jugadoresBindingSource;
        private dbparcial2DataSetTableAdapters.JugadoresTableAdapter jugadoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.DataGridView dataGridView2;
        private dbparcial2DataSet1 dbparcial2DataSet1;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private dbparcial2DataSet1TableAdapters.InventarioTableAdapter inventarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jugadorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloqueIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExportarInventario;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEstadisticas;
    }
}

