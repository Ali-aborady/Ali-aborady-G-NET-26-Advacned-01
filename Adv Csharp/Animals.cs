using Adv_Csharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adv_Csharp
{
    class Animals
    {
        public virtual string Sound() => "...";
    }

    class Dog : Animals
    {
        public override string Sound() => "Woof!";
    }

    class DogProducer : IProducer<Dog>
    {
        public Dog Produce() => new Dog();
    }
}
