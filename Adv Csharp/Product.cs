using Adv_Csharp.Interfaces;

namespace Adv_Csharp
{
   public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
            => $"[{Id}] {Name} - ${Price}";
    }

    // Concrete implementation of IRepository<Product>
    class ProductRepository : IRepository<Product>
    {
        private List<Product> _products = new List<Product>();

        public void Add(Product entity)
        {
            _products.Add(entity);
            Console.WriteLine($"Added: {entity}");
        }

        public void Remove(int id)
        {
            _products.RemoveAll(p => p.Id == id);
            Console.WriteLine($"Removed product with Id={id}");
        }

        public Product GetById(int id)
            => _products.Find(p => p.Id == id);

        public IEnumerable<Product> GetAll()
            => _products;
    }
}