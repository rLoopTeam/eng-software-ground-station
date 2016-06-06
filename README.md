Installation
------------

Requirements:
- nodejs -- if on osx using homebrew, `brew install node`
- libzmq -- if on osx using homebrew, `brew install zmq`

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


Learning Resources
------------------
React tutorial - https://facebook.github.io/react/docs/tutorial.html

If you get stuck understanding something, ping @RoboTeddy on slack and we can figure it out over chat or google hangout.

Everything inside `client/` except `electron-main.js` is written in es6 javascript. It might look a little unfamiliar if you've never seen it before. In particular, you might want to look up es6 arrow functions and destructuring.


Contributing
------------

Let's use GitHub pull requests. That way I (@RoboTeddy on slack) can make sure I understand all the code going in, double-check it for bugs, etc.

A couple of people mentioned they're new to frontend development or some aspects of it -- that's great! Comments on a pull requests are a fantastic way to learn new things.

If anyone else starts contributing lots too, I'll make my changes in pull requests for them to look at as well.
