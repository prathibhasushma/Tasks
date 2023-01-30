restore database Adventureworks
from disk = 'D:\Training and Learning\Adventureworks2016.bak'
with move 'Adventureworks2016_data' to 'D:\Training and Learning\Data\AdventureWorks2016_Data.mdf',
move 'AdventureWorks2016_Log'to 'D:\Training and Learning\Data\AdventureWorks2016_Log.ldf'
use Adventureworks
go
select * from HumanResources.Department
select [DepartmentID],[Name],[GroupName],[ModifiedDate]
from HumanResources.Department 
select * from Person.Person
select Title,FirstName,MiddleName,EmailPromotion
--Alternate names can be given as the following
from person.Person
select Title,FirstName as 'Calling Name',MiddleName as 'Calling middle name',EmailPromotion
from person.Person
select Title,FirstName as Calling ,MiddleName as middle,EmailPromotion
from person.Person 
select Title,FirstName  Calling ,MiddleName  middle,EmailPromotion
from person.Person 
select Title,Calling = FirstName,middle = MiddleName,EmailPromotion
from person.Person
--Filters
select Title,FirstName,MiddleName,EmailPromotion,BusinessEntityID
from person.Person
where BusinessEntityID< 100
select Title,FirstName,MiddleName,EmailPromotion,BusinessEntityID
from person.Person
where BusinessEntityID>400 and BusinessEntityID<=450
select Title,FirstName,MiddleName,EmailPromotion,BusinessEntityID
from person.Person
where BusinessEntityID = 12367 or BusinessEntityID = 14822 or  BusinessEntityID = 17438
select Title,FirstName,MiddleName,EmailPromotion,BusinessEntityID
from person.Person
where BusinessEntityID in(12367,14822,17438)
select Title,FirstName,MiddleName,EmailPromotion,BusinessEntityID
from person.Person
where BusinessEntityID not in(12367,14822,17438)
select title,FirstName,BusinessEntityid
from person.Person
-- distinct multiple rows returns a unique rows that has unique combinations
where title is not null
select distinct Title,FirstName
from person.person
select FirstName
from person.Person
where FirstName like 'j%'--% is a wildcard
select FirstName
from person.Person
where FirstName like 'j__'
select FirstName
from person.Person
where FirstName like 'ja__'
--Joins
select BusinessEntityId,dept.DepartmentId,dhis.DepartmentId
name,startdate
from HumanResources.Department dept 
join HumanResources.EmployeeDepartmentHistory dhis
on dept.DepartmentID = dhis.DepartmentID
-- Joining multiple tables
select per.BusinessEntityid,Firstname,name departmentname
from person.person per
join HumanResources.EmployeeDepartmentHistory dhis
on per.BusinessEntityID = dhis.BusinessEntityID
join HumanResources.Department dept
on dhis.DepartmentID = dept.DepartmentID
use Adventureworks
go
select BusinessEntityid,DepartmentId,ShiftId,startdate
from HumanResources.EmployeeDepartmentHistory
select BusinessEntityId,name,HumanResources.Department.DepartmentID
from HumanResources.EmployeeDepartmentHistory
join HumanResources.Department
on BusinessEntityID = HumanResources.Department.DepartmentID












