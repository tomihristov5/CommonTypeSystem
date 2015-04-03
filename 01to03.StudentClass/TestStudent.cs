// Problem 1. Student class
// Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, 
// mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and 
// faculties.
// Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

// Problem 2. IClonable
// Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a 
// new object of type Student.

// Problem 3. IComparable
// Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) 
// and by social security number (as second criteria, in increasing order).

namespace _01to03.StudentClass
{
    using System;

    public static class TestStudent
    {
        public static void Main()
        {
            var student = new Student("Gosho", "Ivanov", "Petrov", "17493452", "Plovdiv maina str.", "056321845325",
                "gosho@gmail.com", 2, Universities.SanFranciscoUniversity, Faculties.technical,
                Specialties.computerEngeneering);

            Console.WriteLine(student);
            Console.WriteLine("Hashcode: " + student.GetHashCode());

            Console.WriteLine();

            var anotherStudent = new Student("Pesho", "Hristov", "Georgiev", "9843213", "Maina town str.", "045513698534",
                "pesho@gmail.com", 4, Universities.SanFranciscoUniversity, Faculties.science,
                Specialties.physics);

            Console.WriteLine(anotherStudent);
            Console.WriteLine("Hashcode: " + anotherStudent.GetHashCode());

            Console.WriteLine();
            Console.WriteLine(student.CompareTo(anotherStudent));
        }
    }
}
