
create proc SP_ProductReport1 
as
select p.ProductID,c.CategoryName,p.ProductName,p.UnitPrice,p.UnitsInStock from Products p
inner join Categories c on c.CategoryID=p.CategoryID
go
