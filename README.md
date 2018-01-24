# webapi-core-starterkit

This project intended to be a starter kit for a Asp.net Core MVC WebApi project. It will be composed by a layered architecture 
and it will have pretty much everything that you would want already set for you to start your development.

* Swashbuckle / Swagger - Providing automatic documentation for your Api
* Dependency Injection - Architecure in place to prevent developers on creating objects on their own.
* Global exception handling - Central point to handle generic exceptions
* Entity Framework + Sql Server + Migrations
* Log and Profiling - Azure Application Insights but modular to be used with any other Log tool. 
* Unit tests - Business and Data layer
* Validation - TBD

Some of the main goals of this project:

* Provide a boilerplate solution for general WebApi applications.
* Try to avoid usage of Object to Object mappings.
* Try to avoid proxy methods. Eg. Methods on the business layer that may only call the data access directly to retrieve data.
