import math

from flask import Flask, request, url_for

from dotnet_importer import dot_net_math

app = Flask(__name__)


@app.route('/python', methods=["GET"])
@app.route('/', methods=["GET"])
def factorial_python():
    if "n" in request.args:
        n = int(request.args["n"])
        return f"{n}-th factorial is {math.factorial(n)}"

    return default_html(request.base_url, request.args)


@app.route('/dot-net', methods=["GET"])
def factorial_dot_net():

    if "n" in request.args:
        n = int(request.args["n"])
        return f"{n}-th factorial is {int(dot_net_math.Factorial(n))}"

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
