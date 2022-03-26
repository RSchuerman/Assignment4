using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        public static List<Course> _courses = new List<Course>();
        static void Main(string[] args)
        {
            #region setup
            //General Course Setup
            //Computers
            var computerScience1 = new Course("Computer Science I", "CSC150", "Computer Science", "NA");
            var computerScience2 = new Course("Computer Science II", "CSC250", "Computer Science", "CSC150");
            var dataStructures = new Course("Data Structures", "CSC300", "Computer Science", "CSC250");
            var objectOrientedDesign = new Course("Object Oriented Design", "CSC260", "Computer Science", "CSC250");
            //Composition
            var composition1 = new Course("Composition I", "ENGL101", "Written Communication", "NA");
            var composition2 = new Course("Composition II", "ENGL201", "Written Communication", "ENGL101");
            //Spanish
            var spanish1 = new Course("Spanish I", "SPAN101", "Arts and Humanities", "NA");
            var spanish2 = new Course("Spanish II", "SPAN102", "Arts and Humanities", "SPAN101");
            _courses.Add(computerScience1);
            _courses.Add(computerScience2);
            _courses.Add(dataStructures);
            _courses.Add(objectOrientedDesign);
            _courses.Add(composition1);
            _courses.Add(composition2);
            _courses.Add(spanish1);
            _courses.Add(spanish2);

            //Course Section Setup
            //Computers
            //CSC150
            computerScience1.createSection(1.00, "Beacom", "Andrew Kramer", "DO1");
            computerScience1.createSection(2.00, "Beacom", "Andrew Kramer", "DO2");
            computerScience1.createSection(3.00, "Beacom", "Andrew Kramer", "DO3");
            //CSC250
            computerScience2.createSection(1.00, "Beacom", "Tom Halverson", "DO1");
            computerScience2.createSection(2.00, "Beacom", "Tom Halverson", "DO2");
            computerScience2.createSection(3.00, "Beacom", "Tom Halverson", "DO3");
            //CSC300
            dataStructures.createSection(4.00, "Beacom", "Tom Halverson", "DO1");
            dataStructures.createSection(5.00, "Beacom", "Tom Halverson", "DO2");
            dataStructures.createSection(6.00, "Beacom", "Tom Halverson", "DO3");
            //CSC260
            objectOrientedDesign.createSection(1.00, "Beacom", "Jason Jenkins", "DO1");
            objectOrientedDesign.createSection(2.00, "Beacom", "Jason Jenkins", "DO2");
            objectOrientedDesign.createSection(3.00, "Beacom", "Jason Jenkins", "DO3");
            //Composition
            //ENGL101
            composition1.createSection(1.00, "Kennedy Center", "Scott Richardson", "DO1");
            composition1.createSection(2.00, "Kennedy Center", "Scott Richardson", "DO2");
            //ENGL201
            composition2.createSection(3.00, "Kennedy Center", "Scott Richardson", "DO1");
            composition2.createSection(4.00, "Kennedy Center", "Scott Richardson", "DO2");
            //Spanish
            //SPAN101
            spanish1.createSection(1.00, "Internet", "TeacherName", "DO1");
            spanish1.createSection(2.00, "Internet", "TeacherName", "DO2");
            //SPAN102
            spanish2.createSection(3.00, "Internet", "TeacherName", "DO1");
            spanish2.createSection(4.00, "Internet", "TeacherName", "DO2");

                //User Setup
                    //Student
                    var student1 = new Student("Student1@email.com", "Password1!", 1, true, 0.0, "Advisor1");
                    var student2 = new Student("Student2@email.com", "Password1!", 2, true, 0.0, "Advisor1");
                    var student3 = new Student("Student3@email.com", "Password1!", 3, true, 0.0, "Advisor2");
                    var student4 = new Student("Student4@email.com", "Password1!", 4, true, 0.0, "Advisor2");
                    //Faculty
                    var faculty1 = new Faculty("Andrew@email.com", "Password1!", 5, "Computer Science");
                    var faculty2 = new Faculty("Tom@email.com", "Password1!", 6, "Computer Science");
                    var faculty3 = new Faculty("Jason@email.com", "Password1!", 7, "Computer Science");
                    var faculty4 = new Faculty("Scott@email.com", "Password1!", 8, "Written Communication");
                    var faculty5 = new Faculty("TeacherName@email.com", "Password1!", 9, "Arts and Humanities");
                    //Advisor
                    var advisor1 = new Advisor("Advisor1@email.com", "Password1!", 10);
                    var advisor2 = new Advisor("Advisor2@email.com", "Password1!", 11);
            #endregion setup

            student1.addSchedule("Fall2022", "Fall2022", false);
            student1.registerForSection(computerScience1, "CSC150DO1", "Fall2022");
            student1.registerForSection(composition1, "ENGL101DO1", "Fall2022");
            student1.registerForSection(spanish1, "SPAN101DO1", "Fall2022");
            student1.viewSchedule("Fall2022");
        }       
    }
}
