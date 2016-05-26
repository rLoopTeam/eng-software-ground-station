module.exports = {
  entry: "./src/main.jsx",
  output: {
    path: __dirname,
    filename: "./dist/bundle.js"
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
