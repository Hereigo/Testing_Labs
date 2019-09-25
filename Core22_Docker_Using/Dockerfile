FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src

# copy csproj and restore as distinct layers
COPY ["Core22_Docker_Using.csproj", "Core22_Docker_Using.csproj"]
RUN dotnet restore "Core22_Docker_Using.csproj"

COPY . .
WORKDIR "/src"
RUN dotnet build "Core22_Docker_Using.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Core22_Docker_Using.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Core22_Docker_Using.dll"]

# To build project into named container :
#
# docker build -t my_container_name .