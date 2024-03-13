using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_uppgift3
{
    internal class Person
    {
        private int age1;
        private string firstName;
        private string lastName;
        private double height1;
        private double weight1;
        public int Age
        {
            get { return age1; }
            set
            {
                if (value > 0)
                { age1 = value; }
                else
                {
                    throw new ArgumentException("Error: Use a number higher than 0");
                }
            }
        }
        public string fName
        {
            get { return firstName; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length >= 2 && value.Length <= 10)
                {
                    firstName = value;
                }
                else
                {
                    throw new ArgumentException("Name can't be shorter than 2 or longer than 10 letters.");
                }
            }
        }
        public string lName
        {
            get { return lastName; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length >= 3 && value.Length <= 15)
                {
                    lastName = value;
                }
                else
                {
                    throw new ArgumentException("Name can't be shorter than 3 or longer than 15 letters.");
                }
            }
        }
        public double height
        {
            get { return height1; }
            set
            {
                if (value > 0)
                {
                    height1 = value;
                }
                else
                {
                    throw new ArgumentException("Height must be higher than 0");
                }
            }
        }
        public double weight
        {
            get { return weight1; }
            set
            {
                if (value > 0)
                {
                    weight1 = value;
                }
                else
                {
                    throw new ArgumentException("Weight must be higher than 0");
                }
            }


        }
    }
}

