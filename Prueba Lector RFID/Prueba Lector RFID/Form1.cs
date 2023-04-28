using System;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Data.SqlClient;

namespace Prueba_Lector_RFID
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort Port;
        bool IsClosed = false;
        public Form1()
        {
            InitializeComponent();
            Port = new System.IO.Ports.SerialPort();
            Port.PortName = "COM3"; //Puerto serial USB a usar de la compu. (Revisar en el IDE de Arduino). Si está abierto el monitor serial de Arduino no funciona. Cerrarlo.
            Port.BaudRate = 9600; //Baudios. Tiene que coincidir con lo que pusimos en la linea Serial.Begin(...) en el programa del arduino.
            //Port.ReadTimeout = 500; //Medio segundo para cortar conexión por timeout.

            try //Por si no está conectado el Arduino.
            {
                Port.Open(); //Iniciar Escucha.
            }
            catch { } //Agregar aviso de que no está conectado (pendiente).

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Construyo el hilo con el cual escuchar el puerto
            Thread Hilo = new Thread(EscucharSerial);
            Hilo.Start();

        }

        //Punto de escucha del puerto serial (usa hilos)
        private void EscucharSerial()
        {
            while (!IsClosed)
            {
                try
                {
                    string cadena = Port.ReadLine(); //Acá captura el UID.

                    //Resuelve el problema de que la escucha serial se ejecuta en un hilo que no es el principal.
                    txt_udi_receiver.Invoke(new MethodInvoker(
                        delegate
                        {
                            txt_udi_receiver.Text = cadena.Remove(0, 1).Trim();
                        }));
                }
                catch { }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsClosed = true;
            if (Port.IsOpen)
            {
                Port.Close();
            }
        }
        public void txt_udi_receiver_TextChanged(object sender, EventArgs e)
        {
            txt_3dni.Text = "";
        }

        public void login()
        {
            conexionbd conexion = new conexionbd();
            conexion.abrir();

            string consulta = "SELECT * FROM Usuarios WHERE UID = '" + txt_udi_receiver.Text + "'";
            try
            {
                SqlCommand comando = new SqlCommand(consulta, conexion.Conectarbd);

                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {

                    if (txt_3dni.Text == lector.GetValue(0).ToString())
                    {
                        MessageBox.Show("Bienvenido a la Plataforma de NightOps " + lector.GetValue(1).ToString());
                    }
                    else
                    {
                        MessageBox.Show("Acceso Denegado");
                    }
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la consulta!");
            }

            conexion.cerrar();
        }
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}