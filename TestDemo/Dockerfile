FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mjibrandl/dotnetcore-angular:latest AS build
WORKDIR /src
COPY ["TestDemo.csproj", "./"]
RUN dotnet restore "./TestDemo.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "TestDemo.csproj" -c Release -o /app

FROM build AS publish

RUN dotnet publish "TestDemo.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TestDemo.dll"]