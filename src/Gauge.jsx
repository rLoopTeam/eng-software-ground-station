import React from 'react';
import _ from 'underscore';
import {lerp, unlerp, fromPolar, svgArc} from './utils.js'

var Light = ({pos}) =>
  <g>
    <defs>
      <radialGradient id="lightGlow">
        <stop offset="0%" stopColor="#F2A20A" stopOpacity="0.15" />
        <stop offset="100%" stopColor="#F2A20A" stopOpacity="0" />
      </radialGradient>
    </defs>
    <circle cx={pos.x} cy={pos.y} r="2" fill="#F2A20A" />
    <circle cx={pos.x} cy={pos.y} r="35" fill="url(#lightGlow)" />
  </g>;

var Gauge = ({value, minValue, maxValue, arcSpan, majorTickStep,
                    minorTickStep, outterRadius, innerRadius,
                    minorTickLen, majorTickLen}) => {
  var center = {x: outterRadius, y: outterRadius}
  var valueToAngle = (v) =>
    lerp(-arcSpan / 2, arcSpan / 2, unlerp(minValue, maxValue, v));

  var ticks = ({step, radius, length, opacity}) => {
    return _.range(minValue, maxValue + 1, step).map((v) => {
      var theta = valueToAngle(v)
      var p1 = fromPolar(center, radius, theta)
      var p2 = fromPolar(center, radius + length, theta)
      return <line x1={p1.x} y1={p1.y} x2={p2.x} y2={p2.y} key={v}
                   stroke="white" strokeOpacity={opacity} strokeWidth="1" />
    })
  }

  var labels = (step, radius) => {
    return _.range(minValue, maxValue +1, step).map((v) => {
      var p = fromPolar(center, radius, valueToAngle(v));
      return <text x={p.x} y={p.y} fill="white" key={v}
                   textAnchor="middle" alignmentBaseline="central"
                   fontSize="7" fontFamily="Gotham Light">{v}</text>;
    })
  }

  return (
    <svg width={outterRadius*2} height={outterRadius*2}>
      <path d={svgArc(center, innerRadius,
                      valueToAngle(minValue), valueToAngle(maxValue))}
            stroke="white" strokeOpacity={0.3} fill="none" />
      {ticks({step: majorTickStep,
              radius: outterRadius - majorTickLen,
              length: majorTickLen, opacity: 1})}
      {ticks({step: minorTickStep,
              radius: outterRadius - majorTickLen,
              length: minorTickLen, opacity: 0.3})}
      {labels(majorTickStep, outterRadius - majorTickLen - 11)}
      <text textAnchor="middle" x={center.x} y={center.y} fill="white"
            fontSize="26" fontFamily="Gotham Medium">
        {value.toFixed(1)}
      </text>
      <text textAnchor="middle" x={center.x} y={center.y + 25} fill="white"
            fontSize="16" fontFamily="Gotham Light">
        km/h
      </text>
      <Light pos={fromPolar(center, innerRadius, valueToAngle(value))} />
    </svg>
  );
}

module.exports = Gauge;
