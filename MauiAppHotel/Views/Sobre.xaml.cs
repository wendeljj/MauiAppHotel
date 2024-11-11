namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new ContrataçãoHospedagem());
		} catch (Exception ex)
		{
			DisplayAlert("Erro", ex.Message, "OK");
		}
    }
}