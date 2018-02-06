using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLojaVirtual.Entitades
{
    public class Produtos
    {
        public int ProdutoId { get; set; }
        
        public string Nome { get; set; }

        public string Descrição { get; set; }

        public decimal Preco { get; set; }

        public string Categoria { get; set; }  

    }
}
  