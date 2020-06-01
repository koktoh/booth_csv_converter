using System.Text;
using System.Windows;
using BoothCsvConverter.ViewModels;
using BoothCsvConverter.Views;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Unity;

namespace BoothCsvConverter
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        public App()
        {
            // shift-jis を使えるように
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry) { }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();
            ViewModelLocationProvider.Register<MainWindow, MainViewModel>();
        }
    }
}
