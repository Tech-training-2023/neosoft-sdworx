select ProductModelID, rowguid, ModifiedDate from [SalesLT].[ProductModel] --top - 128 rows
union all
select ProductModelID, rowguid, ModifiedDate from [SalesLT].[ProductModelProductDescription] --bottom --762
go

select ProductModelID, rowguid, ModifiedDate from [SalesLT].[ProductModel] --top - 128 rows
union 
select ProductModelID, rowguid, ModifiedDate from [SalesLT].[ProductModelProductDescription] --bottom --762
go

select ProductModelId, Name 
into dbo.Gloves
from SalesLT.ProductModel
where ProductModelID in (3,4)
go


select productmodelId, name
from SalesLT.ProductModel
where ProductModelID not in (3,4)
union all
select productmodelId, name from gloves
insert into dbo.Gloves values ('Full-Finger Gloves')


select ProductModelID, ModifiedDate from [SalesLT].[ProductModel] --top - 128 rows
intersect -- 54 rows
select ProductModelID, ModifiedDate from [SalesLT].[ProductModelProductDescription] --bottom --762

select ProductModelID, ModifiedDate from [SalesLT].[ProductModel] --top - 128 rows
except --74
select ProductModelID, ModifiedDate from [SalesLT].[ProductModelProductDescription] --bottom --762


select ProductModelID, ModifiedDate from [SalesLT].[ProductModelProductDescription] --bottom --762
except
select ProductModelID, ModifiedDate from [SalesLT].[ProductModel] --top - 128 rows
