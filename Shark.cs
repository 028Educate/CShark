using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShark
{
    public class Shark
    {
        //Fields, Properties, methods go here...

        //Name of a shark
        private string _name;
        //Age of a shark in years
        private int _age;
        //Length of shark in feet
        private double _length;

        //Take 3 parameters when constructing the shark
        public Shark(string name, int age, double length)
        {
            //Set the instance variables to the parameter values
            _name = name;
            _age = age;
            _length = length;
        }

        //Getter to retrieve the _name variable
        public string GetName()
        {
            return _name;
        }

        //Setter to set the _name variable only
        //if string passed as parameter is not null or empty
        public void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                _name = name;
            }
        }

        //Getter to retrieve the _age variable
        public int GetAge()
        {
            return _age;
        }

        //Setter to set the _age variable only
        //if int passed as parameter is not <= 0
        public void SetAge(int age)
        {
            if (age > 0)
            {
                _age = age;
            }
        }

        //Getter to retrieve the _length variable
        public double GetLength()
        {
            return _length;
        }

        //Setter to set the _length variable only
        //if double passed as parameter is not <= 0
        public void SetLength(double length)
        {
            if (length > 0)
            {
                _length = length;
            }
        }

        //Method to allow the shark to swim
        public void Swim()
        {
            //Code to perform swimming
            Console.WriteLine("Swimming");
        }

        //Method to allow the shark to eat
        public void Eat()
        {
            //Code to perform eating
            Console.WriteLine("NOM NOM NOM");
        }

        //Method to allow the shark to hunt
        public void Hunt()
        {
            //Code to perform hunting
            Console.WriteLine("Watch out I'm Hunting!");
        }
    }
}
