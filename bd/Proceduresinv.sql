Use Fersoft;
insert into pi_proveedores values(null, 'lacasa','+18494011362','jhijiedi.com','Jhonny Marten');
insert into pi_almacenes values(null, 1, 'k','54645','yug','hhhh');
insert into pi_productos values (null, 'Aserin','toyota',200,1,'Lavar',1,'En el baño');
-- values
delimiter go
drop procedure IF exists SP_PS go
create procedure SP_PS (nomb nvarchar(30)) 
begin
if nomb = '0' then
select * from pi_proveedores;
else select * from pi_proveedores where ID_PRV like concat(nomb,'%') or Telefonos like concat(nomb,'%') or Email like concat(nomb,'%') or 
Nombre_Agente like concat(nomb,'%') or Nombre_Agente like concat(nomb,'%');
end if; end
go
-- Insert 
drop procedure IF exists SP_PI go
create procedure SP_PI (nombreS nvarchar(25),TelefS nvarchar(25),EmailS nvarchar(25),AgenteS nvarchar(25) ) 
begin
insert into pi_proveedores values (null, nombreS, TelefS, EmailS,AgenteS);
select last_insert_id() from pi_proveedores;
end go
-- Update 
drop procedure IF exists SP_PU go
create procedure SP_PU (id int ,nombreS nvarchar(25),TelefS nvarchar(25),EmailS nvarchar(25),AgenteS nvarchar(25) ) 
begin
update pi_proveedores set Nombre=nombreS, Telefonos = TelefS, Email = EmailS, Nombre_Agente=AgenteS where ID_PRV=id;
end go
-- end provedores
-- Inventario;
delimiter go
drop procedure IF exists SP_PiS go
create procedure SP_PiS (nomb nvarchar(30)) 
begin
if nomb='0' then 
select * from pi_productos;
else 
select * from pi_productos P inner join pi_almacenes Al  on P.Id_Al = Al.ID_Al where P.Id_P like concat(nomb,'%') or concat(P.Nombre_Producto,' ',P.Marca_Producto) like concat(nomb,'%') or
P.Marca_Producto like concat(nomb,'%') or P.Precio_V  like concat(nomb,'%') or P.`Categoria`  like concat(nomb,'%') or
 Al.Nombre like concat(nomb,'%');
end if;
end go
-- insert 
drop procedure IF exists SP_PiI go
create procedure SP_PiI (Nomb nvarchar(30),Marca nvarchar(30), Precio float, idprv int, Cat nvarchar(30), idal int , ubi nvarchar(60)) 
begin
insert into pi_productos values (null, Nomb, Marca, Precio, idprv, Cat, idal,ubi);
select last_insert_id() from pi_productos;
end  go
-- update 
drop procedure IF exists SP_PiU go
create procedure SP_PiU (id int, Nomb nvarchar(30),Marca nvarchar(30), Precio float, idprv int, Cat nvarchar(30), idal int , ubi nvarchar(60)) 
begin
update pi_productos set  Nombre_Producto=Nomb, Marca_Producto=Marca, Previco_V=Precio, Id_Prv=idprv,
`Categoria`=Cat, Id_Al=idal,Referencia_Ubi=ubi where Id_P=id;
end 