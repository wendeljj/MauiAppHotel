
using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 185.50,
                ValorDiariaCrianca = 132.50,
            },
             new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 152.80,
                ValorDiariaCrianca = 112.25,
            },
              new Quarto()
            {
                Descricao = "Suíte Básica",
                ValorDiariaAdulto = 137.40,
                ValorDiariaCrianca = 89.90,
            },
              new Quarto(){
              Descricao = "Suíte Super Básica",
                ValorDiariaAdulto = 102.20,
                ValorDiariaCrianca = 55.70,
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContrataçãoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
