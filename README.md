# VehicleWebApi
This project is a proof of concept to demonstrate a .NET Core(2.2) WebApi implementation approach. 

The aim is to create an API endpoint having a scalable/extendable server side backbone. The project is using an in-memory database, generated and processed through Entity Framework Core. 

###### Stracture:
To satisfy the separation of concern principle, I split the solution in a main project that holds the API end points and two other library classes one for the Data Access Layer (DAL) and the other to hold the Data Transfer Objects (DTOs).

###### Features:
__Dipendency Injection:__ I follow dipendency injection to create loosly coupled classes. That way, the system is easier to be extended and maintained and easier to be tested as well.

__Base Generic Repository:__ The individual repositories that are serving the database requests, inherit the capabilities of a base generic repository. That way, avoid code duplications for the common CRUD operations.

__Mapping:__ I am using automapper to map entity models to Dtos and vice versa - avoiding to exposing the entity models to the client.
