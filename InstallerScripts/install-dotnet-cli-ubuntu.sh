#!/bin/bash
sudo apt-get install -y curl gettext libunwind8
curl -sSL https://raw.githubusercontent.com/dotnet/cli/rel/1.0.0-preview1/scripts/obtain/dotnet-install.sh > dotnet-install.sh && chmod a+x dotnet-install.sh
source dotnet-install.sh --version 1.0.0-preview1-002702 --install-dir /usr/local/bin
