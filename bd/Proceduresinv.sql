Use Fersoft;
insert into pi_proveedores values(null, 'lacasa','+18494011362','jhijiedi.com','Jhonny Marten');
insert into pi_almacenes values(null, 1, 'k','54645','yug','hhhh');
insert into pi_productos values (null, 'Aserin','toyota',200,1,'Lavar',1,'En el baño');
-- values
delimiter go
drop procedure IF exists SP_PS go
create procedure SP_PS (nomb nvarchar(30)) 
begin
if nomb = '0' THEN
SELECT *
FROM pi_proveedores;
    ELSE SELECT *
FROM pi_proveedores
WHERE ID_PRV LIKE concat(nomb,'%')
        OR Telefonos LIKE concat(nomb,'%')
        OR Email LIKE concat(nomb,'%')
        OR Nombre_Agente LIKE concat(nomb,'%')
        OR Nombre_Agente LIKE concat(nomb,'%');
end if; end
go
-- Insert 
drop procedure IF exists SP_PI go
create procedure SP_PI (nombreS nvarchar(25),
        TelefS nvarchar(25),
        EmailS nvarchar(25),
        AgenteS nvarchar(25) ) begin insert into pi_proveedores values (null,
         nombreS,
         TelefS,
         EmailS,
        AgenteS);SELECT last_insert_id()
FROM pi_proveedores;
end go
-- Update 
drop procedure IF exists SP_PU go
create procedure SP_PU (id int ,
        nombreS nvarchar(25),
        TelefS nvarchar(25),
        EmailS nvarchar(25),
        AgenteS nvarchar(25),
        idprv int) begin
        UPDATE pi_proveedores SET Nombre=nombreS,
         Telefonos = TelefS,
         Email = EmailS,
         Nombre_Agente=AgenteS,
            Id_Prv=idprv
WHERE Id_P=id;
    END go
-- end provedores
-- Inventario;
delimiter go
drop procedure IF exists SP_PiS go
create procedure SP_PiS (nomb nvarchar(30)) 
begin
if nomb='0' THEN
SELECT *
FROM pi_productos;
    ELSE SELECT *
FROM pi_productos P
INNER JOIN pi_almacenes Al
    ON P.Id_Al = Al.ID_Al
WHERE P.Id_P LIKE concat(nomb,'%')
        OR concat(P.Nombre_Producto,' ',P.Marca_Producto) LIKE concat(nomb,'%')
        OR P.Marca_Producto LIKE concat(nomb,'%')
        OR P.Precio_V LIKE concat(nomb,'%')
        OR P.`Categoria` LIKE concat(nomb,'%')
        OR Al.Nombre LIKE concat(nomb,'%');
end if;
end go
-- insert 
drop procedure IF exists SP_PiI go
create procedure SP_PiI (Nomb nvarchar(30),
Marca nvarchar(30),
    Precio float,
    idprv int,
    Cat nvarchar(30),
    idal int ,
    ubi nvarchar(60)) 
begin 
insert into pi_productos values (null, Nomb, Marca, Precio, idprv, Cat, idal, ubi);
SELECT last_insert_id()
FROM pi_productos;
end  go
-- update 
delimiter go
drop procedure IF exists SP_PiU go
create procedure SP_PiU (id int, Nomb nvarchar(30),Marca nvarchar(30), Precio float, idprv int, Cat nvarchar(30), idal int , ubi nvarchar(60)) begin
UPDATE pi_productos SET Nombre_Producto=Nomb,
         Marca_Producto=Marca,
         Precio_V=Precio,
         Id_Prv=idprv,
         `Categoria`=Cat,
         Id_Al=idal,
        Referencia_Ubi=ubi
