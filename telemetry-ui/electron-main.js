var electron = require('electron');
var zmq = require('zmq');

var app = electron.app;

// user configuration
// app.getPath(userData)
var defaultEndpoint = 'tcp://127.0.0.1:3000';

var mainWindow; // single main window


function createWindow () {
  mainWindow = new electron.BrowserWindow({width: 1280, height: 800})

  var isDev = process.env.ENV === "dev" 
  console.log("Running in", isDev ? "dev" : "prod")

  var url = isDev ?
    'http://localhost:8080/electron-main.html' :
    'file://' + __dirname + '/electron-main.html';

  mainWindow.loadURL(url);

  if (isDev) {
    mainWindow.webContents.on('did-fail-load', function (event, code, desc) {
      if (code == -102) {
        // connection refused-- webpack-dev-server might not be up yet; retry
        console.log("Waiting for webpack-dev-server...");
        setTimeout(function () { mainWindow.loadURL(url)}, 100);
      }
    });
  }

  if (isDev) {
    mainWindow.webContents.openDevTools();
  }

  mainWindow.on('closed', function () {
    mainWindow = null;
  })
}

// This method will be called when Electron has finished
// initialization and is ready to create browser windows.
// Some APIs can only be used after this event occurs.
app.on('ready', createWindow)

// Quit when all windows are closed.
app.on('window-all-closed', function () {
  // On OS X it is common for applications and their menu bar
  // to stay active until the user quits explicitly with Cmd + Q
  if (process.platform !== 'darwin') {
    app.quit()
  }
})

app.on('activate', function () {
  // On OS X it's common to re-create a window in the app when the
  // dock icon is clicked and there are no other windows open.
  if (mainWindow === null) {
    createWindow()
  }
})


// Relay messages into render process ------------------------------------------

var socket; // single global socket at a time, for now

var connect = function (endpoint) {
  if (socket) {
    socket.disconnect();
  }
  socket = zmq.socket('sub');
  socket.connect(endpoint);
  socket.subscribe('telemetry');
  console.log('Listening for zmq publisher at', endpoint);

  socket.on('message', function(msg) {
    var parts = msg.toString().split(' ');
    parts.shift() // remove topic
    var message = JSON.parse(parts.join(' '));
    //console.log(message);

    if (mainWindow) {
      // guard against the case where onMessage doesn't exist yet
      mainWindow.webContents.executeJavaScript(
        "window.onMessage && window.onMessage("+JSON.stringify(message)+")")
    }
  });
}

connect(defaultEndpoint);
