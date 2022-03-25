using System;

namespace CoContraVarianceDemo
{

    public class Animal
    {
        public void Eat() => Console.WriteLine("Eat");
    }
    public class Bird:Animal
    {
        public void Fly() => Console.WriteLine("Fly");

    }
    delegate Animal ReturnAnimalDelegate();
    delegate Bird ReturnBirdDelegate();

    delegate void TakeAnimalDelegate(Animal a);
    delegate void TakeBirdDelegate(Bird b);
    public class CoContraVariance
    {
        public static Bird GetBird() => new Bird();
        public static Animal GetAnimal() => new Animal();


        public static void Eat(Animal a) => a.Eat();
        public static void Fly(Bird b) => b.Fly();
        static void Main(string[] args)
        {
            //Covariance Example
            Animal a = new Bird(); //Valid Statement Due To Implicit Conversion Enabled Known As Covariance
            ReturnAnimalDelegate d = GetBird;//Same As Above

            //Contravariance Example    Reversing The Order Of Assignement Compatibility
            TakeBirdDelegate d2 = Eat;
            d2(new Bird());



        }
    }
}
