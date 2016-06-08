Using the application
---------------------

Ping @RoboTeddy on Slack and he'll send you a standalone build for your OS. The rest of this document only applies if you want to work on the telemetry UI itself.

OSX dependencies for development
--------------------------------

Using homebrew, `brew install node zmq pkg-config`

Windows dependencies for development
------------------------------------

Recommended: develop on linux or osx. But if you're on Windows:

- install python2.7 (won't work with 3)
- set environment variable PYTHON=C:\path\to\python.exe
- install visual studio community 2015
  -  File -> New -> Project, select Visual C++, opt to install Windows 8.1 SDK & Common Tools for Visual C++
- install http://gnuwin32.sourceforge.net/packages/coreutils.htm (just need this for the `env` command) and add them to your PATH

Installation for development
----------------------------

To install and run the mock telemetry publisher:

```
cd mock_publisher/
npm install
npm start
```

To install the telemetry UI for development:

```
cd client/
npm install
```

After installing the telemetry UI, you can use these commands from inside `client/`:

`npm run dev` - run for development (enables livereloading, etc)

`npm start` - run as though in production

`npm run package` - build a standalone .app for running on osx, and put it in `dist/` (later, we'll build standalone linux or windows verisons)


Misc
----

If while starting the client you ever get an error about a node version mismatch, try `npm run postinstall`. It's because the node zeromq binding requires native code. For more information about this error: https://github.com/electron/electron/blob/master/docs/tutorial/using-native-node-modules.md

If you're on windows, and you get an error about loading the zmq dll, try this:
```
cd client/
rm -rf node_modules/zmq
# make sure npm_config_target matches electron-prebuilt version in package.json
# if you're on a 32 bit system, replace x64 with ia32
env npm_config_target=1.2.0 npm_config_arch=x64 npm install zmq
```


Learning Resources
------------------
React tutorial - https://facebook.github.io/react/docs/tutorial.html

If you get stuck understanding something, ping @RoboTeddy on slack and we can figure it out over chat or google hangout.

Everything inside `client/` except `electron-main.js` is written in es6 javascript. It might look a little unfamiliar if you've never seen it before. In particular, you might want to look up es6 arrow functions and destructuring.

If you're wondering what editor to use, I'd recommend https://www.sublimetext.com/ -- it lets you easily install things like jsx syntax highlighting. You can use it for free indefinitely (it just nags you a bit on startup).

Design Reference
----------------

@ilyasvali's design for the pretty UI:
![](https://raw.githubusercontent.com/RoboTeddy/rPanel/master/client/design-reference/ilyas-ui-design.jpg)


Contributing
------------

Let's use GitHub pull requests. That way I (@RoboTeddy on slack) can make sure I understand all the code going in, double-check it for bugs, etc.

A couple of people mentioned they're new to frontend development or some aspects of it -- that's great! Comments on a pull requests are a fantastic way to learn new things.

If anyone else starts contributing lots too, I'll make my changes in pull requests for them to look at as well.
