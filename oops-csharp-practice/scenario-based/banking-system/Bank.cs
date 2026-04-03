    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Tracing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.banking_system
    {
        internal class Bank
        {
            //arrays to store client details
            private string[] clientAddress = new string[50];

            private string[] clientEmail = new string[50];

            private long[] clientPhoneNumber = new long[50];

            private string[] clientName = new string[50];

            //arrays to store client bank details
            private int[] accounts = new int[50];

            private double[] balance = new double[50];

            private bool[] isActive = new bool[50];

            //variable to store total clients
            private int totalClients = 0;

            //bank name
            public const string bankName = "BHARAT BANK";

            //branch name
            public const string branchName = "AGRA BRANCH";

            //IFSC code
            public const string ifscCode = "BHIN2005";
            public static void Main(string[] args)
            {
                //create object of class Bank
                Bank bank = new Bank();

                //display choices
                bank.DisplayChoices(bank);
            }

            //---------------DISPLAY CHOICES------------
            //method to display choices
            public void DisplayChoices(Bank bank)
            {
                //infinite loop to display choices
                while (true)
                {
                    Console.WriteLine("\n1. CLIENT");
                    Console.WriteLine("\n2. MANAGER");
                    Console.WriteLine("\n3. EXIT");
                    Console.WriteLine("\nENTER YOUR CHOICE:");

                    //take user choice
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        //if user enters 1
                        case 1:
                            Client client = new Client();
                            client.ClientMenu(bank);
                            break;

                        //if user enters 2
                        case 2:
                            BankManager bankManager = new BankManager();
                            bankManager.ManagerMenu(bank);
                            break;

                        //if user enters 3
                        case 3:
                            Console.WriteLine("\nEXIT SUCCESSFUL");
                            return;

                        //if user enters invalid input
                        default:
                            Console.WriteLine("\nINVALID INPUT");
                            break;
                    }
                }

            }
            //-------------DEPOSIT AMOUNT----------------
            //method to deposit amount
            public bool DepositAmount(int accountNumber, int amount)
            {
                //loop through accounts and isActive array
                for (int i = 0; i < totalClients; i++)
                {
                    //if account is found and is active
                    if (accounts[i] == accountNumber && isActive[i] == true)
                    {
                        //update balance
                        balance[i] = balance[i] + amount;

                        return true;
                    }
                }
                return false;
            }

            //-------------WITHDRAWAL AMOUNT--------------
            //method to withdrawal amount
            public int WithdrawalAmount(int accountNumber, int amount)
            {
                //loop through accounts, balance and isActive array
                for (int i = 0; i < totalClients; i++)
                {
                    //if account is found and is active
                    if (accounts[i] == accountNumber && isActive[i] == true)
                    {
                        //check if balance is greater than amount
                        if (balance[i] >= amount)
                        {
                            balance[i] = balance[i] - amount;
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                return -1;
            }

            //-------------CHECK BALANCE------------------
            //method to check balance
            public double CheckBalance(int accountNumber)
            {
                //loop through accounts,balance and isActive array
                for (int i = 0; i < totalClients; i++)
                {
                    if (accounts[i] == accountNumber && isActive[i] == true)
                    {
                        return balance[i];
                    }
                }

                return -1;
            }
            //----------------OPEN ACCOUNT----------------
            //method to open new account
            public void OpenAccount(string name, string email, long phoneNumber, string address, int accountNumber)
            {
                //store account number
                accounts[totalClients] = accountNumber;

                //store client name
                clientName[totalClients] = name;

                //store client email
                clientEmail[totalClients] = email;

                //store client phone number
                clientPhoneNumber[totalClients] = phoneNumber;

                //store client address
                clientAddress[totalClients] = address;

                //update is active status
                isActive[totalClients] = true;

                //update total clients
                totalClients++;

                Console.WriteLine("ACCOUNT CREATED SUCCESSFULLY");
            }

            //----------------CLOSE ACCOUNT----------------
            //method to close an account
            public void CloseAccount(int accountNumber)
            {
                //loop through accounts and isActive array
                for (int i = 0; i < totalClients; i++)
                {
                    //if account is found
                    if (accounts[i] == accountNumber && isActive[i] == true)
                    {
                        //update is active status
                        isActive[i] = false;

                        Console.WriteLine("ACCOUNT CLOSED SUCCESSFULLY");

                        return;
                    }
                }

                Console.WriteLine("\nACCOUNT NOT FOUND");
            }

            //----------------VIEW ALL ACCOUNTS-----------
            //method to view all accounts
            public void ViewAllAccounts()
            {
                for (int i = 0; i < totalClients; i++)
                {
                    Console.WriteLine("------------------------------------------------------------\n");

                    //display account number
                    Console.WriteLine("\nACCOUNT NUMBER: " + accounts[i]);

                    //display client name
                    Console.WriteLine("CLIENT NAME: " + clientName[i]);

                    //display client email
                    Console.WriteLine("CLIENT EMAIL: " + clientEmail[i]);

                    //display client phone number
                    Console.WriteLine("CLIENT PHONE NUMBER: " + clientPhoneNumber[i]);

                    //display client address
                    Console.WriteLine("CLIENT ADDRESS: " + clientAddress[i]);

                    //display balance
                    Console.WriteLine("BALANCE: " + balance[i]);

                    //display account status
                    Console.WriteLine("ACTIVE: " + isActive[i]);

                }
            }
        }
    }
