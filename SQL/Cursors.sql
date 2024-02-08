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

Fetch Next From ProductModelCursor into @ProductModelId

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