using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9

{
    class Program
    {

        static void Main(string[] args)
            
        {
            int number;
            Console.WriteLine("Welcome to our C# class!");

            Console.WriteLine("Which student would you like to learn more about? (enter a number 1-5)");
            number = int.Parse(Console.ReadLine());
            if (number > 5 || number < 1)

            {
                Console.WriteLine("That student does not exist. Please try gain. (enter a numer 1-5)");
                
            }
            else if (true)
            {
               
        
            }            

            List<Student> Students = new List<Student>(5);

            Student Student1 = new Student()
            {
                ID = 1,
                Name = "Adam Brown",
                HomeTown = "Detroit",
                FavoriteFood = "Italian",
                FavoriteColor = "Blue",
            };
            Student Student2 = new Student()
            {
                ID = 2,
                Name = "Cathy Doss",
                HomeTown = "Southfield",
                FavoriteFood = "Chinese",
                FavoriteColor = "Green",
            };
            Student Student3 = new Student()
            {
                ID = 3,
                Name = "Ernie Faulk",
                HomeTown = "Warren",
                FavoriteFood = "Mexican",
                FavoriteColor = "Red",
            };
            Student Student4 = new Student()
            {
                ID = 4,
                Name = "George Hunter",
                HomeTown = "Roseville",
                FavoriteFood = "Greek",
                FavoriteColor = "Orange",
            };

            Student Student5 = new Student()
            {
                ID = 5,
                Name = "Ian Jack",
                HomeTown = "Ferndale",
                FavoriteFood = "Caribbean",
                FavoriteColor = "Purple",
            };
            Students.Add(Student1);
            Students.Add(Student2);
            Students.Add(Student3);
            Students.Add(Student4);
            Students.Add(Student5);
            foreach(Student student in Students)
            {
                Console.WriteLine("{0} lives in {1}, loves {2} cuisine and favorite color is {3}.", student.Name, student.HomeTown, student.FavoriteFood, student.FavoriteColor);
            }

        }
            
            public class Student
            {
            public int ID { get; set; }
            public string Name { get; set; }
            public string HomeTown { get; set; }
            public string FavoriteFood { get; set; }
            public string FavoriteColor { get; set; }
            
        



        }
    }
}


