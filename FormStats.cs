using System;
using System.Data.SqlClient;
using System.Windows.Forms;
//using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoTallerG8
{
    public partial class FormStats : Form
    {
        public FormStats()
        {
            InitializeComponent();

            // Agregar eventos para validar las fechas cada vez que cambien
            dtpStartDate.ValueChanged += new EventHandler(DateTimePickers_ValueChanged);
            dtpEndDate.ValueChanged += new EventHandler(DateTimePickers_ValueChanged);

            // Inicialmente comprobar la validez de las fechas
            ValidateDates();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet11.ventas_cabecera' Puede moverla o quitarla según sea necesario.
            this.ventas_cabeceraTableAdapter.Fill(this.dataSet11.ventas_cabecera);

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private bool showingTotalSales = true;

        // Método para cargar datos en el gráfico
        private void btnLoadChart_Click(object sender, EventArgs e)
        {
            showingTotalSales = !showingTotalSales; // Alterna entre las dos métricas
            LoadChart();
        }

        // Método que carga los datos en el gráfico
        private void LoadChart()
        {
            // Limpiar los datos previos del gráfico
            chartVentas.Series.Clear();
            chartVentas.ChartAreas[0].AxisX.Title = "Fecha";
            chartVentas.ChartAreas[0].AxisY.Title = showingTotalSales ? "Ingresos Totales ($)" : "Número de Ventas";

            // Crear una serie para el gráfico
            var series = chartVentas.Series.Add("Ventas");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            // Configurar el eje Y para mostrar solo números enteros si se trata del número de ventas
            if (!showingTotalSales)
            {
                chartVentas.ChartAreas[0].AxisY.LabelStyle.Format = "0"; // Formato entero para evitar decimales
                chartVentas.ChartAreas[0].AxisY.Interval = 1; // Intervalo de 1 en el eje Y para evitar duplicados
            }
            else
            {
                chartVentas.ChartAreas[0].AxisY.LabelStyle.Format = "C"; // Formato de moneda si es total de ingresos
                chartVentas.ChartAreas[0].AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            }

            // Conexión a la base de datos
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["pruebaLogin.Properties.Settings.db_piazza_giovanniConnectionString"].ConnectionString; // Reemplaza con tu cadena de conexión
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query;

                // Verifica si estamos mostrando total de ingresos o número de ventas
                if (showingTotalSales)
                {
                    // Consulta para total de ingresos por día
                    query = "SELECT fecha, SUM(total_venta) AS total FROM ventas_cabecera WHERE fecha BETWEEN @startDate AND @endDate GROUP BY fecha";
                    labelMetric.Text = "Ingresos por dia";
                }
                else
                {
                    // Consulta para número de ventas por día
                    query = "SELECT fecha, COUNT(*) AS total FROM ventas_cabecera WHERE fecha BETWEEN @startDate AND @endDate GROUP BY fecha";
                    labelMetric.Text = "Ventas por dia";
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Parámetros de la consulta
                    cmd.Parameters.AddWithValue("@startDate", dtpStartDate.Value);
                    cmd.Parameters.AddWithValue("@endDate", dtpEndDate.Value);

                    // Abrir la conexión
                    con.Open();

                    // Ejecutar la consulta y cargar los datos
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime fecha = Convert.ToDateTime(reader["fecha"]);
                            double total = Convert.ToDouble(reader["total"]);

                            // Añadir puntos al gráfico
                            series.Points.AddXY(fecha, total);
                        }
                    }

                    // Cerrar la conexión
                    con.Close();
                }
            }
        }


        // Método para validar las fechas seleccionadas
        private void DateTimePickers_ValueChanged(object sender, EventArgs e)
        {
            ValidateDates();
        }

        // Método que comprueba si la fecha final es mayor o igual a la fecha inicial
        private void ValidateDates()
        {
            if (dtpEndDate.Value >= dtpStartDate.Value)
            {
                // Si la fecha final es válida, habilitar el botón
                btnLoadChart.Enabled = true;
            }
            else
            {
                // Si la fecha final es menor a la fecha inicial, deshabilitar el botón
                btnLoadChart.Enabled = false;
            }
        }
    }
}
