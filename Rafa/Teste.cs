using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rafa
{
    public class Teste
    {
        public static IList<Categoria> artigos;

        public Teste()
        {
            var devOps = new List<Artigo>();

            devOps.Add(new Artigo()
            {
                Id = "azure-devops",
                Name = "Azure DevOps"
            });
            devOps.Add(new Artigo()
            {
                Id = "ci-cd",
                Name = "CI/CD"
            });

            var javaScript = new List<Artigo>();
            javaScript.Add(new Artigo()
            {
                Id = "functions",
                Name = "Funções"
            });

            artigos = new List<Categoria>()
            {
                new Categoria() { Nome = "DevOps", Artigos = devOps },
                new Categoria() { Nome = "JavaScript", Artigos = javaScript },
            };
        }

        public IList<Artigo> ListarArtigos(string categoria)
        {
            if (categoria == null)
            {
                Console.WriteLine("A categoria deve ser informada!");
            }

            if (!artigos.Any(c => c.Nome == categoria))
            {
                Console.WriteLine("A categoria não existe!");
            }

            return artigos.First(c => c.Nome == categoria).Artigos;
        }
    }
}
