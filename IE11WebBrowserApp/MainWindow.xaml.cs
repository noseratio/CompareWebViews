// https://github.com/noseratio/CompareWebViews 
// by @noseratio

using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Navigation;

namespace IE11WebBrowserApp
{
    public partial class MainWindow : Window
    {
        static MainWindow()
        {
            SetBrowserCompatibilityMode();
        }

        public MainWindow()
        {
            this.InitializeComponent();
            this.Loaded += MainWindow_Loaded;
            this.WebBrowserView.LoadCompleted += WebBrowserView_LoadCompleted;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.WebBrowserView.Navigate(new Uri("https://www.bing.com").AbsoluteUri);
        }

        void WebBrowserView_LoadCompleted(object sender, NavigationEventArgs e)
        {
            this.WebBrowserView.Focus();
            this.WebBrowserView.InvokeScript("focus");
        }

        static void SetBrowserCompatibilityMode()
        {
            // https://stackoverflow.com/a/18333982

            // FeatureControl settings are per-process
            var fileName = Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName);

            if (String.Compare(fileName, "devenv.exe", true) == 0) // make sure we're not running inside Visual Studio
                return;

            using (var key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION",
                RegistryKeyPermissionCheck.ReadWriteSubTree))
            {
                // Webpages containing standards-based !DOCTYPE directives are displayed in IE11 Standards mode.
                UInt32 mode = 11000; 
                key.SetValue(fileName, mode, RegistryValueKind.DWord);
            }

            using (var key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_NINPUT_LEGACYMODE",
                RegistryKeyPermissionCheck.ReadWriteSubTree))
            {
                // disable Legacy Input Model
                UInt32 mode = 0;
                key.SetValue(fileName, mode, RegistryValueKind.DWord);
            }
        }
    }
}
