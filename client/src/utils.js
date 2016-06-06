var lerp = (min, max, x) => min + x * (max - min)
var unlerp = (min, max, x) => (x - min) / (max - min)

var degToRad = (x) => (x - 90) * Math.PI / 180.0;

// adapted from http://stackoverflow.com/a/18473154
var fromPolar = (center, r, angle) => {
  return {
    x: center.x + (r * Math.cos(degToRad(angle))),
    y: center.y + (r * Math.sin(degToRad(angle)))
  };
}

// adapted from http://stackoverflow.com/a/18473154
var svgArc = (center, radius, startAngle, endAngle) => {
  var start = fromPolar(center, radius, endAngle);
  var end = fromPolar(center, radius, startAngle);
  var arcSweep = endAngle - startAngle <= 180 ? "0" : "1";
  var d = [
    "M", start.x, start.y, 
    "A", radius, radius, 0, arcSweep, 0, end.x, end.y
  ].join(" ");
  return d;
}

// groupsOf([1, 2, 3, 4], 2) --> [[1, 2], [3, 4]]
var groupsOf = (xs, n, step) => {
  step = step === undefined ? n : step
  if (xs.length % step !== 0) throw "uneven groups"
  var groups = [];
  for (var i = 0; i + n <= xs.length; i += step) {
    groups.push(xs.slice(i, i + n))
  }
  return groups;
}

module.exports = {fromPolar, svgArc, lerp, unlerp, groupsOf}
