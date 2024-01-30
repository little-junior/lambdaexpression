namespace ExpressoesLambda
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public decimal Preco { get; set; }

        public override string ToString()
        {
            return $"Titulo: {Titulo}\nAutor: {Autor}\nAno de publicação: {AnoPublicacao}\nPreço: {Preco}";
        }
    }
}
