// https://github.com/noseratio/CompareWebViews 
// by @noseratio

using System.Windows;

namespace WebView2App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.WebView.Source = new System.Uri("https://www.bing.com/");
        }
    }
}
