using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_linked_list
{
    internal class TaskNode
    {
        //task attributes
        public int taskId;

        public string taskName;

        public int priority;

        public string dueDate;

        //pointer for circular linked list
        public TaskNode next;

        //constructor
        public TaskNode(int taskId, string taskName, int priority, string dueDate)
        {
            this.taskId = taskId;
            this.taskName = taskName;
            this.priority = priority;
            this.dueDate = dueDate;
        }
    }

    class TaskScheduler
    {
        //head node
        TaskNode head;

        //pointer to track current task
        TaskNode current;

        //method to add task at beginning
        public void AddAtBeginning(TaskNode node)
        {
            //check if list is empty
            if (head == null)
            {
                head = node;
                node.next = head;
                current = head;
                return;
            }

            //store last node
            TaskNode temp = head;

            while (temp.next != head)
            {
                temp = temp.next;
            }

            //link new node
            node.next = head;

            temp.next = node;

            head = node;
        }

        //method to add task at last
        public void AddAtLast(TaskNode node)
        {
            //check if list is empty
            if (head == null)
            {
                head = node;
                node.next = head;
                current = head;
                return;
            }

            //store last node
            TaskNode temp = head;

            while (temp.next != head)
            {
                temp = temp.next;
            }

            //link new node at end
            temp.next = node;
            node.next = head;
        }

        //method to add task at specific position
        public void AddAtPosition(TaskNode node, int position)
        {
            //if position is first or list is empty
            if (position <= 1 || head == null)
            {
                AddAtBeginning(node);
                return;
            }

            //store head in temp variable
            TaskNode temp = head;
            int count = 1;

            //loop to reach desired position
            while (temp.next != head && count < position - 1)
            {
                temp = temp.next;
                count++;
            }

            //update links
            node.next = temp.next;
            temp.next = node;
        }

        //method to remove task by task id
        public void RemoveTask(int taskId)
        {
            //check if list is empty
            if (head == null)
            {
                Console.WriteLine("NO TASKS AVAILABLE");
                return;
            }

            TaskNode temp = head;
            TaskNode prev = null;

            //loop through circular list
            do
            {
                //check task id
                if (temp.taskId == taskId)
                {
                    //if only one node
                    if (temp == head && temp.next == head)
                    {
                        head = current = null;
                    }
                    //if head node
                    else if (temp == head)
                    {
                        prev = head;
                        while (prev.next != head)
                        {
                            prev = prev.next;
                        }
                        head = head.next;
                        prev.next = head;
                    }
                    //if middle or last node
                    else
                    {
                        prev.next = temp.next;
                    }

                    Console.WriteLine("TASK REMOVED SUCCESSFULLY");
                    return;
                }

                prev = temp;
                temp = temp.next;

            } while (temp != head);

            Console.WriteLine("TASK NOT FOUND");
        }

        //method to view current task and move to next
        public void ViewCurrentTask()
        {
            //check if list is empty
            if (current == null)
            {
                Console.WriteLine("NO TASKS AVAILABLE");
                return;
            }

            //display current task
            DisplayTask(current);

            //move to next task
            current = current.next;
        }

        //method to display all tasks
        public void DisplayAllTasks()
        {
            //check if list is empty
            if (head == null)
            {
                Console.WriteLine("NO TASKS AVAILABLE");
                return;
            }

            //store head in temp variable
            TaskNode temp = head;

            //loop through circular list
            do
            {
                DisplayTask(temp);
                temp = temp.next;

            } while (temp != head);
        }

        //method to search task by priority
        public void SearchByPriority(int priority)
        {
            //check if list is empty
            if (head == null)
            {
                Console.WriteLine("NO TASKS AVAILABLE");
                return;
            }

            TaskNode temp = head;
            bool found = false;

            //loop through circular list
            do
            {
                //check priority
                if (temp.priority == priority)
                {
                    DisplayTask(temp);
                    found = true;
                }
                temp = temp.next;

            } while (temp != head);

            //if no task found
            if (!found)
            {
                Console.WriteLine("NO TASK FOUND WITH GIVEN PRIORITY");
            }
        }

        //method to display single task
        public void DisplayTask(TaskNode task)
        {
            Console.WriteLine("\nTASK ID: " + task.taskId);

            Console.WriteLine("TASK NAME: " + task.taskName);

            Console.WriteLine("PRIORITY: " + task.priority);

            Console.WriteLine("DUE DATE: " + task.dueDate);

            Console.WriteLine("---------------------------------------");
        }

        ////main method
        public static void Main(string[] args)
        {
            Start();
        }

        //method to start program
        public static void Start()
        {
            //create object of TaskScheduler
            TaskScheduler scheduler = new TaskScheduler();

            //infinite loop until user exits
            while (true)
            {
                //display menu
                Console.WriteLine("\n----- TASK SCHEDULER SYSTEM -----");
                Console.WriteLine("1. ADD TASK AT BEGINNING");
                Console.WriteLine("2. ADD TASK AT LAST");
                Console.WriteLine("3. ADD TASK AT SPECIFIC POSITION");
                Console.WriteLine("4. REMOVE TASK BY TASK ID");
                Console.WriteLine("5. VIEW CURRENT TASK");
                Console.WriteLine("6. SEARCH TASK BY PRIORITY");
                Console.WriteLine("7. DISPLAY ALL TASKS");
                Console.WriteLine("8. EXIT");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    //add task at beginning
                    case 1:
                        //take task id
                        Console.Write("ENTER TASK ID: ");
                        int id1 = Convert.ToInt32(Console.ReadLine());

                        //take task name
                        Console.Write("ENTER TASK NAME: ");
                        string name1 = Console.ReadLine();

                        //take priority
                        Console.Write("ENTER PRIORITY: ");
                        int priority1 = Convert.ToInt32(Console.ReadLine());

                        //take due date
                        Console.Write("ENTER DUE DATE: ");
                        string date1 = Console.ReadLine();

                        //add task at beginning
                        scheduler.AddAtBeginning(new TaskNode(id1, name1, priority1, date1));
                        
                        Console.WriteLine("TASK ADDED AT BEGINNING");
                        break;

                    //add task at last
                    case 2:
                        //take task id
                        Console.Write("ENTER TASK ID: ");
                        int id2 = Convert.ToInt32(Console.ReadLine());

                        //take task name
                        Console.Write("ENTER TASK NAME: ");
                        string name2 = Console.ReadLine();

                        //take priority
                        Console.Write("ENTER PRIORITY: ");
                        int priority2 = Convert.ToInt32(Console.ReadLine());

                        //take due date
                        Console.Write("ENTER DUE DATE: ");
                        string date2 = Console.ReadLine();

                        //add task at last
                        scheduler.AddAtLast(new TaskNode(id2, name2, priority2, date2));
                        
                        Console.WriteLine("TASK ADDED AT LAST");
                        break;

                    //add task at specific position
                    case 3:
                        //take task id
                        Console.Write("ENTER TASK ID: ");
                        int id3 = Convert.ToInt32(Console.ReadLine());

                        //take task name
                        Console.Write("ENTER TASK NAME: ");
                        string name3 = Console.ReadLine();

                        //take priority
                        Console.Write("ENTER PRIORITY: ");
                        int priority3 = Convert.ToInt32(Console.ReadLine());

                        //take due date
                        Console.Write("ENTER DUE DATE: ");
                        string date3 = Console.ReadLine();

                        //take position
                        Console.Write("ENTER POSITION: ");
                        int position = Convert.ToInt32(Console.ReadLine());

                        //add task at given position
                        scheduler.AddAtPosition(new TaskNode(id3, name3, priority3, date3), position);
                      
                        Console.WriteLine("TASK ADDED AT GIVEN POSITION");
                        break;

                    //remove task
                    case 4:
                        //take task id
                        Console.Write("ENTER TASK ID TO REMOVE: ");
                        int removeId = Convert.ToInt32(Console.ReadLine());

                        //remove task
                        scheduler.RemoveTask(removeId);
                        break;

                    //view current task and move to next
                    case 5:
                        //view current task
                        scheduler.ViewCurrentTask();
                        break;

                    //search task by priority
                    case 6:
                        //take priority
                        Console.Write("ENTER PRIORITY TO SEARCH: ");
                        int searchPriority = Convert.ToInt32(Console.ReadLine());

                        //search task
                        scheduler.SearchByPriority(searchPriority);
                        break;

                    //display all tasks
                    case 7:
                        //display task list
                        scheduler.DisplayAllTasks();
                        break;

                    //exit program
                    case 8:
                        Console.WriteLine("EXIT SUCCESSFUL THANK YOU");
                        return;

                    default:
                        Console.WriteLine("INVALID CHOICE");
                        break;
                }
            }
        }
    }
}
