using Adv_Csharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adv_Csharp
{
    public class Animall
    {
        public string Name { get; set; } = "Animal";
    }

        public class Dogg : Animall
        {
            public string Breed { get; set; } = "Unknown";
        }

        // Consumes Animal (base type)
        class AnimalConsumer : IConsumer<Animall>
        {
            public void Consume(Animall item)
                => Console.WriteLine($"Consuming animal: {item.Name}");
        }
    }
