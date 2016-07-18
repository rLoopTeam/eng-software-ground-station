import leftPad from 'left-pad';
import rightPad from 'right-pad';
import React from 'react';
import _ from 'underscore';
import MuiThemeProvider from 'material-ui/styles/MuiThemeProvider';
import Paper from 'material-ui/Paper';
import RaisedButton from 'material-ui/RaisedButton';
import Toggle from 'material-ui/Toggle';


import injectTapEventPlugin from 'react-tap-event-plugin';

// Needed for onTouchTap
// http://stackoverflow.com/a/34015469/988941
injectTapEventPlugin();

import parameters from '../parameters.json'

var formatNumber = (value, preDecimalLen, postDecimalLen) => {
  var str = value.toString();
  if (str.indexOf("e") !== -1) { return str } // exponent. run away.

  var parts = str.split('.');
  var hasDecimal = parts.length > 1;
  var predecimal = parts[0];
  var postdecimal = hasDecimal ? parts[1] : " ";

  return leftPad(predecimal, preDecimalLen) +
    (hasDecimal ? "." : " ") +
    rightPad(postdecimal, postDecimalLen);
}

var NodeTable = ({params, values}) =>
  <table className="raw">
    <tbody>
      {_.map(params, ([index, min, max, unit, desc]) =>
        <tr key={index}>
          <td>{index}</td>
          <td style={{textAlign: "right"}}>
            {_.has(values, index) ? formatNumber(values[index], 5, 18) : "?"}
          </td>
          <td>{unit}</td>
          <td>{desc}</td>
        </tr>
      )}
    </tbody>
  </table>;

var RawScreen = ({latestValues}) => {
  return (
	<div style={{padding: 30}}>
	  {_.map(parameters, (params, nodeName) => {
		return (
			<MuiThemeProvider>
			<Paper>
			<div key={nodeName}>

				<Paper style={{padding: 2, marginBottom: 10, marginTop: 10}}>
				<h1>{nodeName} node:</h1>
				</Paper>

				<div>
					<RaisedButton label="Flash Teensy" primary={true} style={{margin: 10}}/>
					<RaisedButton label="Update Pi" primary={true} style={{margin: 10}}/>
					<RaisedButton label="Rename Node" primary={true} style={{margin: 10}}/>
				</div>

				<div style={{width: 150}}>
						<Toggle label="Logging" style={{margin: 10}} />
				</div>
				
				<NodeTable params={params} values={latestValues[nodeName]} />
		  </div>
		  </Paper>
		  </MuiThemeProvider>
		);
	  })}
	</div>
  );
};

export default RawScreen;
