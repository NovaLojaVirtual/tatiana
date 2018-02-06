using ClassLojaVirtual.Entitades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLojaVirtual.Repositório1
{
  public class ProdutosRepositorio
    {
        private readonly EfDBContext _context = new EfDBContext();

        public IEnumerable<Produtos> Produto
        {
            get { return _context.Produto; }

        }
    }
}
