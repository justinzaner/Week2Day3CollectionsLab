using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week2Day3CollectionsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a list to hold the names of people.           
            List<Person> listOfPeople = new List<Person>();

            // Creates a streamreader to read from a text file.
            System.IO.StreamReader fileReader = new System.IO.StreamReader(@"C:\Users\Justin\Desktop\ListOfNames.txt");

            // While the streamreader has not yet reached the end of the stream, continue this loop.
            while (!fileReader.EndOfStream)
            {
                // Create a new person and set their name as the name that is read from the text file. Then add the person to the list. 
                Person newPerson = new Person(fileReader.ReadLine());
                listOfPeople.Add(newPerson);
            }

            // This for loop will print the name of each person on the list until it has printed every one.
            for (int i = 0; i < listOfPeople.Count; i++)
            {
                listOfPeople[i].Print();
            }

            // Prevent program from closing during debug.
            Console.ReadLine();
        }
    }

    // Creat the class person, which will be assigned names from the text file.
    class Person
    {
        public string name = "";
        public Person(string _name)
        {
            name = _name;
        }

        public void Print()
        {
            Console.WriteLine(name);
        }

    }
}