using ConsultaCrea_Cliente.Model.datasource;
using ConsultaCrea_Cliente.View;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ConsultaCrea_Cliente.Model
{
    class Ivend : Model.Interfaces.ICreaCliente, Model.Interfaces.IConsulta
    {
        private string Address, ConnString;
        private IvendDBDataContext db;
        private IvendAPI.IntegrationServiceClient client;

        public Ivend()
        {
            Address = VConfigurador.getInstancia.serializadora.WsAdIvnd.ToString(); //"http://localhost/iVendAPI/iVendAPI.svc";
            client = new IvendAPI.IntegrationServiceClient();
            client.Endpoint.Address = new System.ServiceModel.EndpointAddress(Address);
            ConnString = "Data Source="+VConfigurador.getInstancia.serializadora.SvrIvnd.ToString()+";Initial Catalog="+VConfigurador.getInstancia.serializadora.DBIvnd.ToString()+";Persist Security Info=True;User ID="+
                VConfigurador.getInstancia.serializadora.UsrIvnd.ToString()+"; Password="+VConfigurador.getInstancia.serializadora.PassIvnd.ToString();
            db = new datasource.IvendDBDataContext(ConnString);
        }

        public void agregarCliente(string rnc, string nombre, string grupoCliente)
        {
            
        }

        public string modificarCliente(string id, string nombre, string grupoCliente)
        {
            IvendAPI.Customer cust = client.GetCustomer(id);
            cust.FirstName = nombre;
            cust.CustomerGroupId = grupoCliente;
            IvendAPI.Customer rs = new IvendAPI.Customer();
            rs = client.SaveCustomer(cust);
            string err = rs.Message;
            return err;
        }

        public string buscarCliente(string TaxNumber)
        {
            var qCliente = from T0 in db.CusCustomers
                           where T0.TaxNumber.Trim().Equals(TaxNumber.Trim())
                           select T0.Id;

            foreach (var q in qCliente)
            {
                return q.ToString();
            }
            return "";
        }

        public System.Data.DataSet buscarGrupoCliente()
        {
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Description FROM cuscustomergroup", conn);
            DataSet ds = new DataSet();
            da.Fill(ds); 
            conn.Close();
            return ds;
        }
    }
}
