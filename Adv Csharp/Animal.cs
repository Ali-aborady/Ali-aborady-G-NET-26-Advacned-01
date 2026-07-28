namespace Adv_Csharp
{
    public class Animal
    {
        public string Name { get; set; } = "Unknown";
        public override string ToString() => $"Animal: {Name}";
    }
}

