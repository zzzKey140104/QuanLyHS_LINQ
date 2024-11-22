using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyHS_LINQ;

namespace QuanLyHS_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo danh sách học sinh
            List<Student> students = new List<Student>
            {
                new Student(1, "A", 20),
                new Student(2, "B", 25),
                new Student(3, "C", 15),
                new Student(4, "D", 21),
                new Student(5, "E", 30)
            };

            // a. In danh sách toàn bộ học sinh
            Console.WriteLine("Danh sach hoc sinh:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            // b. Tìm và in danh sách các học sinh có tuổi từ 15 đến 18
            Console.WriteLine("\nHoc sinh co tuoi tu 15 -> 18:");
            var age15to18 = students.Where(s => s.Age >= 15 && s.Age <= 18);
            foreach (var student in age15to18)
            {
                Console.WriteLine(student);
            }

            // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
            Console.WriteLine("\nHoc sinh co ten bat dau bang chu 'A':");
            var nameStartWithA = students.Where(s => s.Name.StartsWith("A"));
            foreach (var student in nameStartWithA)
            {
                Console.WriteLine(student);
            }

            // d. Tính tổng tuổi của tất cả học sinh trong danh sách
            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh: {totalAge}");

            // e. Tìm và in ra học sinh có tuổi lớn nhất
            var oldestStudent = students.OrderByDescending(s => s.Age).First();
            Console.WriteLine($"\nHoc sinh lon tuoi nhat: {oldestStudent}");

            // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra
            Console.WriteLine("\nDanh sach hoc sinh duoc sap xep theo so tuoi tang dan:");
            var sortedStudents = students.OrderBy(s => s.Age);
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}
