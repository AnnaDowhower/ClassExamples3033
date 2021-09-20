using System;
using System.Collections.Generic;
using System.Text;

namespace WPF
{
    public class Student
    {
        public int SoonerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsOnProbation { get; set; }
        public double GPA { get; set; }

        private double BursarBalance;

        public Student()
        {
            SoonerID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            IsOnProbation = false; //default is false typically
            GPA = 0;
            BursarBalance = 0;
        }
        public Student(int id, string fName, string lName, double BursarBalance)
        {
            SoonerID = id;
            FirstName = fName;
            LastName = lName;
            IsOnProbation = false;
            GPA = 0;
            this.BursarBalance = BursarBalance;
        }

        public void MakePayment(double amount)
        {
            if (amount <0)
            {
                Console.WriteLine("Invalid");
                //throw new Exception("Amount must be greater than 0");
            }
            BursarBalance -= amount;
        }

        public double CheckBalance()
        {
            return BursarBalance;
        }
        public string ToSring()
        {
            return $"{LastName}, {FirstName} ({GPA})";
        }
    }
}
