//Mapeamento 01

from c in docs.Companies
select new
{
    SourceId = c.Id,
    Name = c.Contact.Name,
    Type = "Company's Contact"
}

//Mapeamento 02
from s in docs.Suppliers
select new
{
    SourceId = s.Id,
    Name = s.Contact.Name,
    Type = "Supplier's Contact"
}

//Mapeamento 03
from e in docs.Employees
select new
{
    SourceId = e.Id,
    Name = e.FirstName + " " + e.LastName,
    Type = "Employee"
}

//Store type, name, sourceId



