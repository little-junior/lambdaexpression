namespace ExpressoesLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Livro> livros = new List<Livro>
            {
                new Livro { Titulo = "Aprendendo C#", Autor = "Autor1", AnoPublicacao = 2020, Preco = 50.0m },
                new Livro { Titulo = "C# Avançado", Autor = "Autor2", AnoPublicacao = 2022, Preco = 70.0m },
                new Livro { Titulo = "Design Patterns", Autor = "Autor3", AnoPublicacao = 2019, Preco = 60.0m }
            };

            var repositorio = new LivroRepository(livros);

            var filtroAno = new LivroFilter(2020);
            var filtroPreco = new LivroFilter(59.90m);
            var filtroTitulo = new LivroFilter("c#");

            var listaFiltradaAno = repositorio.Filtrar(filtroAno.Filter);
            var listaFiltradaPreco = repositorio.Filtrar(filtroPreco.Filter);
            var listaFiltradaTitulo = repositorio.Filtrar(filtroTitulo.Filter);

            ImprimirLista(listaFiltradaAno);
            //ImprimirLista(listaFiltradaPreco);
            //ImprimirLista(listaFiltradaTitulo);


        }

        static void ImprimirLista(List<Livro> lista)
        {
            lista.ForEach(elemento => Console.WriteLine(elemento.ToString() + "\n"));   
        }
    }
}
