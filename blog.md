## Comparing working memory sets of various WebView-based Windows Desktop apps  

The original source code repo is [here](https://github.com/noseratio/CompareWebViews). Each application simply loads [Bing home page](https://www.bing.com/):

|App|Working set size|
|---|----------------|
|[Legacy IE11 WebBrowser WPF](https://github.com/noseratio/CompareWebViews/tree/main/IE11WebBrowserApp)|164MB|
|[MSEdge WebView2 WPF](https://github.com/noseratio/CompareWebViews/tree/main/WebView2App)|582MB|
|[Chromely/CefSharp](https://github.com/noseratio/CompareWebViews/tree/main/ChromelyApp)|516MB|
|[Electron v10](https://github.com/noseratio/CompareWebViews/tree/main/ElectronApp)|570MB|

<hr>

A screenshot of [Process Explorer](https://docs.microsoft.com/en-us/sysinternals/downloads/process-explorer):

![WebView working memory sets](https://raw.githubusercontent.com/noseratio/CompareWebViews/main/procexp.jpg)
