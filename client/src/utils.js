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

module.exports = {fromPolar, svgArc, lerp, unlerp}
