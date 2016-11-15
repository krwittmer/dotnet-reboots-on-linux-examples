#!/bin/bash
curl -sL https://deb.nodesource.com/setup_6.x | sudo bash -
sudo apt-get install nodejs
npm install -g grunt grunt-cli bower
npm install -g yo
npm install -g generator-aspnet 

mkdir -p /root/.config/configstore
chmod g+rwx /root /root/.config /root/.config/configstore

