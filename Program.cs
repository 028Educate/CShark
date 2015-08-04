using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShark
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new Shark object passing 
            //details to custom constructor
            Shark CShark = new Shark("C Shark", 20, 18);

            //Output shark details using getters
            Console.WriteLine("Shark Details");
            Console.WriteLine("\nName: " + CShark.GetName() + 
                              "\nAge: " + CShark.GetAge() +
                              "\nLength: " + CShark.GetLength()+ "ft");

            //Call Hunt and Eat methods
            Console.WriteLine("\nTime to hunt");
            CShark.Hunt();
            CShark.Eat();
        }
    }
}
