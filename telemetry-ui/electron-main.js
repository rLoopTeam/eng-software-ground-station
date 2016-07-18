var electron = require('electron');
var zmq = require('zmq');

var app = electron.app;

// user configuration
// app.getPath(userData)


var mainWindow; // single main window
var activeIPs = [];


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

var zmq = require('zmq');
var socket = zmq.socket('sub');

socket.connect('tcp://192.168.0.200:3000');
socket.subscribe('telemetry');
console.log('Listening for zmq publisher on port 3000');

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

//Looks for an ip in the activeIPs array
function hasIP(ip) {
	for(var i  = 0; i < activeIPs.length;i++) {
		if( activeIPs[i][0] == ip){
			return true;
		}
	}
	return false;
}


//Looks at the latest timestamps of data received from the activeIPs
//and tries to reconnect if it's been a few seconds since we last heard from it
function hostTimeoutCheck()
{
	var time = new Date().getTime();
	for(var i  = 0; i < activeIPs.length;i++) {
		if( (time - activeIPs[i][1]) > 3000){
			console.log('Lost connection with '+activeIPs[i][0])
			activeIPs[i][1] = activeIPs.splice(i,1);
			i = 0;
		}
	}
}

const dgram = require('dgram')
const server = dgram.createSocket('udp4');

server.on('error', (err) => {
	console.log(`server error:\n${err.stack}`);
	server.close();
});

//TODO: look for rPod text at beginning of frame
server.on('message', (msg, rinfo) => {
	//console.log(`Beacon from ${rinfo.address}`);
	if ( hasIP(`${rinfo.address}`) == false ){
		console.log('tcp://'+`${rinfo.address}`+':3000');
		socket.connect('tcp://'+`${rinfo.address}`+':3000');
		socket.subscribe('telemetry');
		console.log('Subscribing to Pi');
		activeIPs.push([`${rinfo.address}`,new Date().getTime()]);
	}else{
		for(var i  = 0; i < activeIPs.length;i++) {
			if( activeIPs[i][0] == `${rinfo.address}`){
				activeIPs[i][1]= new Date().getTime();
			}
		}
	}
});

server.on('listening', () => {
	var address = server.address();
	console.log(`server listening ${address.address}:${address.port}`);

		
});

var os = require('os');
var ifaces = os.networkInterfaces();

Object.keys(ifaces).forEach(function (ifname) {
  var alias = 0;

  ifaces[ifname].forEach(function (iface) {
    if ('IPv4' !== iface.family || iface.internal !== false) {
      // skip over internal (i.e. 127.0.0.1) and non-ipv4 addresses
      return;
    }

    if (alias >= 1) {
      // this single interface has multiple ipv4 addresses
      console.log(ifname + ':' + alias, iface.address);
    } else {
      // this interface has only one ipv4 adress
      console.log(ifname, iface.address);
	  	server.bind(50051, iface.address, function () {
			server.setBroadcast(true);
			server.addMembership('239.3.14.159');
		});
    }
    ++alias;
  });
});

//Auto reconnect if a client stops sending data
setInterval(hostTimeoutCheck, 3000);
