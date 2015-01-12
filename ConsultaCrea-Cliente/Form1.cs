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

        private Ivend ivend;

        public Form1()
        {
            InitializeComponent();
            ivend = new Ivend();
            /*Inicializa ComboBox*/
            CmbGrupos.DataSource = ivend.buscarGrupoCliente().Tables[0];
            CmbGrupos.DisplayMember = "Description";
            CmbGrupos.ValueMember = "Id";
        }

        private void btnBuscarRNC_Click(object sender, EventArgs e)
        {
            TxtId.Text = "";
            bool isResultado = ConsultarDGII();
            string IdCliente = ivend.buscarCliente(mTxtRNC.Text.ToString());
            if (isResultado && (IdCliente.Length > 0))
            {
                DialogResult isRespuesta = MessageBox.Show("Este cliente ya está en el sistema. Desea Actualizar sus Datos?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification, false);
                if (isRespuesta == System.Windows.Forms.DialogResult.Yes)
                {
                    groupBox2.Enabled = true;
                    TxtId.Text = IdCliente;
                }
                else { groupBox2.Enabled = false; }
            }
            if (isResultado && (IdCliente.Length <= 0)) { groupBox2.Enabled = true; }
            if (!isResultado) { groupBox2.Enabled = false; }
        }

        private bool ConsultarDGII()
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
                return true;
            }
            else
            {
                txtNombre.Text = "";
                txtNombreComercial.Text = "";
                txtCategoria.Text = "";
                txtRegimenDePago.Text = "";
                txtEstado.Text = "";
                MessageBox.Show("No existen resultados de esta búsqueda.");
                return false;
            }
        }

        private void mTxtRNC_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyValue ==  )
            //{
            ////  //  ConsultarDGII();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // boton para agregar datos a Ivend
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.VConfigurador.getInstancia.Visible = true;
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
