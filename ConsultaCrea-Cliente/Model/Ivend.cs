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
        private string Address, ConnString;
        private IvendDBDataContext db;

        public Ivend()
        {
            Address = VConfigurador.getInstancia.serializadora.WsAdIvnd.ToString(); //"http://localhost/iVendAPI/iVendAPI.svc";
            IvendAPI.IntegrationServiceClient client = new IvendAPI.IntegrationServiceClient();
            client.Endpoint.Address = new System.ServiceModel.EndpointAddress(Address);
            ConnString = "Data Source="+VConfigurador.getInstancia.serializadora.SvrIvnd.ToString()+";Initial Catalog="+VConfigurador.getInstancia.serializadora.DBIvnd.ToString()+";Persist Security Info=True;User ID="+
                VConfigurador.getInstancia.serializadora.UsrIvnd.ToString()+"; Password="+VConfigurador.getInstancia.serializadora.PassIvnd.ToString();
            db = new datasource.IvendDBDataContext(ConnString);
        }

        public void agregarCliente(string rnc, string nombre)
        {
            throw new NotImplementedException();
        }

        public bool buscarCliente(string id)
        {
            var qCliente = from T0 in db.CusCustomers
                           where T0.TaxNumber.Equals(id)
                           select T0;
            foreach (var q in qCliente)
            {
                return true;
            }
            return false;
        }
    }
}
