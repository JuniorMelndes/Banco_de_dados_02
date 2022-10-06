//Mapeamento

from p in docs.Products
let category = LoadDocument(p.Category, "Categories").Name
let supplier = LoadDocument(p.Supplier, "Suppliers").Name
select new{
    ProductName = p.Name,
    CategoryName = category,
    SupplierName = supplier,
    PricePerUnit = p.PricePerUnit
}

//redução

from result in results
group result by new { result.ProductName, result.CategoryName, result.SupplierName } into g
select new {
    ProductName = g.Key.ProductName,
    CategoryName = g.Key.CategoryName,
    SupplierName = g.Key.SupplierName,
    PricePerUnit = g.Sum(x => x.PricePerUnit)
    
}