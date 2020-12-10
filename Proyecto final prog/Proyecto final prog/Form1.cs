using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final_prog
{
    public partial class Form1 : Form
    {
        double precio = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lblfecha.Text = DateTime.Today.Date.ToString("d");
            lblPrecio.Text = (0).ToString("C");
        }
        private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string producto = cboProductos.Text;

            if (producto.Equals("Botana normal")) precio = 120;
            if (producto.Equals("Botana crispy")) precio = 130;
            if (producto.Equals("Botana bufalo")) precio = 140;

            lblPrecio.Text = precio.ToString("C");


        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (cboProductos.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un producto...!!");
            else if (Txtcantidad.Text == "")
                MessageBox.Show("Debe seleccionar una cantidad....!!");
            else if (cboTipo.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un tipo....!!");
        }
    }
} 
