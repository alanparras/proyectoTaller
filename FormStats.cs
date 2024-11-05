using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

            dtpStartDateE.ValueChanged += new EventHandler(DateTimePickersE_ValueChanged);
            dtpEndDateE.ValueChanged += new EventHandler(DateTimePickersE_ValueChanged);

            // Inicialmente comprobar la validez de las fechas
            ValidateDates();

            LoadEmployees();


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
                series.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            }
            else
            {
                chartVentas.ChartAreas[0].AxisY.LabelStyle.Format = "C"; // Formato de moneda si es total de ingresos
                series.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
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

        private void DateTimePickersE_ValueChanged(object sender, EventArgs e)
        {
            ValidateDatesE();
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

        private void ValidateDatesE()
        {
            if (dtpEndDateE.Value >= dtpStartDate.Value)
            {
                // Si la fecha final es válida, habilitar el botón
                btnLoadEmployeeChart.Enabled = true;
            }
            else
            {
                // Si la fecha final es menor a la fecha inicial, deshabilitar el botón
                btnLoadEmployeeChart.Enabled = false;
            }
        }

        private void btnLoadEmployeeChart_Click(object sender, EventArgs e)
        {
            showingTotalSales = !showingTotalSales; // Alterna entre las dos métricas
            LoadEmployeeSalesChart();
        }

        private void LoadEmployeeSalesChart()
        {
            // Limpiar los datos previos del gráfico
            chartVentasEmpleados.Series.Clear(); // Cambiar el nombre del gráfico
            chartVentasEmpleados.ChartAreas[0].AxisX.Title = "Fecha";
            chartVentasEmpleados.ChartAreas[0].AxisY.Title = showingTotalSales ? "Ingresos Totales ($)" : "Número de Ventas";

            // Obtener el empleado seleccionado

            string selectedEmployeeId = null;
            bool filterByEmployee = false;

            int comboBoxItemId = cmbEmpleados.SelectedIndex;
            if (comboBoxItemId == 0)
            {
                selectedEmployeeId = "Todos";

            }
            else
            {
                selectedEmployeeId = ((ComboBoxItem)(cmbEmpleados.SelectedItem)).Value;
                filterByEmployee = true;
            }

            // Conexión a la base de datos
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["pruebaLogin.Properties.Settings.db_piazza_giovanniConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query;

                if (showingTotalSales)
                {
                    // Consulta para total de ingresos por empleado
                    query = @"
                SELECT u.id AS usuario_id, u.nombre, vc.fecha, SUM(vc.total_venta) AS total 
                FROM ventas_cabecera vc
                JOIN usuarios u ON vc.usuario_id = u.id 
                WHERE u.perfil_id = 3 AND vc.fecha BETWEEN @startDate AND @endDate ";
                }
                else
                {
                    // Consulta para número de ventas por empleado
                    query = @"
                SELECT u.id AS usuario_id, u.nombre, vc.fecha, COUNT(*) AS total 
                FROM ventas_cabecera vc
                JOIN usuarios u ON vc.usuario_id = u.id 
                WHERE u.perfil_id = 3 AND vc.fecha BETWEEN @startDate AND @endDate ";
                }

                // Añadir condición para filtrar por empleado si es necesario
                if (filterByEmployee)
                {
                    query += " AND u.id = @selectedEmployeeId ";
                }

                query += " GROUP BY u.id, u.nombre, vc.fecha";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Parámetros de la consulta
                    cmd.Parameters.AddWithValue("@startDate", dtpStartDate.Value);
                    cmd.Parameters.AddWithValue("@endDate", dtpEndDate.Value);
                    if (filterByEmployee)
                    {
                        cmd.Parameters.AddWithValue("@selectedEmployeeId", selectedEmployeeId);
                    }

                    // Abrir la conexión
                    con.Open();

                    // Ejecutar la consulta y cargar los datos
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        var employeeColors = new Dictionary<int, Color>();
                        int colorIndex = 0;

                        while (reader.Read())
                        {
                            DateTime fecha = Convert.ToDateTime(reader["fecha"]);
                            double total = Convert.ToDouble(reader["total"]);
                            int usuarioId = Convert.ToInt32(reader["usuario_id"]);
                            string nombre = reader["nombre"].ToString();

                            // Crear una serie para cada empleado si no existe
                            if (!employeeColors.ContainsKey(usuarioId))
                            {
                                var seriesEmpleados = chartVentasEmpleados.Series.Add(nombre);
                                seriesEmpleados.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
                                seriesEmpleados.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
                                seriesEmpleados.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

                                // Asignar un color único a la serie
                                seriesEmpleados.Color = GetColor(colorIndex);
                                employeeColors[usuarioId] = seriesEmpleados.Color;
                                colorIndex++;
                            }

                            // Añadir puntos al gráfico
                            var series = chartVentasEmpleados.Series[nombre];
                            series.Points.AddXY(fecha, total);
                        }
                    }

                    // Cerrar la conexión
                    con.Close();
                }
            }

            // Configurar el eje Y según lo que estemos mostrando
            if (!showingTotalSales)
            {
                // Para número de ventas por día
                chartVentasEmpleados.ChartAreas[0].AxisY.LabelStyle.Format = "0"; // Formato entero para evitar decimales
                labelMetricE.Text = "Ventas por dia";

            }
            else
            {
                // Para ingresos totales en dinero
                chartVentasEmpleados.ChartAreas[0].AxisY.LabelStyle.Format = "C"; // Formato de moneda
                labelMetricE.Text = "Ingresos por dia";
            }


        }

        private Color GetColor(int index)
        {
            // Array de colores
            Color[] colors = new Color[]
            {
        Color.Red,
        Color.Blue,
        Color.Green,
        Color.Orange,
        Color.Purple,
        Color.Brown,
        Color.Cyan,
        Color.Magenta,
        Color.Yellow,
        Color.Gray
            };

            // Devolver color basado en el índice
            return colors[index % colors.Length];
        }

        private void LoadEmployees()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["pruebaLogin.Properties.Settings.db_piazza_giovanniConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT id, nombre FROM usuarios WHERE perfil_id = 3"; // Selecciona empleados con perfil_id 3

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmbEmpleados.Items.Clear();
                        cmbEmpleados.Items.Add("Todos"); // Opción para ver todos los empleados

                        while (reader.Read())
                        {
                            cmbEmpleados.Items.Add(new ComboBoxItem
                            {
                                Text = reader["nombre"].ToString(),
                                Value = reader["id"].ToString()
                            });
                        }

                        cmbEmpleados.SelectedIndex = 0; // Selecciona la primera opción por defecto
                    }

                    con.Close();
                }
            }
        }

        // Clase para gestionar los ítems del ComboBox
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public override string ToString()
            {
                return Text; // Muestra el nombre del empleado en el ComboBox
            }
        }

    }
}
