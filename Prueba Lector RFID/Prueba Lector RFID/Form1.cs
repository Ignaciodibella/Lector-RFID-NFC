using System;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

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
            Port.PortName = "COM4"; //Puerto serial USB a usar de la compu. (Revisar en el IDE de Arduino) 
            Port.BaudRate = 9600; //Baudios. Tiene que coincidir con lo que pusimos en la linea Serial.Begin(...) en el programa del arduino.
            //Port.ReadTimeout = 500; //Medio segundo para cortar conexión por timeout.

            try //Por si no está conectado el Arduino.
            {
                Port.Open(); //Iniciar Escucha.
            }
            catch { } //Agregar aviso de que no está conectado (pendiente).
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                            txt_udi_receiver.Text = cadena.Remove(0, 10);  //Habria que quitar el Remove(0,10) y que el programa de arduino solo devuelva el UDI, sin cadenas previas.
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
    }
}