FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine as docfx
WORKDIR /build

RUN dotnet tool update -g docfx

FROM docfx AS build
COPY ./docs .
ENV PATH=$PATH:/root/.dotnet/tools
RUN docfx build docfx.json

FROM nginx:alpine
COPY --from=build /build/_site/ /usr/share/nginx/html