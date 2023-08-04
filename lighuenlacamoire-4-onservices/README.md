# Proceso de archivo de texto
El proyecto presenta las siguientes cualidades:

* [API RESTful](https://docs.microsoft.com/en-us/azure/architecture/best-practices/api-design) para exponer los servicios de la aplicación.
* Documentación basada en [OpenAPI 3.0](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-6.0&tabs=visual-studio).

### Contenido

- **API**: expone los servicios de aplicación implementando el diseño REST. Esta capa expone las funcionalidades/recursos implementados en la capa "Application".
- **Domain**: contiene los objetos del domino que modelan los datos y lógica requeridos por el negocio.

### Ejecucion y Prueba
Simplemente levantar el proyecto y se abrira swagger hay solo un endpoint el cual solicita seleccionar un archivo para subir y realizar el proceso:
> NOTA: Se adjunta un [Archivo de texto](/reporte.txt) utilizado para las pruebas el cual posee el formato deseado.
>
