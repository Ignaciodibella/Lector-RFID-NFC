using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Prueba_Lector_RFID
{
    public partial class PantallaUsuario : Form
    {
        public string UserName { get; set; }
        public string UsrUid { get; set; }
        public string Saldo { get; set; }
        public PantallaUsuario()
        {
            InitializeComponent();
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            ComprarProductos comprarProductos = new ComprarProductos();

            comprarProductos.Show();
            this.Hide();

        }

        private void btn_cargar_saldo_Click(object sender, EventArgs e)
        {
            CargarSaldo cargarSaldo = new CargarSaldo();

            cargarSaldo.Show();
            this.Hide();
        }

        private void PantallaUsuario_Load(object sender, EventArgs e)
        {
            lbl_bienvenida.Text = "¡Hola " + UserName + "!";
        }
    }
}
