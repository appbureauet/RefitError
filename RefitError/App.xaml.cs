using System;

using Xamarin.Forms;
using RefitError.Services;
using Refit;

namespace RefitError
{
    public partial class App : Application
    {
        public static bool UseMockDataStore = true;
        public static string BackendUrl = "https://localhost:5000";

        public App()
        {
            InitializeComponent();

            if (UseMockDataStore)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<CloudDataStore>();

            var nonsenseApi = RestService.For<INonsenseApi>("https://api.nonsense.com");

            var octocat = nonsenseApi.Nonsense("octocat");

            if (Device.RuntimePlatform == Device.iOS)
                MainPage = new MainPage();
            else
                MainPage = new NavigationPage(new MainPage());
        }
    }
}
