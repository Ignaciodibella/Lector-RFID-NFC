using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Lector_RFID
{
    public partial class ComprarProductos : Form
    {
        public ComprarProductos()
        {
            InitializeComponent();
        }

        private void ComprarProductos_Load(object sender, EventArgs e)
        {
            conexionbd conexion = new conexionbd();
            conexion.abrir();

            string consulta = "SELECT * FROM Productos";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion.Conectarbd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                gridProductos.DataSource = dataTable;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la consulta!");
            }

            conexion.cerrar();
        }

        private void gridProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Producto seleccionado.
            //Confirmar compra y descontar saldo.
        }
    }
}
