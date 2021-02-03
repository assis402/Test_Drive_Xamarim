using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    public class Agendamento
    {
        public Veiculo Veiculo { get; set; }
        public string Nome { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }

        private DateTime data = DateTime.Today;
        public DateTime Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
        public TimeSpan Hora { get; set; }
    }
}