WHERE Id_P=id;
end 
-- Cliente TABLE
-- select TABLE
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
delimiter go
drop procedure IF exists SP_ClS go
create procedure SP_ClS (nomb nvarchar(30))
begin
if nomb='0' then
select * from F_Clientes;
else 
SELECT *
FROM F_Clientes
WHERE Cedula LIKE concat(nomb,'%')
        OR RNC LIKE concat(nomb,'%')
        OR Nombre LIKE concat(nomb,'%')
        OR Apellido LIKE concat(nomb,'%')
        OR Telefono LIKE concat(nomb,'%')
        OR Ubicacion LIKE concat(nomb,'%')
        OR Email LIKE concat(nomb,'%')
        OR ID_Cl LIKE concat(nomb,'%'); end if;
end go
-- insert
drop procedure IF exists SP_ClI go
create procedure SP_ClI (Cedula nvarchar(20), RNC nvarchar(20), Nombre nvarchar(20), Apellido nvarchar(20), Telefono nvarchar(18), Ubicacion nvarchar(60), Email nvarchar(50))
begin
insert into F_Clientes values (null, Cedula, RNC, Nombre, Apellido, Telefono, Ubicacion, Email);
select last_insert_id() from F_Clientes;
end go
-- update
drop procedure IF exists SP_ClU go
create procedure SP_ClU (id int, Cedula nvarchar(20), RNC nvarchar(20), Nombre nvarchar(20), Apellido nvarchar(20), Telefono nvarchar(18), Ubicacion nvarchar(60), Email nvarchar(50))
begin
UPDATE F_Clientes SET Cedula=Cedula,
         RNC=RNC,
         Nombre=Nombre,
         Apellido=Apellido,
         Telefono=Telefono,
         Ubicacion=Ubicacion,
         Email=Email
WHERE ID_Cl=id; end go
-- end clientes
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
constraint FK_Ventas_Inventario foreign key (Id_P) references PI_Inventario (Id_P),
constraint FK_Ventas_Factura foreign key (Id_Factura) references F_Facturas (Id_F)
);
create view 
-- Facturacion
-- select TABLE
DELIMITER go 
drop procedure IF exists SP_FACS go
create procedure SP_FACS (nomb nvarchar(30))
begin
if nomb='0' then
select * from F_Facturas;
else
SELECT F.Id_F,
        F.Id_Cliente,
        F.MontoTotal,
        F.TotalItbs,
        F.Fecha_emitida,
        F.Id_U
FROM F_Facturas F
INNER JOIN F_Clientes C
    ON F.Id_Cliente=C.ID_Cl
where F.Id_F LIKE concat(nomb,'%')
        OR F.Id_Cliente LIKE concat(nomb,'%')
        OR F.MontoTotal LIKE concat(nomb,'%')
        OR F.TotalItbs LIKE concat(nomb,'%')
        OR F.Fecha_emitida LIKE concat(nomb,'%')
        OR F.Id_U LIKE concat(nomb,'%')
        OR C.Nombre LIKE concat(nomb,'%');
end if;
end go
-- select ventas
drop procedure IF exists SP_VS go
create procedure SP_VS (nomb nvarchar(30))
begin
if nomb='0' then
select * from F_Ventas;
else
SELECT F.Id_P,
        P.Nombre_Producto,
        P.Marca_Producto,
        P.Previco_V,
        F.Total_V
        from F_Ventas F INNER join PI_Inventario P on F.Id_P=P.Id_P
where F.Id_factura LIKE concat(nomb,'%');
end if;
end go
-- insert
drop procedure IF exists SP_FI go
create procedure SP_FI (Id_Cliente int, MontoTotal float, TotalItbs float, Fecha_emitida datetime, Id_U int)
begin
insert into F_Facturas values (null, Id_Cliente, MontoTotal, TotalItbs, Fecha_emitida, Id_U);
select last_insert_id() from F_Facturas;
end go
-- insert ventas
drop procedure IF exists SP_VI go
create procedure SP_VI (Id_P int, Total_V int, Id_factura int)
begin
insert into F_Ventas values ( Id_P, Total_V, Id_factura);
select last_insert_id() from F_Ventas;
end go
