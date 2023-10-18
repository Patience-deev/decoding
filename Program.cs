using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string IDNumber = "9702010441088";
            if (IDNumber.Length != 13)
            {
                Console.WriteLine("Invalid ID number. It should be 13 characters long.");
                return;
            }
            int year = int.Parse(IDNumber.Substring(0, 2));
            int month = int.Parse(IDNumber.Substring(2, 2));
            int day = int.Parse(IDNumber.Substring(4, 2));

            DateTime dateOfBirth = new DateTime(1900 + year, month, day);
            char genderCode = IDNumber[6];

            string gender = (genderCode >= '0' && genderCode <= '4') ? "Female" : "Male";
            char citizenship = IDNumber[10];
            string citizenshipStatus = (citizenship == '0') ? "SA Citizen" : "Permanent Resident";
            Console.WriteLine("Date of Birth: " + dateOfBirth.ToShortDateString());
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Citizenship Status: " + citizenshipStatus);
            Console.ReadLine();
        }
    }
}
