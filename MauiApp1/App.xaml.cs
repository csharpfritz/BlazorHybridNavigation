using Microsoft.AspNetCore.Components.WebView.Maui;

namespace MauiApp1
{
	public partial class App : Application
	{
		public App(NavigatorService navigatorService)
		{
			InitializeComponent();
			NavigatorService = navigatorService;
		}

		public NavigatorService NavigatorService { get; }

		private void MenuItem_Clicked(object sender, EventArgs e)
		{

			var menuItem = (MenuItem)sender;
			var url = menuItem.Text switch
			{
				"Counter" => "/counter",
				"Weather" => "/weather",
				_ => "/"
			};

			NavigatorService.NavigationManager.NavigateTo(url);

		}
	}
}
