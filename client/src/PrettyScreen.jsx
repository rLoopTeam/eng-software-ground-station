import React from 'react'

import Gauge from './Gauge.jsx';
//import TimeChart from './TimeChart.jsx'

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
    <div style={{padding: 30, backgroundColor: "#2d343e",
                 position: "absolute", left:0,top:0,bottom:0,right:0}}>
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

export default PrettyScreen;
