use adventureworks
go

-- Query 1
select * from Person.Person
select firstname,lastname,Title 
from Person.Person
where title  IS NOT NULL


--Query 2
select firstname,lastname
from person.person
where firstname like '%a%' and LastName like '%a%'


--Query3
select CurrencyCode,Name
from sales.Currency
where currencycode in(select CurrencyCode 
from sales.countryregioncurrency)

--Query4
--No need to create a table to copy from other table
select * into HR_Dept from HumanResources.Department
select * from HR_Dept

--Query 5
    use practise
    go
    create table loop_task(
    sno int identity(1,1),
    Name varchar(20),
    Department varchar(20),
    Place varchar(60),
    deptid int
    );
     declare @var int
     set @var = 1
     while @var < = 21
     begin
     insert into loop_task values('Tommy','Developement','Chennai',@var)
     set @var = @var + 1
     end
     select * from loop_task

--Query 6
use Adventureworks
go
select * from HumanResources.Department
select * from Person.BusinessEntityAddress
select businessentityid,addresstypeid
from Person.BusinessEntityAddress per
join HumanResources.Department dept
on per.BusinessEntityID = dept.DepartmentID

--Query7
select * from HumanResources.Department
select distinct groupname
from HumanResources.Department

--Query8
select businessentityid,addresstypeid 
from humanresources.department dept
join Person.BusinessEntityAddress bea
on dept.DepartmentID = bea.AddressID

--Query9
SELECT DATEDIFF(year, startdate, enddate) AS DateDiff from HumanResources.EmployeeDepartmentHistory;

--Query10
select * from Sales.SalesPersonQuotaHistory

select * from Sales.SalesPersonQuotaHistory
where  SalesQuota + 5000 > = 100000

select * from sales.SalesPersonQuotaHistory
where SalesQuota < = 5000

--Query11
select * from sales.salestaxrate

select max(taxrate) as Max_taxrate 
from sales.SalesTaxRate

-- Query12
select * from HumanResources.Employee
select * from HumanResources.Department
select * from HumanResources.EmployeeDepartmentHistory

select dept.DepartmentID,emp.BusinessEntityID,edh.ShiftID,emp.BirthDate,year(getdate())-year(BirthDate) as age
from HumanResources.Employee emp join
HumanResources.Department dept on
emp.BusinessEntityID=dept.DepartmentID
join HumanResources.EmployeeDepartmentHistory edh
on emp.BusinessEntityID=edh.BusinessEntityID


--Query13
create view [calculated_age] as
select dept.DepartmentID,emp.BusinessEntityID,edh.ShiftID,emp.BirthDate,year(getdate())-year(BirthDate) as age
from HumanResources.Employee emp join
HumanResources.Department dept on
emp.BusinessEntityID=dept.DepartmentID
join HumanResources.EmployeeDepartmentHistory edh
on emp.BusinessEntityID=edh.BusinessEntityID

select * from calculated_age

--Query14
declare @table varchar(50) = 'select count(*) from  [HumanResources].[Department]'
select @table
execute sp_executesql @table

select count(*) from  [HumanResources].[Department]

CREATE PROCEDURE sp_getrowsbytable @TableName Varchar(50) 
AS 
BEGIN 
SELECT COUNT(*) as No_of_rows_hr
FROM @TableName 
END

--Query15

select*from HumanResources.Department
select*from HumanResources.EmployeePayHistory

select max(rate) max_rate ,name 
from HumanResources.Department dept
join HumanResources.EmployeePayHistory payh
on dept.DepartmentID = payh.BusinessEntityID
group by name


---Query16
select*from Person.Person -->first,last,middle,title(not null)
select*from Person.BusinessEntityAddress

select firstname,lastname,middlename,title,addresstypeid,per.BusinessEntityID
from person.person per
left join Person.BusinessEntityAddress bae
on per.BusinessEntityID = bae.BusinessEntityID
where title is not null

 --Query 17

select*from Production.ProductInventory

select ProductID,LocationID,Shelf
from production.ProductInventory
where ProductID >= 300 and ProductID <=350
or LocationID = 50 or Shelf = 'E'


--Query  18

select * from Production.ProductInventory
select * from production.Location

select loc.LocationID,shelf,name
from production.ProductInventory  pie
join production.Location  loc
on pie.ProductID = loc.LocationID

 --query 19
select * from Person.StateProvince
select * from Person.Address

select addressid,addressline1,addressline2,stp.StateProvinceID,stp.StateProvinceCode,CountryRegionCode
from person.stateprovince stp
join person.Address ad
on stp.stateprovinceid = ad.AddressID

 
 --Query20

 select * from sales.SalesOrderHeader
 select * from sales.SalesTerritory
 select * from sales.CountryRegionCurrency

 select currencycode,sum (subtotal + taxamt ) as total
 from sales.SalesOrderHeader soh 
 join sales.SalesTerritory sst
 on soh.TerritoryID = sst.TerritoryID
 join sales.CountryRegionCurrency cgc
 on sst.CountryRegionCode = cgc.CountryRegionCode
 group by CurrencyCode



