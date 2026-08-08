using UniversityApp.Services;
namespace UniversityApp.Models
{
    public class Student
    {
        public string Name{get;set;}
        public int ID;
        public Student(string name, int id)
        {
            Name=name;
            ID=id;
        }
        public double _balance;
        public double Balance
        {
            get{return _balance;}
            set
            {
                if (value >= 0)
                {
                    _balance=value;
                }
                else
                {
                    Console.WriteLine("Error: Balance cannot be negative.");
                }
            }
        }
        public void Enroll(Course course)
        {
            double finalFee=TuitionCalculator.CalculateFee(this, course);
            if (Balance >= course.Fee)
            {
                Balance-=finalFee;
                Console.WriteLine($"{Name} enrolled in {course.Title} for {finalFee}£ - Remain Balance:{Balance}£\n");
            }
            else
            {
                Console.WriteLine($"Insufficient funds for {Name} to enroll in {course.Title}. Required: {finalFee} £, Balance: {Balance} £\n");
            }
            
        }

    }
}