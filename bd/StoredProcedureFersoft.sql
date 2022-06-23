#/////////////////////////Stored Procedure//////////////////////////////////
#{Nomina}:
Use Fersoft;
insert into N_Empresas values (null,'0020202','Fersoft','827272','manuedejesu');
insert into N_Sucursales values(null,'Ladeloovando','277282','dametuquerer',1);
insert into N_Departamentos values  (null,'Pro Salud','Santo Domingo','+1 (849) 401-1362',1);
insert into N_Empleados values(null,'222-2222222-2','Juan','Gome','Empresario',255,300,'12-4','+1(849) 401-1362',1);
insert into N_Usuarios values (1,0,'ecb80fffef1947a59eb3fff9d3dddfc60140387317a22d9c0e3f3f85177f3e68'); 
#(Empleados):
#insert
delimiter //
drop procedure  if exists SP_EI//
create procedure SP_EI(
Cedula nvarchar(20),Nombre varchar(25),
Apellido varchar (25),
Puesto nvarchar(250),
SueldoXH float,
SueldoXHE float,
Horario nvarchar(30),
Telefono nvarchar(20),
Id_dep int)
begin 
insert into N_Empleados  values(null,Cedula,Nombre,Apellido,Puesto,SueldoXH,SueldoXHE,Horario,Telefono,Id_dep);
select last_insert_id() from N_Empleados;
end //
delimiter ;
#select 
delimiter go
drop procedure IF exists SP_ES go
create procedure SP_ES (nomb nvarchar(30)) 
begin
if nomb = '0' then select * from N_V_EmpED; 
else
select * from N_V_EmpED Nom where concat(Nom.Nombre ,' ', Nom.Apellido) like concat(nomb,'%') or Nom.Apellido like concat(nomb,'%')
or (nomb like '%-%' and Nom.Cedula like concat(nomb,'%')) or Nom.ID_E like concat(nomb,'%') or Nom.Puesto like concat(nomb,'%') or Nom.Telefono like concat(nomb,'%');
end if;
end go
#login
delimiter go
drop procedure if exists SP_LES go
create procedure SP_LES (in Cedula nvarchar(20)) 
begin
select U.ID_U,U.Rol, U.Pass from N_Usuarios U
inner join N_Empleados E on U.ID_U=E.ID_E where E.Cedula=Cedula
or CONVERT(ID_E, nchar)=Cedula;
end
go
drop procedure if exists SP_LE go
create procedure SP_LE (id int) begin
select * from N_V_EmpED E where id= E.ID_E;
end go
#update 
drop procedure if exists SP_EU go
create procedure  SP_EU (id int,
Cedula1 nvarchar(20),
Nombre1 varchar(25),
Apellido1 varchar (25),
Puesto1 nvarchar(25),
SueldoXH1 float,
SueldoXHE1 float,
Horario1 nvarchar(30),
Telefono1 nvarchar(20),
Id_dep1 int)
begin 
update N_Empleados set 
Cedula=Cedula1,Nombre=Nombre1,Apellido=Apellido1,
Puesto=Puesto1,Id_dep=Id_dep1,SueldoXH=SueldoXH1,SueldoXHE=SueldoXHE1,
Horario=Horario1, Telefono=Telefono1 where ID_E=id;
end
go
#delete
drop procedure if exists SP_ED go
create procedure SP_ED (id int) begin
#alter table N_Empleados Drop constraint FK_Empleados_Departamentos;
delete from N_Empleados where ID_E=id;
#alter table N_Empleados add constraint FK_Empleados_Departamentos foreign key (Id_Dep) references N_Departamentos (ID_Dep)
 end go
