using UniversityApp.Models;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Student s = new Student("Alice", 1234);
Student senior = new Student("Senior Student", 6000);
Student junior = new Student("Junior Student", 1000);
Console.WriteLine($"Student Name:{s.Name} - ID:{s.ID}");
Course c1 = new Course("Programming", 1000);
senior.Balance=1000;
junior.Balance=1000;
s.Balance=600;
s.Enroll(c1);
Console.WriteLine($"Student Name:{senior.Name} - ID:{senior.ID}");
senior.Enroll(c1);

Console.WriteLine($"Student Name:{junior.Name} - ID:{junior.ID}");
junior.Enroll(c1);

