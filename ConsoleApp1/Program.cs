using System.Text.RegularExpressions;

namespace ConsoleApp1
{

    internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter fullname: ");
                string fullname = Console.ReadLine();
                Console.Write("Enter email: ");
                string email = Console.ReadLine();
                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                User user = new User(fullname, email, password);
                if (user.Password == null)
                {
                    Console.WriteLine("User creation failed due to invalid password.");
                    return;
                }

                while (true)
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Show info");
                    Console.WriteLine("2. Create new group");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        user.ShowInfo();
                    }
                    else if (choice == "2")
                    {
                        Console.Write("Enter group number: ");
                        string groupNo = Console.ReadLine();
                        Console.Write("Enter student limit: ");
                        int studentLimit = int.Parse(Console.ReadLine());

                        Group group = new Group(groupNo, studentLimit);

                        if (group.GroupNo == null || group.StudentLimit == 0)
                        {
                            Console.WriteLine("Group creation failed.");
                            continue;
                        }

                        while (true)
                        {
                            Console.WriteLine("Group Menu:");
                            Console.WriteLine("1. Show all students");
                            Console.WriteLine("2. Get student by id");
                            Console.WriteLine("3. Add student");
                            Console.WriteLine("0. Quit");

                            string groupChoice = Console.ReadLine();

                            if (groupChoice == "1")
                            {
                                var students = group.GetAllStudents();
                                foreach (var student in students)
                                {
                                    student.StudentInfo();
                                }
                            }
                            else if (groupChoice == "2")
                            {
                                Console.Write("Enter student id: ");
                                int id = int.Parse(Console.ReadLine());
                                var student = group.GetStudent(id);
                                if (student != null)
                                {
                                    student.StudentInfo();
                                }
                                else
                                {
                                    Console.WriteLine("Student not found.");
                                }
                            }
                            else if (groupChoice == "3")
                            {
                                Console.Write("Enter student fullname: ");
                                string studentFullname = Console.ReadLine();
                                Console.Write("Enter student point: ");
                                double point = double.Parse(Console.ReadLine());
                                var student = new Student(studentFullname, point);
                                group.AddStudent(student);
                            }
                            else if (groupChoice == "0")
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }


    

