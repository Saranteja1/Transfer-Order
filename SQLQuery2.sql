sp_Function

select * from Project 
select * from Project 
update  Project set ProjectName='10P1288989' where ProjectId='4'


create table Trnasferorder(staffnumber varchar(7),Name varchar(500),Department varchar(150),Desgination varchar(500),Location varchar(500),Cluster varchar(500),Email varchar(150),Adress varchar(500),ImmedaiteSup varchar(500),UplineSup varchar(500),SelectProcess varchar(500),ExistingProject varchar(500),NewProject varchar(500),ExistingDept varchar(500),NewDept varchar(500),ExistingFunction varchar(500),NewFunction varchar(500),Deflag varchar(2)Default 'N')
alter table Trnasferorder Add DateInserted DATETIME NOT NULL DEFAULT (GETDATE())
select * from Trnasferorder

--------->Insert Procedure<----------------------
create procedure sp_insertvalues
as
begin
select * from Trnasferorder
end
exec sp_insertvalues


