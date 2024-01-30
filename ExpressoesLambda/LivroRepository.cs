namespace ExpressoesLambda
{
    internal class LivroRepository
    {
        private List<Livro> livros;

        public LivroRepository(List<Livro> livros)
        {
            this.livros = livros;
        }

        public List<Livro> Filtrar(Filter<Livro> filtro)
        {
            return livros.Where(x => filtro(x)).ToList();
        }
    }
}
