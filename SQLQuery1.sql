sp_dropdownlist
select j.Staffno from employee j where j.ImmedaiteSupervisor='4070'
Create procedure sp_dropdownlistforDropdownImmSupervisor @ImmedaiteSupervisor varchar(5)
as
begin
--select (j.Staffno||j.Name),j.EmployeeId from employee j where j.ImmedaiteSupervisor=@ImmedaiteSupervisor
select  (Staffno+' -- '+Name) as EmployeeName, EmployeeId as EmployeeNumber from employee where ImmedaiteSupervisor=@ImmedaiteSupervisor
end

Exec sp_dropdownlistforDropdownImmSupervisor '4070'




select  (Staffno+' -- '+Name) as EmployeeName, EmployeeId as EmployeeNumber from employee where ImmedaiteSupervisor='4070'

select sys.procedures


