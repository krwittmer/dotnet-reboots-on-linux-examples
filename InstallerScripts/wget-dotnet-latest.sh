#!/bin/bash
sudo apt-get update
sudo apt-get -y upgrade
sudo apt-get -y install curl cmake llvm-3.6 clang-3.5 lldb-3.6 lldb-3.6-dev libunwind8 libunwind8-dev gettext libicu-dev liblttng-ust-dev libcurl4-openssl-dev libssl-dev uuid-dev make cmake automake libtool zlib1g
echo "deb http://llvm.org/apt/trusty/ llvm-toolchain-trusty-3.6 main" | sudo tee /etc/apt/sources.list.d/llvm.list; wget -O - http://llvm.org/apt/llvm-snapshot.gpg.key | sudo apt-key add -; sudo apt-get update; sudo apt-get -y install liblldb-3.6

wget https://dotnetcli.blob.core.windows.net/dotnet/preview/Installers/Latest/dotnet-host-ubuntu-x64.latest.deb
wget https://dotnetcli.blob.core.windows.net/dotnet/preview/Installers/Latest/dotnet-sharedframework-ubuntu-x64.latest.deb
wget https://dotnetcli.blob.core.windows.net/dotnet/preview/Installers/Latest/dotnet-hostfxr-ubuntu-x64.latest.deb
wget https://dotnetcli.blob.core.windows.net/dotnet/preview/Installers/Latest/dotnet-sdk-ubuntu-x64.latest.deb

dpkg -i dotnet-host-ubuntu-x64.latest.deb; dpkg -i dotnet-sharedframework-ubuntu-x64.latest.deb; dpkg -i dotnet-hostfxr-ubuntu-x64.latest.deb; dpkg -i dotnet-sdk-ubuntu-x64.latest.deb
