using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyrctofechanoconosola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("la fecha es: " + date1.Value.ToString("dd/mm/yyyy")); // Se peude NO poner el Tostring
            
            //capturar una fecha, guaardarla en una variable, usar y mostrar en pantalla.
            DateTime fecha;
            fecha = date1.Value;
            Console.WriteLine("la fecha es:" + fecha.ToString("dd/mm/yyyy"));



        }

        private void boton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("la fecha es:" + Calendar1.SelectionStart.ToString("dd/mm/yyyy"));
        }
    }
}
