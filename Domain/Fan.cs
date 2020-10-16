using System;

namespace Domain
{
    public class FAN : Usuario
    {
        public FAN (string nome) : base(nome)
        {
            Nome = nome;
        }
    }
}
