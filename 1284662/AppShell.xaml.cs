using _1284662.views;

namespace _1284662;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(SurveyDetailsView), typeof(SurveyDetailsView));
    }
}
