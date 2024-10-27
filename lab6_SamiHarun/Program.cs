namespace lab6_SamiHarun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            Bird bird = new Bird();
            Bulldog bulldog = new Bulldog();
            Chihuahua chihuahua = new Chihuahua();

            dog.MakeSound();
            cat.MakeSound();
            bird.MakeSound();
            bulldog.MakeSound();
            chihuahua.MakeSound();
        }
    }
}
