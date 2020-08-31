## Comparing process working sets of various WebView-based Windows Desktop apps

Let's comparing the working sets of various WebView-based Windows Desktop apps. 

Each application simply loads [Bing home page](https://www.bing.com/).

|App|Working set size|
|---|----------------|
|[Legacy IE11 WebBrowser WPF](./IE11WebBrowserApp)|164 MB|
|[MSEdge WebView2 WPF](./WebView2App)|582 MB|
|[Chromely/CefSharp](./ChromelyApp)|516 MB|
|[Electron v10](./ElectronApp)|570 MB|

<hr>

A screenshot of [Process Explorer](https://docs.microsoft.com/en-us/sysinternals/downloads/process-explorer):

![WebView working memory sets](procexp.jpg)
