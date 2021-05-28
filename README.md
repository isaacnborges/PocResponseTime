# Poc - ResponseTime

This is a sample project that demonstrates how to log a response time on console.

This project use [Stopwatch](https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch?view=net-5.0) to calculate how long the request took.

## Dependencies 

- [Docker](https://docs.docker.com/get-docker/)

## Run locally
- ### Running the API 

1. After cloning this repository go into the directory and run `docker-compose up`.

## Debug 

- [Visual Studio](https://docs.microsoft.com/en-us/visualstudio/containers/edit-and-refresh?view=vs-2019)
- [Visual Studio Code](https://code.visualstudio.com/docs/containers/debug-netcore)

## Informations

This repositores consists in two simple API that communicate each other with http protocols.

1. Products.Api - An Api that provide some products to be consumed.

2. ResponseMiddleware.Api - An api that consume Products.Api via http protocol.

## Response time

The project ResponseMiddleware.Api log two diferente response time.
- The first one log all the requests using a `ResponseTimeMiddleware`;
- The second response time log only the requests that are consumed using a specific HttpClient, `ProductApiClient`.