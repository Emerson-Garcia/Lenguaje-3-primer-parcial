using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_button_Click(object sender, EventArgs e)
        {
            // variables

            decimal numero1 = 0;
            decimal numero2 = 0;

            numero1 = Convert.ToDecimal(numero1_textBox.Text);
            numero2 = Convert.ToDecimal(numero2_textBox.Text);

            decimal suma = numero1 + numero2;

            MessageBox.Show("La suma es: " + suma);
            MostrarMensaje();
        }
       // procedimiento
        private void MostrarMensaje()
        {
            MessageBox.Show("Hola Emerson");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }    // funcion


    
}
