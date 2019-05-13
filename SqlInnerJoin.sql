--------->Insert Procedure<----------------------
alter procedure sp_insertimmedsup(@staffnumber varchar(7),@Name varchar(500),
@Department varchar(150),@Desgination varchar(500),
@Location varchar(500),@Cluster varchar(500),
@Email varchar(150),@Adress varchar(500),@ImmedaiteSup varchar(500),
@UplineSup varchar(500),@SelectProcess varchar(500),@ExistingProject varchar(500)=NULL,
@NewProject varchar(500)=NULL,@ExistingDept varchar(500)=NULL,@NewDept varchar(500)=NULL,
@ExistingFunction varchar(500)=NULL,@NewFunction varchar(500)=NULL)
as
begin


insert into Trnasferorder(staffnumber,
Name,Department,Desgination,
Location,Cluster,Email,Adress,
ImmedaiteSup,UplineSup,
SelectProcess,ExistingProject,
NewProject,ExistingDept,
NewDept,ExistingFunction,NewFunction) 
values
(@staffnumber,@Name,@Department,@Desgination,@Location,@Cluster,
@Email,@Adress,@ImmedaiteSup,@UplineSup,@SelectProcess,@ExistingProject,
@NewProject,@ExistingDept,@NewDept,@ExistingFunction,@NewFunction)
end
exec 

select * from Trnasferorder 
alter table Trnasferorder add SNO  int IDENTITY(1,1) PRIMARY KEY