//Mapeamento

from p in docs.Products
select new
{
    p.Name,
    p.Category,
    p.Supplier,
    p.PricePerUnit
}