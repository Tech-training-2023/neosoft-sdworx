-- VIEWS
create view SalesLT.vOrderDescription
as
select sod.SalesOrderID as ID, sod.SalesOrderDetailID as DetailedId, sod.OrderQty as Quantity, sod.UnitPrice,
soh.OrderDate as Date, soh.DueDate as Duedate, soh.CustomerId as CustomerID, soh.Subtotal as Total, 
concat(cust.Title, ' ', cust.FirstName,' ', cust.LastName) as CustomerName
from SalesLT.SalesOrderDetail as sod
join SalesLT.SalesOrderHeader as soh on sod.SalesOrderID = soh.SalesOrderID
join SalesLT.Customer as cust
on soh.CustomerID = cust.CustomerID


select * from SalesLT.vOrderDescription
order by Quantity, UnitPrice desc

selec * from [sys].[messages]
where language_id = 1033 and severity > 19
order by message_id desc