

namespace lakierySklep
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            Window window = base.CreateWindow(activationState);

            window.MaximumHeight = 800;
            window.MinimumHeight = 800;

            window.MaximumWidth = 500;
            window.MinimumWidth = 500;

            return window;
        }
    }
}
