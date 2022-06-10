#/////////////////////////Stored Procedure//////////////////////////////////
#{Nomina}:
insert into N_Empresbegin values ('0020202','Fersoft','827272','manuedejesu');
insert into N_Sucursales values('Ladeloovando','277282','dametuquerer',1);
insert into N_Departamentos values  ('Pro Salud','Santo Domingo','+1 (849) 401-1362',1);
insert into N_Empleados values('222-2222222-2','Juan','Gome','Empresario',255,300,'12-4','+1(849) 401-1362',1);
insert into N_Usuarios values (1,0,'ecb80fffef1947a59eb3fff9d3dddfc60140387317a22d9c0e3f3f85177f3e68'); 
#(Empleados):
#insert
delimiter //
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
insert into N_Empleados  values(Cedula,Nombre,Apellido,Puesto,SueldoXH,SueldoXHE,Horario,Telefono,Id_dep);
select last_insert_id() from N_Empleados;
end //
delimiter ;
#select 
delimiter go
drop procedure IF exists SP_ES go
create procedure SP_ES (in nomb varchar(25)) 
begin
if nomb = '0' then select * from N_V_EmpED; 
else
select * from N_V_EmpED Nom where Nom.Nombre +' '+ Nom.Apellido like (nomb + '%') or Nom.Apellido like (nomb + '%')
or (nomb like '%-%' and Nom.Cedula like (nomb + '%')) or Nom.ID_E like (nomb + '%') or Nom.Puesto like (nomb + '%');
end if;
end go
delimiter ;

#login
create or replace  procedure SP_LES Cedula nvarchar(20) begin
select U.ID_U,U.Rol, U.Pbegins from N_Usuarios U inner join N_Empleados E on U.ID_U=E.ID_E where E.Cedula=Cedula or CONVERT(nvarchar,ID_E)=Cedula;
go
create or replace  procedure SP_LE id int begin
select * from N_V_EmpED E where id= E.ID_E;
go
#update 
create or replace  procedure SP_EU id int,
Cedula nvarchar(20),
Nombre varchar(25),
Apellido varchar (25),
Puesto nvarchar(25),
SueldoXH float,
SueldoXHE float,
Horario nvarchar(30),
Telefono nvarchar(20),
Id_dep int
begin 
update  N_Empleados set [Cedula]=Cedula,[Nombre]=Nombre,[Apellido]=Apellido,Puesto=Puesto,[Id_dep]=Id_dep,[SueldoXH]=SueldoXH,[SueldoXHE]=SueldoXHE,[Horario]=Horario, [Telefono]=Telefono where ID_E=id;
go
#delete
create or replace  procedure SP_ED id int begin
#alter table N_Empleados Drop constraint FK_Empleados_Departamentos;
delete from N_Empleados where ID_E=id;
#alter table N_Empleados add constraint FK_Empleados_Departamentos foreign key (Id_Dep) references N_Departamentos (ID_Dep)
go
#(Departamentos):
#insert
create or replace  procedure SP_DepI
Nombre varchar(25),
Ubicacion varchar(60),
Telefono nvarchar(20),
Id_Suc int
begin
DECLARE generated_keys table([Id] int);
insert into N_Departamentos  OUTPUT inserted.ID_Dep INTO generated_keys values  (Nombre,Ubicacion,Telefono,Id_Suc);
SELECT g.Id
FROM generated_keys begin g;
go
#select 
create or replace   procedure SP_DepS nomb nvarchar(25) begin
if nomb = '0'
select * from N_Departamentos;
else 
select * from N_Departamentos D inner join N_Sucursales S on D.Id_Suc=S.ID_Suc where D.Nombre like nomb + '%' or D.ID_Dep like nomb + '%' or d.Telefono 
like nomb + '%' or d.Ubicacion  like nomb + '%' or S.Nombre like nomb + '%';
go
#update 
create or replace procedure SP_DepU id int,
Nombre varchar(25),
Ubicacion varchar(60),
Telefono nvarchar(20),
Id_Suc int
begin
update N_Departamentos set  [Nombre]=Nombre,[Ubicacion]=Ubicacion,[Telefono]=Telefono,[Id_Suc]=Id_Suc where id=ID_Dep;
go
#Delete
create or replace procedure SP_DepD id int begin
alter table [dbo].[N_Empleados] drop constraint [FK_Empleados_Departamentos];
delete from [dbo].[N_Departamentos] where ID_Dep=id;
alter table N_Departamentos add constraint FK_Empleados_Departamentos foreign key (Id_Dep) references N_Departamentos (ID_Dep);
go
#(nominaF):
#time search
select * from V_N_Nomina
select * from N_Nomina
select * from N_Empleados

