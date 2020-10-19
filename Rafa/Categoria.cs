using System.Collections.Generic;

namespace Rafa
{
    public class Categoria
    {
        public string Nome { get; set; }
        public IList<Artigo> Artigos { get; set; }
    }
}
