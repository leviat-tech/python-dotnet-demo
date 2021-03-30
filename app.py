import math

from flask import Flask, request

from dotnet_importer import Math

app = Flask(__name__)


@app.route("/python", methods=["GET"])
@app.route("/", methods=["GET"])
def factorial_python():
    if "n" in request.args:
        n = int(request.args["n"])
        return f"{n}-th factorial is {math.factorial(n)}"

    return default_html(request.base_url, request.args)


@app.route("/Add", methods=["GET"])
def factorial_python_ADD():
    if "a" in request.args and "b" in request.args:
        a = int(request.args["a"])
        b = int(request.args["b"])
        # Since Math.Add is not a class method it needs to be instantiated first
        math_instance = Math()
        return f"{a}+{b} = {math_instance.Add(a, b)}"

    return default_html(request.base_url, request.args)


def default_html(url, arguments):
    rendered_props = ", ".join([f"{key}: {value}" for key, value in arguments.items()])

    return f"""
    This route calculates the nth factorial.<br/>
    Input prop n to get n-th factorial. e.g. 
    <a href="{url}?n=5">
        {url}?n=5
    </a> to get 5-th factorial.
    <br/>
    Got the following props: {rendered_props}<br/>
    """
