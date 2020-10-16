using System;

namespace Domain
{
    public class Usuario
    {
        protected string Nome { get; set; }

        public Usuario(string nome)
        {
            Nome = nome;
        }
    }
}
