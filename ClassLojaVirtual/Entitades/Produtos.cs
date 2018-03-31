using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLojaVirtual.Entitades
{
    public class Produtos
    {
        [Key]
        public int ProdutoId { get; set; }
        
        public string Nome { get; set; }
        [Column("Descricao")]
        public string Descrição { get; set; }

        public decimal Preco { get; set; }

        public string Categoria { get; set; }  

    }
}
  