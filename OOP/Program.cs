using OOP.Objetos;
using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var objetoAzul = new FormaGeometrica("azul");
            var objetoAmarelo = new FormaGeometrica("amarelo");

            Console.WriteLine($"A cor do objeto azul é {objetoAzul.GetCor()}");
            Console.WriteLine($"A cor do objeto amarelo é {objetoAmarelo.GetCor()}");

            var retangulo = new Retangulo(10, 60, "vermelho");
            Console.WriteLine($"A área do retângulo é {retangulo.CalcularArea()}");
            Console.WriteLine($"Á área de um retângulo que tem {retangulo.largura}m de largura e {retangulo.altura}m de altura é: {retangulo.CalcularArea()}m²");
            Console.WriteLine($"A cor do retângulo é {retangulo.GetCor()}");

            var quadrado = new Quadrado(5, "azul");
            Console.WriteLine($"Eu tenho um quadrado {quadrado.GetCor()} de tamanho {quadrado.largura}m e que tem área de {quadrado.CalcularArea()}m²");

            var x = new Retangulo(25, 30, "lilás");
            var y = new Quadrado(80, "roxo");
            VerificarCor.FormaECor(x);
            VerificarCor.FormaECor(y);

            var losango = new Losango(10, 60, "verde");
            Console.WriteLine($"O losango da cor {losango.GetCor()} tem a área de {losango.CalcularArea()}m²");
        }
    }
}
