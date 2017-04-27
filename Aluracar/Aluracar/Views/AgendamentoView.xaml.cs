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
	public partial class AgendamentoView : ContentPage
	{
        public Carro Veiculo { get; set; }
        public AgendamentoView (Carro veiculo)
		{
			InitializeComponent ();
            Veiculo = veiculo;
            BindingContext = this;
		}
	}
}
