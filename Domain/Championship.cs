using System;
using System.Collections.Generic;

namespace Domain
{
    public class Championship
    {
        private List<Register> users { get; set; }
        public IReadOnlyCollection<Register> Users => users;
        public Time()
        {
            Users = new List<Register>();
        }
    }
}
