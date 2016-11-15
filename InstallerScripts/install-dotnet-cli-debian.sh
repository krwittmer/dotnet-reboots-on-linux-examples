#!/bin/bash
sudo apt-get -y update
sudo apt-get -y install libicu gettext curl unzip automake libtool wget libunwind libuv
curl -sSL https://raw.githubusercontent.com/dotnet/cli/rel/1.0.0-preview1/scripts/obtain/dotnet-install.sh > dotnet-install.sh
source dotnet-install --version 1.0.0-preview1-002702 --install-dir ~/dotnet
sudo ln -s ~/dotnet/dotnet /usr/local/bin
