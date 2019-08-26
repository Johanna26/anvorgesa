using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salchipapa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (usu.Text=="Juancho"&& password.Text== "123tamarindo")
            {
                MessageBox.Show("Bienvenido señor Don ")
            }
            else
            {
                MessageBox.Show("Usuario o contraseña no valido");
                usu.Text = " ";
                password.Text = " ";
                usu.Focus();
            }
        }

        private void Salida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
