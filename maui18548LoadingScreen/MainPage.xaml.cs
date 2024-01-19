
namespace maui18548LoadingScreen
{
	public partial class MainPage : ContentPage
	{
		private readonly AppReadyService _appReadyService;

		public MainPage(AppReadyService appReadyService)
		{
			InitializeComponent();
			_appReadyService = appReadyService;

			_appReadyService.AppReady += AppReadyService_AppReady;
			_appReadyService.AppLoading += AppReadyService_AppLoading;

			BindingContext = this;
		}

        private void AppReadyService_AppLoading(object? sender, int e)
        {
            LoadValue = $"Loaded {e}%...";
			OnPropertyChanged(nameof(LoadValue));
        }

        public string? LoadValue { get; set; }


        private void AppReadyService_AppReady(object? sender, EventArgs e)
		{
			blazorWebView.IsVisible = true;
            LoadingPanel.IsVisible = false;
		}
	}
}
