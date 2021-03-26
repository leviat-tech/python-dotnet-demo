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

## Install

This repository is intended to be built in Ubuntu 20.04 LTS. Different distributions/version might
differ slightly in the installation of Mono dependancies. Consult 
(https://www.mono-project.com/download/stable/#download-lin) for details.

### Getting this repository

Use GIT to clone this repository and enter the directory.

```bash
git clone https://github.com/leviat-tech/python-dotnet-demo
cd python-dotnet-demo
```

### Add Dotnet dependencies

```bash
sudo apt install gnupg ca-certificates
sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
echo "deb https://download.mono-project.com/repo/ubuntu stable-focal main" | sudo tee /etc/apt/sources.list.d/mono-official-stable.list
```

### Install libraries and prerequesites

```bash
sudo apt update
sudo apt install clang libglib2.0-dev python3-dev python3-venv python3-pip mono-devel
```

### Setting up Python virtualenv

```bash
python3 -m venv .venv
source .venv/bin/activate
pip install wheel
pip install -r requirements.txt
```

## Building C# dll

```bash
csc Math.cs -t:library
```

## Running server

```bash
./run.sh
```
