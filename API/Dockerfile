# Build for testing on local machine
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build

WORKDIR /app

COPY . ./
RUN dotnet publish API/API.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app

COPY --from=build /app/out . 

ENTRYPOINT ["dotnet", "API.dll"]