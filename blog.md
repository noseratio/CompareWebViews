## Comparing process working sets of WebView-based Windows Desktop apps  

Let's compare the working sets of various WebView-based Windows Desktop apps. 
Each application simply loads [the Bing homepage](https://www.bing.com/).

The original source code repo is [here](https://github.com/noseratio/CompareWebViews).

|App|Working set size|
|---|----------------|
|[Legacy IE11 WebBrowser WPF](https://github.com/noseratio/CompareWebViews/tree/main/IE11WebBrowserApp)|164 MB|
|[MSEdge WebView2 WPF](https://github.com/noseratio/CompareWebViews/tree/main/WebView2App)|582 MB|
|[Chromely/CefSharp](https://github.com/noseratio/CompareWebViews/tree/main/ChromelyApp)|516 MB|
|[Electron v10](https://github.com/noseratio/CompareWebViews/tree/main/ElectronApp)|570 MB|

<hr>

A screenshot of [Process Explorer](https://docs.microsoft.com/en-us/sysinternals/downloads/process-explorer):

![WebView working memory sets](https://raw.githubusercontent.com/noseratio/CompareWebViews/main/procexp.jpg)
