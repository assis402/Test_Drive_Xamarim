using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    public class Veiculo
    {
        public const int FreioABS = 800;
        public const int ArCondicionado = 1000;
        public const int Mp3Player = 500;

        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string PrecoFormatado
        {
            get { return string.Format("R$ {0}", Preco); }
        }

        public bool TemFreioABS { get; set; }
        public bool TemArCondicionado { get; set; }
        public bool TemMp3Player { get; set; }

        public string PrecoTotalFormatado
        {
            get
            {
                return string.Format("Valor Total: R$ {0}",
                    Preco
                    + (TemFreioABS ? Veiculo.FreioABS : 0)
                    + (TemArCondicionado ? Veiculo.ArCondicionado : 0)
                    + (TemMp3Player ? Veiculo.Mp3Player : 0));
            }
        }
    }
}
