using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_uppgift3
{
    internal class PersonHandler {


        public Person CreatePerson(int age, string fname, string lname, int height, int weight) 
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
    }
}
