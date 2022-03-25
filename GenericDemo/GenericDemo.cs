using System;

namespace GenericDemo
{
    public class GenericClass<T>
    {
        private T data;
        public T value
        {
            get
            {
                return this.data;

            }

            set
            {
                this.data = value;

            }
        }


    }
    public class GenericDemo
    {
        static void Main(string[] args)
        {
            GenericClass<int> intClass = new GenericClass<int>();
            intClass.value = 101;
            GenericClass<string> stringClass = new GenericClass<string>();
            stringClass.value = "Sarvesh";

            Console.WriteLine("Value From Int Class Object"+intClass.value+"Value From String Class Object"+stringClass.value);

        }
    }
}
