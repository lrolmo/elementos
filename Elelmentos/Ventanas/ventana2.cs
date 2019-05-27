using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventanas
{
    public partial class ventana2 : Form
    {
        public ventana2()
        {
            InitializeComponent();
        }

        private void ventana2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = 0;
            string elegidos;

            if (checkBox1.Checked== true)
            {
                contador++;
            }
            if (checkBox2.Checked == true)
            {
                contador++;
            }
            if (radioButton1.Checked == true)
            {
                elegidos = "Tarjeta de Credito";
            }
            else
            {
                elegidos = "PayPal";
            }
            MessageBox.Show("Ha elegido "+contador+" frutas y cancela con "+elegidos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Principio ventanaLogin = new Principio();
            //ventanaLogin.Show();
        }
    }
}
