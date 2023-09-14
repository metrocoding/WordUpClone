using WordUpClone.Pages;

namespace WordUpClone;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new PageOne());
    }
}