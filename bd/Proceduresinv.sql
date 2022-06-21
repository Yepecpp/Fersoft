insert into pi_proveedores values(null, 'lacasa','+18494011362','jhijiedi.com','Jhonny Marten');
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
end go
-- Update 
drop procedure IF exists SP_PU go
create procedure SP_PU (id int ,nombreS nvarchar(25),TelefS nvarchar(25),EmailS nvarchar(25),AgenteS nvarchar(25) ) 
begin
update pi_proveedores set Nombre=nombreS, Telefonos = TelefS, Email = EmailS, Nombre_Agente=AgenteS where ID_PRV=id;
end go
-- end provedores
delimiter go