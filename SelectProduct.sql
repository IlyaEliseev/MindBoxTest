SELECT p.Name as ProductName, c.Name as CategoryName 
FROM Products as p
LEFT JOIN ProductsCategories as pc on p.Id = pc.ProductId
LEFT JOIN Categories as c on c.Id = pc.CategoryId
