import React from 'react';
import ReactDOM from 'react-dom';

import Gauge from './Gauge.jsx'

require('./main.css');

var Panel = ({title, children}) =>
  <div style={{width: 300, borderTop: "1px solid #545F6E"}}>
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
            value={state.velocity * 60 * 60 / 1000} minValue={0} maxValue={800}
            units="km/h"
            majorTickStep={100} minorTickStep={20}
            majorTickLen={10} minorTickLen={5} />
        </div>
      </Panel>
      <Panel title="Cooling">
      </Panel>
    </div>,
    document.getElementById('render-target')
  );
};

// animation fo show
var acceleration = 10; // m/s^2
var maxVelocity = 155; // m/s

var state = {velocity: 0}; // m/s

var lastUpdate = Date.now();
window.requestAnimationFrame(function tick () {
  state.velocity = Math.min(
    state.velocity + acceleration * (Date.now() - lastUpdate) / 1000,
    maxVelocity);
  lastUpdate = Date.now();
  render(state);
  window.requestAnimationFrame(tick);
});
