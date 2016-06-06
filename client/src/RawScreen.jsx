import leftPad from 'left-pad';
import rightPad from 'right-pad';
import React from 'react';
import _ from 'underscore';

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
          <div key={nodeName}>
            <h1>{nodeName} node:</h1>
            <NodeTable params={params} values={latestValues[nodeName]} />
          </div>
        );
      })}
    </div>
  );
};

export default RawScreen;
