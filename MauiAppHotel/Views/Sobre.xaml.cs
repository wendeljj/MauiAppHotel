namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new Contrata��oHospedagem());
		} catch (Exception ex)
		{
			DisplayAlert("Erro", ex.Message, "OK");
		}
    }
}