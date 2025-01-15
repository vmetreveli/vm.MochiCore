FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/vm.MochiCore.Api/vm.MochiCore.Api.csproj", "src/vm.MochiCore.Api/"]
COPY ["src/vm.MochiCore.Application/vm.MochiCore.Application.csproj", "src/vm.MochiCore.Application/"]
COPY ["src/vm.MochiCore.Domain/vm.MochiCore.Domain.csproj", "src/vm.MochiCore.Domain/"]
COPY ["src/Framework/Framework.Infrastructure/Framework.Infrastructure.csproj", "src/Framework/Framework.Infrastructure/"]
COPY ["src/Framework/Framework.Abstractions/Framework.Abstractions.csproj", "src/Framework/Framework.Abstractions/"]
COPY ["src/Infrastructure/vm.MochiCore.Infrastructure/vm.MochiCore.Infrastructure.csproj", "src/Infrastructure/vm.MochiCore.Infrastructure/"]
RUN dotnet restore "src/vm.MochiCore.Api/vm.MochiCore.Api.csproj"
COPY . .
WORKDIR "/src/src/vm.MochiCore.Api"
RUN dotnet build "vm.MochiCore.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "vm.MochiCore.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "vm.MochiCore.Api.dll"]
