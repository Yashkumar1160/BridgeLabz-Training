using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review.course_management
{
    internal class CourseMenu
    {

        public static void DisplayMenu()
        {
            Console.WriteLine("-------COURSE MANAGEMENT SYSTEM--------");

            CourseUtility utility = new CourseUtility();

            while (true)
            {
                Console.WriteLine("\n1. ADD STUDENT IN HYBRID COURSE");
                Console.WriteLine("2. ADD STUDENT IN OFFLINE COURSE");
                Console.WriteLine("3. ADD STUDENT IN ONLINE COURSE");
                Console.WriteLine("4. DISPLAY ALL STUDENTS");
                Console.WriteLine("5. DISPLAY TOTAL STUDENTS");
                Console.WriteLine("6. EXIT PROGRAM");
                Console.Write("ENTER YOUR CHOICE: ");

                int choice=Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("ENTER ROLL NUMBER: ");
                        int hybridRollNumber = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("ENTER STUDENT NAME: ");
                        string hybridStudentName=Console.ReadLine();

                        HybridCourse hybridCourse = new HybridCourse(hybridStudentName, "HYBRID COURSE", hybridRollNumber);

                        utility.AddStudentCourse(hybridCourse);
                        break;


                    case 2:
                        Console.WriteLine("ENTER ROLL NUMBER: ");
                        int offlineRollNumber = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("ENTER STUDENT NAME: ");
                        string offlineStudentName = Console.ReadLine();

                        OfflineCourse offlineCourse = new OfflineCourse(offlineStudentName, "OFFLINE COURSE", offlineRollNumber);

                        utility.AddStudentCourse(offlineCourse);
                        break;


                    case 3:
                        Console.WriteLine("ENTER ROLL NUMBER: ");
                        int onlineRollNumber = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("ENTER STUDENT NAME: ");
                        string onlineStudentName = Console.ReadLine();


                        OnlineCourse onlineCourse = new OnlineCourse(onlineStudentName, "ONLINE COURSE", onlineRollNumber);

                        utility.AddStudentCourse(onlineCourse);
                        break;


                    case 4:
                        utility.DisplayCourseDetails();
                        break;

                    case 5:
                        utility.DisplayTotalStudents();
                        break;

                    case 6:
                        Console.WriteLine("EXIT SUCCESSFUL");
                        return;

                    default:
                        Console.WriteLine("INVALID CHOICE");
                        break;


                }

            }
        }
    }
}
