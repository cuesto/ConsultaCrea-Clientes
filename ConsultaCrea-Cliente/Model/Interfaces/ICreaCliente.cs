using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCrea_Cliente.Model.Interfaces
{
    interface ICreaCliente
    {
        void agregarCliente(string rnc, string nombre, string grupoCliente);
        string modificarCliente(string id, string nombre, string grupoCliente);
    }
}
