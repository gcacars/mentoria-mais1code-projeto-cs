namespace OOP.Objetos
{
    public class FormaGeometrica
    {
        private string corObjeto = null;

        public FormaGeometrica(string cor)
        {
            corObjeto = cor;
        }

        public string GetCor()
        {
            return corObjeto;
        }
    }
}
