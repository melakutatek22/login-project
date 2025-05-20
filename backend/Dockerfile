# Dockerfile (inside /backend)

# Set up the SDK image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# Correct relative path inside build context
COPY ./LoginForm.API/LoginForm.API.csproj ./LoginForm.API/
RUN dotnet restore ./LoginForm.API/LoginForm.API.csproj

# Copy all source files
COPY . .

# Build and publish
WORKDIR /src/LoginForm.API
RUN dotnet build -c Release -o /app/build
RUN dotnet publish -c Release -o /app/publish

# Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "LoginForm.API.dll"]
