using Xamarin.Forms;

namespace SugarHill
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new SugarHillPage();
		}

		protected override void OnStart()
		{
			// Handle when your app start
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
