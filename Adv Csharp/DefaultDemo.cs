namespace Adv_Csharp
{
    public class DefaultDemo
    {
        public static T GetDefault<T>()
        {
            return default(T)!; 
        }

        public static T GetValueOrDefault<T>(T[] array, int index)
        {
            if (array == null || index < 0 || index >= array.Length)
                return default!; 
            return array[index];
        }
    }
}
