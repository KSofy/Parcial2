using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MinecraftManagerUI
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            this.inventarioTableAdapter.Fill(this.dbparcial2DataSet1.Inventario);

            
            var bloques = dbparcial2DataSet1.Inventario
                .AsEnumerable()
                .Select(row => row.BloqueId)
                .Distinct()
                .ToList();

           
            comboBoxFiltro.Items.Clear();
            comboBoxFiltro.Items.Add("Todos"); 
            comboBoxFiltro.Items.AddRange(bloques.Cast<object>().ToArray());

            
            comboBoxFiltro.SelectedIndex = 0;
            CargarEstadisticas();
        }
        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string filtroSeleccionado = comboBoxFiltro.SelectedItem.ToString();

            
            if (filtroSeleccionado == "Todos")
            {
                
                dataGridView2.DataSource = inventarioBindingSource;
            }
            else
            {
                
                int bloqueIdSeleccionado = int.Parse(filtroSeleccionado);

                
                inventarioBindingSource.Filter = $"BloqueId = {bloqueIdSeleccionado}";
            }
        }
        private void btnExportarInventario_Click(object sender, EventArgs e)
        {
            
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivo CSV (*.csv)|*.csv";
                saveFileDialog.Title = "Guardar Inventario como CSV";
                saveFileDialog.FileName = "Inventario.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog.FileName))
                        {
                            
                            string headers = string.Join(",", dataGridView2.Columns
                                .Cast<DataGridViewColumn>()
                                .Select(column => column.HeaderText));
                            file.WriteLine(headers);

                            
                            foreach (DataGridViewRow row in dataGridView2.Rows)
                            {
                                if (!row.IsNewRow) 
                                {
                                    string rowData = string.Join(",", row.Cells
                                        .Cast<DataGridViewCell>()
                                        .Select(cell => cell.Value?.ToString() ?? ""));
                                    file.WriteLine(rowData);
                                }
                            }
                        }

                        MessageBox.Show("Inventario exportado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al exportar el inventario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void CargarEstadisticas()
        {
            
            chartEstadisticas.Series.Clear();
            chartEstadisticas.ChartAreas.Clear();

            
            ChartArea chartArea = new ChartArea("MainArea");
            chartEstadisticas.ChartAreas.Add(chartArea);

            
            Series series = new Series("Bloques por Jugador")
            {
                ChartType = SeriesChartType.Column
            };

            
            chartEstadisticas.Series.Add(series);

            
            var estadisticas = dbparcial2DataSet1.Inventario
                .AsEnumerable()
                .GroupBy(row => row.JugadorId) 
                .Select(group => new
                {
                    JugadorId = group.Key,
                    CantidadBloques = group.Count()
                })
                .ToList();

            
            foreach (var estadistica in estadisticas)
            {
                series.Points.AddXY($"Jugador {estadistica.JugadorId}", estadistica.CantidadBloques);
            }
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
