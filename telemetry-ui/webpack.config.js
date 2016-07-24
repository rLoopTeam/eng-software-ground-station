
module.exports = {
  entry: "./src/main.jsx",
  target: 'electron',
  output: {
    path: __dirname,
    filename: "./renderer-bundle.js"
  },
  module: {
    loaders: [
      {
        test: /\.jsx?$/,
        exclude: /node_modules/,
        loader: 'babel',
        query: {
          presets: ['react', 'es2015']
        }
      },
	  {
        test: /\.scss$/,
        loaders: ["style", "css", "sass"]
      },
      {
        test: /\.ttf$/,
        loader: 'url',
        query: {
          mimetype: 'application/x-font-ttf'
        }
      },
      {test: /\.json$/, loader: "json"},
      {test: /\.css$/, loader: "style!css"}
    ]
  }
};
