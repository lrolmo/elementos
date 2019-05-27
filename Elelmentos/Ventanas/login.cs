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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "LRM" && textBox2.Text == "1234")
            {
                //MessageBox.Show("ACCESO CORRECTO");
                this.Hide();
                Principio nuevaventana = new Principio();
                nuevaventana.Show();
            }
            else
            {
                MessageBox.Show("ERROR.. usuario o contraseña incorrecta...");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
