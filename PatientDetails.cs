using System;

namespace Assignment1
{

    public class Patient
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }


        public Patient(double purchases, string name, int id)
        {
            Id = Id;
            Name = Name;
            Number = Number;
        }


        public string GetContactInfo() { return "ContactInfo"; }
        public string GetTransactionHistory() { return "History"; }


    }

    class PatientPrgm
    {
        static void Main()
        {

            Patient pst1 = new Patient(4987.63, "Northwind", 90108);


            pst1.Id += 1;
        }
    }
}