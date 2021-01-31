using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalheView : ContentPage
    {
        private const int FreioABS = 800;
        private const int ArCondicionado = 1000;
        private const int Mp3Player = 500;

        public Veiculo Veiculo { get; set; }
        bool temFreioABS;
        bool temArCondicionado;
        bool temMp3Player;

        public bool TemFreioABS
        {
            get
            {
                return TemFreioABS;
            }
            set
            {
                temFreioABS = value;
                OnPropertyChanged();
            }
        }

        public bool TemArCondicionado
        {
            get
            {
                return TemArCondicionado;
            }
            set
            {
                temArCondicionado = value;
                OnPropertyChanged();
            }
        }

        public bool TemMp3Player
        {
            get
            {
                return TemMp3Player;
            }
            set
            {
                temMp3Player = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public string ValorTotal
        {
            get
            {
                return string.Format("Valor Total: R$ {0}",
                    Veiculo.Preco
                    + (TemFreioABS ? FreioABS : 0)
                    + (TemArCondicionado ? FreioABS : 0)
                    + (TemFreioABS ? FreioABS : 0));
            }
        }
        public string TextoFreioABS
        {
            get
            {
                return string.Format("Freio ABS - R$ {0}", FreioABS);
            }
        }
        public string TextoArCondicionado
        {
            get
            {
                return string.Format("Ar Condicionado - R$ {0}", ArCondicionado);
            }
        }
        public string TextoMp3Player
        {
            get
            {
                return string.Format("Mp3 Player - R$ {0}", Mp3Player);
            }
        }


        public DetalheView(Veiculo veiculo)
        {
            InitializeComponent();

            this.Title = veiculo.Nome;
            this.BindingContext = this;
        }

        private void buttonProximo_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new AgendamentoView(this.Veiculo));
        }
    }
}