using HomeWork21Aprel.Models;
using System;

namespace HomeWork21Aprel
{
    class Program
    {
        static void Main(string[] args)
        {
            string FullName = Console.ReadLine();
            string GroupNo = Console.ReadLine();
            Student student = new Student("Qurban Zakiri","P128",29);
            Console.WriteLine(Student.CheckGroupNo(GroupNo));
            Console.WriteLine(Student.ChechFullName(FullName));
            

        }
    }
}
