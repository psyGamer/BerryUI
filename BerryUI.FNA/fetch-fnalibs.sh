#!/usr/bin/env sh

curl https://nightly.link/FNA-XNA/fnalibs-dailies/workflows/ci/main/fnalibs.zip --location --output fnalibs-win-linux.zip
curl https://nightly.link/FNA-XNA/fnalibs-dailies/workflows/ci/main/fnalibs-apple.zip --location --output fnalibs-osx.zip

unzip fnalibs-win-linux.zip -d fnalibs-win-linux
unzip fnalibs-osx.zip -d fnalibs-osx

rm -rf runtimes
mkdir -p runtimes/win-x86 runtimes/win-x64 runtimes/linux-x64 runtimes/osx-x64

cp -r fnalibs-win-linux/x86 runtimes/win-x86/native
cp -r fnalibs-win-linux/x64 runtimes/win-x64/native
cp -r fnalibs-win-linux/lib64 runtimes/linux-x64/native
cp -r fnalibs-osx/osx runtimes/osx-x64/native

rm -rf fnalibs-win-linux.zip fnalibs-win-linux
rm -rf fnalibs-osx.zip fnalibs-osx 
