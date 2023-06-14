namespace HotelBookingUI.Views;

public partial class DetailPage : ContentPage
{
	public DetailPage()
	{
		InitializeComponent();
        BindingContext = new ViewModels.DetailsViewModel();
    }
}
