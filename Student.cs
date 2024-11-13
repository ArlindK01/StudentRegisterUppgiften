using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DatabaserUppgiftStudent
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string City { get; set; } = "";

        public override string? ToString()
        {
            return $"ID: {StudentId}, Förnamn: {FirstName}, Efternamn: {LastName}, Stad: {City}";
        }
    }
}

