# python-dotnet-demo

## Install

This repository is intended to be built in Ubuntu 20.04 LTS. Different distributions/version might
differ slightly in the installation of Mono dependancies. Consult 
(https://www.mono-project.com/download/stable/#download-lin) for details.

### Add Dotnet dependencies

```
sudo apt install gnupg ca-certificates
sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
echo "deb https://download.mono-project.com/repo/ubuntu stable-focal main" | sudo tee /etc/apt/sources.list.d/mono-official-stable.list
```

### Install libraries and prerequesites

```
sudo apt update
sudo apt install clang libglib2.0-dev python3-dev mono-devel
```

### Setting up Python virtualenv

```
python3 -m venv .venv
source .venv/bin/activate
pip install wheel
pip install -r requirements.txt
```

## Building C# dll

```
csc Math.cs -t:library
```

## Running server

```
./run.sh
```
