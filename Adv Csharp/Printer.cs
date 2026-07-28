using Adv_Csharp.Interfaces;

namespace Adv_Csharp
{
    class Printer<T> where T : IPrintable
    {
        private List<T> _items = new List<T>();

        public void Add(T item) => _items.Add(item);

        // Can call Print() because T is guaranteed to implement IPrintable
        public void PrintAll()
        {
            foreach (T item in _items)
                item.Print(); // safe to call!
        }
    }
}
