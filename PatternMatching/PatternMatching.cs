using System;

namespace PatternMatching
{
    class Student
    {
        public int student_id { get; set; }
        public string student_name { get; set; }
        public string student_class { get; set; }
        public Student(int student_id, string student_name, string student_class)
        {
            this.student_id = student_id;
            this.student_name = student_name;
            this.student_class = student_class;
        }

    }


    class Teacher
    {
        public string Name { get; set; }
        public string Specialization { get; set; }

        public Teacher(string Name,string Specialization)
        {
            this.Name = Name;
            this.Specialization = Specialization;
        }
    }

    class Anonymouse
    {
        public int just_id { get; set; }
        public Anonymouse(int just_id)
        {
            this.just_id = just_id;
        }

    }


    public class PatternMatching
    {
        static void Main(string[] args)
        {
            Student sarvesh = new Student(101, "Sarvesh Patil", "MCA3");
            Teacher sir = new Teacher("Patil Sir", "PT");
            Anonymouse anon = new Anonymouse(1);
            if (sarvesh is Student)
            {
                Console.WriteLine("True");

            }
            else
            {
                Console.WriteLine("False");
            }

            checkObject(sarvesh);
            checkObject(sir);
            checkObject(anon);
            Console.ReadKey();

        }


        public static void checkObject(object obj)
        {
            switch(obj)
            {
                case Student student:
                    Console.WriteLine("Student Class Object");
                    Console.WriteLine(student.student_id+student.student_name+student.student_class);
                    break;

                case Teacher teacher:
                    Console.WriteLine("Teacher Class Object");
                    Console.WriteLine(teacher.Name+teacher.Specialization);
                    break;

                default:
                    throw new ArgumentException(
                        message: "Object Not Recognised",
                        paramName: nameof(obj));


            }

        }
    }
}
