import React from 'react';
import ReactDOM from 'react-dom';
import ReconnectingWebSocket from 'reconnectingwebsocket';
import _ from 'underscore';

import Gauge from './Gauge.jsx'

//import TimeChart from './TimeChart.jsx'

require('./main.css');

var Panel = ({title, children}) =>
  <div style={{width: 300, minHeight: 200, borderTop: "1px solid #545F6E"}}>
    <h1 style={{color: "#676F7F", fontSize: 9, lineHeight: "9px",
                marginTop: 6, fontFamily: 'Gotham Book'}}>
      {title.toUpperCase()}
    </h1>
    {children}
 </div>;

var render = (state) => {
  ReactDOM.render(
    <div style={{padding: 30}}>
      <Panel title="Speedometer">
        <div style={{textAlign: "center", marginTop: 20}}>
          <Gauge
            innerRadius={60} outterRadius={100} arcSpan={250}
            value={state.velocity === null ?
                    null : state.velocity * 60 * 60 / 1000}
            minValue={0} maxValue={800}
            units="km/h"
            majorTickStep={100} minorTickStep={20}
            majorTickLen={10} minorTickLen={5} />
        </div>
      </Panel>
      <Panel title="Temperature">
        {/*<TimeChart values={state.temperatures} />*/}
      </Panel>
      <Panel title="Cooling">
      </Panel>
    </div>,
    document.getElementById('render-target')
  );
};

var state = {
  velocity: null, // Number in m/s, or null if not known
  temperatures: [[Date.now(), 30]] // [[millisecondTimestamp, centigrade], ...]
};

render(state);


var socket = new ReconnectingWebSocket(
  "ws://localhost:8765",
  null,
  {reconnectInterval: 100, maxReconnectInterval: 1000}
);

socket.onopen = (event) => {
  console.log("websocket established");
};

socket.onmessage = (event) => {
  var state = JSON.parse(event.data);
  render(state)
}


// Animation for demo ----------------------------------------------------------


/*
var acceleration = 10; // m/s^2
var maxVelocity = 155; // m/s
var temperatureHz = 3;

var lastUpdate = Date.now();
window.requestAnimationFrame(function tick () {
  state.velocity = Math.min(
    state.velocity + acceleration * (Date.now() - lastUpdate) / 1000,
    maxVelocity);

  var [lastTempertureMts, lastTemperatureValue] = _.last(state.temperatures);
  if (Date.now() - _.last(state.temperatures)[0] > 1000 / temperatureHz) {
    state.temperatures.push(
      [Date.now(), lastTemperatureValue + _.random(-200, 300)/100]
    );
  }

  render(state);
  lastUpdate = Date.now();
  window.requestAnimationFrame(tick);
});
*/