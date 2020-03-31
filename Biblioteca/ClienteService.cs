using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ClienteService
    {
        public void Add (int id, string nome, string telefone, decimal salario, string endereco)
        {
            Cliente cl = new Cliente()
            {
                Id = id,
                Nome = nome,
                Telefone = telefone,
                Endereco = endereco,
                Salario = salario
            };
            new Cliente().Add(cl);
        }

        public List<Cliente> ListAll()
        {
            return new Cliente().ListAll();
        }
    }
}
