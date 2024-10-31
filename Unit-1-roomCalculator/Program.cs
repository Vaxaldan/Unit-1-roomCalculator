using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace Unit_1_roomCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, and welcome to my room calculator!");

            Console.WriteLine("Please enter the length of the room.");
            double roomLength = double.Parse(Console.ReadLine());
            Console.WriteLine($"You enetered {roomLength}");
           
            Console.WriteLine("Please enter the width of the room");
            double roomWidth = double.Parse(Console.ReadLine());
            Console.WriteLine($"You enetered {roomWidth}");
            
            double roomArea = roomLength * roomWidth;
            double roomPerimeter = 2 * (roomWidth + roomLength); 

            Console.WriteLine(roomPerimeter);
            Console.WriteLine(roomArea);

            if (roomArea <= 250)
            {
                Console.WriteLine($"Your room is {roomArea}, and is considered small.");
            }
            else if (roomArea > 250 && roomArea <= 650)
            {
                Console.WriteLine($"Your room is {roomArea}, and is considred medium.");
            }
            else if (roomArea >= 650)
            {
                Console.WriteLine($"Your room is {roomArea}, and is considred large.");
            }
            
            
        }
    }
}
