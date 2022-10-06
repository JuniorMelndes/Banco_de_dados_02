
//Mapeamento
from counter in counters.Products
let product = LoadDocument(counter.DocumentId, "Products")
where counter.Name.Contains("⭐")
select new {
    Name = product.Name,
    Rating = counter.Name.Length,
    TotalVotes = counter.Value,
    AllRatings = new []
    {
        new
        {
            Rating = counter.Name,
            Votes = counter.Value
        }
    }
}

//redução
from result in results
group result by result.Name into g
let totalVotes = g.Sum(x => x.TotalVotes)
let rating = g.Sum(x => x.TotalVotes / (double)totalVotes * x.Rating)
select new {
   Name = g.Key,
   Rating = rating,
   TotalVotes = totalVotes,
   AllRatings = g.SelectMany(x => x.AllRatings).ToArray()
}