SELECT TOP(1) Name, ProductID, ListPrice, StandardCost FROM SalesLT.Product ORDER BY ListPrice DESC

--Subquery
select ProductId, Name, StandardCost 
FROM SalesLT.Product where 
ListPrice = (SELECT MAX(Listprice) FROM SalesLT.Product)

SELECT SalesOrderID, ProductID, OrderQty,
    (SELECT AVG(OrderQty)
     FROM SalesLT.SalesOrderDetail) AS AvgQty
FROM SalesLT.SalesOrderDetail
WHERE SalesOrderID = 
    (SELECT MAX(SalesOrderID)
     FROM SalesLT.SalesOrderHeader);

SELECT CustomerID, SalesOrderID
FROM SalesLT.SalesOrderHeader
WHERE CustomerID = (
    SELECT CustomerID FROM SalesLT.CustomerAddress 
	where AddressId IN
	(SELECT AddressID
    FROM SalesLT.Address
    WHERE CountryRegion = 'Canada'));


	SELECT SalesOrderID, CustomerID, OrderDate
FROM SalesLT.SalesOrderHeader AS o1
WHERE SalesOrderID =
    (SELECT MAX(SalesOrderID)
     FROM SalesLT.SalesOrderHeader AS o2
     WHERE o2.CustomerID = o1.CustomerID)
ORDER BY CustomerID, OrderDate;

select CustomerID, FirstName, MiddleName, LastName from SalesLT.Customer where LastName = N'Caprio'

declare @name nvarchar(max)
set @name=N'James';
select @name as Name;

declare @uniquevalue uniqueidentifier  
set @uniquevalue = NEWID()
select @uniquevalue

select customerid, lastname 
from SalesLT.Customer
where LastName Collate Latin1_General_CS_AS = N'caprio'
select newid() as guid_from_newid, CAST('1C0E3B5C-EA7A-41DC-8E1C-D0A302B5E58B' AS uniqueidentifier) as guid_from_string


select [AddressID],[City],[StateProvince],[CountryRegion],
concat(city,','+ stateprovince,','+countryregion,','+PostalCode) as location
from SalesLT.Address;

select [AddressID],[City],[StateProvince],[CountryRegion],
city+' '+ stateprovince+' '+countryregion+' '+PostalCode as location
from SalesLT.Address;


Declare @money money = 120.595
select @money as unformatted_value,
FORMAT(@money, 'C', 'zh-cn') as zh_cn_currency,
FORMAT(@money, 'C', 'en-us') as en_us_currency,
FORMAT(@money, 'C', 'en-gb') as en_gb_currency,
FORMAT(@money, 'C', 'de-de') as de_de_currency,
FORMAT(@money, 'C', 'pl-pl') as pl_pl_currency,
FORMAT(@money, 'C', 'mu-mu') as mu_mu_currency

select Substring('Microsoft SQL Server',11,3) as substring
select LEFT('Microsoft SQL Server', 9) as leftstring, Right('Microsoft SQL Server',6) as rightstring
select LEN(N'Microsoft SQL Server') as length
select DATALENGTH(N'Microsoft SQL Server   ') as datalength

select CHARINDEX('SQL', 'Microsoft SQL Server') as result

select REPLACE('Learning about t-sql string functions', 'T-SQL', 'transact-sql') as result

select upper('Learning about t-sql string functions') as upper, lower('Learning about t-sql string functions') as lower
 
-- LIKE predicate
-- % means string of any length, 'sand%' => sandwich, sandwiches
-- _  means single character, '_a%' =>match any string with 2nd character as a
-- [list of characters]- '[DEF]%' => means any string that starts witjh D or E or F
-- [character range, ]- [N-Z]%' => means match any string that starts with a letter between N to Z
-- [^ character list or range], Like '^[A]%' - means mach any string that begin with any character except A

-- before sql server 2008 datetime and smalldatetime were only 2 date and time datatype
-- In Sql Server 2008 introduced datetime2, date, time, datetimeoffset
-- In Sql Server 2012 introduced DateFromParts and EoMonth functions
-- datetime - 'YYYYMMDD hh:mm:ss.nnn'
-- smalldatetime - 'YYYYMMDD hh:mm:ss'
-- datetime2 - 'YYYYMMDD hh:mm:ss.nnnnnnn
-- date - 'YYYYMMDD' or 'YYYY-MM-DD'
-- time - 'hh:mm:ss.nnnnnnn'
-- datetimeoffset - 'YYYYMMDD hh:mm:ss.nnnnnnn[+|-]hh:mm ex- '20140212 12:30:15.1234567 +00:00
select * from [SalesLT].[SalesOrderDetail] order by modifieddate desc

select SalesOrderDetailID, ProductID, OrderQty, UnitPrice
from [SalesLT].[SalesOrderDetail]
where ModifiedDate = '20080601'

declare @dateonly as datetime2 = '20231219'
select @dateonly as result

declare @timeonly as time = '12:39:43'
select CAST(@timeonly as datetime2) as result

select GETDATE(), GETUTCDATE(), SYSDATETIME(), SYSDATETIMEOFFSET()

select DATENAME(MM,'20080601')--getdate())
select DATEPART(MM,'20080601')-- getdate())

Select datediff(YY, '20080601', GETDATE())

select DATEADD(YY,10,'20080601')
select ISDATE('20080601')