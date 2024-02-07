-- INNER JOIN and CROSS APPLY
SELECT o.SalesOrderID, o.OrderDate, d.ProductID, d.UnitPrice, d.OrderQty
FROM [SalesLT].[SalesOrderHeader] as o
INNER JOIN [SalesLT].[SalesOrderDetail] as d
ON o.SalesOrderID = d.SalesOrderID
-- CROSS APPLY
SELECT o.SalesOrderID, o.OrderDate,  od.ProductID, od.UnitPrice, od.OrderQty
FROM SalesLT.SalesOrderHeader as o
CROSS APPLY( SELECT ProductID, UnitPrice, OrderQty
FROM SalesLT.SalesOrderDetail as d
WHERE o.SalesOrderID = d.SalesOrderID
) as od

select CustomerId from SalesLT.Customer --847 rows

-- OUTER APPLY
SELECT c.CustomerID,TopOrders.SalesOrderID, TopOrders.OrderDate
FROM [SalesLT].[Customer] as c
OUTER APPLY(
SELECT TOP(3) SalesOrderID, CAST(Orderdate as date) as OrderDate
FROM [SalesLT].[SalesOrderHeader] as o
Where o.CustomerID = c.CustomerID
Order By OrderDate desc, SalesOrderID desc) as TopOrders;