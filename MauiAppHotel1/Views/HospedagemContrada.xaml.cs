namespace MauiAppHotel1.Views;

public partial class HospedagemContrada : ContentPage
{
	public HospedagemContrada()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		try
		{
			Navigation.PopAsync();
		}
		catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
	}
}