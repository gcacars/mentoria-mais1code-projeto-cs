namespace OOP.Objetos
{
    public class Retangulo : FormaGeometrica
    {
        protected int alturaObjeto = 0;
        protected int larguraObjeto = 0;
        
        public Retangulo(int alt, int larg, string cor) : base(cor)
        {
            alturaObjeto = alt;
            larguraObjeto = larg;
        }

        public virtual int CalcularArea()
        {
            return alturaObjeto * larguraObjeto;
        }

        public int altura { get { return alturaObjeto; } }
        public int largura { get { return larguraObjeto; } }
    }
}
