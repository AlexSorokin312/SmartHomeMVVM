using System.Windows;
using SmartHomeMVVM.Stores;
using SmartHomeMVVM.ViewModels;
namespace SmartHomeMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            NavigationStore navigationStore = new NavigationStore();
           // navigationStore.CurrentViewModel = new CameraViewModel(navigationStore);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }

    }
}
