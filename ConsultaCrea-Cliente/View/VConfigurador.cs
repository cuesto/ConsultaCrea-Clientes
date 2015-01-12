using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ConsultaCrea_Cliente.Model;

namespace ConsultaCrea_Cliente.View
{
    public partial class VConfigurador : Form, ISerializable
    {
        private static VConfigurador Instancia;
        public Serializadora serializadora;

        private VConfigurador()
        {
            InitializeComponent();
            serializadora = Model.Serializadora.LeerObjeto("conf.bin");
            TBWsAddress.Text = serializadora.WsAdIvnd.ToString();
            TBServer.Text = serializadora.SvrIvnd.ToString();
            TBDatabase.Text = serializadora.DBIvnd.ToString();
            TBUser.Text = serializadora.UsrIvnd.ToString();
            TBPass.Text = serializadora.PassIvnd.ToString();
        }

        public static VConfigurador getInstancia
        {
            get
            {
                if(Instancia == null)
                {
                    Instancia = new VConfigurador();
                }
                return Instancia;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serializadora = new Model.Serializadora();
            serializadora.WsAdIvnd = TBWsAddress.Text;
            serializadora.SvrIvnd = TBServer.Text;
            serializadora.DBIvnd = TBDatabase.Text;
            serializadora.UsrIvnd = TBUser.Text;
            serializadora.PassIvnd = TBPass.Text;
            serializadora.EscribirObjeto("conf.bin");
            this.Visible = false;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
