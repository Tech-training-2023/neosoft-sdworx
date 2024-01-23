
create procedure sp_getOrders
	@orderid as int = null,
	@orderdate as date = null,
	@custid as int = null
as
	select SalesOrderID, OrderDate, ShipDate, CustomerID, ShipToAddressID 
	from SalesLT.SalesOrderHeader
	where (SalesOrderID = @orderid or SalesOrderID is null)
	and (OrderDate = @orderdate or OrderDate is null)
	and (CustomerID = @custid or CustomerID is null)
go

exec sp_getOrders @orderdate = '20080601', @custid = 29847, @orderid = 71774
go
exec sp_getOrders default, '20080601', default
