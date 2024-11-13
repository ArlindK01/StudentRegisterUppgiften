using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaserUppgiftStudent
{
    internal class StudentLogbook
    {
        StudentHandler studentHandler = new StudentHandler();
        public void StartStudentLogbook()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("1. Registrera ny student.");
                Console.WriteLine("2. Ändra en befintlig student.");
                Console.WriteLine("3. Lista alla studenter.");
                Console.WriteLine("4. Avsluta.");

                if (!int.TryParse(Console.ReadLine(), out int menyChoise))
                {
                    Console.WriteLine("Vänligen ange ett giltigt alternativ.");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                
                switch (menyChoise)
                {
                    case 1:
                        studentHandler.AddStudent();
                        break;

                    case 2:
                        studentHandler.ChangeStudent();
                        break;

                    case 3:
                        studentHandler.ListAllStudents();
                        break;

                    case 4:
                        Console.WriteLine("Du har valt att avsluta... ");
                        Console.ReadLine();
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        Console.ReadLine();
                        break;
                }
                Console.Clear();
            }
        }

    }
}
