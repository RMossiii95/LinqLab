using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            //Nums questions
            //1
            Console.WriteLine("Minimum value of the array: ");

            foreach(int m in nums)
            {
                Console.WriteLine(m);
            }
            int result = nums.Min();
            Console.WriteLine("Minimum Value: {0}", result);

            //2
            Console.WriteLine();
            Console.WriteLine("Maximum value of the array: ");

            foreach(int m in nums)
            {
                Console.WriteLine(m);
            }
            int result2 = nums.Max();
            Console.WriteLine("Maximum value: {0}", result2);

            //3
            Console.WriteLine();
            Console.WriteLine("Maximum value less than 10000");

            int mxValueLessThan10000 = nums.Where(x => x < 10000).Max();
            Console.WriteLine("Max less than 10000: " + mxValueLessThan10000);

            //4
            Console.WriteLine();
            Console.WriteLine("Values between 10 and 100");
            List<int> numsInRange = nums.Where(x => 10 <= x && x <= 100).ToList();

            foreach(int m in numsInRange)
            {
                Console.WriteLine(m);
            }

            //5
            Console.WriteLine();
            Console.WriteLine("All values between 100000 and 999999");
            List<int> numsInRange2 = nums.Where(x => 100000 <= x && x <= 999999).ToList();

            foreach(int m in numsInRange2)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();

            //6
            List<int> evens = nums.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("All evens");
            foreach (int even in evens)
            {
                Console.WriteLine(even);
            }
            Console.WriteLine();
            //For Students

            //1 
            List<Student> numsInRange3 = students.Where(x => x.Age > 21).ToList();
            foreach(Student a in numsInRange3)
            {
                
                Console.WriteLine("Students over 21:" + a.Name);
            }
            Console.WriteLine();

            //2 
            
            int findOldestStudent = students.Max(x => x.Age);
            List<Student> oldestStudent = students.Where(x => x.Age == findOldestStudent).ToList();
            foreach(Student o in oldestStudent)
            {
                Console.WriteLine("Oldest Student: " + o.Name + o.Age);
            }
            Console.WriteLine();

            //3 
            int findYoungestStudent = students.Min(x => x.Age);
            List<Student> youngestStudent = students.Where(x => x.Age == findYoungestStudent).ToList();
            foreach(Student y in youngestStudent)
            {
                Console.WriteLine("Youngest Student " + y.Name + y.Age);
            }
            Console.WriteLine();

            //4
            Console.WriteLine("Oldest student under 25:");
            
            int oldestAgeUnder25 = students.Where(x => x.Age < 25).Max(x => x.Age);
            Student oldestStudentUnder25 = students.Where(x => x.Age == oldestAgeUnder25).ToList().First();
            Console.WriteLine(oldestStudentUnder25.Name);

            //5
            Console.WriteLine();
            Console.WriteLine("All stidents over 21 and even");
            List<Student> over21Even = students.Where(x => x.Age >= 25 && x.Age % 2 == 0).ToList();
            
            foreach (Student s in over21Even)
            {
                Console.WriteLine(s.Name);
            }

            //6

            Console.WriteLine();
            Console.WriteLine("All students between 13 and 19");
            List<Student> ageInRange = students.Where(x => 13 <= x.Age && x.Age < 19).ToList();

            foreach (Student m in ageInRange)
            {
                Console.WriteLine(m.Name);
            }
            Console.WriteLine();

            //7
            Console.WriteLine("Students whose name stats with a vowel:");
            List<Student> nameStartsWithVowel = students.Where(x => x.Name.StartsWith('A') || x.Name.StartsWith('E') || x.Name.StartsWith('I') | x.Name.StartsWith('O') || x.Name.StartsWith('U')).ToList();
            foreach (Student s in nameStartsWithVowel)
            {
                Console.WriteLine(s.Name);
            }
        }
    }
}
