#!/bin/bash 
sudo dnf install -y libunwind libicu 
curl -sSL -o dotnet.tar.gz https://go.microsoft.com/fwlink/?LinkID=816869 
sudo mkdir -p /opt/dotnet && sudo tar zxf dotnet.tar.gz -C /opt/dotnet 
sudo ln -s /opt/dotnet/dotnet /usr/local/bin 
 
curl -sSL -o code.el7.x86_64.rpm https://go.microsoft.com/fwlink/?LinkID=760867 
sudo dnf install -y code.el7.x86_64.rpm
