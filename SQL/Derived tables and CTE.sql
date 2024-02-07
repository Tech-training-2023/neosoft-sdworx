-- Derived table 

-- select <outer query column list>
--   FROM (SELECT <inner  query column list>
--      FROM <table source>) AS <derived table alias>

select * from [SalesLT].[SalesOrderHeader]
select * from saleslt.customer
insert into SalesLT.SalesOrderHeader (RevisionNumber, Duedate,OrderDate,[ShipMethod], CustomerID) 
values (2, '2015-07-09','2015-07-09','CARGO TRANSPORT 5', 2)

-- using derived table to retrieve informations about orders placed by distinct customers per year:

SELECT orderyear, count(distinct cust_id) as cust_count
FROM 
	(select year(orderdate) as orderyear, CustomerID as cust_id from SalesLT.SalesOrderHeader) as derived_year
Group by orderyear
order by cust_count; --inline alias -> recommended

SELECT orderyear, count(distinct cust_id) as cust_count
FROM (select year(orderdate), CustomerID from SalesLT.SalesOrderHeader) as derived_year(orderyear, cust_id)
Group by orderyear; --external alias

-- passing arguments to the derived tables

DECLARE @TaxAmt money = 2000.00;
SELECT OrderYear, COUNT(DISTINCT Cust_Id) AS Cust_Count
FROM
	(SELECT YEAR(OrderDate) as orderYear, CustomerId as Cust_Id FROM SalesLT.SalesOrderHeader
		WHERE TaxAmt > @TaxAmt) as DerivedYear
GROUP BY orderYear
Order By orderYear;
go

-- Nesting and resuing derived tables
SELECT OrderYear, cust_count
FROM
	(SELECT orderyear, count(distinct CustomerId) as cust_count 
	FROM 
		(SELECT YEAR(orderdate) as OrderYear, CustomerId FROM SalesLT.SalesOrderHeader) as derived_table_1
     GROUP BY OrderYear) as derived_table_2
where cust_count > 10

-- CTE
-- Syntax
-- WITH <CTE name>
-- AS (<CTE definition>)

WITH CTE_Year --name of CTE
AS -- define the subquery
(
	SELECT YEAR(orderdate) as orderYear, CustomerId
	From SalesLT.SalesOrderHeader
)
SELECT orderYear, COUNT(DISTINCT CustomerId) AS Cust_Count
FROM CTE_Year -- reference the CTE in the outer Query
GROUP BY orderYear
Order By orderYear

