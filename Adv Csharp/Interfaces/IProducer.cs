namespace Adv_Csharp.Interfaces
{
    public interface IProducer<out T>
    {
        T Produce();
    }
}
