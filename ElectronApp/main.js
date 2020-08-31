// https://github.com/noseratio/CompareWebViews 
// by @noseratio

'use strict';

async function main() {
  // Modules to control application life and create native browser window
  const { app, BrowserWindow, ipcMain } = require('electron');

  function createMainWindow() {
    // Create the browser window.
    const window = new BrowserWindow({ width: 1024, height: 576, center: true });

    window.loadURL("https://www.bing.com");

    return window;
  }

  // 'ready' will be fired when Electron has finished
  // initialization and is ready to create browser windows.
  // Some APIs can only be used after this event occurs.
  await new Promise(resolve => app.once('ready', resolve));

  // exit when all windows are closed and this promise is resolved
  const terminationPromise = new Promise(resolve => 
    app.once('window-all-closed', resolve));

  // create the main window
  const mainWindow = createMainWindow();

  // awaiting terminationPromise here keeps the mainWindow object alive
  await terminationPromise;

  app.exit(0);
}

main().catch(error => {
  console.error(error);
  process.exit(1);
});
