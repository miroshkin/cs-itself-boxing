using System;

namespace CS.Itself.Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 234;
            var box = new Box<int>(i);
            Console.WriteLine(box);
            Console.WriteLine(box.GetType());

            Console.WriteLine();

            int j = 234;
            object o = j;

            Console.WriteLine(o);
            Console.WriteLine(o.GetType());
        }
    }

    sealed class Box<T>
    {
        private T value;
        public Box(T t)
        {
            value = t;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
