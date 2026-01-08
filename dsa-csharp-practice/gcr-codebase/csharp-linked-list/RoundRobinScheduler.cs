using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_linked_list
{
    internal class ProcessNode
    {
        //process attributes
        public int processId;

        public int burstTime;

        public int priority;

        //pointer to next process in circular list
        public ProcessNode next;

        //constructor to initialize process
        public ProcessNode(int processId, int burstTime, int priority)
        {
            this.processId = processId;
            this.burstTime = burstTime;
            this.priority = priority;
            this.next = null;
        }
    }

    class RoundRobinScheduler
    {
        //head of the circular linked list
        private ProcessNode head;

        //method to add process at end
        public void AddProcess(ProcessNode node)
        {
            //if list is empty 
            if (head == null)
            {
                head = node;
                node.next = head;
                return;
            }

            //traverse to the last node
            ProcessNode temp = head;
            while (temp.next != head)
            {
                temp = temp.next;
            }

            //link new node at end 
            temp.next = node;
            node.next = head;
        }

        //method to remove process by ID
        public void RemoveProcess(int processId)
        {
            //if list is empty
            if (head == null)
            {
                Console.WriteLine("NO PROCESSES IN QUEUE");
                return;
            }

            ProcessNode temp = head;
            ProcessNode prev = null;

            //head needs to be removed
            if (head.processId == processId)
            {
                //if only one node in list
                if (head.next == head)
                {
                    head = null;
                    Console.WriteLine("PROCESS REMOVED SUCCESSFULLY");
                    return;
                }

                //find last node
                ProcessNode last = head;
                while (last.next != head)
                {
                    last = last.next;
                }

                head = head.next;
                last.next = head;
                Console.WriteLine("PROCESS REMOVED SUCCESSFULLY");
                return;
            }

            //traverse list to find process
            prev = head;
            temp = head.next;

            while (temp != head)
            {
                if (temp.processId == processId)
                {
                    prev.next = temp.next;
                    Console.WriteLine("PROCESS REMOVED SUCCESSFULLY");
                    return;
                }
                prev = temp;
                temp = temp.next;
            }

            Console.WriteLine("PROCESS NOT FOUND");
        }

        //method to display all processes in the queue
        public void DisplayQueue()
        {
            if (head == null)
            {
                Console.WriteLine("NO PROCESSES IN QUEUE");
                return;
            }

            Console.WriteLine("\nCURRENT PROCESSES IN QUEUE:");
            ProcessNode temp = head;
            do
            {
                Console.WriteLine($"PROCESS ID: {temp.processId}, BURST TIME: {temp.burstTime}, PRIORITY: {temp.priority}");
                temp = temp.next;
            } while (temp != head);
        }

        //method to simulate round robin scheduling
        public void SimulateRoundRobin(int timeQuantum)
        {
            if (head == null)
            {
                Console.WriteLine("NO PROCESSES TO EXECUTE");
                return;
            }

            Console.WriteLine($"\nSIMULATING ROUND-ROBIN SCHEDULING (TIME QUANTUM = {timeQuantum})");

            //initialize variables to calculate waiting time and turnaround time
            int totalProcesses = 0;

            int totalWaitingTime = 0;

            int totalTurnaroundTime = 0;

            //first, count total processes
            ProcessNode temp = head;

            do
            {
                totalProcesses++;
                temp = temp.next;
            } while (temp != head);

            //create arrays to store remaining burst time and waiting time for each process
            int[] remainingBurst = new int[totalProcesses];

            int[] waitingTime = new int[totalProcesses];

            int[] turnAroundTime = new int[totalProcesses];

            //map process IDs to array index
            ProcessNode[] processList = new ProcessNode[totalProcesses];
            temp = head;
            int index = 0;
            do
            {
                remainingBurst[index] = temp.burstTime;
                waitingTime[index] = 0;
                processList[index] = temp;
                index++;
                temp = temp.next;
            } while (temp != head);

            //simulate execution
            bool done;
            do
            {
                done = true;
                for (int i = 0; i < totalProcesses; i++)
                {
                    if (remainingBurst[i] > 0)
                    {
                        done = false;

                        //execute process for time quantum or remaining burst time
                        int execTime = Math.Min(timeQuantum, remainingBurst[i]);
                        Console.WriteLine($"PROCESS {processList[i].processId} EXECUTED FOR {execTime} UNIT(S)");

                        //decrease remaining burst time
                        remainingBurst[i] -= execTime;

                        //update waiting time for other processes
                        for (int j = 0; j < totalProcesses; j++)
                        {
                            if (j != i && remainingBurst[j] > 0)
                            {
                                waitingTime[j] += execTime;
                            }
                        }
                    }
                }
            } while (!done);

            //calculate turnaround time for each process
            for (int i = 0; i < totalProcesses; i++)
            {
                turnAroundTime[i] = waitingTime[i] + processList[i].burstTime;
                totalWaitingTime += waitingTime[i];
                totalTurnaroundTime += turnAroundTime[i];
            }

            //display results
            Console.WriteLine("\nPROCESS\tBURST TIME\tWAITING TIME\tTURNAROUND TIME");
            for (int i = 0; i < totalProcesses; i++)
            {
                Console.WriteLine($"{processList[i].processId}\t{processList[i].burstTime}\t\t{waitingTime[i]}\t\t{turnAroundTime[i]}");
            }

            Console.WriteLine($"\nAVERAGE WAITING TIME: {(double)totalWaitingTime / totalProcesses:F2}");
            Console.WriteLine($"AVERAGE TURNAROUND TIME: {(double)totalTurnaroundTime / totalProcesses:F2}");
        }

        //main method
        public static void Main(string[] args)
        {
            //create scheduler object
            RoundRobinScheduler scheduler = new RoundRobinScheduler();

            //create some processes
            ProcessNode p1 = new ProcessNode(1, 10, 2);

            ProcessNode p2 = new ProcessNode(2, 5, 1);

            ProcessNode p3 = new ProcessNode(3, 8, 3);

            //add processes to queue
            scheduler.AddProcess(p1);
            scheduler.AddProcess(p2);
            scheduler.AddProcess(p3);

            Console.WriteLine("PROCESSES ADDED TO QUEUE: 1, 2, 3");

            //display current queue
            scheduler.DisplayQueue();

            //simulate round-robin with time quantum = 3
            scheduler.SimulateRoundRobin(3);

            //remove a process after execution
            Console.WriteLine("\nREMOVING PROCESS ID 2");
            scheduler.RemoveProcess(2);

            //display queue after removal
            scheduler.DisplayQueue();
        }
    }
}
