# python-dotnet-demo

The contents of this repository are written partially in Python and partially in C#. 
Both of this languages can be run in Linux, Windows or MacOS environments. The same is 
true when combining them. However, the resulting API will be deployed on Linux-based 
machines in production. To have the best development experience, it is thus *strongly 
suggested* to run them in a Linux-like environment. Under Windows, this would mean 
installing a WSL (Windows subsystem for Linux) or a virtual machine. 

All of the instructions in this readme are written for a Linux-like environment.

## Linux-like environment on Windows

To create a Linux-like environment in Windows, you can follow steps in 

(https://docs.microsoft.com/en-us/windows/wsl/install-win10)

Alternatively, you can install the Linux in a virtual machine on Windows.

### Getting this repository

Use GIT to clone this repository and enter the directory.

```bash
git clone https://github.com/leviat-tech/python-dotnet-demo
cd python-dotnet-demo
```

### Add and install .NET dependencies

The below installation is specific for Ubuntu 20.04, taken from 
(https://docs.microsoft.com/en-au/dotnet/core/install/linux-ubuntu#2004-). 
Consult detailed instructions for other each major supported distributions at
(https://docs.microsoft.com/en-au/dotnet/core/install/linux).

```bash
wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
sudo apt update
sudo apt install apt-transport-https
sudo apt update
sudo apt install dotnet-sdk-5.0
```

### Install libraries and prerequesites

```bash
sudo apt update
sudo apt install build-essentials python3-dev python3-venv python3-pip
```

### Setting up Python virtualenv

```bash
python3 -m venv .venv
source .venv/bin/activate
pip install wheel
pip install -r requirements.txt
```

## Building C# project dll

```bash
dotnet publish MathDemoSrc/MathDemo --configuration Release --self-contained
```

## Running server

```bash
./run.sh
```
