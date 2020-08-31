// https://github.com/noseratio/CompareWebViews 
// by @noseratio

using Chromely.Core;
using Chromely.Core.Configuration;
using System;

namespace ChromelyApp
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var config = DefaultConfiguration.CreateForRuntimePlatform();
            config.CefDownloadOptions = new CefDownloadOptions(true, true);
            config.WindowOptions.Position = new WindowPosition(1, 2);
            config.WindowOptions.Size = new WindowSize(1024, 576);
            config.StartUrl = "https://www.bing.com";
            config.DebuggingMode = false;

            AppBuilder
               .Create()
               .UseApp<Chromely.ChromelyBasicApp>()
               .UseConfig<DefaultConfiguration>(config)
               .Build()
               .Run(args);
        }
    }
}
