using Adv_Csharp.Interfaces;

namespace Adv_Csharp
{
    abstract class Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class SmartRepository<T>
        where T : Entity, IDescribable, new()
    {
        private List<T> _items = new List<T>();

        public T CreateNew(int id, string name)
        {
            T item = new T(); // allowed by new()
            item.Id = id;
            item.Name = name;
            return item;
        }

        public void Add(T item) => _items.Add(item);

        public void DescribeAll()
        {
            foreach (T item in _items)
                Console.WriteLine(item.Describe()); // allowed by IDescribable
        }
    }

    class Employee : Entity, IDescribable
    {
        public string Department { get; set; } = "N/A";

        public string Describe()
            => $"Employee [{Id}] {Name} — Dept: {Department}";
    }
}
