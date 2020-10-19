using System;

namespace Rafa
{
    class Program
    {
        static void Main(string[] args)
        {
            var instancia = new Teste();
            var artigos = instancia.ListarArtigos("DevOps");
            
            foreach (var artigo in artigos)
            {
                var texto = string.Format("Artigo [{0}]: {1}", artigo.Id, artigo.Name);
                Console.WriteLine(texto);
            }
        }
    }
}
