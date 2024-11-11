namespace MauiAppHotel.Views;

public partial class ContrataçãoHospedagem : ContentPage
{
    App PropriedadesApp;
	public ContrataçãoHospedagem()
	{
		InitializeComponent();
        PropriedadesApp = (App)Application.Current;
        pick_suite.ItemsSource = PropriedadesApp.lista_quartos;
        datein_picker.MinimumDate = DateTime.Now;
        datein_picker.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);
        dateout_picker.MinimumDate = datein_picker.Date.AddDays(1);
        dateout_picker.MaximumDate = datein_picker.Date.AddMonths(2);
	}

    private void Button_Clicked_1(object sender, EventArgs e)
    {

        double quantadult = stepper_adult.Value;
        double quantcrianca = stepper_child.Value;

        try
        {
            Navigation.PushAsync(new HospedagemContratada(quantadult, quantcrianca));
        } catch(Exception ex)
        {
            DisplayAlert("Erro", ex.Message, "OK");
        }
    }

    private void datein_picker_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = elemento.Date;

        dateout_picker.MinimumDate = data_selecionada_checkin.Date.AddDays(1);
        dateout_picker.MaximumDate = data_selecionada_checkin.Date.AddMonths(2);
    }

    private void btn_sobre_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Sobre());
        } catch(Exception ex)
        {
            DisplayAlert("Erro", ex.Message, "OK");
        }
    }
}