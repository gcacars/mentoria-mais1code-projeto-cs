using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Objetos
{
    public class Losango : Retangulo
    {
        public Losango(int alt, int larg, string cor) : base(alt, larg, cor)
        {

        }

        public override int CalcularArea()
        {
            return (base.alturaObjeto * base.larguraObjeto) / 2;
        }
    }
}
