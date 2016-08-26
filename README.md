# Yaasync
Synchronization tool for No Man's Sky PC
http://qjimbo.co/yaasync

# What is complete
* Program engine (MVC+Unity Services Code Structure)
* OpenGL hook screenshot engine (needs to be updated to x64)
* API pinging/screenshot-upload and API URL management.
* Auto updating

# TO-DO
* Finding RAM Address/Pointers/Functions to load data from the game while it is running
* OpenGL capture needs to be updated from 32 bit to 64 bit. This is currently using juce's engine with the source available here: https://github.com/juce/taksi/tree/opengl-only

# Overview
Yaasync is named after the planet Yaasrij featured heavily in the early demos of No Man's Sky. It will allow users of the PC version of the game to synchronize their galactic and planet surface position with any server on the internet via an open API. What's more, is it also allows screenshot capturing, stamps the coordinate information in the image, and can also upload screenshots via the same API.

I'm hoping this will be the defacto way that people can share their discoveries and track each others movement in the game. It features auto-updating so we can keep it up to date with each new patch and release.

I'm looking to the community to help with this project - thanks!

# API
GET: http://address/?action=availableactions&amp;key=&lt;key&gt;

Return CSV: syncposition,syncscreens

GET: http://address/?action=syncposition&amp;key=&lt;key&gt;&amp;galaxy=&lt;galaxy&gt;&amp;system=&lt;system&gt;&amp;planet=&lt;planet&gt;&amp;gX=&lt;galaxy x&gt;&amp;gY=&lt;galaxy y&gt;&amp;gZ=&lt;galaxy z&gt;&amp;sX=&lt;surface x&gt;&amp;sY=&lt;surface y&gt;&amp;sZ=&lt;surface z&gt;

URL is pinged every minute from app.

GET: http://address/?action=syncscreenshot&amp;key=&lt;key&gt;&amp;screenshotid=&lt;screenshotid&gt;&amp;galaxy=&lt;galaxy&gt;&amp;system=&lt;system&gt;&amp;planet=&lt;planet&gt;&amp;gX=&lt;galaxy x&gt;&amp;gY=&lt;galaxy y&gt;&amp;gZ=&lt;galaxy z&gt;&amp;sX=&lt;surface x&gt;&amp;sY=&lt;surface y&gt;&amp;sZ=&lt;surface z&gt;

POST: PNG Format screenshot

Screenshot ID: &lt;Unix Timestamp&gt;-&lt;GUID&gt;
