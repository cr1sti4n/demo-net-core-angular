# TestDemo
Este proyecto esta realizco con tecnologia netcore 2.2 integrado Angular version 8

# Docker
Se implmento docker, se usa la imagen microsoft/dotnet:2.2-aspnetcore-runtime, el cual tiene todos los requerimientos para desplegar el app

Se integro docker compose, para integrar el app con sql server

# WCF
Se implemento un proyecto WCF para exponer los servicios

# Bd
La base de dstos es SQL Server, la cual esta alojada en un servicio Azure

# Nota
Actualmente el proyecto esta usando la conexion a base de datos Azure, si desea iniciarlo con una base de dartos en docker, utilize docker compose

# Deploy Azure
Para visualizar el proyecto ingresar : http://netcoreangulardemo.westus2.azurecontainer.io/


# Intrucciones
Para compilar el app front :
1. Ejecute: docker build -t testdemoimage1 .
2. Para poder ver la imagen ejecute: docker run -it --rm -p 3000:80 --name testdemoimagecontainer testdemoimage1
3. Si desea iniciar el proyecto con docker compose (App net core, Sql Server), ejecute : docker-compose build
4. DEspues del build ejecute: docker-compose up

