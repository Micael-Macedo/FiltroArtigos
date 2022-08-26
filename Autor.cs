using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeLambida
{
    public class Autor
    {
        public Autor(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public string Nome { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return "Nome autor:" + Nome + "E-mail: " + Email.ToString();
        }
    }
}