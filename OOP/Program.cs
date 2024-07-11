namespace OOP
{
    internal class Program
    {
        static void PrintPerson(Person person)
        {
            Console.WriteLine($"Name Is {person.Name}");
            Console.WriteLine($"Birth Date Is  {person.BirthDate}");

        }
        static void Main(string[] args)
        {
            Person ahmad=new Employee();
            ahmad.SetName("ahmad");
            ahmad.SetBirthDate( new DateOnly(1990,1,1));

           Program.PrintPerson(ahmad);


            Person Abdo = new Appliciant ();
            Abdo.SetName("Abdo");
            Abdo.SetBirthDate(new DateOnly(1999, 1, 1));
            Program.PrintPerson(Abdo);


            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");

            Animal an = new Cat();
            an.MakeSound();


            //If Casting
            ((Cat)an).MakeSound();




            Dog dog = new Dog();
            dog.MakeSound();


            dog.MakeSound(2);


        }
    }
}
