using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultaCrea_Cliente.View;
using ConsultaCrea_Cliente.Model.datasource;

namespace ConsultaCrea_Cliente.Model
{
    class Ivend : Model.Interfaces.ICreaCliente, Model.Interfaces.IConsulta
    {
        private string address, connString;

        public Ivend() { }
        public Ivend(string serverAddress)
        {
            address = VConfigurador.getInstancia.serializadora.WsAdIvnd.ToString(); //"http://localhost/iVendAPI/iVendAPI.svc";
            IvendAPI.IntegrationServiceClient client = new IvendAPI.IntegrationServiceClient();
            client.Endpoint.Address = new System.ServiceModel.EndpointAddress(serverAddress);
            connString = "Data Source="+VConfigurador.getInstancia.serializadora.SvrIvnd.ToString()+";Initial Catalog="+VConfigurador.getInstancia.serializadora.DBIvnd.ToString()+";Persist Security Info=True;User ID="+
                VConfigurador.getInstancia.serializadora.UsrIvnd.ToString()+"; Password="+VConfigurador.getInstancia.serializadora.PassIvnd.ToString();
            IvendDBDataContext db = new datasource.IvendDBDataContext(connString);
        }

        public void agregarCliente(string rnc, string nombre)
        {
            throw new NotImplementedException();
        }

        public bool buscarCliente(string id)
        {
            throw new NotImplementedException();
        }
    }
}
