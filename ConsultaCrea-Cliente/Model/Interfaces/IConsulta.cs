using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCrea_Cliente.Model.Interfaces
{
    interface IConsulta
    {
        string buscarCliente(string TaxNumber);
        DataSet buscarGrupoCliente();
    }
}
