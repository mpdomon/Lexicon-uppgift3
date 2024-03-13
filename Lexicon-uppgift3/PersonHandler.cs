using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_uppgift3
{
    internal class PersonHandler {


        public Person CreatePerson(int age, string fname, string lname, double height, double weight) 
        { 
            Person person = new Person();
            person.Age = age;
            person.fName = fname;
            person.lName = lname;
            person.height = height;
            person.weight = weight;

            return person;
        }


        public void setAge (Person pers, int age) {
            pers.Age = age;
        }

        public void setFname (Person pers, string fname)
        {
            pers.fName = fname;
        }

        public void setLname (Person pers, string lname)
        {
            pers.lName = lname;
        }

        public void setHeight (Person pers, double height) 
        {
            pers.height = height;
        }

        public void setWeight (Person pers, double weight)
        {
            pers.weight = weight;
        }

    }
}
