# Base de Datos
El proyecto presenta las siguientes cualidades:

* Arquitectura [Domain-Driven Design (DDD)](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/ddd-oriented-microservice).
* [API RESTful](https://docs.microsoft.com/en-us/azure/architecture/best-practices/api-design) para exponer los servicios de la aplicación.
* Base de datos SQL Server:
  * Patrón de diseño: [Unit Of Work](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/infrastructure-persistence-layer-implementation-entity-framework-core)
* Documentación basada en [OpenAPI 3.0](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-6.0&tabs=visual-studio).

### Contenido

- **API**: expone los servicios de aplicación implementando el diseño REST. Esta capa expone las funcionalidades/recursos implementados en la capa "Application".
- **Services**: expone las funcionalidades/recursos que se consumen a través de endpoints en la capa "API". Interactúa con la capa de "Infrastructure" y con los objetos de la capa "Domain", orquestando las tareas necesarias para el manejo de la base de datos.
- **Infrastructure**: implementa las capacidades técnicas requeridas por las capas "Services" y "Domain". Por ejemplo, la implementación de persistencia para la base de datos.
- **Domain**: contiene los objetos del domino que modelan los datos y lógica requeridos por el negocio.

> NOTA: Como ORM se ha utilizado [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) con un enfoque "InMemory" para el modelado del dominio y posterior generación automática del esquema de base de datos, por lo tanto, los objetos del dominio implementan atributos y validaciones para asegurar la correctitud y consistencia de los datos.
>


### Ejecucion y Prueba
Simplemente levantar el proyecto y se abrira swagger hay solo un endpoint el cual devuelve el resultado de la query:
> NOTA: Como fue mencionado previamente, la base de datos se configuro como "InMemory", por lo cual no es necesario levantar un motor de base de datos o correr algun script, solo levantar el proyecto alcanza.
>
