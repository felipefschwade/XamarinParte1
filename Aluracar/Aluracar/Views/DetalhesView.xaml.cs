using Aluracar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aluracar.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetalhesView : ContentPage
	{
        public Carro Veiculo { get; set; }
        const int ABS = 800;
        const int AR_COND = 1000;
        const int MP3 = 500;

        bool temAbs;
        public bool TemAbs
        {
            get { return temAbs; }
            set
            {
                temAbs = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }
        bool temAr;
        public bool TemAr
        { 
            get { return temAr; }
            set
            {
                temAr = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }
        bool temMp3;
        public bool TemMp3
        {
            get { return temMp3; }
            set
            {
                temAbs = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public string TextoAbs
        {
            get { return String.Format("Freio ABS - R$ {0}", ABS); }
        }
        public string TextoArCond
        {
            get { return String.Format("Ar Condicionado - R$ {0}", AR_COND); }
        }
        public string TextoMp3
        {
            get { return String.Format("Ar Condicionado - R$ {0}", MP3); }
        }

        public string ValorTotal
        {
            get
            {
                return String.Format("Valor Total R$ {0}",
              this.Veiculo.Valor + (this.TemAbs ? ABS : 0)
              + (this.TemAr ? AR_COND : 0)
              + (this.TemMp3 ? MP3 : 0)
              );
            }
        }

        public DetalhesView (Carro veiculo)
		{
			InitializeComponent ();
            Veiculo = veiculo;
            BindingContext = this;
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgendamentoView(Veiculo));
        }
    }
}
