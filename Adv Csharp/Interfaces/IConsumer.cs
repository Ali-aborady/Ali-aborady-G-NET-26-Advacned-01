namespace Adv_Csharp.Interfaces
{
    public interface IConsumer<in T>
    {
        void Consume(T item);
    }
}
