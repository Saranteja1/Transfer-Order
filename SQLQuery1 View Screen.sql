select * from Trnasferorder

Alter Procedure Sp_View(@Action varchar(100),@staffnumber varchar(10))
as
Begin
If @Action='Select' 
Begin
select (staffnumber+'-->'+upper(Name)) as StaffNumber,Name from Trnasferorder
End

If @Action='SelectingValuesfordataset' 
Begin
select * from Trnasferorder where  staffnumber=@staffnumber
End
End

Exec Sp_View  'SelectingValuesfordataset','4080'


select * from Trnasferorder
select Name, 
case when Name='saran' Then 'Devleoper' 
          Else 'Nothing'
		  End Saran From Trnasferorder

		  select * from Trnasferorder
		  select * from Department





		   

							
select DeptID,DeptName,
case when DeptName='IT' Then 'Devleoper'
when DeptName='HR'  THEN 'jUNIOR HR'
Else 'Not Allotes'
End TemporayDesgination From Department

select * from Department
 

