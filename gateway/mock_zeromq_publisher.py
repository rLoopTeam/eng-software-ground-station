#!/usr/bin/env python

import json
import random
import sys
import time

import zmq

ZMQ_PORT = 5556
ZMQ_TOPIC = "telemetry"

context = zmq.Context()
socket = context.socket(zmq.PUB)
socket.bind("tcp://*:%s" % ZMQ_PORT)

hz = 20
state = {
  "velocity": 0 # m/s
}
max_velocity = 155
while True:
    state["velocity"] = (state["velocity"] + 1) % max_velocity
    print("Producing state", state)
    socket.send(("%s %s" % (ZMQ_TOPIC, json.dumps(state))).encode('utf-8'))
    time.sleep(1 / hz)
