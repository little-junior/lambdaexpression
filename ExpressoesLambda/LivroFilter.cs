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
        public object arg { get; set; }
        public LivroFilter(int ano)
        {
            arg = ano;
            Filter = FiltrarPorAnoPublicacao;
        }

        public LivroFilter(decimal preco)
        {
            arg = preco;
            Filter = FiltrarPorPrecoMaximo;
        }

        public LivroFilter(string titulo)
        {
            arg = titulo;
            Filter = FiltrarPorTitulo;
        }
        public bool FiltrarPorAnoPublicacao(Livro livro) => livro.AnoPublicacao >= (int)arg;

        public bool FiltrarPorPrecoMaximo(Livro livro) => livro.Preco <= (decimal)arg;

        public bool FiltrarPorTitulo(Livro livro) => livro.Titulo.Contains((string)arg);
    }
}
