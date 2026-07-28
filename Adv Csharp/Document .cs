using Adv_Csharp.Interfaces;
using System.Collections.Generic;
namespace Adv_Csharp
{
    public class Document : IPrintable
    {
        public string Title { get; set; } = string.Empty;
        public int Pages { get; set; }

        public void Print()
            => Console.WriteLine($"Printing: {GetInfo()}");

        public string GetInfo()
            => $"'{Title}' ({Pages} pages)";
    }
}
