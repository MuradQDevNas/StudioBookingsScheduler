#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p 9afe87e8-8c96-411e-bf1e-eb47870aa664 -t
    fi
    cd ../
fi

docker-compose up -d
