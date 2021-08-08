FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 81
EXPOSE 5005

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Leave.Api/Leave.Api.csproj", "Leave.Api/"]
RUN dotnet restore "Leave.Api/Leave.Api.csproj"
COPY . .
WORKDIR "/src/Leave.Api"
RUN dotnet build "Leave.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Leave.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Leave.Api.dll"]
