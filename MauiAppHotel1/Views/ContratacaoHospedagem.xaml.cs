namespace MauiAppHotel1.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesApp;
    private object pck_quarto;
    private object dtpck_checkin;
    private object dtpck_checkout;

    public object DameTime { get; private set; }

    public ContratacaoHospedagem()
    {
        InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

        dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MaximumDate = new DateTime(DateTime.Now. Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);

    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private void Buttom_Clicked(Object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HospedagemContrada());
        }
        catch (Exception ex)
        {
            DisplayAlert = ("Ops", ex.Message, "OK");
        }
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = elemento.Date;

        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
}
