FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ./LoginForm.API/LoginForm.API.csproj ./LoginForm.API/
RUN dotnet restore ./LoginForm.API/LoginForm.API.csproj
COPY . .
WORKDIR /src/LoginForm.API
RUN dotnet publish -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "LoginForm.API.dll"]
