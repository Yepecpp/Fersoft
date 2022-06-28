create database Fersoft;
use Fersoft;
#Nomina 
Create table N_Empresas(
ID_Emp int auto_increment primary key,
RNC nvarchar(30),
Nombre nvarchar(25) not null,
Telefono nvarchar(15)not null,
Direccion nvarchar(65)
);
Create Table N_Sucursales(
ID_Suc int auto_increment primary key,
Nombre nvarchar(25) not null,
Telefono nvarchar(15),
Direccion nvarchar(65),
Id_Emp int not null,
constraint FK_Sucursales_Empresas foreign key (Id_Emp) references N_Empresas(ID_Emp)
);
Create table N_Departamentos(
ID_Dep int primary key auto_increment,
Nombre varchar(25) not null,
Ubicacion varchar(60),
Telefono nvarchar(20),
Id_Suc int not null,
constraint FK_Departamento_Sucursales foreign key (Id_Suc) references N_Sucursales(ID_Suc)
);
Create Table N_Empleados(
ID_E int auto_increment primary key,
Cedula nvarchar(20) not null,
Nombre varchar(25) not null,
Apellido varchar (25),
Puesto nvarchar(20),
SueldoXH float,
SueldoXHE float,
Horario nvarchar(30),
Telefono nvarchar (20),
Id_Dep int not null,
constraint FK_Empleados_Departamentos foreign key (Id_Dep) references N_Departamentos (ID_Dep)
);
create table N_Usuarios(
ID_U int primary key,
Rol smallint not null,
Pass nvarchar(250) not null,
constraint Fk_Usuario_Emp foreign key (ID_U) references N_Empleados (ID_E)
);
Create table N_Jornada(
ID_Jor int auto_increment primary key,
IDE int not null,
Entrada datetime not null, 
Salida datetime,
constraint FK_Jornada_Empleados foreign key (IDE) references N_Empleados (ID_E)
);
Create table N_Nomina (
Id_Nom int auto_increment primary key,
Id_E int not null,
Fecha datetime not null,
Horas int,
Total_Salario float,
D_SGS float,
IRS float,
S_Neto float,
Estado_Pago varchar(10) not null,
constraint FK_Nomina_Empleado foreign key (Id_E) references N_Empleados (ID_E)
);
#views 
create or replace view N_V_EmpED as 
select  E.ID_E, E.Cedula,E.Nombre, E.Apellido,E.Puesto,E.SueldoXH,E.SueldoXHE,E.Horario,E.Telefono,E.Id_Dep,
D.Nombre as Nom_Dep,S.Nombre as Nom_Suc,Emp.Nombre as Nom_Emp
from N_Empleados E inner join N_Departamentos D on E.Id_Dep=D.ID_Dep inner join N_Sucursales S on S.ID_Suc=D.Id_Suc  inner join N_Empresas Emp on Emp.ID_Emp=S.Id_Emp;

create or replace view V_N_Nomina as 
select Id_Nom,Nom.Id_E, E.Nombre, E.Apellido,E.Cedula, E.Puesto,E.SueldoXH,E.SueldoXHE, Nom.Fecha,Nom.Horas,Nom.Total_Salario,Nom.D_SGS,
Nom.IRS,Nom.S_Neto,Nom.Estado_Pago from N_Nomina Nom inner join N_Empleados E on E.ID_E=Nom.Id_E;


# proveedores y inventario
Create table PI_Almacenes(
ID_Al int auto_increment primary key,
Id_suc int,
Nombre nvarchar(25) not null,
Telefono nvarchar(20),
Ubicacion nvarchar(60),
Horario_Disp nvarchar(10)
);
Create Table PI_Proveedores (
ID_PRV int auto_increment primary key,
Nombre varchar (30) not null,
Telefonos nvarchar(50),
Email nvarchar(30),
Nombre_Agente varchar(25)
);

Create Table PI_Productos(
Id_P int auto_increment primary key,
Nombre_Producto nvarchar(30) not null,
Marca_Producto nvarchar(30),
Precio_V float,
#Stock int,
Id_Prv int not null,
#UltimoRestock datetime,
Categoria nvarchar (12),
Id_Al int not null,
Referencia_Ubi nvarchar(60),
constraint FK_Inventario_Proveedores foreign key (Id_Prv) references PI_Proveedores (ID_PRV),
constraint FK_Inventario_Almacenes foreign key (Id_Al) references PI_Almacenes (ID_Al)
);
#Facturas
Create table F_Clientes(
ID_Cl int auto_increment primary key,
Cedula nvarchar(20),
RNC nvarchar(20),
Nombre nvarchar (20)not null,
Apellido varchar (25),
Telefono nvarchar(18),
Ubicacion nvarchar(60)not null,
Email nvarchar(50)
);
Create Table F_Facturas(
Id_F int auto_increment primary key,
Id_Cliente int not null,
MontoTotal float,
TotalItbs float,
Fecha_emitida datetime,
Id_U int,
constraint FK_Facturas_Usuario foreign key (Id_U) references N_Usuarios (ID_U),
constraint FK_Facturas_Cliente foreign key (Id_Cliente) references F_Clientes (ID_Cl)
);

Create table F_Ventas (
Id_P int not null, 
Total_V int, 
Id_factura int not null,
constraint FK_Ventas_Inventario foreign key (Id_P) references PI_productos (Id_P),
constraint FK_Ventas_Factura foreign key (Id_Factura) references F_Facturas (Id_F)
);