#(Departamentos):
#insert
drop procedure if exists SP_DepI go
create procedure  SP_DepI(
Nombre varchar(25),
Ubicacion varchar(60),
Telefono nvarchar(20),
Id_Suc int)
begin
insert into N_Departamentos values  (null,Nombre,Ubicacion,Telefono,Id_Suc);
select last_insert_id() from N_Departamentos;
end go
#select 
drop procedure if exists SP_DepS go
create procedure  SP_DepS (in nomb nvarchar(25)) begin
if nomb = '0' then
select * from N_Departamentos;
else 
select * from N_Departamentos D inner join N_Sucursales S on D.Id_Suc=S.ID_Suc where D.Nombre like concat(nomb, '%') or D.ID_Dep like concat(nomb, '%') or d.Telefono 
like concat(nomb , '%') or d.Ubicacion  like concat(nomb, '%') or S.Nombre like concat(nomb, '%');
end if;
end go
#update 
delimiter go
drop procedure if exists SP_DepU go
create procedure SP_DepU (in id int,
Nombrev varchar(25),
Ubicacionv varchar(60),
Telefonov nvarchar(20),
Id_Sucv int)
begin
update N_Departamentos set  Nombre=Nombrev,Ubicacion=Ubicacionv,Telefono=Telefonov,Id_Suc=Id_Sucv where id=ID_Dep;
end
go
#Delete
drop procedure if exists SP_DepD go
create procedure  SP_DepD (in id int) begin
alter table N_Empleados drop constraint FK_Empleados_Departamentos;
delete from N_Departamentos where ID_Dep=id;
alter table N_Departamentos add constraint FK_Empleados_Departamentos foreign key (Id_Dep) references N_Departamentos (ID_Dep);
end go
#(nominaF):
#time search
#update N_Nomina set Fecha='12-12-2021' where Id_E=2;
#DBCC CHECKIDENT ('N_Nomina', RESEED,1 );
#select top 1 v.Fecha from V_N_Nomina V order by V.Fecha beginc
#go
#lbegint nom
drop procedure if exists SP_NomLN go
create procedure  SP_NomLN (in id nvarchar(25),Fin datetime) begin
declare Ln datetime default null;
 select  Ln = N.Fecha from V_N_Nomina N where N.Id_E=id or N.Cedula=id  order by N.Id_Nom desc limit 1;
if Ln is null then
select  J.Entrada, J.Salida,ID_Jor from   N_Jornada J inner join  V_N_Nomina N on J.IDE=N.Id_E  where convert(N.Id_E, nchar)=id or N.Cedula=id and Salida<=Fin;
else 
select  J.Entrada, J.Salida,j.IDE from N_Jornada J inner join  V_N_Nomina N on J.IDE=N.Id_E  where convert(N.Id_E, nchar)=id or N.Cedula=id and Salida>=Ln and Salida<=Fin;
end if; end
go
call SP_NomLN(1,'12/12/22');
#insert 
delimiter go
drop procedure if exists SP_NomI go
create procedure  SP_NomI 
(Id_E int,
Fecha datetime,
Horas smallint,
Total_Salario float,
D_SGS float,
IRS float,
S_Neto float, 
`Estado_Pago` varchar(10)
)
begin 
insert into N_Nomina  values(null,Id_E,Fecha,Horas,Total_Salario,D_SGS,IRS,S_Neto,`Estado_Pago`);
end go
#Select 
#id
drop procedure if exists SP_NomS go
create procedure SP_NomS (nomb nvarchar(25) , Fin date, Fout datetime) begin
if nomb = '0' then
select * from V_N_Nomina Nom where Nom.Fecha>=Fin and Nom.Fecha<=Fout;
else 
select * from V_N_Nomina Nom where concat(Nom.Nombre,' ', Nom.Apellido) like concat(nomb, '%') or Nom.Id_Nom like concat(nomb, '%') or (nomb like '%-%' and Nom.Cedula like concat(nomb, '%'))
and Nom.Fecha>=Fin and Nom.Fecha<=Fout;
end if;
end
go
drop procedure if exists SP_NomSE go
create procedure SP_NomSE (nomb nvarchar(25), Fin date, Fout date, estado varchar(10)) begin
if nomb = '0' then
select * from V_N_Nomina V  where
V.Fecha>=Fin and V.Fecha<=Fout and estado=V.`Estado_Pago`;
else 
select * from V_N_Nomina Nom where concat(Nom.Nombre,' ', Nom.Apellido) like concat(nomb, '%') or Nom.Id_Nom like concat(nomb, '%') or (nomb like '%-%' and Nom.Cedula like concat(nomb, '%'))
and Nom.Fecha>=Fin and Nom.Fecha<=Fout and estado=Nom.`Estado_Pago`;
end if;
end go
#update
#estado
drop procedure if exists SP_NomU go
create procedure SP_NomU (in id int,
`Estado_Pagov` varchar(10))
begin 
update N_Nomina  set `Estado_Pago`=`Estado_Pagov` where id=Id_Nom;
end
go
#delete
drop procedure if exists SP_NomD go
create procedure SP_NomD (id int) begin
delete from N_Nomina where Id_Nom=id;
end
go
#Jornada

