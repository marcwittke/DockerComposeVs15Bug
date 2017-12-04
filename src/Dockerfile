FROM microsoft/aspnetcore-build:2.0
COPY . /app
WORKDIR /app/WebApplication5
RUN ["dotnet", "restore"]

WORKDIR /app/WebApplication5
RUN ["dotnet", "build"]

EXPOSE 80/tcp
ENTRYPOINT ["dotnet", "run"]