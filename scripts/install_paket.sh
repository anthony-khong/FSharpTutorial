#! /bin/bash

mkdir -p .paket
curl -L https://github.com/fsprojects/Paket/releases/download/5.194.0/paket.bootstrapper.exe -o .paket/paket.bootstrapper.exe
mono .paket/paket.bootstrapper.exe
echo ".paket/paket.exe" >> .gitignore
echo ".packages" >> .gitignore
mono .paket/paket.exe install
