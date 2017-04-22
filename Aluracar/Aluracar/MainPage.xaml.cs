using Aluracar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Aluracar
{
	public partial class MainPage : ContentPage
	{
        public IList<Carro> Veiculos { get; set; }

        public MainPage()
		{
			InitializeComponent();
            Veiculos = new List<Carro>()
            {
                new Carro { Nome = "Azera", Valor = 58000 },
                new Carro { Nome = "Fiesta 2.0", Valor = 40000 },
                new Carro { Nome = "S10 Flex", Valor = 30000 }
            };
            BindingContext = this;
        }
	}
}
