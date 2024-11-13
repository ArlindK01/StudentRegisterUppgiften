using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaserUppgiftStudent
{
    internal class StudentHandler
    {
        private readonly StudentDbContext dbCtx = new StudentDbContext();

        public void AddStudent()
        {
            Console.WriteLine("Ange studentens förnamn:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Ange studentens efternamn:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Ange studentens stad:");
            string city = Console.ReadLine();

            Student newStudent = new Student
            {
                FirstName = firstName,
                LastName = lastName,
                City = city
            };

            dbCtx.Students.Add(newStudent);
            dbCtx.SaveChanges();

            Console.WriteLine("Studenten har registrerats.");
            Console.ReadLine();
        }

        public void ChangeStudent()
        {
            foreach (var item in dbCtx.Students)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Vilken student vill du ändra? Välj studentens ID: ");
            int studentUpdate = int.Parse(Console.ReadLine());
            var changedStudent = dbCtx.Students.Where(S => S.StudentId == studentUpdate).FirstOrDefault<Student>();

            Console.WriteLine("Nytt Förnamn: ");
            string newFirstName = Console.ReadLine();
            changedStudent.FirstName = newFirstName;

            Console.WriteLine("Nytt efternamn: ");
            string newLastName = Console.ReadLine();
            changedStudent.LastName = newLastName;


            Console.WriteLine("Ny stad: ");
            string newCity = Console.ReadLine();
            changedStudent.City = newCity;
            dbCtx.SaveChanges();

            Console.WriteLine("Ändringarna är gjorda! ");
            Console.ReadLine();

        }
        public void ListAllStudents()
        {
            var students = dbCtx.Students.ToList();
            if (!students.Any())
            {
                Console.WriteLine("Inga studenter registrerade.");
                return;
            }

            Console.WriteLine("Lista över alla registrerade studenter:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.ReadLine();
        }

    }
}