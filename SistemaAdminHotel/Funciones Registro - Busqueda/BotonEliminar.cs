using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaAdminHotel.Funciones_Registro___Busqueda
{
    public class BotonEliminar
    {
        private DataGridView tablaDato;
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Aleantoni\\Downloads\\Desarrollo de Software VIII\\Alejandro Carrera 1-739-1733\\SistemaAdminHotel\\SistemaAdminHotel\\database\\SilverBullet.mdf\";Integrated Security=True;Connect Timeout=30";
        public BotonEliminar(DataGridView tablaDato)
        {
            this.tablaDato = tablaDato;
        }

        public void EliminarFilaSeleccionada()
        { 
            if (tablaDato.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(tablaDato.SelectedRows[0].Cells["id"].Value);

                tablaDato.Rows.RemoveAt(tablaDato.SelectedRows[0].Index);

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "DELETE FROM Reservaciones WHERE id = @Id";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Id", id);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Fila eliminada correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro al eliminar la fila en la base de datos: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila");
            }
        }
    }
}