#select 
#string
drop procedure if exists SP_JSN go
create procedure SP_JSN ( in str nvarchar(25), Fin date, Fout datetime) begin
if (str='0') then
select e.ID_E, e.Nombre,e.Apellido,e.Horario,J.Entrada,J.Salida
from N_Jornada J inner join N_Empleados E on E.ID_E=J.IDE; 
else
select e.ID_E, e.Nombre,e.Apellido,e.Horario,J.Entrada,J.Salida
from N_Jornada J inner join N_Empleados E on E.ID_E=J.IDE 
where J.Entrada>=Fin and J.Entrada<=Fout and(E.Nombre like concat(str, '%') or  convert(e.ID_E,nchar) = str or (str like '%-%' and E.Cedula like concat(str, '%')));
end if; end
go

#timetowork
delimiter go
drop procedure if exists SP_JP go
create procedure SP_JP (str nvarchar(25), fechai datetime) begin
declare  inp datetime default null; 
declare id int default 0;
select  id= E.ID_E from N_Empleados E where str = E.Cedula or E.ID_E=str;
select inp= J.Entrada from N_Jornada J where J.IDE=id order by Entrada desc;
if 
((select count(IDE) from N_Jornada J where J.IDE=id)>0 and(select  Salida from N_Jornada J where J.IDE=id order by Entrada desc limit 1) is null) then
update N_Jornada set  Salida=fechai where IDE = id and Entrada=inp;
else 
insert into N_Jornada  values (null,id, fechai, null);
end if; end
go
call SP_JP('1', '12/11/22');
drop procedure if exists SP_IU go
create procedure SP_IU (id int, rol smallint, pass nvarchar(250)) begin
insert into  N_Usuarios values (id,rol,pass); 
end
go
delimiter go
drop procedure if exists SP_US go
create procedure  SP_US (str nvarchar (25)) begin
if str='0' then
Select U.ID_U, U.Rol from N_Usuarios U;
else 
Select U.ID_U, U.Rol from N_Usuarios U inner join N_V_EmpED E on U.ID_U=E.ID_E 
where U.ID_U like concat(str, '%')or #por id
(str like '%-%' and E.Cedula like concat(str, '%')) #por cedula
or E.Nom_Dep like concat(str, '%') or E.Nom_Suc like concat(str, '%') or e.Nom_Emp like concat(str, '%') #por empresa 
or  (str like 'Admin%' and U.Rol=0) or (str like 'Supervisor%' and U.Rol=1) or (str like 'Empleado%' and U.Rol=2) #por rol
or concat(E.Nombre ,' ', E.Apellido) like concat(str,'%') or E.Apellido like concat(str,'%');
end if; end
go


delimiter go
drop procedure if exists SP_UU go
create procedure  SP_UU (id int, str nvarchar(250)) begin
if length(str)<2 then
Update N_Usuarios set Rol=str where id = ID_U;
else 
update N_Usuarios set Pass=str where id = ID_U;
end if; end
go
select * from N_Jornada;
select * from V_N_Nomina;
delete from N_Nomina where Id_Nom>0
truncate table N_Jornada
update N_Jornada set  Entrada= '2022-04-16 12:51:52.617' where IDE =1
go
#user #insert

update N_Nomina set Total_Salario=20,S_Neto=10, IRS=10,D_SGS=10;
select * from V_N_Nomina;
select * from N_Nomina;
select * from N_Empleados;
select * from N_Departamentos;