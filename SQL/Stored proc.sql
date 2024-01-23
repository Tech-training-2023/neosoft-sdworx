select rt.id as Id, rt.name as Name,rt.city + ' '+ rt.state + '-' + rt.postcode as Address, rv.rating as Rating, 
rv.decription as Description from Restaurants as rt
join reviews rv
on rt.id = rv.restaurantId


create proc sp_getAllRestaurantsDetails
As

--query
go