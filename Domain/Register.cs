using System;

namespace Domain
{
    public class Register
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }

        public Register(string name, string type)
        {
            Id = Guid.NewGuid();
            Name = name;
            Type = type;
        }
    }
}
