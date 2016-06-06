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
  1: 0, // seq
  3: 30, // temp
  11: 8, // current
  55: 0 // speed
};

var nextState = function (_state) {
  return {
    1: (_state[1] + 1) % 500,
    3: _state[3] + (Math.random() - 0.5),
    11: _state[11] + (Math.random() - 0.5)/10,
    55: (_state[55] + 4) % 500
  }
}

var hz = 5;

setInterval(function() {
  var msg = {
    node: "command",
    data: [1, state[1], 3, state[3], 11, state[11], 55, state[55]],
    mts: Date.now()
  }
  state = nextState(state);
  console.log("Publishing msg", msg);
  socket.send('telemetry' + ' ' + JSON.stringify(msg));
}, 1000 / hz);
