namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada(double quantadult, double quantcrianca)
	{
		InitializeComponent();
		adult_lbl.Text = quantadult.ToString();
		crianca_lbl.Text = quantcrianca.ToString();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PopAsync();
		}
		catch (Exception ex) { DisplayAlert("Erro", ex.Message, "OK"); }
    }
}