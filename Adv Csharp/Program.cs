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

            #region Question 2
            //Generic Class Container<T> with Add and Get

            //// Integer container
            //Container<int> intContainer = new Container<int>();
            //intContainer.Add(10);
            //intContainer.Add(20);
            //Console.WriteLine(intContainer.Get(0)); 
            //Console.WriteLine(intContainer.Get(1)); 

            //// String container
            //Container<string> strContainer = new Container<string>();
            //strContainer.Add("Hello");
            //strContainer.Add("World");
            //Console.WriteLine(strContainer.Get(0)); 

            #endregion

            #region Question 3
            //Multiple Type Parameters: Pair<TKey, TValue>

            //var p1 = new Pair<string, int>("Age", 25);
            //Console.WriteLine(p1);

            //var p2 = new Pair<int, double>(1, 3.14);
            //Console.WriteLine(p2);

            //var swapped = p1.Swap();
            //Console.WriteLine(swapped);

            #endregion

            #region question 4
            //Generic Method: Swap<T>

            /*
            A GENERIC METHOD is a method with its OWN type parameter,
            independent of the class it belongs to.
            
            Syntax:  public static void MethodName<T>(...)
            The compiler infers T from the arguments passed.
            */

            //int x = 5, y = 10;
            //Console.WriteLine($"Before: x={x}, y={y}"); 
            //Utilities.Swap<int>(ref x, ref y);
            //Console.WriteLine($"After:  x={x}, y={y}"); 


            //string s1 = "Hello", s2 = "World";
            //Console.WriteLine($"Before: s1={s1}, s2={s2}");
            //Utilities.Swap(ref s1, ref s2); 
            //Console.WriteLine($"After:  s1={s1}, s2={s2}");


            #endregion


        }
    }
}
