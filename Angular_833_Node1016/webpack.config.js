const path = require('path');
const webpack = require('webpack');

module.exports = {
    entry: {
        'polyfills': './src/polyfills.ts',
        'app': './src/main.ts'
    },
    output: {
        path: path.resolve(__dirname, './public'), // output dir
        publicPath: '/public/',
        filename: "[name].js" // output file name
    },
    resolve: {
        extensions: ['.ts', '.js']
    },
    module: {
        rules: [ // Webpack doesn't know how to load .ts files - here are special loaders.
            {
                test: /\.ts$/,
                use: [{
                        loader: 'awesome-typescript-loader',
                        options: {
                            configFileName: path.resolve(__dirname, 'tsconfig.json')
                        }
                    },
                    'angular2-template-loader'
                ]
            }
        ]
    },
    plugins: [
        new webpack.ContextReplacementPlugin( // help to define correct path in different OSs
            /angular(\\|\/)core/,
            path.resolve(__dirname, 'src'), // source dir for income files
            {} // routes map here
        )
    ]
}