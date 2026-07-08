using Microsoft.Extensions.DependencyInjection;

namespace FlexLayout_6133261
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new FlexLayoutPage();
        }
    }
}