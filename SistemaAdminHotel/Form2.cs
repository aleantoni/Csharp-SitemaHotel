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
using SistemaAdminHotel.Funciones_Registro___Busqueda;

namespace SistemaAdminHotel
{
    public partial class Busqueda : Form
    {
        private BotonEliminar botonEliminar;
        public Busqueda()
        {
            InitializeComponent();
            botonEliminar = new BotonEliminar(tablaDato);
            


        }

       
        private void Busqueda_Load_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }


        /*private void cargars()
        {
            Conexion con = new Conexion();
            dataGridView1.DataSource = con.tabla("SELECT * FROM ReserHabitacion");



        }*/

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMo‌​de.Fill);
            //tablaDato.Columns[0].Width = 100;
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            //cargars();
        }*/

        private void cargar_Click(object sender, EventArgs e)
        {
            //limpiar tabla de datos
            tablaDato.DataSource = null;
            tablaDato.Rows.Clear();
            tablaDato.Columns.Clear();

            //Consulta a la base de datos para obtener los datos
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Aleantoni\\Downloads\\Desarrollo de Software VIII\\Alejandro Carrera 1-739-1733\\SistemaAdminHotel\\SistemaAdminHotel\\database\\SilverBullet.mdf\";Integrated Security=True;Connect Timeout=30";
            string query = "SELECT * FROM Reservaciones";

            tablaDato.Columns.Add("Nombre", "Nombre");
            tablaDato.Columns.Add("Apellido", "Apellido");
            tablaDato.Columns.Add("Cedula", "Cedula");
            tablaDato.Columns.Add("Telefono", "Telefono");
            tablaDato.Columns.Add("TipoHabitacion", "Tipo de Habitacion");
            tablaDato.Columns.Add("Estadia", "Estadia");
            tablaDato.Columns.Add("Total", "Total");
            tablaDato.Columns.Add("FormaPago", "Forma de Pago");
            tablaDato.Columns.Add("Descuento", "Descuento");
            tablaDato.Columns.Add("Cambio", "Cambio");
            tablaDato.Columns.Add("Fecha", "Fecha");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                //Recorrido de los registros de la tabla
                if (reader.HasRows)
                { 
                while (reader.Read())
                {
                    //obtener los valores de la columna
                    string columna1 = reader["Nombre"].ToString();
                    string columna2 = reader["Apellido"].ToString();
                    string columna3 = reader["Cedula"].ToString();
                    string columna4 = reader["Telefono"].ToString();
                    string columna5 = reader["Tipo de Habitacion"].ToString();
                    string columna6 = reader["Estadia"].ToString();
                    string columna7 = reader["Total"].ToString();
                    string columna8 = reader["Forma de Pago"].ToString();
                    string columna9 = reader["Descuento"].ToString();
                    string columna10 = reader["Cambio"].ToString();
                    string columna11 = reader["Fecha"].ToString();

                    //Agregar nueva fila cada vez que hay datos nuevos
                    tablaDato.Rows.Add(columna1, columna2, columna3, columna4, columna5, columna6, columna7, columna8, columna9, columna10, columna11);
                }
                }
                else
                {
                    MessageBox.Show("No hay datos disponibles");
                }
                reader.Close();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text;

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Aleantoni\\Downloads\\Desarrollo de Software VIII\\Alejandro Carrera 1-739-1733\\SistemaAdminHotel\\SistemaAdminHotel\\database\\SilverBullet.mdf\";Integrated Security=True;Connect Timeout=30";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Reservaciones WHERE Nombre LIKE @SearchTerm OR Apellido LIKE @SearchTerm";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                DataTable dataTable = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }

                //Limpia el contenido existente del DataGridView
                tablaDato.DataSource = null;
                tablaDato.Rows.Clear();
                tablaDato.Columns.Clear();


                //Actualiza el origen de los datos del DataGridView con los resultados
                tablaDato.DataSource = dataTable;
            
            }

            
         }

        private void update_Click(object sender, EventArgs e)
        {
            if (tablaDato.DataSource != null)
            { 
            DataTable cambios = ((DataTable)tablaDato.DataSource).GetChanges();

            if (cambios != null)
            {
                foreach (DataRow row in cambios.Rows)
                {
                    //Obtener valores modificados 
                    int id = Convert.ToInt32(row["ID"]);
                    string nombre = row["Nombre"].ToString();
                    string apellido = row["Apellido"].ToString();
                    string cedula = row["Cedula"].ToString();
                    string telefono = row["Telefono"].ToString();
                    string tipoHabitacion = row["Tipo de Habitacion"].ToString();
                    string estadia = row["Estadia"].ToString();
                    decimal total = Convert.ToDecimal(row["Total"]);
                    string formaPago = row["Forma de Pago"].ToString();
                    decimal descuento = Convert.ToDecimal(row["Descuento"]);
                    decimal cambio = Convert.ToDecimal(row["Cambio"]);
                    DateTime fecha = Convert.ToDateTime(row["Fecha"]);

                    //Actualiza la tabla 
                    string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Aleantoni\\Downloads\\Desarrollo de Software VIII\\Alejandro Carrera 1-739-1733\\SistemaAdminHotel\\SistemaAdminHotel\\database\\SilverBullet.mdf\";Integrated Security=True;Connect Timeout=30";
                    string query = "UPDATE Reservaciones SET Nombre = @Nombre, Apellido = @Apellido, Cedula = @Cedula, " +
                                   "Telefono = @Telefono, [Tipo de Habitacion] = @TipoHabitacion, Estadia = @Estadia, " +
                                   "Total = @Total, [Forma de Pago] = @FormaPago, Descuento = @Descuento, Cambio = @Cambio, " + 
                                   "Fecha = @Fecha WHERE ID = @ID";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Apellido", apellido);
                        command.Parameters.AddWithValue("@Cedula", cedula);
                        command.Parameters.AddWithValue("@Telefono", nombre);
                        command.Parameters.AddWithValue("@TipoHabitacion", tipoHabitacion);
                        command.Parameters.AddWithValue("@Estadia", estadia);
                        command.Parameters.AddWithValue("@Total", total);
                        command.Parameters.AddWithValue("@FormaPago", formaPago);
                        command.Parameters.AddWithValue("@Descuento", descuento);
                        command.Parameters.AddWithValue("@Cambio", cambio);
                        command.Parameters.AddWithValue("@Fecha", fecha);
                        command.Parameters.AddWithValue("@ID", id);

                        command.ExecuteNonQuery();

                    }
                }

                //Actualizar la fuente de datos del DataGridView
                ((DataTable)tablaDato.DataSource).AcceptChanges();

                MessageBox.Show("Los cambios se guardaron correctamente");
            }
            else
            {
                MessageBox.Show("No se han realizado los cambios");
            }
            }
            else
            {
                MessageBox.Show("No hay datos en la tabla");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            
            botonEliminar.EliminarFilaSeleccionada();

        }
    }
}
