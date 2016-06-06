import React from 'react';

import Highcharts = from 'highcharts/highstock';

var TimeChart = React.createClass({
  getInitialState: () => {
    // the number of values that have been added to the chart so far
    return {renderedLength: null}, 
  },
  render: () => {
    // hmm, just return a div with the chart here...
    return <div>{JSON.stringify(this.props.values)}</div>;
  },
  componentDidUpdate: () => {
    // componentDidUpdate isn't called after the initial render
    this.setState({renderedLength: this.props.values.length})
  }
});

export default TimeChart;
