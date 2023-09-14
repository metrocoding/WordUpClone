namespace WordUpClone.Pages;

public partial class PageThree : ContentPage
{
    public PageThree()
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private void OnContinueCLicked(object sender, EventArgs e)
    {
        DisplayAlert("Hooray", "End of the line", "OK");
    }

    private void OnFluentTapped(object sender, TappedEventArgs e)
    {
        _ResetAllGridsStyle();
        GridFluent.SetDynamicResource(StyleProperty, "SelectedGridBackground");
        TitleFluent.SetDynamicResource(StyleProperty, "SelectedLabelTextColor");
        CaptionFluent.SetDynamicResource(StyleProperty, "SelectedLabelTextColor");
    }

    private void OnIntermediateTapped(object sender, TappedEventArgs e)
    {
        _ResetAllGridsStyle();
        GridIntermediate.SetDynamicResource(StyleProperty, "SelectedGridBackground");
        TitleIntermediate.SetDynamicResource(StyleProperty, "SelectedLabelTextColor");
        CaptionIntermediate.SetDynamicResource(StyleProperty, "SelectedLabelTextColor");
    }

    private void OnBasicTapped(object sender, TappedEventArgs e)
    {
        _ResetAllGridsStyle();
        GridBasic.SetDynamicResource(StyleProperty, "SelectedGridBackground");
        TitleBasic.SetDynamicResource(StyleProperty, "SelectedLabelTextColor");
        CaptionBasic.SetDynamicResource(StyleProperty, "SelectedLabelTextColor");
    }

    private void OnBeginnerTapped(object sender, TappedEventArgs e)
    {
        _ResetAllGridsStyle();
        GridBeginner.SetDynamicResource(StyleProperty, "SelectedGridBackground");
        TitleBeginner.SetDynamicResource(StyleProperty, "SelectedLabelTextColor");
        CaptionBeginner.SetDynamicResource(StyleProperty, "SelectedLabelTextColor");
    }

    private void _ResetAllGridsStyle()
    {
        GridFluent.SetDynamicResource(StyleProperty, "NormalGridBackground");
        GridIntermediate.SetDynamicResource(StyleProperty, "NormalGridBackground");
        GridBeginner.SetDynamicResource(StyleProperty, "NormalGridBackground");
        GridBasic.SetDynamicResource(StyleProperty, "NormalGridBackground");

        TitleFluent.SetDynamicResource(StyleProperty, "NormalLabelText");
        TitleIntermediate.SetDynamicResource(StyleProperty, "NormalLabelText");
        TitleBeginner.SetDynamicResource(StyleProperty, "NormalLabelText");
        TitleBasic.SetDynamicResource(StyleProperty, "NormalLabelText");

        CaptionFluent.SetDynamicResource(StyleProperty, "NormalLabelText");
        CaptionIntermediate.SetDynamicResource(StyleProperty, "NormalLabelText");
        CaptionBeginner.SetDynamicResource(StyleProperty, "NormalLabelText");
        CaptionBasic.SetDynamicResource(StyleProperty, "NormalLabelText");
    }

    private async void OnBackCLicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}