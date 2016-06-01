#!/usr/bin/env python

import asyncio
import logging
import sys

import websockets
import zmq
import zmq.asyncio

WS_PORT = 8765
ZMQ_URL = "tcp://localhost:5556"
ZMQ_TOPIC = "telemetry"

logging.getLogger().setLevel(logging.DEBUG)

# use zmq_poll, which is like poll except also supports zmq sockets
loop = zmq.asyncio.ZMQEventLoop() 
asyncio.set_event_loop(loop) 

ctx = zmq.asyncio.Context()
zmqsocket = ctx.socket(zmq.SUB)
zmqsocket.connect(ZMQ_URL)
zmqsocket.setsockopt_string(zmq.SUBSCRIBE, ZMQ_TOPIC)

connected_websockets = set()

async def handler(websocket, path):
    logging.info("New client connected")
    connected_websockets.add(websocket)
    # when this function returns, the server closes the websocket.
    # so, don't return until the client disconnects
    while websocket.open:
        await asyncio.sleep(1)
    logging.info("Client disconnected (1)")
    connected_websockets.discard(websocket)

async def send(websocket, msg):
    try:
        await websocket.send(msg)
        logging.debug("Relayed %s", msg)
    except websockets.exceptions.ConnectionClosed:
        logging.info("Client disconnected (2)")
        connected_websockets.discard(websocket)

async def relay():
  logging.info("Ready to relay")
  while True:
      msg = await zmqsocket.recv()
      topic, body = msg.decode('utf-8').split(' ', 1)
      logging.debug("Received message to relay %s", body)
      for websocket in connected_websockets:
          asyncio.ensure_future(send(websocket, body))

start_server = websockets.serve(handler, 'localhost', WS_PORT)

asyncio.get_event_loop().run_until_complete(start_server)
asyncio.get_event_loop().run_until_complete(relay())
asyncio.get_event_loop().run_forever()
