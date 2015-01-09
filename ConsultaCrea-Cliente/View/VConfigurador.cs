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

namespace ConsultaCrea_Cliente.View
{
    public partial class VConfigurador : Form, ISerializable
    {
        private static VConfigurador Instancia;

        private VConfigurador()
        {
            InitializeComponent();
            Model.Serializadora serializadora = Model.Serializadora.LeerObjeto("conf.bin");
            TBWsAddress.Text = serializadora.WsAdIvnd.ToString();
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
            Model.Serializadora serializadora = new Model.Serializadora();
            serializadora.WsAdIvnd = TBWsAddress.Text;
            serializadora.EscribirObjeto("conf.bin");
            this.Visible = false;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
