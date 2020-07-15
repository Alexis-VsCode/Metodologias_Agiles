using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Forma_MetodologiasAgiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPresionar_Click(object sender, EventArgs e)
        {
            string message = "¿Desea Ingresar A La Materia?";
            string title = "Evento_Del_Boton_Click_Presionar";
            //  MessageBox.Show(message, title);
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Bienvenido A La Materia Metodologias Agiles","Bienvenido");
            }
            else
            {
                MessageBox.Show("Saliendo De La Materia", "Gracias");
                this.Close();
            }
        }
    }
}
