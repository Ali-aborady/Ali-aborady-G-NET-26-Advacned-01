using System.ComponentModel;
using System.Data;

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

            #region Question 5
            //Generic Method FindMax<T>

            /*
            FindMax<T> finds the largest element in an array.
            We need T to implement IComparable<T> so we can compare values.
            This is a generic constraint (covered in Q10).
            */

            //int[] ints = { 3, 7, 1, 9, 4 };
            //double[] doubles = { 1.5, 3.2, 0.8, 2.9 };
            //string[] words = { "banana", "apple", "cherry" };

            //Console.WriteLine(SearchHelper.FindMax(ints));    // 9
            //Console.WriteLine(SearchHelper.FindMax(doubles)); // 3.2
            //Console.WriteLine(SearchHelper.FindMax(words));   // cherry

            #endregion

            #region Question 6
            //Generic Interface: IRepository<T>

            //var repo = new ProductRepository();
            //repo.Add(new Product { Id = 1, Name = "Laptop", Price = 999.99 });
            //repo.Add(new Product { Id = 2, Name = "Phone", Price = 499.99 });

            //Console.WriteLine(repo.GetById(1)); 
            //foreach (var p in repo.GetAll())
            //    Console.WriteLine(p);

            //repo.Remove(1);

            #endregion

            #region Question 7
            //What is the 'struct' constraint? Write an example.
            /*
            The 'struct' constraint restricts T to VALUE TYPES ONLY
            (int, double, bool, DateTime, custom structs, etc.)
            This guarantees T is never null.

            Syntax: where T : struct
            */

            //var intWrapper = new ValueWrapper<int>();
            //Console.WriteLine(intWrapper.GetOrDefault()); // 0 

            //intWrapper.Set(42);
            //Console.WriteLine(intWrapper.GetOrDefault()); // 42

            #endregion

            #region Question 8
            //What is the 'class' constraint? Write an example
            /*
            The 'class' constraint restricts T to REFERENCE TYPES ONLY
            (string, class instances, arrays, interfaces, delegates, etc.)
            This means T can be null.

            Syntax: where T : class
            */

            //var checker = new NullChecker<string>();
            //Console.WriteLine(checker.IsNull(null));   // True
            //Console.WriteLine(checker.IsNull("hello"));// False
            //Console.WriteLine(checker.Describe("C#")); // String: C#

            #endregion

            #region Question 9
            //What is the 'new()' constraint? Write an example.

            /*
            The 'new()' constraint requires T to have a PUBLIC PARAMETERLESS CONSTRUCTOR.
            This allows you to create new instances of T inside the generic class/method.

            Syntax: where T : new ()
            Note: new () must be the LAST constraint if combined with others.
            */

            //var animalFactory = new Factory<Animal>();
            //Animal a = animalFactory.Create();
            //Console.WriteLine(a); 

            //Animal[] animals = animalFactory.CreateArray(3);
            //Console.WriteLine(animals.Length); 

            //var intFactory = new Factory<int>(); 
            //int n = intFactory.Create();
            //Console.WriteLine(n); 

            #endregion

            #region Question 10
            //What is the interface constraint? Write an example.

            /*
            An INTERFACE CONSTRAINT restricts T to types that
            implement a specific interface.
            This lets you call interface methods on T inside the generic class.

            Syntax: where T : IInterfaceName
            */
            //var printer = new Printer<Document>();
            //printer.Add(new Document { Title = "C# Guide", Pages = 300 });
            //printer.Add(new Document { Title = "Generics", Pages = 150 });
            //printer.PrintAll();

            #endregion

            #region Question 11
            //What is the base class constraint? Write an example.

            /*
            A BASE CLASS CONSTRAINT restricts T to a specific class
            OR any class that INHERITS from it.
            This lets you access the base class members inside the generic.

            Syntax: where T : BaseClassName
            */

            //var circles = new ShapeCollection<Circle>();
            //circles.Add(new Circle { Radius = 5, Color = "Red" });
            //circles.Add(new Circle { Radius = 3, Color = "Blue" });
            //circles.DescribeAll();
            //Console.WriteLine($"Total area: {circles.TotalArea():F2}");

            #endregion

            #region Question 12
            //How do you apply multiple constraints? Write an example. 

            /*
            You can apply MULTIPLE constraints to a type parameter.
            All must be satisfied at the same time.

            Order rules:
            1. class / struct    (if used)
            2. Base class        (only one allowed)
            3. Interface(s)      (as many as needed)
            4. new()             (always LAST)
            */

            //var repo = new SmartRepository<Employee>();

            //var e = repo.CreateNew(1, "Ahmed");
            //e.Department = "Engineering";
            //repo.Add(e);

            //repo.Add(repo.CreateNew(2, "Sara"));

            //repo.DescribeAll();
            #endregion

            #region Question 13
            //What does the 'default' keyword do in generics?
            /*
            The 'default' keyword returns the DEFAULT VALUE for type T:
            -0         for numeric types (int, double, etc.)
            -false     for bool
            - '\0'      for char
            - null      for reference types (class, string, interface)
            - zeroed struct for value types
            */

            //Console.WriteLine(DefaultDemo.GetDefault<int>());     // 0
            //Console.WriteLine(DefaultDemo.GetDefault<bool>());    // False
            //Console.WriteLine(DefaultDemo.GetDefault<double>());  // 0
            //Console.WriteLine(DefaultDemo.GetDefault<string>() == null); // True
            //Console.WriteLine(DefaultDemo.GetDefault<DateTime>()); // 01/01/0001

            //int[] nums = { 10, 20, 30 };
            //Console.WriteLine(DefaultDemo.GetValueOrDefault(nums, 1));  // 20
            //Console.WriteLine(DefaultDemo.GetValueOrDefault(nums, 99)); // 0 (default)

            #endregion

            #region Question 14
            // Write a SafeList<T> that returns default when the index is invalid.

            var safeInts = new SafeList<int>();
            safeInts.Add(10);
            safeInts.Add(20);
            safeInts.Add(30);

            Console.WriteLine(safeInts.Get(0));   
            Console.WriteLine(safeInts.Get(1));   
            Console.WriteLine(safeInts.Get(99)); 
            Console.WriteLine(safeInts[-1]);       

            var safeStrings = new SafeList<string>();
            safeStrings.Add("Hello");
            Console.WriteLine(safeStrings.Get(5) == null ? "null" : safeStrings.Get(5));
            #endregion



        }
    }
}
