using WordUpClone.Pages;

namespace WordUpClone;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("NewPage", typeof(PageOne));
    }
}