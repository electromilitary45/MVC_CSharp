----CREACION DATABASE
Create Database CRUDPRACTICA
go

Drop Database CRUDPRACTICA
go

use CRUDPRACTICA
go

----------------------TABLAS---------------------------
Create table Usuario(
id int identity(1,1) primary key, 
nombre varchar(50) not null,
apellido varchar(50) not null,
usuario varchar(50) not null,
correo varchar(255) not null,
contrasena varchar(255) not null,
);

------------------CONSULTAS-------------------------
select * from Usuario
go

