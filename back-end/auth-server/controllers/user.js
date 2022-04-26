const User = require('../models/user');


function register(req, res, next) {
    return User.create();
}

module.exports = {
    register
}