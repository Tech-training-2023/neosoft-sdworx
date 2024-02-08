--select * from [SalesLT].[Product] where ProductModelID in (6, 9, 30) order by ProductModelID;
--Go

/*Declare @ProductModelId int;
Declare @Name nvarchar(50);
--Declare the cursor using declare keyword
Declare ProductModelCursor Cursor For

Select ProductModelID, Name
From SalesLT.Product where ProductModelID = 9;
--open statement, executes SELECT Statement 
-- and populates the result set
Open ProductModelCursor
-- Fetch the row from the result set into the variables
Fetch Next From ProductModelCursor into @ProductModelId, @Name
-- if result set still has rowsm @@FETCH_STATUS will be 0
While(@@FETCH_STATUS = 0)
Begin 
Print 'Id = '+ CAST(@ProductModelId as nvarchar(10))+' Name = '+ @Name;
Fetch Next From ProductModelCursor into @ProductModelId, @Name;
End

-- Release the rowset
Close ProductModelCursor
-- Deallocate the resources associated with the cursor
Deallocate ProductModelCursor
*/
------ 
Declare @ProductModelId int;
Declare ProductCursor Cursor For
Select ProductModelID From SalesLT.Product
Open ProductCursor

Fetch Next From ProductCursor into @ProductModelId

While(@@FETCH_STATUS = 0)
Begin 
Declare @ListPrice money;
Select @ListPrice = ListPrice From SalesLT.Product where ProductModelId = @ProductModelId
if(@ProductModelId = 6)
Begin
	Update SalesLT.Product set ListPrice = 1450.00 where ProductModelID = @ProductModelId
End
else if(@ProductModelId = 9)
Begin
	Update SalesLT.Product set ListPrice = 350.00 where ProductModelID = @ProductModelId
End
else if(@ProductModelId = 30)
Begin
	Update SalesLT.Product set ListPrice = 800.00 where ProductModelID = @ProductModelId
End
 Fetch Next From ProductCursor into @ProductModelId
End
Close ProductCursor
Deallocate ProductCursor

DELETE From Gloves --where ProductModelId = 3
select * from [dbo].[Gloves]

use RestaurantDb
Delete from Restaurants where Id = 2
insert into Restaurants Values ('LAntica','London', 'GW16JY', 'London');

Truncate table Reviews

Select * from Reviews

drop table Reviews

USE [RestaurantDb]
GO

/****** Object:  Table [dbo].[Restaurants]    Script Date: 2/8/2024 10:19:23 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Restaurants](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[postcode] [varchar](7) NOT NULL,
	[state] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [RestaurantDb]
GO

/****** Object:  Table [dbo].[Reviews]    Script Date: 2/8/2024 10:20:42 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Reviews](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[rating] [int] NOT NULL,
	[decription] [varchar](250) NULL,
	[restaurantId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD FOREIGN KEY([restaurantId])
REFERENCES [dbo].[Restaurants] ([id])
ON DELETE CASCADE
GO

