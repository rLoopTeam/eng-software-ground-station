var zmq = require('zmq')
var socket = zmq.socket('pub');

socket.bindSync('tcp://127.0.0.1:3000');
console.log('Publisher bound to port 3000');

// example message...
/*
{
  node: "power"
  data: [index1, value1, index2, value2, ...]
  mts: <milliseconds since unix epoch>
}
*/

var state = {
  seq: 0,
  he1tmp: 30,
  he1current: 8,
  speed: 0
};

var nextState = function (_state) {
  return {
    seq: (_state.seq + 1) % 500,
    he1temp: _state.he1tmp + (Math.random() - 0.5),
    he1current: _state.he1current + (Math.random() - 0.5)/10,
    speed: (_state.speed + 4) % 500
  }
}

var hz = 5;

setInterval(function() {
  var msg = {
    node: "command",
    data: [1, state.seq, 3, state.he1tmp, 11, state.he1current, 55, state.speed]
  }
  state = nextState(state);
  console.log("Publishing msg", msg);
  socket.send('telemetry' + ' ' + JSON.stringify(msg));
}, 1000 / hz);
