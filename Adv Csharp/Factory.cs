namespace Adv_Csharp
{
    public class Factory<T> where T : new()
    {
        public T Create()
        {
            return new T(); 
        }

        public T[] CreateArray(int count)
        {
            T[] array = new T[count];
            for (int i = 0; i < count; i++)
                array[i] = new T(); 
            return array;
        }
    }
}
