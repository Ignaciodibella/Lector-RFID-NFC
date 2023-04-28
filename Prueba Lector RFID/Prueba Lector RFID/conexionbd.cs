using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Lector_RFID
{
    internal class conexionbd
    {
        string cadenaConexion = "server = DESKTOP-7612LDC\\SQLEXPRESS01; database = PruebaLectorRFID; integrated security = true";
        public SqlConnection Conectarbd = new SqlConnection();
        public conexionbd() 
        {
            Conectarbd.ConnectionString = cadenaConexion;
        }

        public void abrir()
        {
            try
            {
                Conectarbd.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con el servidor de BD: " + ex.ToString());
            }
        }

        public void cerrar()
        { 
            Conectarbd.Close();
        }
    }
}
