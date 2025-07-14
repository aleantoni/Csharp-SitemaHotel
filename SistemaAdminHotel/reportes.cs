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
using System.Windows.Forms.DataVisualization.Charting;

namespace SistemaAdminHotel
{
    public partial class reportes : Form
    {
        public reportes()
        {
            InitializeComponent();
        }
       
           
                string Cadena = @"server=ALEJANDROANTONI; Initial Catalog = Usuarios; Integrated Security = true";
                
                SqlDataAdapter da;
                DataTable dt;
                DataRow dr;
                String Consulta;
        


        private void generar_Click(object sender, EventArgs e)
        {
            /*Consulta = "Select * From ReserHabitacion";
            da = new SqlDataAdapter(Consulta, Cadena);
            dt = new DataTable();
            da.Fill(dt);
            this.chart1.Palette = ChartColorPalette.Excel;
            this.chart1.Titles.Add("Actividad");

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dr = dt.Rows[i];
                    Series series = this.chart1.Series.Add(dr.ItemArray[0].ToString());
                    series.Points.Add(Convert.ToDouble(dr.ItemArray[5]));
                }
            }*/

            Ventas_Diarias llamarForm = new Ventas_Diarias();

            llamarForm.ShowDialog();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            /*this.chart1.SaveImage("C:\\Users\\Alejandro Antonio\\Downloads\\Grafico.png", ChartImageFormat.Png);
            MessageBox.Show("Imagen guardada correctamente");*/
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
