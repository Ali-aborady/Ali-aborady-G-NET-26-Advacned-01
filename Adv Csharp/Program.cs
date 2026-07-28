namespace Adv_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            // What is a Generic Class? Why Use Generics?

            /*
            A GENERIC CLASS is a class that is defined with a type parameter (T)
            so it can work with ANY data type without code duplication.

            Why use generics?
            1. Type Safety   → compile-time type checking (no runtime cast errors)
            2. Reusability   → one class works for int, string, double, any type
            3. Performance   → no boxing/unboxing overhead (unlike object-based)
            4. Clean Code    → no need to write the same class for every type

            Without generics (bad — requires boxing/unboxing):
            */
            //class BoxObject
            //{
            //    private object _value;
            //    public void Set(object v) { _value = v; }
            //    public object Get() { return _value; }
            //}

            //// With generics (type-safe, fast, reusable):
            //class Box<T>
            //{
            //    private T _value;
            //    public void Set(T v) { _value = v; }
            //    public T Get() { return _value; }
            //}


            #endregion

        }
    }
}
