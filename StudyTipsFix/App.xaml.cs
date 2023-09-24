using StudyTipsFix.Models;
using StudyTipsFix.Views;

namespace StudyTipsFix;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MainPage());
	}
}
