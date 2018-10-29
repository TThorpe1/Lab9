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

            // James - Try to use validation, google int.TryParse() instead.
            number = int.Parse(Console.ReadLine());

            // James - if you are looking within a number range, you want to use "&&" instead of "||", you
            // want to use "&&" because it's logically saying a number is within the range of 2 to 4.
            // with your current logic, you are saying if the number is LARGER than 5, or if it is, LESS than 1, 
            // so your current logic is not checking within that number range, it's checking for the opposite, also,
            // your logic has no reason to check the second condition, because IF the number is already greater than 5, than your
            // if statement will shortcircuit and only consider the first condition without looking at the second condition.
            // Also, if you want the user to select between 5 and 1, you would need to use 
            // number <=(which is less than or and equal to) and number >= (which is greater than and equal to).
            if (number > 5 || number < 1)
            // James - From a user experience, consider displaying all of the possible users to select from so 
            // the user has some insight on who they are selecting, it could look like 
            // 1) Adam Brown
            // 2) Cathy Doss
            {
                Console.WriteLine("That student does not exist. Please try gain. (enter a numer 1-5)");
                
            }
            // James - if you want the program to run if the condition above is false, you do not need an 
            // esle if, you can just use an "else"
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
            // James - This is going to display every single user in the list, so the user does not have a chance to actually display the
            // selected user. 
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


