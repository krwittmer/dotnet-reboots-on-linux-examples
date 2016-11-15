FROM microsoft/dotnet:latest

# Set ASP.NET Core environment variables
ENV ASPNETCORE_URLS="http://*:5000"

COPY . /app

WORKDIR /app

RUN ["dotnet", "restore"]

RUN ["dotnet", "build"]

EXPOSE 5000/tcp

ENTRYPOINT ["dotnet", "run"]

