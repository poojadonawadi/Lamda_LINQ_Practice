using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LambdaExpression_And_LINQ_Practice
{
    internal class PersonDataManagement
    {
        public int SSN { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int age { get; set; }

        public static void GetDetails()
        {

            List<PersonDataManagement> data = new List<PersonDataManagement>()
            {
            new PersonDataManagement{SSN = 101, name = "Pooja", address = "Donawadi", age = 22},
            new PersonDataManagement{SSN = 121, name = "Disha", address = "Sakhalkar", age = 18},
            new PersonDataManagement{SSN = 131, name = "Ankitha", address = "BL", age = 75},
            new PersonDataManagement{SSN = 151, name = "Pushpa", address = "Hiremath", age = 21},
            new PersonDataManagement{SSN = 151, name = "Vijaylaxmi", address = "Kudachi", age = 15},
            };
            

            // UC 1: Desplaying top two records having age less than 60
            List<PersonDataManagement> records = data.FindAll(x => x.age <= 60).Take(2).ToList();
            //List<PersonDataManagement> result = records.Take(2).ToList();

            foreach (PersonDataManagement element in records)
            {
                Console.WriteLine($"SSN: {element.SSN} Name:{element.name} Address:{element.address} Age:{element.age}");
            }

            //UC 2: get person records age between 13 and 18
            List<PersonDataManagement> ageBetween = data.FindAll(a => a.age >= 13 && a.age <= 18).ToList();

            foreach(PersonDataManagement getData in ageBetween)
            {
                Console.WriteLine($"SSN: {getData.SSN} Name:{getData.name} Address:{getData.address} Age:{getData.age}");
            }

            //UC 3: Average of age in the list
            double getAgeAverage = data.Average(x => x.age);

            Console.WriteLine(getAgeAverage);

            //UC 4: Checking for specific person
            List<PersonDataManagement> person = data.FindAll(res => res.name == "shivleela").ToList();

            Console.WriteLine("The person with specific name is present");
            
            
        }

    }
}
