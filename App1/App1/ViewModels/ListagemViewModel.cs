using App1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class ListagemViewModel
    {
        public List<Veiculo> Veiculos { get; set; }

        Veiculo veiculoSelecionado;

        public Veiculo VeiculoSelecionado 
        {
            get 
            {
                return veiculoSelecionado;
            }
            set
            {
                veiculoSelecionado = value;
                MessagingCenter.Send()
            }
        }

        public ListagemViewModel()
        {
            this.Veiculos = new ListagemVeiculos().Veiculos;
        }
    }
}
