heroku create
heroku config:add BUILDPACK_URL=https://github.com/friism/heroku-buildpack-mono/
git push heroku master