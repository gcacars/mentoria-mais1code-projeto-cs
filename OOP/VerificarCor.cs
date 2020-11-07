using OOP.Objetos;
using System;

namespace OOP
{
    public static class VerificarCor
    {
        public static void FormaECor(Retangulo ret)
        {
            var tipo = "retangulo";

            if (ret is Quadrado)
            {
                tipo = "quadrado";
            }

            Console.WriteLine($"O {tipo} de largura {ret.largura} é da cor {ret.GetCor()}");
        }
    }
}
