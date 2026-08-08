using UniversityApp.Models;
namespace UniversityApp.Services
{
    public static class TuitionCalculator
    {
        public static double CalculateFee(Student student, Course course)
        {
            if (student.ID > 5000)
            {
               return course.Fee * 0.8; 
            }
            else
            {
                return course.Fee;
            }
        }
    }
}