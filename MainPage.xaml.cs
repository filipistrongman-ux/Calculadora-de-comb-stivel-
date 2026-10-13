using meuappcombustivel.Models;
using meuappcombustivel.PageModels;

namespace meuappcombustivel.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }

        private async void OnCalcularClicked(object sender, EventArgs e)
        {
            string marca = MarcaEntry.Text;
            string modelo = ModeloEntry.Text;

            if (double.TryParse(GasolinaEntry.Text, out double gasolina) &&
                double.TryParse(EtanolEntry.Text, out double etanol))
            {
                if (etanol <= gasolina * 0.70)
                {
                    await DisplayAlertAsync("Resultado", $"O etanol está compensando para o seu {marca} {modelo}.", "OK");
     

                }
                else
                {
                    await DisplayAlertAsync("Resultado", $"A gasolina está compensando para o seu {marca} {modelo}.", "OK");
     




                }

            }
            else
            {
                await DisplayAlertAsync("Erro", "Digite corretamente os preços da gasolina e do etanol.", "OK");



            }
        }
    }
}