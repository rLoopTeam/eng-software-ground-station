var electron = require('electron');
var app = electron.app;

var mainWindow;

function createWindow () {
  mainWindow = new electron.BrowserWindow({width: 1280, height: 800})
  console.log("Running in", process.env.ENV === "dev" ? "dev" : "prod")
  mainWindow.loadURL(
    process.env.ENV === "dev" ?
      'http://localhost:8080/electron-main.html' :
      'file://' + __dirname + '/electron-main.html');
  mainWindow.webContents.openDevTools()

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

var zmq = require('zmq');
var socket = zmq.socket('sub');

socket.connect('tcp://127.0.0.1:3000');
socket.subscribe('telemetry');
console.log('Listening for zmq publisher on port 3000');

socket.on('message', function(msg) {
  var parts = msg.toString().split(' ', 2)
  var message = JSON.parse(parts[1]);
  //console.log(message);

  if (mainWindow) {
    // guard against the case where onMessage doesn't exist yet
    mainWindow.webContents.executeJavaScript(
      "window.onMessage && window.onMessage("+JSON.stringify(message)+")")
  }
});
