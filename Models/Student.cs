using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork21Aprel.Models
{
    class Student
    {
        private string _fullname;
        public string FullName 
        {
            get => _fullname;
            set
            {
                if (!ChechFullName(value))
                {
                    Console.WriteLine("Duzgun daxil et !");
                    value = Console.ReadLine();
                }
            }
        }
        private string _groupNo;
        public string GroupNo 
        {
            get => _groupNo;
            set
            {
                if (!CheckGroupNo(value))
                {
                    Console.WriteLine("Qrupun nomresini duzgun daxil et!");
                    value = Console.ReadLine();
                }
            }
        }
        public int Age;

        
        public Student(string fullName , string groupNo , int age)
        {
            FullName = fullName;
            GroupNo = groupNo;
            Age = age;
        }
        



        public static bool CheckGroupNo(string groupnno)
        {
            if (groupnno.Length == 4)
            {
                int count = 0;
                bool check = false;

                if (char.IsUpper(groupnno[0]))
                {
                    for (int i = 1; i < groupnno.Length; i++)
                    {
                        if (char.IsDigit(groupnno[i]))
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (count == 3)
                    {
                        check = true;
                        return check;
                    }
                }
            }
           return false;



        }
        public static bool ChechFullName(string Fullname)
        {
            bool check = false;
            int count = 0;

            if (Fullname.Contains(' '))

            { 
                foreach (char item in Fullname)
                {
                    if(item  == ' ')
                    {
                        count++;
                    }
                }
                if (count >= 1)
                {
                    check = true;
                }
                
            }
            else { return check; }



            return check;
        }
    }
}
