using consulta_dgii_csharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultaCrea_Cliente.Model;

namespace ConsultaCrea_Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscarRNC_Click(object sender, EventArgs e)
        {
            ConsultarDGII();
        }

        private void ConsultarDGII()
        {
            ResultRnc result = new ResultRnc();
            result = RncQueryWrapper.QueryByRnc(mTxtRNC.Text);
            if (result.Nombre != null)
            {
                txtNombre.Text = result.Nombre;
                txtNombreComercial.Text = result.NombreComercial;
                txtCategoria.Text = result.Categoria;
                txtRegimenDePago.Text = result.RegimenDePago;
                txtEstado.Text = result.Estado;
            }
            else
            {
                txtNombre.Text = "";
                txtNombreComercial.Text = "";
                txtCategoria.Text = "";
                txtRegimenDePago.Text = "";
                txtEstado.Text = "";
                MessageBox.Show("No existen resultados de esta búsqueda.");
            }
        }

        private void mTxtRNC_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyValue ==  )
            //{
            //  //  ConsultarDGII();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarDGII();
            Ivend ivend = new Ivend();
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.VConfigurador.getInstancia.Visible= true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            View.VConfigurador.getInstancia.TopMost = true;
        }
    }
}
