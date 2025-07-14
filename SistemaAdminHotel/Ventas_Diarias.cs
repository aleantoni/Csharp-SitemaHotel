using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SistemaAdminHotel.Funcion_Guardar_Reporte;
using System.Windows.Forms.DataVisualization.Charting;


namespace SistemaAdminHotel
{
    public partial class Ventas_Diarias : Form
    {
        public Ventas_Diarias()
        {
            InitializeComponent();
            Load += chart1_Load;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Aleantoni\\Downloads\\Desarrollo de Software VIII\\Alejandro Carrera 1-739-1733\\SistemaAdminHotel\\SistemaAdminHotel\\database\\SilverBullet.mdf\";Integrated Security=True;Connect Timeout=30";
            string consulta = "SELECT Fecha, Total FROM Reservaciones";
            DataTable dtReservaciones = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(consulta, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dtReservaciones);
            }

            chart1.Series.Clear();
            chart1.Series.Add("ReservacionesDiarias");
            chart1.Series["ReservacionesDiarias"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            chart1.Series["ReservacionesDiarias"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            foreach (DataRow row in dtReservaciones.Rows)
            {
                DateTime fecha = Convert.ToDateTime(row["Fecha"]);
                int totalReservaciones = Convert.ToInt32(row["Total"]);
                chart1.Series["ReservacionesDiarias"].Points.AddXY(fecha, totalReservaciones);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "C:/Users/Aleantoni/Documents/Reporte.pdf";
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            Chart chart = chart1;

            SaveArchive.GenerateReport(path, fecha, chart);
        }
    }

    
}
