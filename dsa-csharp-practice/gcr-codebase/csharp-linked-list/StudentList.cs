using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_linked_list
{
    internal class StudentNode
    {
        //student attributes
        public int rollNumber;

        public string name;

        public int age;

        public char grade;

        public StudentNode next;

        //constructor
        public StudentNode(int rollNumber, string name, int age, char grade)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.age = age;
            this.grade = grade;
        }
    }

    class StudentList
    {
        //head node
        StudentNode head;

        //method to add student at first
        public void AddStudent(StudentNode node)
        {
            node.next = head;

            head = node;
        }

        //method to add student at last
        public void AddStudentAtLast(StudentNode node)
        {
            if (head == null)
            {
                head = node;

                return;
            }
            StudentNode temp = head;

            //loop through list
            while (temp.next != null)
            {
                temp = temp.next;
            }

            //update temp
            temp.next = node;
        }

        //method to delete student
        public void DeleteStudent(int rollNumber)
        {
            if (head == null)
            {
                return;
            }
            if (head.rollNumber == rollNumber)
            {
                head = head.next;
                return;
            }

            StudentNode temp = head;

            while (temp.next != null && temp.next.rollNumber != rollNumber)
            {
                temp = temp.next;
            }

            if (temp.next != null)
            {
                temp.next = temp.next.next;
            }
        }

        //method to search student with roll number
        public StudentNode SearchStudent(int rollNumber)
        {
            //store head in temp variable
            StudentNode temp = head;

            //loop through list
            while (temp != null)
            {
                //if student roll numbers are same
                if (temp.rollNumber == rollNumber)
                {
                    return temp;
                }

                temp = temp.next;
            }
            return null;
        }

        //method to update student grade
        public void UpdateGrade(int rollNumber, char studentGrade)
        {
            //search for student node with roll number
            StudentNode node = SearchStudent(rollNumber);

            //check if node is not null
            if (node != null)
            {
                node.grade = studentGrade;
            }
        }


        //method to display list
        public void Display()
        {
            //check if a student exists
            if (head == null)
            {
                Console.WriteLine("NO STUDENT ADDED");
                return;
            }

            //store head in temp variable
            StudentNode temp = head;

            //loop through list
            while (temp != null)
            {
                Console.WriteLine("\nSTUDENT ROLL NUMBER: " + temp.rollNumber);

                Console.WriteLine("STUDENT NAME: " + temp.name);

                Console.WriteLine("STUDENT AGE: " + temp.age);

                Console.WriteLine("STUDENT GRADE: " + temp.grade);

                Console.WriteLine("-------------------------------------------");

                //update temp node
                temp = temp.next;
            }
        }

        //main method
        public static void Main(string[] args)
        {
            Start();
        }
        public static void Start()
        {

            //create object of class StudentList
            StudentList list = new StudentList();

            //infinite loop until user exits
            while (true)
            {
                //display menu
                Console.WriteLine("\n----- STUDENT RECORD MANAGEMENT SYSTEM -----");
                Console.WriteLine("1. ADD STUDENT AT BEGINNING");
                Console.WriteLine("2. ADD STUDENT AT LAST");
                Console.WriteLine("3. DELETE STUDENT");
                Console.WriteLine("4. SEARCH STUDENT");
                Console.WriteLine("5. UPDATE STUDENT GRADE");
                Console.WriteLine("6. DISPLAY STUDENT LIST");
                Console.WriteLine("7. EXIT");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    //add student at beginning
                    case 1:
                        //take roll number
                        Console.Write("ENTER ROLL NUMBER: ");
                        int roll1 = Convert.ToInt32(Console.ReadLine());

                        //take name
                        Console.Write("ENTER NAME: ");
                        string name1 = Console.ReadLine();

                        //take age
                        Console.Write("ENTER AGE: ");
                        int age1 = Convert.ToInt32(Console.ReadLine());

                        //take grade
                        Console.Write("ENTER GRADE: ");
                        char grade1 = Convert.ToChar(Console.ReadLine());

                        //add student 
                        list.AddStudent(new StudentNode(roll1, name1, age1, grade1));
                        
                        Console.WriteLine("STUDENT ADDED AT BEGINNING");
                        break;

                    //add student at last
                    case 2:
                        //take roll number
                        Console.Write("ENTER ROLL NUMBER: ");
                        int roll2 = Convert.ToInt32(Console.ReadLine());

                        //take name
                        Console.Write("ENTER NAME: ");
                        string name2 = Console.ReadLine();

                        //take age
                        Console.Write("ENTER AGE: ");
                        int age2 = Convert.ToInt32(Console.ReadLine());

                        //take grade
                        Console.Write("ENTER GRADE: ");
                        char grade2 = Convert.ToChar(Console.ReadLine());

                        //add student at last
                        list.AddStudentAtLast(new StudentNode(roll2, name2, age2, grade2));
                       
                        Console.WriteLine("STUDENT ADDED AT LAST");
                        break;

                    //delete student node
                    case 3:
                        //take roll number
                        Console.Write("ENTER ROLL NUMBER TO DELETE: ");
                        int delRoll = Convert.ToInt32(Console.ReadLine());

                        //delete student node
                        list.DeleteStudent(delRoll);
                        Console.WriteLine("DELETED SUCCESSFULLY");
                        break;

                    //search student
                    case 4:
                        //take roll number
                        Console.Write("ENTER ROLL NUMBER TO SEARCH: ");
                        int searchRoll = Convert.ToInt32(Console.ReadLine());

                        //store result in found variable
                        StudentNode found = list.SearchStudent(searchRoll);

                        if (found != null)
                        {
                            Console.WriteLine("\nSTUDENT FOUND");
                            Console.WriteLine("ROLL NUMBER: " + found.rollNumber);
                            Console.WriteLine("NAME: " + found.name);
                            Console.WriteLine("AGE: " + found.age);
                            Console.WriteLine("GRADE: " + found.grade);
                        }
                        else
                        {
                            Console.WriteLine("STUDENT NOT FOUND");
                        }
                        break;

                    //update student grade
                    case 5:
                        //take roll number
                        Console.Write("ENTER ROLL NUMBER: ");
                        int updateRoll = Convert.ToInt32(Console.ReadLine());

                        //take new grade
                        Console.Write("ENTER NEW GRADE: ");
                        char newGrade = Convert.ToChar(Console.ReadLine());

                        //update grade
                        list.UpdateGrade(updateRoll, newGrade);
                        Console.WriteLine("GRADE UPDATED");
                        break;

                    case 6:
                        //display list
                        list.Display();
                        break;

                    case 7:
                        Console.WriteLine("EXIT SUCCESSFUL THANKYOU");
                        return;

                    default:
                        Console.WriteLine("INVALID CHOICE");
                        break;
                }
            }

        }
    }
}