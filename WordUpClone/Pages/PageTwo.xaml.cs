namespace WordUpClone.Pages;

public partial class PageTwo : ContentPage
{
    public PageTwo()
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void OnAmericanClicked(object sender, EventArgs e)
    {
        AmericanBtn.SetDynamicResource(StyleProperty, "PrimaryButton");
        BritishBtn.SetDynamicResource(StyleProperty, "SecondaryButton");
        await Navigation.PushAsync(new PageThree());
    }

    private async void OnBritishClicked(object sender, EventArgs e)
    {
        AmericanBtn.SetDynamicResource(StyleProperty, "SecondaryButton");
        BritishBtn.SetDynamicResource(StyleProperty, "PrimaryButton");
        await Navigation.PushAsync(new PageThree());
    }

    private async void OnBackCLicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}