#!/bin/bash
su -c 'yum update'
sudo yum install unzip yum-utils automake libtool wget libunwind libuv
curl -sSL https://raw.githubusercontent.com/dotnet/cli/rel/1.0.0-preview1/scripts/obtain/dotnet-install.sh | bash /dev/stdin --version 1.0.0-preview1-002702 --install-dir ~/dotnet
sudo ln -s ~/dotnet/dotnet /usr/local/bin
