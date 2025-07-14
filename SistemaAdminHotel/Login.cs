using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace SistemaAdminHotel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwdn, int wmsg, int wparam, int lparam);

        /*public void logins()
        {
            try
            {
                SqlConnection connectionString = new SqlConnection (@"server=ALEJANDROANTONI; Initial Catalog=Usuarios; Integrated Security=true;");
                
                    connectionString.Open();
                    SqlCommand cmd = new SqlCommand("SELECT trabajador, pass FROM login WHERE trabajador='" + user.Text + "' AND pass='" + pass.Text + "'", connectionString);


                    cmd.ExecuteNonQuery();
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    //Llenando el dataAdapter
                    da.Fill(ds, "login");
                    //utilizado para representar una fila de la tabla que necesitas en este caso usuario
                    DataRow DR;
                    DR = ds.Tables["login"].Rows[0];



                    if ((user.Text == DR["trabajador"].ToString()) || (pass.Text == DR["pass"].ToString()))
                    {
                        //instanciando el formulario principal
                        Inicio frmPrincipal = new Inicio();
                        frmPrincipal.Show();//abriendo el formulario principal
                        this.Hide();//esto sirve para ocultar el formulario de login
                    }

                }
            
           catch
            {
                MessageBox.Show("Error su contraseña o usuario son invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }*/

        //conexion a la base de datos, modo local
        private SqlConnection EstablecerConexion()
        {
           string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Aleantoni\\Downloads\\Desarrollo de Software VIII\\Alejandro Carrera 1-739-1733\\SistemaAdminHotel\\SistemaAdminHotel\\database\\SilverBullet.mdf\";Integrated Security=True;Connect Timeout=30";
            SqlConnection conexion = new SqlConnection(connectionString);
            return conexion;
        }

        //Metodo de verificacion de datos para el login del usuario

        private bool VerificarCredenciales(string correo, string contraseña)
        {
            using (SqlConnection conexion = EstablecerConexion())
            {
                try
                {
                    conexion.Open();

                    //Consulta SQL para verificacion de los datos de usuarios
                    string consulta = "SELECT COUNT(*) FROM Usuarios WHERE Correo =@Correo AND Contraseña =@Contraseña";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@Correo", correo);
                    comando.Parameters.AddWithValue("@Contraseña", contraseña);

                    int resultado = (int)comando.ExecuteScalar();

                    if(resultado > 0)
                    {
                        //Datos validos
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error de conexion a la base de datos: " + ex.Message);
                }
            }
            return false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //logins();

            string correo = user.Text;
            string contraseña = pass.Text;

            if (VerificarCredenciales(correo, contraseña))
            {
                //MessageBox.Show("Inicio de sesion exitoso");

                Inicio frmPrincipal = new Inicio();
                frmPrincipal.Show();//abriendo el formulario principal
                this.Hide();//esto sirve para ocultar el formulario de login
            }
            else 
            {
                MessageBox.Show("Datos Incorrectos. Intentalo de nuevo");
            
            }
        }

        private void user_Enter(object sender, EventArgs e)
        {
            if (user.Text == "CORREO")
            {
                user.Text = "";
                user.ForeColor = Color.LightGray;
            }
        }

        private void user_Leave(object sender, EventArgs e)
        {
            if (user.Text == "")
            {
                user.Text = "CORREO";
                user.ForeColor = Color.DarkGray;
            }
        }

        private void pass_Enter(object sender, EventArgs e)
        {
            if (pass.Text == "CONTRASEÑA")
            {
                pass.Text = "";
                pass.ForeColor = Color.LightGray;
                pass.UseSystemPasswordChar = true;
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (pass.Text == "")
            {
                pass.Text = "CONTRASEÑA";
                pass.ForeColor = Color.DarkGray;
                pass.UseSystemPasswordChar = false;
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
