using DogDoorApp.Models;

namespace DogDoorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);

            Console.WriteLine("Fido starts barking.");
            remote.PressButton();

            Console.WriteLine("\nFido has gone outside...");
            Console.WriteLine("\nFido's all done...");

            Thread.Sleep(10000);
            Console.WriteLine("\nBut he is stuck outside");

            Console.WriteLine("Fido starts barking...");
            Console.WriteLine("So Grab the Controller");
            remote.PressButton();

            Console.WriteLine("\nFido's back inside...");
            Console.ReadLine();
        }
    }
}
