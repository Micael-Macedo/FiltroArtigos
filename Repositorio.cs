using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeLambida
{
    public class Repositorio
    {
        public ICollection<Artigo> Artigos { get; set; }
        public ICollection<Artigo> FiltraArtigosPorPalavraChave(string palavrasChaves) {
            ICollection<Artigo> artigosFiltrados = (ICollection<Artigo>)Artigos.Where(a => a.PalavrasChaves.Exists(p => p == palavrasChaves));
            return artigosFiltrados;
        }
    }
}