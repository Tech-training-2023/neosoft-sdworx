--DDL - CREATE, ALTER, DROP
create database RestaurantDb;
use RestaurantDb;
create table Restaurants(
   id int identity(1,1) primary key,
   name varchar(50) not null,
   city varchar(50) not null,
   postcode varchar(7) not null,
   state varchar(50)
);
create table Reviews(
	id int identity(1,1) primary key,
	rating int not null,
	decription varchar(250),
	restaurantId int references Restaurants(id) on delete cascade
);
-- seeding data 
insert into restaurants (name, city, postcode, state) values
('1947', 'London', 'UW1 5GH', 'London'),
('Ihop', 'Dallas', '76019', 'Texas'),
('Franco Manco', 'Ealing', 'YT7 9UH', 'London')
 select * from Restaurants

 insert into Reviews (rating, decription, restaurantId) values
 (5, 'very good ambience', 1),
 (4, 'good food but small portions', 1),
 (5, 'very good sourdough pizza', 2),
 (4, 'good place to have breakfast pancakes', 3)

 select * from Reviews
 select rs.id, rs.name, rs.postcode, rv.rating, rv.decription
 from Restaurants as rs
 right join Reviews as rv on rs.id = rv.id
 
 -- clean up
-- drop table Reviews
-- drop table Restaurants;
-- drop database RestaurantDb;