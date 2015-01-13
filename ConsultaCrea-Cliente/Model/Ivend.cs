using ConsultaCrea_Cliente.IvendAPI;
using ConsultaCrea_Cliente.Model.datasource;
using ConsultaCrea_Cliente.View;
using System;
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
        private static Random random = new Random((int)DateTime.Now.Ticks);

        public Ivend()
        {
            Address = VConfigurador.getInstancia.serializadora.WsAdIvnd.ToString(); //"http://localhost/iVendAPI/iVendAPI.svc";
            client = new IvendAPI.IntegrationServiceClient();
            client.Endpoint.Address = new System.ServiceModel.EndpointAddress(Address);
            ConnString = "Data Source="+VConfigurador.getInstancia.serializadora.SvrIvnd.ToString()+";Initial Catalog="+VConfigurador.getInstancia.serializadora.DBIvnd.ToString()+";Persist Security Info=True;User ID="+
                VConfigurador.getInstancia.serializadora.UsrIvnd.ToString()+"; Password="+VConfigurador.getInstancia.serializadora.PassIvnd.ToString();
            db = new datasource.IvendDBDataContext(ConnString);
        }

        public string agregarCliente(string rnc, string nombre, string grupoCliente)
        {
            IvendAPI.Customer cust = new IvendAPI.Customer();
            cust.Id = RandomString(9);
            cust.TaxNumber = rnc;
            if (cust.TaxNumber.ToString().Trim().Length == 9)
            { cust.TaxCompanyType = CompanyType.Company; }
            else if (cust.TaxNumber.ToString().Trim().Length == 11)
            { cust.TaxCompanyType = CompanyType.Private; }
            cust.FirstName = nombre;
            cust.CustomerGroupId = grupoCliente;
            cust.IsActive = true;
            cust.CanOrderItems = true;
            IvendAPI.Customer rs = new IvendAPI.Customer();
            rs = client.SaveCustomer(cust);
            return rs.Message;
        }

        public string modificarCliente(string id, string nombre, string grupoCliente)
        {
            IvendAPI.Customer cust = client.GetCustomer(id);
            cust.FirstName = nombre;
            cust.CustomerGroupId = grupoCliente;
            IvendAPI.Customer rs = new IvendAPI.Customer();
            rs = client.SaveCustomer(cust);
            return rs.Message;
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

        private string RandomString(int Size)
        {
            string input = "abcdefghijklmnopqrstuvwxyz0123456789";
            var chars = Enumerable.Range(0, Size)
                                   .Select(x => input[random.Next(0, input.Length)]);
            return new string(chars.ToArray());
        }
    }
}
