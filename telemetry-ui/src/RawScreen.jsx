import leftPad from 'left-pad';
import rightPad from 'right-pad';
import React from 'react';
import _ from 'underscore';
import ReactDOM from 'react-dom';
import 'grommet/grommet.min.css';
import Meter from 'grommet/components/Meter';
import Box from 'grommet/components/Box';
import Footer from 'grommet/components/Footer';
import Button from 'grommet/components/Button';
import Tabs from 'grommet/components/Tabs';
import Tab from 'grommet/components/Tab';
import Menu from 'grommet/components/Menu';


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

var NodeTable = ({params, values, nodeName}) =>
  <table className="raw" key={nodeName}>
    <tbody key={{nodeName}+"d"}>
      {_.map(params, ([index, min, max, unit, desc]) =>
        <tr key={index}>
          <td key={{index}+"a"}>{index}</td>
          <td style={{textAlign: "right"}} key={index}>
            {_.has(values, index) ? formatNumber(values[index], 5, 18) : "?"}
          </td>
		<td key={{index}+"b"}>{unit}</td>
          <td key={{index}+"c"}>{desc}</td>
        </tr>
      )}
    </tbody>
  </table>;
  
var dataDivStyle = {
	position: 'relative',
	top: 20,
	bottom: 0,
	overflowY: 'scroll',
	padding: 30,
	border: '2px solid black',
	borderRadius: "10px",
	height: "700px"
};



var RawScreen = React.createClass({
	
	doNothing: function() {
		const { dialog } = require('electron').remote;
		dialog.showOpenDialog(function (fileNames) {
			if (fileNames === undefined) return;
			var file = fileNames[0];
			var client = require('scp2');
			client.scp(file, 'root:MoreCowbell@192.168.0.200:/', function(err) {});
		});
	},
	handleFile: function(e) {
		
	},
	
	render: function () {

		return (
		<div style={{padding: 30}}>
		<Button label="Program Teensy" onClick={this.doNothing}/>
		<Tabs justify="start">
			  {_.map(parameters, (params, nodeName) => {
				return (
					<Tab title={nodeName}>
						<div>

							<div style={{padding:5}}/>
							<Button label="Rename Node" onClick={this.doNothing}/>
							<div key={nodeName} style={dataDivStyle}>
								<NodeTable params={params} values={this.props.latestValues[nodeName]} nodeName={nodeName} />
							</div>
						</div>
					</Tab>
				);
			  })}
		  </Tabs>
		</div>
		);
	}
});

export default RawScreen;
