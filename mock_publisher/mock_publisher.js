var zmq = require('zmq')
var socket = zmq.socket('pub');

socket.bindSync('tcp://127.0.0.1:3000');
console.log('Publisher bound to port 3000');

var hz = 20;


// example message...
/*
{
  node: "power"
  data: [index1, value1, index2, value2, ...]
  mts: <milliseconds since unix epoch>
}
*/

var state = {
  velocity: 0 // m/s
}

setInterval(function(){
  state.velocity = (state.velocity + 1) % 155
  console.log("Publishing state", state);
  socket.send('telemetry' + ' ' + JSON.stringify(state));
}, 1000 / hz);
