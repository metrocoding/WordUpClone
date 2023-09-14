namespace WordUpClone.Pages;

public partial class PageOne : ContentPage
{
    public PageOne()
    {
        InitializeComponent();
        var width = DeviceDisplay.Current.MainDisplayInfo.Width;
        Squares.HeightRequest = width / DeviceDisplay.Current.MainDisplayInfo.Density;
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void OnNavigateClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PageTwo());
    }

    private void OnLoginClicked(object sender, EventArgs e)
    {
        DisplayAlert("Error", "Not implemented", "OK");
    }
}