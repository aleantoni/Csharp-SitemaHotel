using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace SistemaAdminHotel
{
    class Conexion
    {
        public static string conex = @"server=ALEJANDROANTONI; Initial Catalog=Usuarios; Integrated Security=true;";
        SqlConnection con = new SqlConnection(conex);

        public void Open()
        {
            con.Open();
        }

        public void Close()
        {
            con.Close();
        }

        public DataTable tabla(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

            da.SelectCommand = new SqlCommand(sql, con);

            da.Fill(ds);

            dt = ds.Tables[0];

            return dt;
        }

       //public string ingresar()
       // {
       //     string salida;
       //     try
       //     {
       //         SqlCommand ing = new SqlCommand(con);

       //     }

       //     catch (Exception)
       //     {
       //         salida = "No se pudo realizar la funcion";
       //     }


       //     return salida;
       // }

    }
}
