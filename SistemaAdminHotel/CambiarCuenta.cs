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
    public partial class CambiarCuenta : Form
    {
        public CambiarCuenta()
        {
            InitializeComponent();
        }
        
        SqlConnection cone = new SqlConnection(@"server=ALEJANDROANTONI; Initial Catalog=Usuarios; Integrated Security=true;");

        private void button1_Click(object sender, EventArgs e)
        {
            
            cone.Open();
            string cambiar = cont.Text;
            string cam = contra.Text;
            string parametros = @"UPDATE login SET " + @"[pass] = @pass" + @" WHERE [pass] = @passes";

            try
            {
                SqlCommand comande = new SqlCommand(parametros, cone);
                comande.Parameters.AddWithValue("pass", cam);
                comande.Parameters.AddWithValue("passes", cambiar);

                comande.ExecuteNonQuery();

                MessageBox.Show("Se modifico la contraseña sastifactoriamente");
            }

            catch (Exception)
            {
                MessageBox.Show("Debe llenar todos los campos");
            }

        }
        }
    }

