using Avalonia.Controls;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Markup.Xaml.Styling;
using Avalonia.Styling;
namespace AvaloniaApplication3.Views
{
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {
            InitializeComponent();

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            pageContainer = this.FindControl<ContentControl>("pageContainer");

            // ѕо умолчанию устанавливаем первую страницу
            //ShowPage(new StartPage());
        }
        private void ShowPage(Control page)
        {
            pageContainer.Content = page;
        }

        private void HoverItem(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {

            var item = (TextBlock)sender;




        }
        private void Theme(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {


            if (Application.Current.RequestedThemeVariant == ThemeVariant.Dark)
            {
                Application.Current.RequestedThemeVariant = ThemeVariant.Light;


            }
            else
            {
                Application.Current.RequestedThemeVariant = ThemeVariant.Dark;

            }


        }

        private void SwitchPage(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            ShowPage(new StartPage());
        }
    }
}
