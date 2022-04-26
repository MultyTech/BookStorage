const express = require('express');
const cookieParser = require('cookieParser');
const cookieSecret = process.env.COOKIESECRET || 'suPeRSeCR3t';

module.exports = (app) => {
    app.use(express.json());
    app.use(cookieParser(cookieSecret));
    app.use(express.static(path.resolve(__basedir, 'static')))
}