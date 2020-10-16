using System;

namespace Domain
{
    public class Player
    {
        public string Nome { get; private set; }
        public Time Time { get; private set; }     
        public int Gol { get; private set;}
        public Player(string nome, Time time)
        {
            Nome = nome;
            Time = time;
        }

        public void DesvincularTime()
        {
            Time = null;
        }
    }
}
