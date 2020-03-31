using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        #region Atributos 

        public static List<Cliente> lstCli = new List<Cliente>();

        #endregion Atributos

        #region Propriedades

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public decimal Salario { get; set; }
        public string Endereco { get; set; }

        #endregion Propriedades

        #region Métodos

        public void Add (Cliente c)
        {
            lstCli.Add(c);
        }

        public List<Cliente> ListAll()
        {
            return lstCli;
        }

        public override string ToString()
        {
            return "id: " + this.Id + 
                 "\nNome: " + this.Nome + 
                 "\nTelefone: " + this.Telefone + 
                 "\nSalário: " + this.Salario + 
                 "\nEndereço: " + this.Endereco;
        }

        #endregion Métodos
    }
}
