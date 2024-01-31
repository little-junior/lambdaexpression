using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressoesLambda
{
    public class LivroFilter
    {
        public Filter<Livro> Filter { get; set; }
        public object FilterArgument { get; set; }
        public LivroFilter(int ano)
        {
            FilterArgument = ano;
            Filter = FiltrarPorAnoPublicacao;
        }

        public LivroFilter(decimal preco)
        {
            FilterArgument = preco;
            Filter = FiltrarPorPrecoMaximo;
        }

        public LivroFilter(string titulo)
        {
            FilterArgument = titulo;
            Filter = FiltrarPorTitulo;
        }
        private bool FiltrarPorAnoPublicacao(Livro livro) => livro.AnoPublicacao >= (int)FilterArgument;

        private bool FiltrarPorPrecoMaximo(Livro livro) => livro.Preco <= (decimal)FilterArgument;

        private bool FiltrarPorTitulo(Livro livro) => livro.Titulo.Contains((string)FilterArgument, StringComparison.CurrentCultureIgnoreCase);
    }
}
