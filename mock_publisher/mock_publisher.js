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
  0: 0, // seq
  3: 30, // temp
  27: 8, // current
};

var nextState = function (_state) {
  return {
    0: (_state[0] + 1) % 500,
    3: _state[3] + (Math.random() - 0.5),
    27: _state[27] + (Math.random() - 0.5)/10,
  }
}

var hz = 5;

setInterval(function() {
  var msg = {
    node: "command",
    data: [0, state[0], 3, state[3], 27, state[27]],
    mts: Date.now()
  }
  state = nextState(state);
  console.log("Publishing msg", msg);
  socket.send('telemetry' + ' ' + JSON.stringify(msg));
}, 1000 / hz);
