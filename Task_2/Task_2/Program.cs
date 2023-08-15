using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(1111111, "John", "2223323939");
            student.DisplayInfo();

            Xodimlar xodimlar= new Xodimlar(2222222,"Ismatov Ibrohim","+999 93 486 55 04");
            xodimlar.ishhaqi = 200;
            xodimlar.DisplayInfo();

            Teacher teacher = new Teacher(12345, "A.Ochilov", "91 810 56 09");
            teacher.DisplayInfo();
           



        }
    }
    class odamlar
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public odamlar(int id,string fullname,string phonenumber)
        {
            Id = id;    
            FullName = fullname;
            PhoneNumber = phonenumber;
        }
        public void DisplayInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Id: {Id}\nFullName: {FullName}\nPhoneNumber: {PhoneNumber}");
            
        }

    }
    class Student : odamlar
    {
        public Student(int id, string fullname, string phonenumber)
            : base(id, fullname, phonenumber)
        {

        }


    }

    class Xodimlar : odamlar
    {
        public double ishhaqi { get; set; }

        public Xodimlar(int id, string fullname, string phonenumber)
            : base(id, fullname, phonenumber)
        {

        }
        public double Oylik()
        {

            return ishhaqi * 0.13;

        }
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Ish haqini 13%: {Oylik()}");
            Console.WriteLine();
        }
    }
        class Teacher : odamlar
        {
            
            public Teacher(int Id, string FullName, string PhoneNumber)
                           : base(Id, FullName, PhoneNumber)
            {

            }
           
        }
    
}