delete from N_Nomina where Id_Nom>0
update N_Nomina set Fecha='12-12-2021' where Id_E=2;
DBCC CHECKIDENT ('N_Nomina', RESEED,1 );
select top 1 v.Fecha from V_N_Nomina V order by V.Fecha beginc
go
#lbegint nom
create or replace  procedure SP_NomLN id nvarchar(25),Fin datetime begin
declare Ln datetime;
set Ln = (select top 1 N.Fecha from V_N_Nomina N where convert(nvarchar,N.Id_E)=id or N.Cedula=id  order by N.Id_Nom desc)
if Ln is null begin
select  J.Entrada, J.Salida,ID_Jor from   N_Jornada J inner join  V_N_Nomina N on J.IDE=N.Id_E  where convert(nvarchar,N.Id_E)=id or N.Cedula=id and Salida<=Fin
end 
else begin 
select  J.Entrada, J.Salida,j.IDE from N_Jornada J inner join  V_N_Nomina N on J.IDE=N.Id_E  where convert(nvarchar,N.Id_E)=id or N.Cedula=id and Salida>=Ln and Salida<=Fin
end
go

exec SP_NomSI 2,'12-12-2021','12-12-2022'
exec SP_NomLN 1, '2022-04-16 23:59:52.617'
#insert 
create or replace  procedure SP_NomI
Id_E int,
Fecha datetime,
Horbegin smallint,
Total_Salario float,
D_SGS float,
IRS float,
S_Neto float,
Estado_Pago varchar(10)
begin 
DECLARE generated_keys table([Id] int);
insert into N_Nomina  OUTPUT inserted.Id_Nom INTO generated_keys values(Id_E,Fecha,Horbegin,Total_Salario,D_SGS,IRS,S_Neto,Estado_Pago);
SELECT g.Id
FROM generated_keys begin g;
go
#Select 
#id
create or replace  procedure SP_NomS nomb nvarchar(25) , Fin date, Fout datetime begin
if nomb = '0'
select * from V_N_Nomina Nom where Nom.Fecha>=Fin and Nom.Fecha<=Fout;
else 
select * from V_N_Nomina Nom where (Nom.Nombre +' '+ Nom.Apellido like nomb + '%' or Nom.Id_Nom like nomb + '%' or (nomb like '%-%' and Nom.Cedula like nomb + '%'))
and Nom.Fecha>=Fin and Nom.Fecha<=Fout;
go
create or replace  procedure [dbo].[SP_NomSE] nomb nvarchar(25), Fin date, Fout date, estado varchar(10) begin
if nomb = '0'
select * from V_N_Nomina V  where
V.Fecha>=Fin and V.Fecha<=Fout and estado=V.Estado_Pago;
else 
select * from V_N_Nomina Nom where (Nom.Nombre +' '+ Nom.Apellido like nomb + '%' or Nom.Id_Nom like nomb + '%' or Nom.Cedula like nomb + '%') 
and Nom.Fecha>=Fin and Nom.Fecha<=Fout and estado=Nom.Estado_Pago;
go
#update
#estado
create or replace  procedure SP_NomU id int,
Estado_Pago varchar(10)
begin 
update N_Nomina  set [Estado_Pago]=Estado_Pago where id=Id_Nom;
go
/*
create or replace  procedure SP_NomU id int,
Id_E int,
Fecha datetime,
Horbegin smallint,
Total_Salario float,
D_SGS float,
IRS float,
S_Neto float,
Estado_Pago varchar(10)
begin 
update N_Nomina  set [Id_E]=Id_E,[Fecha]=Fecha,[Horbegin]=Horbegin,[Total_Salario]=Total_Salario,[D_SGS]=D_SGS,[IRS]=IRS,[S_Neto]=S_Neto,[Estado_Pago]=Estado_Pago where id=Id_Nom;
go*/
#delete
create or replace procedure SP_NomD id int begin
delete from [dbo].[N_Nomina] where Id_Nom=id;
go
#Jornada

