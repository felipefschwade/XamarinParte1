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
