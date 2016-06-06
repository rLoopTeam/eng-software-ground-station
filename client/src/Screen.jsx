import React from 'react';
import _ from 'underscore';

import Gauge from './Gauge.jsx';
//import TimeChart from './TimeChart.jsx'

require('./main.css');

var RawScreen = (state) => {
  return <div>I am the raw ui</div>
};

var Panel = ({title, children}) =>
  <div style={{width: 300, minHeight: 200, borderTop: "1px solid #545F6E"}}>
    <h1 style={{color: "#676F7F", fontSize: 9, lineHeight: "9px",
                marginTop: 6, fontFamily: 'Gotham Book'}}>
      {title.toUpperCase()}
    </h1>
    {children}
 </div>;

var PrettyScreen = ({latestValues}) => {
  return (
    <div style={{padding: 30}}>
      <Panel title="Speedometer">
        <div style={{textAlign: "center", marginTop: 20}}>
          <Gauge
            innerRadius={60} outterRadius={100} arcSpan={250}
            value={latestValues.command[55] === undefined ?
                    null : latestValues.command[55]}
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
    </div>
  );
}

var screens = [RawScreen, PrettyScreen]
var Screen = React.createClass({
  // props: latestValues
  getInitialState () {
    return {SelectedScreen: RawScreen}
  },
  toggle () {
    this.setState({
      SelectedScreen: _.first(_.without(screens, this.state.SelectedScreen))
    });
  },
  render () {
    var SelectedScreen = this.state.SelectedScreen;
    return (
      <div>
        <a href="#" onClick={this.toggle}>toggle screen</a>
        <SelectedScreen latestValues={this.props.latestValues} />
      </div>
    );
  }
});

module.exports = Screen;
