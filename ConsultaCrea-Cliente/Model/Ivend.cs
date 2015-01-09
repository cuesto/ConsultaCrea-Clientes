using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCrea_Cliente.Model
{
    class Ivend : Model.Interfaces.ICreaCliente, Model.Interfaces.IConsulta
    {
        public Ivend() { }
        public Ivend(string serverAddress)
        {
            string address = "http://localhost/iVendAPI/iVendAPI.svc";
            IvendAPI.IntegrationServiceClient client = new IvendAPI.IntegrationServiceClient();
            client.Endpoint.Address = new System.ServiceModel.EndpointAddress(serverAddress);
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
