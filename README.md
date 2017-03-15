# ExamenMVC
Examen Técnico Atracción de Talento Yunntech


PREREQUISITOS 
- Visual Studio 2015 Community / Visual Studio 2017 Community
- 2.MSSQL Server 2012
- 3.Install the .NET Core tools preview for Visual Studio (https://www.microsoft.com/net/core#windowsvs2015)
- 4.NET Core SDK (https://www.microsoft.com/net/core#windowscmd)
- Nota 1: Las instrucciones indican usar la unidad “C:\”, en caso de no contar con esta unidad puede usar la que tenga disponible.
- Nota 2: El ejercicio indica que se debe tener instalada la siguiente instancia de Sql Server: 
- Servidor=.\SQLExpress 
- Usuario=sa
- Contraseña=password$$1
- DB=ExamenMVC 

- INSTALACIÓN 
- 1.Descargar y descomprimir ZIP
- 2.Abrir la base de datos ExamenMVC usando el Sql Server Manahement Studio, usar las siguientes credenciales: 
- Servidor=.\SQLExpress 
- Usuario=sa 
- Contraseña=password$$1
- 3.Asegurarse que la base de datos esté limpia (sin tablas, vistas, SPs)
- 4.Abrir la Developer Command Prompt for VS2015 y cambiarse al directorio C:\ExamenMVC\src\ExamenMVC
- 5.Ejecutar el comando:  dotnet ef migrations add initial
- 6.Si el comando anterior termina correctamente, ejecutar el siguiente comando: dotnet ef database update
- 7.Al finalizar regresar al Sql Server Management Studio para validar que se hayan creado los objetos en la bases de datos
- 8.Abrir y ejecutar el proyecto
