FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["EP.DotsBoxes.Web/EP.DotsBoxes.Web.csproj", "EP.DotsBoxes.Web/"]
COPY ["EP.DotsBoxes.Logic/EP.DotsBoxes.Logic.csproj", "EP.DotsBoxes.Logic/"]
COPY ["EP.DotsBoxes.Data/EP.DotsBoxes.Data.csproj", "EP.DotsBoxes.Data/"]
RUN dotnet restore "EP.DotsBoxes.Web/EP.DotsBoxes.Web.csproj"
COPY . .
WORKDIR "/src/EP.DotsBoxes.Web"
RUN dotnet build "EP.DotsBoxes.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "EP.DotsBoxes.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "EP.DotsBoxes.Web.dll"]
