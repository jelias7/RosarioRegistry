Create Database RosarioRegister
GO
Use RosarioRegister
GO
Create Table Usuarios(
UsuarioID int primary key identity,
Nombres varchar(30),
Email varchar(30),
NivelUsuario varchar(30),
Usuario varchar(30),
FechaIngreso DateTime,
Clave int
);

Create Table Cargos(
CargoID int primary key identity,
Descripcion varchar(50)
);