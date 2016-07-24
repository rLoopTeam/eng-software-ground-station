import React from 'react';
import _ from 'underscore';
import ReactDOM from 'react-dom';
import 'grommet/grommet.min.css';
import Meter from 'grommet/components/Meter';
import Box from 'grommet/components/Box';
import Footer from 'grommet/components/Footer';
import Tabs from 'grommet/components/Tabs';
import Tab from 'grommet/components/Tab';

import PrettyScreen from './PrettyScreen.jsx';
import RawScreen from './RawScreen.jsx';

require('./main.css');

var screens = [RawScreen, PrettyScreen]
var RootScreen = React.createClass({
  // props: latestValues
  getInitialState () {
    return {Screen: RawScreen}
  },
  toggle () {
    this.setState({
      Screen: _.first(_.without(screens, this.state.Screen))
    });
  },
  render () {
    var Screen = this.state.Screen;
    return (
      <div>
		<Tabs id='topTabs' initialIndex={2}>
			<Tab  title="Overview">
				<PrettyScreen latestValues={this.props.latestValues} />
			</Tab>
			<Tab title="Data Logging">
			</Tab>
			<Tab title="Raw Data">
				<RawScreen latestValues={this.props.latestValues} />
			</Tab>
			<Tab title="Network Status">
			</Tab>
		</Tabs>
      </div>
    );
  }
});

export default RootScreen;
