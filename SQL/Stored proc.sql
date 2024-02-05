create proc sp_getAllRestaurantsDetails
As
select rt.id as Id, rt.name as Name,rt.city + ' '+ rt.state + '-' + rt.postcode as Address, rv.rating as Rating, 
rv.decription as Description from Restaurants as rt
join reviews rv
on rt.id == rv.restaurantId
go

exec sp_getAllRestaurantsDetails
go

alter proc sp_getRestaurantDetailsById
	@id as int 
as
	select rt.id as Id, rt.name as Name,rt.city + ' '+ rt.state + '-' + rt.postcode as Address, rv.rating as Rating, 
	rv.decription as Description from Restaurants as rt
	join reviews rv
	on rt.id = rv.restaurantId
	where rt.id = @id
go

exec sp_getRestaurantDetailsById @id = 2

exec [sys].[sp_databases]
exec [sys].[sp_helptext] sp_getRestaurantDetailsById

----- dynamic sql commands
use AdventureWorksLT2022
select * from SalesLT.customer

DECLARE @sqlstring as varchar(250) = 'SELECT FirstName,' +' LastName '+ ' from SalesLT.Customer'
exec (@sqlstring)
go

exec sys.sp_executesql N'SELECT Title, FirstName, LastName from SalesLT.Customer where Title =@title',
N'@title nvarchar(10)', 
@title = "Ms.";
go

-- RAISERROR
Declare @id int = 14
if exists(select CustomerID as Id, Concat(Title,' ',FirstName, ' ', MiddleName,' ',LastName) as Name, EmailAddress, CompanyName 
from SalesLT.Customer
where CustomerID = @id)
begin
Print N'Customer exists'
end
else
begin
RAISERROR('%s %d', 10, 1, N'Customer does not exists', 50004);
end

-- @@ERROR
PRINT 'Error=' + CAST(@@ERROR AS VARCHAR(8));

RAISERROR(N'Message', 16, 1);
IF @@ERROR <> 0
PRINT 'Error=' + CAST(@@ERROR AS VARCHAR(8));
GO

DECLARE @ErrorValue int;
RAISERROR(N'Message', 16, 1);
SET @ErrorValue = @@ERROR;
IF @ErrorValue <> 0
PRINT 'Error=' + CAST(@ErrorValue AS VARCHAR(8));