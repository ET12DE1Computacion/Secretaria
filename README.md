![.NET Core](https://github.com/ET12DE1Computacion/Secretaria/workflows/.NET%20Core/badge.svg)

# Secretaria

_Acá va un párrafo que describa lo que es el proyecto_

## Comenzando 🚀

Clonar el repositorio github, desde Github Desktop o ejecutar en la terminal o CMD:

```
git clone https://github.com/et12de1computacion/secretaria.git
```


### Pre-requisitos 📋

- Net Core 3.1.7 (SDK 3.1.401) [descarga](https://dotnet.microsoft.com/download/dotnet-core/3.1)

- Entity Framework Core 3.x, en el CMD o terminal ejecutar el siguiente comando: [ver docs](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet)
```
dotnet tool install --global dotnet-ef
```

### Instalación 🔧

Para crear las bases de datos mediante Entity Framework:

- Configurar el archivo **appsetting.json** los **connectionString** del servidor de base de datos 
- Desde el Visual Studio acceder al menu **Herramientas** -> **Gestor de Paquetes Nuget** -> **Consola de Paquetes Nuget** ejecutar los siguientes comandos:
```
dotnet ef database update --project Secretaria.FrontEnd --context SecretariaDbContext
```
```
dotnet ef database update --project Secretaria.FrontEnd --context ApplicationDbContext
```

## Despliegue 📦

_Agrega notas adicionales sobre que cosas se debe instalar, configurar y como hacer deploy_

## Construido con 🛠️

_Menciona las herramientas y versiones que utilizaste para crear tu proyecto_

* [Visual Studio](https://visualstudio.microsoft.com/es/)
* [Net Core](https://dotnet.microsoft.com/download)
* [MySql](https://dev.mysql.com/downloads/mysql/)

## Wiki 📖

Puedes encontrar mucho más de cómo utilizar este proyecto en nuestra [Wiki](https://github.com/tu/proyecto/wiki)

## Versionado 📌

Usamos [SemVer](http://semver.org/) para el versionado. Para todas las versiones disponibles, mira los [tags en este repositorio](https://github.com/tu/proyecto/tags).

## Autores ✒️

_Menciona a todos aquellos que ayudaron a levantar el proyecto desde sus inicios_

* **Max Power** - *Desarrollo* - [Maxpower](https://github.com/maxpower)
* **Cosme Fulanito** - *Documentación* - [Cosmefulanito](#Cosmefulanito)

## Licencia 📄

Este proyecto está bajo la Licencia (Tu Licencia) - mira el archivo [LICENSE.md](LICENSE.md) para detalles