#select 
#string
create or replace  procedure SP_JSN str nvarchar(25), Fin date, Fout datetime begin
if (str='0')
select e.ID_E, e.Nombre,e.Apellido,e.Horario,J.Entrada,J.Salida
from N_Jornada J inner join N_Empleados E on E.ID_E=J.IDE 
else
begin
select e.ID_E, e.Nombre,e.Apellido,e.Horario,J.Entrada,J.Salida
from N_Jornada J inner join N_Empleados E on E.ID_E=J.IDE 
where J.Entrada>=Fin and J.Entrada<=Fout and(E.Nombre like str + '%'or  convert(nvarchar,e.ID_E) = str or (str like '%-%' and E.Cedula like str + '%'))
end
go

#timetowork
create or replace  proc SP_JP str nvarchar(25), fechai datetime begin
declare  inp datetime; 
declare id int 
set id = (select top 1 E.ID_E from N_Empleados E where str = E.Cedula or CONVERT(nvarchar,E.ID_E)=str)
set inp = (select top 1 Entrada from N_Jornada J where J.IDE=id order by Entrada desc);
if 
((select COUNT (IDE) from N_Jornada J where J.IDE=id)>0 and(select top 1 Salida from N_Jornada J where J.IDE=id order by Entrada desc) is null) begin
update N_Jornada set  Salida=fechai where IDE = id and Entrada=inp
end 
else begin
insert into N_Jornada  values (id, fechai, null)
end
go

exec SP_JP 1,'2022-04-16 23:51:52.617'
select * from N_Jornada
select * from V_N_Nomina
delete from N_Nomina where Id_Nom>0
truncate table N_Jornada
update N_Jornada set  Entrada= '2022-04-16 12:51:52.617' where IDE =1
go
#user #insert
create or replace  proc SP_IU id int, rol smallint,pbegins nvarchar(250) begin
insert into  N_Usuarios values (id,rol,pbegins); 
go
create or replace  proc SP_US str nvarchar (25) begin
if str='0'
Select U.ID_U, U.Rol from N_Usuarios U 
else 
Select U.ID_U, U.Rol from N_Usuarios U inner join N_V_EmpED E on U.ID_U=E.ID_E 
where U.ID_U like str + '%' or #por id
(str like '%-%' and E.Cedula like str + '%') #por cedula
or E.Nom_Dep like str + '%' or E.Nom_Suc like str + '%' or e.Nom_Emp like str + '%' #por empresa 
or  (str like 'Admin%' and U.Rol=0) or (str like 'Supervisor%' and U.Rol=1) or (str like 'Empleado%' and U.Rol=2)  #por rol
go
create or replace  proc SP_UU id int, str nvarchar(250) begin
if LEN(str)<2
Update N_Usuarios set Rol=PARSE(str begin smallint) where id = ID_U;
else 
update N_Usuarios set Pbegins=str where id = ID_U;
go
exec SP_UU 1, 'ecb80fffef1947a59eb3fff9d3dddfc60140387317a22d9c0e3f3f85177f3e68'
select * from N_Departamentos
update N_Nomina set Total_Salario=20,S_Neto=10, IRS=10,D_SGS=10;
select * from N_Nomina