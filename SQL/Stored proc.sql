create proc sp_getAllRestaurantsDetails
As
select rt.id as Id, rt.name as Name,rt.city + ' '+ rt.state + '-' + rt.postcode as Address, rv.rating as Rating, 
rv.decription as Description from Restaurants as rt
join reviews rv
on rt.id == rv.restaurantId
go

exec sp_getAllRestaurantsDetails


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
