using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeLambida
{
    public class Artigo
    {
        public string Titulo { get; set; }
        public List<string> PalavrasChaves { get; set; }
        public string Instituicao { get; set; }
        public ICollection<Autor> Autores { get; set; }

        public Artigo(string titulo, List<string> palavrasChaves, string instituicao, ICollection<Autor> autores)
        {

            this.Titulo = titulo;
            this.PalavrasChaves = palavrasChaves;
            this.Autores = autores;
            this.Instituicao = instituicao;
        }
        public override string ToString()
        {
            string autores="";
            foreach (var autor in Autores)
            {
                 autores += autor + "\n" ;
            }

            string palavrasChaves="";
            foreach (var palavraChave in PalavrasChaves)
            {
                 palavrasChaves += palavraChave + "\n" ;
            }
            return "Titulo: " + Titulo + "\n" + "Autores: " + autores + "\n"+  "Palavras Chaves: " + palavrasChaves;
        }
    }
}