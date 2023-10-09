FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/be/SearchService/Microblog.SearchService.Presentation/Microblog.SearchService.Presentation.csproj", "src/be/SearchService/Microblog.SearchService.Presentation/"]
RUN dotnet restore "src/be/SearchService/Microblog.SearchService.Presentation/Microblog.SearchService.Presentation.csproj"
COPY . .
WORKDIR "/src/src/be/SearchService/Microblog.SearchService.Presentation"
RUN dotnet build "Microblog.SearchService.Presentation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Microblog.SearchService.Presentation.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Microblog.SearchService.Presentation.dll"]
