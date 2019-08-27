const path = require("path");
const webpack = require('webpack');
const UglifyJsPlugin = require('uglifyjs-webpack-plugin');
const TerserJSPlugin = require('terser-webpack-plugin');
const MiniCssExtractPlugin = require('mini-css-extract-plugin');
const OptimizeCSSAssetsPlugin = require('optimize-css-assets-webpack-plugin');
const { CleanWebpackPlugin } = require('clean-webpack-plugin');

const config = {
    entry: {
        index: ['./js/index.js', './scss/index.scss'],
        home: ['./scss/views/home.scss'],
        article: ['./scss/views/article.scss'],
        article_list: ['./scss/views/article-list.scss'],
        hero: ['./scss/views/partials/hero.scss'],
        nav: ['./scss/views/partials/nav.scss'],
        footer: ['./scss/views/partials/footer.scss']
    },
    output: {
        filename: '[name].js',
        path: path.resolve(__dirname, "./dist")
    },
    module: {
        rules: [
            {
                test: /\.js$/,
                exclude: /node_modules/,
                use: {
                    loader: "babel-loader"
                }
            },
            {
                test: /\.scss$/,
                use: [
                    //"style-loader",
                    MiniCssExtractPlugin.loader,
                    "css-loader",
                    "sass-loader"
                ]
            }
        ]
    },
    optimization: {
        minimizer: [
            new TerserJSPlugin({}),
            new OptimizeCSSAssetsPlugin({})]
    },
    plugins: [
        new CleanWebpackPlugin(),
        new UglifyJsPlugin(),
        new MiniCssExtractPlugin({
            // all options are optional
            filename: '[name].css',
            ignoreOrder: false // Enable to remove warnings about conflicting order
        }),
        new webpack.ProvidePlugin({
            $: "jquery",
            jQuery: "jquery",
            "window.$": "jquery",
            "window.jQuery": "jquery"
        })
    ]
};

module.exports = config;