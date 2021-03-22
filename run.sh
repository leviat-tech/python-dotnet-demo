#!/bin/bash

source .venv/bin/activate
export FLASK_ENV=development
export FLASK_app=app.py
flask run