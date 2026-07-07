using Microsoft.Extensions.DependencyInjection;

namespace AbsoluteLayout_6133261
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new StackLayout();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}