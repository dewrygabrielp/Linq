using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            List<Person> lst = new List<Person>()
            {
                new Person(){Name = "Dewry", Age = 24},
                new Person(){Name= "Darlenis", Age = 22},
                new Person(){Name= "Danilo", Age = 51}
            };
            List<Person> lst1 = new List<Person>()
             {
                 new Person(){Name = "Vicenta", Age = 51},
                 new Person(){Name= "Ramon", Age = 44},
                 new Person(){Name= "Juan Pablo Duarte", Age = 44}
             };
            /*List<Pet> ListPet = new List<Pet>()
            {
                new Pet() {NamePet = "Nigga", Color = "Black"},
                new Pet() {NamePet = "Bobby", Color="Brown"},
                new Pet() {NamePet = "Tito", Color = "White"}
            };*/
            List<string> ListOrder = (from d in lst select d).Union(lst1).OrderBy(d => d.Age).Select(d => d.NameAndAge).ToList();
            //IMPORTAN!
            /* with this catch it will omit the first three data of the collection and it will only take the first one after the omitted three.
to show all remove the skip and take methods*/

            List<string> ListOrder1 = (from d in lst select d).Union(lst1).Skip(3).Take(1).OrderBy(d => d.Age).Select(d => d.NameAndAge).ToList();
            /*
            List<string> ListPet = new List<string>()
            {
                 "Nigga - Black",
                
               "Bobby  - Brown", "Tito - White"
            };
            //TESTING METHODS:
           // take, skip, select, union, count
            List<string> OrderList = (from d in lst

                                      select d.NameAndAge )
                                      .Union(ListPet)
                                      .OrderBy(d=>d)
                                      .ToList();
            */

            foreach (var item in ListOrder)
            {
                Console.WriteLine(item);
            }
           

            Console.ReadKey();
        }
        class Person
        {
            private string _Name;
            private int _Age;
            public string NameAndAge
            {
                get {
                    return Name +" " + Age;
                }
            }
            public string Name { get => _Name; set => _Name = value; }
            public int Age { get => _Age; set => _Age = value; }
            
        }
        class Pet
        {
            private string _NamePet;
            private string _Color;

            public string NameAndColor
            {
                get
                {
                    return NamePet + " " + Color;
                }
            }

            public string NamePet { get => _NamePet; set => _NamePet = value; }
            public string Color { get => _Color; set => _Color = value; }
        }
    }
}
