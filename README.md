# ExamenMVC
Examen Técnico Atracción de Talento Yunntech

ASP.NET Core Web Application in C# using jQuery, Boostrap and AngularJS, Entity Framework Code First

PREREQUISITOS 
- Visual Studio 2015 Community / Visual Studio 2017 Community
- MSSQL Server 2012
- Install the .NET Core tools preview for Visual Studio (https://www.microsoft.com/net/core#windowsvs2015)
- NET Core SDK (https://www.microsoft.com/net/core#windowscmd)

Nota 1: Las instrucciones indican usar la unidad “C:\”, en caso de no contar con esta unidad puede usar la que tenga disponible.

Nota 2: El ejercicio indica que se debe tener instalada la siguiente instancia de Sql Server: 

- Servidor=.\SQLExpress 
- Usuario=sa
- Contraseña=password$$1
- DB=ExamenMVC 

INSTALACIÓN 
- Asegurarse que la base de datos esté limpia (sin tablas, vistas, SPs)
- Abrir la Developer Command Prompt for VS2015 y cambiarse al directorio C:\ExamenMVC\src\ExamenMVC
- Ejecutar el comando:  dotnet ef migrations add initial
- Si el comando anterior termina correctamente, ejecutar el siguiente comando: dotnet ef database update
- Al finalizar regresar al Sql Server Management Studio para validar que se hayan creado los objetos en la bases de datos
- Abrir y ejecutar el proyecto
