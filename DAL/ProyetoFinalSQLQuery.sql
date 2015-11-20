Create DataBase BillEasyDb

use BillEasyDb

Create Table Clientes(
ClienteId Int Identity Primary Key,
CiudadId Int References Ciudades(CiudadId),
Nombres Varchar(50),
Apellidos Varchar(50),
Telefono Varchar(14),
Celular Varchar(12),
Direccion Varchar(150),
Email Varchar(100),
Cedula Varchar(13)
)
Select Count(Nombre) from Ciudades
select *from Clientes
drop table Clientes

Insert into Usuarios(NombreUsuario,Contrasena) Values('Anthony','Anthony2424')
select *from Usuarios
drop table Usuarios

Create Table Usuarios(
UsuarioId Int Identity Primary Key,
Nombres Varchar(50),
NombreUsuario Varchar(50),
Contrasena Varchar(40),
Area Varchar(100),
Fecha varchar(10)
)
Create Table Ventas(
VentaId Int Identity Primary Key,
UsuarioId Int References Usuarios(UsuarioId),
ClienteId Int References Clientes(ClienteId),
Fecha Varchar(10),
ITBIS Float,
Descuentos Float,
TipoVentas Varchar(9),
NFC Varchar(20),
TipoNFC Varchar(20),
Total Float
)
drop Table Ventas

Create Table Compras(
CompraId Int Identity Primary Key,
ProveedorId Int References Proveedores(ProveedorId),
Fecha Varchar(10),
Cantidad Int,
TipoCompra Varchar(9),
NFC Varchar(20),
TipoDeComprovanteFiscal Varchar(20),
Flete Float,
Monto Float
)

Create Table Productos(
ProductoId Int Identity Primary Key,
ProveedorId Int References Proveedores(ProveedorId),
MarcaId Int References Marcas(MarcaId),
Nombre Varchar(50),
Cantidad Int,
Precio Float,
Costo Float,
ITBIS Float
)
select *from Productos


Create Table Proveedores(
ProveedorId Int Identity Primary Key,
NombreEmpresa Varchar(70),
Direccion Varchar(150),
Telefono Varchar(12),
Email Varchar(50),
CiudadId Int References Ciudades(CiudadId),
RNC Varchar(20),
NombreRepresentante Varchar(50),
Celular Varchar(12)
)

Create Table DetallesVentas(
VentaId Int References Ventas(VentaId),
UsuarioId Int References Usuarios(UsuarioId),
ClienteId int references Clientes(ClienteId),
ProductoId int references Productos(ProductoId),
Cantidad Int,
Precio Float
)
drop table DetallesVentas

Create Table DetallesCompras(
CompraId Int Identity Primary Key,
ProductoId Int References Productos(ProductoId),
UsuarioId Int References Usuarios(UsuarioId),
Costo Float
)

Create Table Marcas(
MarcaId Int Identity Primary Key,
Nombre Varchar (50)
)

Create Table Ciudades(
CiudadId Int Identity Primary Key,
Nombre Varchar(50),
CodigoPostal int,
)