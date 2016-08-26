# Yaasync
Synchronization tool for No Man's Sky PC
http://qjimbo.co/yaasync

# What is complete
* Auto updating
* Program engine (MVC+Unity Services Code Structure)
* Screenshot engine (needs to be updated to x64)
* API upload and URL management.

# TO-DO
* Finding RAM Address/Pointers/Functions to load data from games
* OpenGL capture needs to be updated from 32 bit to 64 bit. This is currently using juce's engine with the source available here: https://github.com/juce/taksi/tree/opengl-only

# Overview
Yaasync is named after the planet Yaasrij featured heavily in the early demos of No Man's Sky. It will allow users of the PC version of the game to synchronize their galactic and planet surface position with any server on the internet via an open API. What's more, is it also allows screenshot capturing, stamps the coordinate information in the image, and can also upload screenshots via the same API.

I'm hoping this will be the defacto way that people can share their discoveries and track each others movement in the game. It features auto-updating so we can keep it up to date with each new patch and release.

I'm looking to the community to help with this project - thanks!

# API
GET: http://address/?action=availableactions&key=<key>
Return CSV: syncposition,syncscreens

GET: http://address/?action=syncposition&key=<key>&galaxy=<galaxy>&system=<system>&planet=<planet>&gX=<galaxy x>&gY=<galaxy y>&gZ=<galaxy z>&sX=<surface x>&sY=<surface y>&sZ=<surface z>
URL is pinged every minute from app.

GET: http://address/?action=syncscreenshot&key=<key>&screenshotid=<screenshotid>&galaxy=<galaxy>&system=<system>&planet=<planet>&gX=<galaxy x>&gY=<galaxy y>&gZ=<galaxy z>&sX=<surface x>&sY=<surface y>&sZ=<surface z>
POST: PNG Format screenshot
Screenshot ID: <Unix Timestamp>-<GUID>
