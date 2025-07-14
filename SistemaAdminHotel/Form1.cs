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

namespace SistemaAdminHotel
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void insertar()
        {
           /* string name = nombre.Text, lastname = apellido.Text, ids = id.Text, num = numero.Text, room = tipoh.Text, day = dia.Text;
            SqlConnection cone = new SqlConnection(@"server=ALEJANDROANTONI; Initial Catalog=Usuarios; Integrated Security=true;");
            cone.Open();
            string parametros = "Insert into ReserHabitacion (Nombre, Apellido, IDPersonal, NumTelefonico, TipoHabitacion, DiasAloja) values (@Nombre, @Apellido, @IDPersonal, @NumTelefonico, @TipoHabitacion, @DiasAloja)";
            try
            {
                //SqlCommand comando = new SqlCommand(parametros, cone);
                comando.Parameters.AddWithValue("@Nombre", name);
                comando.Parameters.AddWithValue("@Apellido", lastname);
                comando.Parameters.AddWithValue("@IDPersonal", ids);
                comando.Parameters.AddWithValue("@NumTelefonico", num);
                comando.Parameters.AddWithValue("@TipoHabitacion", room);
                comando.Parameters.AddWithValue("@DiasAloja", day);

                comando.ExecuteNonQuery();

                MessageBox.Show("Se Ingreso los Datos Correctamente");
                
            }
            catch (Exception)
            {
                MessageBox.Show("No pudo realizarse el registro");
            }*/
            string nombres = nombre.Text;
            string apellidos = apellido.Text;
            string cedulas = id.Text;
            string telefonos = numero.Text;
            string tipoHabitacions = tipoh.Text;
            int estadia = Convert.ToInt32(dia.Text);
            decimal totals = Convert.ToDecimal(total.Text);
            string formaPago = formpay.Text;
            decimal descuento = Convert.ToDecimal(efectivo.Text);
            decimal cambios = Convert.ToDecimal(cambio.Text);

            //Obtener la fecha del DateTimePicker
            DateTime fechaReserva = fechar.Value;

            //cadena de insercion SQL
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Aleantoni\\Downloads\\Desarrollo de Software VIII\\Alejandro Carrera 1-739-1733\\SistemaAdminHotel\\SistemaAdminHotel\\database\\SilverBullet.mdf\";Integrated Security=True;Connect Timeout=30";

            string query = "INSERT INTO Reservaciones (Nombre, Apellido, Cedula, Telefono, [Tipo de Habitacion], Estadia, Total, [Forma de Pago], Descuento, Cambio, Fecha)" +
                           "VALUES (@Nombre, @Apellido, @Cedula, @Telefono, @TipoHabitacion, @Estadia, @Total, @FormaPago, @Descuento, @Cambio, @Fecha)";
        
             //Crear la conexion y el comando SQL
             using (SqlConnection con = new SqlConnection(connectionString))
             using (SqlCommand cmd = new SqlCommand(query, con))
            {
                //pasando parametros
                cmd.Parameters.AddWithValue("@Nombre", nombres);
                cmd.Parameters.AddWithValue("@Apellido", apellidos);
                cmd.Parameters.AddWithValue("@Cedula", cedulas);
                cmd.Parameters.AddWithValue("@Telefono", telefonos);
                cmd.Parameters.AddWithValue("@TipoHabitacion", tipoHabitacions);
                cmd.Parameters.AddWithValue("@Estadia", estadia);
                cmd.Parameters.AddWithValue("@Total", totals);
                cmd.Parameters.AddWithValue("@FormaPago", formaPago);
                cmd.Parameters.AddWithValue("@Descuento", descuento);
                cmd.Parameters.AddWithValue("@Cambio", cambios);
                cmd.Parameters.AddWithValue("@Fecha", fechaReserva);

                //Abrir la conexion
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                //Verificacion de datos insertados
                if(rowsAffected > 0)
                {
                    MessageBox.Show("Los datos fueron registrados correctamente");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al registrar los datos");
                }
            }
        
        }



        private void insertar2()
        {
            string name = nombre.Text, lastname = apellido.Text, ids = id.Text, tol = total.Text, pay = formpay.Text, money = efectivo.Text, chan = cambio.Text;
            SqlConnection conex = new SqlConnection(@"server=ALEJANDROANTONI; Initial Catalog=Usuarios; Integrated Security=true;");
            conex.Open();
            string parameter = "Insert into ReportCobros (Nombre, Apellido, IDPersonal, Total, Efectivo, FormaPago, Cambio) values (@Nombre, @Apellido, @IDPersonal, @Total, @Efectivo, @FormaPago, @Cambio)";
            try
            {
                SqlCommand comando = new SqlCommand(parameter, conex);
                comando.Parameters.AddWithValue("@Nombre", name);
                comando.Parameters.AddWithValue("@Apellido", lastname);
                comando.Parameters.AddWithValue("@IDPersonal", ids);
                comando.Parameters.AddWithValue("@Total", tol);
                comando.Parameters.AddWithValue("@Efectivo", money);
                comando.Parameters.AddWithValue("@FormaPago", pay);
                comando.Parameters.AddWithValue("@Cambio", chan);

                comando.ExecuteNonQuery();

                MessageBox.Show("Se Ingreso los Datos Correctamente");

            }
            catch (Exception)
            {
                MessageBox.Show("No pudo realizarse el registro");
            }
        }



        private void proceder_Click(object sender, EventArgs e)
        {
           insertar2();
            
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            insertar();
        }
    }
}
