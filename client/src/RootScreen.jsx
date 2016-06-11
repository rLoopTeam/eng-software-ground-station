import React from 'react';
import _ from 'underscore';

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
        <a href="#" onClick={this.toggle}
           style={{position: 'fixed', right: 20, bottom: 20, zIndex: 2}}>
          toggle screen
        </a>
        <Screen latestValues={this.props.latestValues} />
      </div>
    );
  }
});

export default RootScreen;
