namespace maui18548LoadingScreen
{
	public class AppReadyService
	{
		public event EventHandler? AppReady;
        public event EventHandler<int>? AppLoading;


        public void NotifyAppLoading(int loadValue)
        {
            AppLoading?.Invoke(this, loadValue);
        }

        public void NotifyAppReady()
		{
			AppReady?.Invoke(this, EventArgs.Empty);
		}
	}
}
