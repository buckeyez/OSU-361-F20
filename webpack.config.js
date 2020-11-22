const path = require('path');
const VueLoaderPlugin = require('vue-loader/lib/plugin');
const { SourceMapDevToolPlugin } = require('webpack');

module.exports = {
  mode: 'development',
  entry: {
    main: './Client-App/main.js',
  },
  output: {
    path: path.join(__dirname, 'wwwroot/dist'),
    filename: 'bundle.js',
    publicPath: '/dist/',
  },
  module: {
    rules: [
      {
        test: /\.js$/,
        enforce: 'pre',
        use: ['source-map-loader'],
      },
      {
        test: /\.vue$/,
        loader: 'vue-loader',
      },
      {
        test: /\.css$/,
        use: ['style-loader', 'css-loader'],
      },
      {
        test: /\.mp4$/,
        use: {
          loader: 'file-loader',
          options: {
            name: '[name].[ext]',
          },
        },
      },
    ],
  },
  plugins: [new VueLoaderPlugin(), new SourceMapDevToolPlugin({ filename: '[file].map' })],
};
