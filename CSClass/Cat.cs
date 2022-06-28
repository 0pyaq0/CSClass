using System;

namespace CSClass
{
    public class Cat : Animal
    {

        public new void Eat()
        {
            Console.WriteLine("고양이가 야금야금 먹어요.");
        }
        public void Meow()
        {
            Console.WriteLine("냥냥");
        }
    }
}