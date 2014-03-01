Katana
======

This is a OWIN test project. For now it runs static files, Web Api and SignalR.

For running on Heroku do the following:
. Create Heroku account and install tools
. Git clone this repository
. Build the project
. navigate prompt to directory with file 'Procfile'
. Enter command: 'heroku create'
. Enter command: 'heroku config:add BUILDPACK_URL=https://github.com/friism/heroku-buildpack-mono/'
. Enter command: 'git push heroku master'
. Enter command: 'heroku open'

You should see now the default page (index.html) with links to Web Api and SignalR.