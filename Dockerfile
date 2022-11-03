FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /home

# copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# copy everything else and build app
COPY ./ ./
RUN dotnet publish -c Release -o target

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /home
COPY --from=build /home/target .
RUN ls
ENTRYPOINT ["dotnet", "personaapi-dotnet.dll"]
