import React from 'react';
import ReactDOM from 'react-dom';
import _ from 'underscore';

import parameters from '../parameters.json'

import {groupsOf} from './utils.js'
import Screen from './Screen.jsx'

console.log("parameters", parameters)

// list of all telemtry messages received
// XXX: consider how quickly this will grow in memory. likely need to prune.
var messages = [];

// latest value of each parameter for each node
// {<node name>: {<parameter index>: <value>}}
var latestValues = _.object(
  _.map(_.keys(parameters), (nodeName) => [nodeName, {}])
);

window.__debug = {messages, latestValues};

var hasRequestedRender = false;
var render = (_latestValues) => {
  ReactDOM.render(
    <Screen latestValues={_latestValues} />,
    document.getElementById('render-target')
  );
  hasRequestedRender = false;
};

render(latestValues);

// called by external parent (electron-main.js)
window.onMessage = (message) => {
  messages.push(message);
  _.each(groupsOf(message.data, 2), ([index, value]) => {
    latestValues[message.node][index] = value;
  })
  if (!hasRequestedRender) {
    window.requestAnimationFrame(_.bind(render, null, latestValues));
    hasRequestedRender = true;
  }
};
