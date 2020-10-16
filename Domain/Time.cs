using System;
using System.Collections.Generic;

namespace Domain
{
    public class Time
    {
        public Time(string nomeTime, int pontuacao, int partidasDisputadas, int vitorias, int derrotas, int empate, int golsPro, int golsContra, double percentagemAproveitamento) 
        {
            this.NomeTime = nomeTime;
                this.Pontuacao = pontuacao;
                this.PartidasDisputadas = partidasDisputadas;
                this.Vitorias = vitorias;
                this.Derrotas = derrotas;
                this.Empate = empate;
                this.GolsPro = golsPro;
                this.GolsContra = golsContra;
                this.PercentagemAproveitamento = percentagemAproveitamento;
               
        }
        public string NomeTime {get; private set;}
        private List<Player> players { get; set;}
        public IReadOnlyCollection<Player> Players => players;
        public int Pontuacao { get; private set;}
        public int PartidasDisputadas { get; private set;} 
        public int Vitorias { get; private set; }   
        public int Derrotas { get; private set; }   
        public int Empate { get; private set;} 
        public int GolsPro { get; private set;}
        public int GolsContra { get; private set;} 
        public double PercentagemAproveitamento { get; private set;}


        public Time(string nomeTime)
        {
            NomeTime = nomeTime;
            players = new List<Player>();
        }

        public void DisputarPartida()
        {
            PartidasDisputadas++;
        }

        public bool MarcarVitoria()
        {
            Vitorias++;
            return true;
        }
        
        public bool MarcarDerrota()
        {
            Derrotas++;
            return true;
        }

        public bool MarcarEmpate()
        {
            Empate++;
            return true;
        }

        public void MarcarGolsContra()
        {
            GolsContra++;
        }

        public void MarcarGolsPro()
        {
            GolsPro++;
        }

        public void AtualizarPerctAproveitamento()
        {
            PercentagemAproveitamento = (Pontuacao/(PartidasDisputadas * 3))*100;
        }

        public void MarcarPontuacao()
        {
            if (this.MarcarVitoria())
            {
                Pontuacao +=3;
            }
            else if (this.MarcarEmpate())
            {
                Pontuacao +=1;
            }
        }

        public bool AdicionarJogador(Player player)
        {
            if (players.Count < 16 || players.Count > 32 )
            {
                return false;
            }
            player.DesvincularTime();
            players.Add(player);
            return true;
        }

        public bool RemoverJogador(Player player)
        {
            if (players.Count < 16 || players.Count > 32 )
            {
                return false;
            }
           
            players.Remove(player);
            return true;
        }

        public override string ToString()
        {
            return $"{NomeTime} | {Pontuacao} | {PartidasDisputadas} | {Vitorias} | {Empate} | {Derrotas} | {GolsPro} | {GolsContra} | {Math.Round(PercentagemAproveitamento, 2)}%";
        }
    }
}
