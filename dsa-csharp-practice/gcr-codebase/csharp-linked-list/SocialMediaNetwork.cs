using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_linked_list
{
    internal class UserNode
    {
        //user attributes
        public int userId;

        public string name;

        public int age;

        //array to store friend IDs
        public int[] friendIds = new int[100];

        //variable to store total friend count
        public int friendCount = 0;

        //pointer to next user in singly linked list
        public UserNode next;

        //constructor
        public UserNode(int userId, string name, int age)
        {
            this.userId = userId;
            this.name = name;
            this.age = age;
            this.next = null;
        }
    }

    class SocialMediaNetwork
    {
        //head node
        private UserNode head;

        //method to add user at last
        public void AddUser(UserNode node)
        {
            if (head == null)
            {
                head = node;
                return;
            }

            UserNode temp = head;

            //loop through list
            while (temp.next != null)
            {
                temp = temp.next;
            }

            //update last node
            temp.next = node;
        }

        //method to search user by ID
        public UserNode SearchByUserId(int userId)
        {
            UserNode temp = head;

            //loop through list
            while (temp != null)
            {
                if (temp.userId == userId)
                {
                    return temp;
                }
                temp = temp.next;
            }

            return null;
        }

        //method to search user by Name
        public UserNode SearchByUserName(string name)
        {
            UserNode temp = head;

            //loop through list
            while (temp != null)
            {
                if (temp.name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return temp;
                }
                temp = temp.next;
            }

            return null;
        }

        //method to add a friend connection
        public void AddFriend(int userId1, int userId2)
        {
            //search users
            UserNode user1 = SearchByUserId(userId1);
            UserNode user2 = SearchByUserId(userId2);

            if (user1 == null || user2 == null)
            {
                Console.WriteLine("ONE OR BOTH USERS NOT FOUND");
                return;
            }

            //add friend ID to array
            user1.friendIds[user1.friendCount] = userId2;
            user1.friendCount++;

            user2.friendIds[user2.friendCount] = userId1;
            user2.friendCount++;

            Console.WriteLine("FRIEND CONNECTION ADDED BETWEEN " + user1.name + " AND " + user2.name);
        }

        //method to remove a friend connection
        public void RemoveFriend(int userId1, int userId2)
        {
            //search users
            UserNode user1 = SearchByUserId(userId1);
            UserNode user2 = SearchByUserId(userId2);

            if (user1 == null || user2 == null)
            {
                Console.WriteLine("ONE OR BOTH USERS NOT FOUND");
                return;
            }

            //remove friend ID from first user
            for (int i = 0; i < user1.friendCount; i++)
            {
                if (user1.friendIds[i] == userId2)
                {
                    //shift remaining IDs
                    for (int j = i; j < user1.friendCount - 1; j++)
                    {
                        user1.friendIds[j] = user1.friendIds[j + 1];
                    }
                    user1.friendCount--;
                    break;
                }
            }

            //remove friend ID from second user
            for (int i = 0; i < user2.friendCount; i++)
            {
                if (user2.friendIds[i] == userId1)
                {
                    //shift remaining IDs
                    for (int j = i; j < user2.friendCount - 1; j++)
                    {
                        user2.friendIds[j] = user2.friendIds[j + 1];
                    }
                    user2.friendCount--;
                    break;
                }
            }

            Console.WriteLine("FRIEND CONNECTION REMOVED BETWEEN " + user1.name + " AND " + user2.name);
        }

        //method to display all friends of a user
        public void DisplayFriends(int userId)
        {
            //search user
            UserNode user = SearchByUserId(userId);

            if (user == null)
            {
                Console.WriteLine("USER NOT FOUND");
                return;
            }

            if (user.friendCount == 0)
            {
                Console.WriteLine(user.name + " HAS NO FRIENDS");
                return;
            }

            Console.WriteLine("\nFRIENDS OF " + user.name + ":");

            //loop through friend IDs
            for (int i = 0; i < user.friendCount; i++)
            {
                UserNode friend = SearchByUserId(user.friendIds[i]);
                Console.WriteLine(friend.name + " (ID: " + friend.userId + ")");
            }
        }

        //method to find mutual friends between two users
        public void FindMutualFriends(int userId1, int userId2)
        {
            //search users
            UserNode user1 = SearchByUserId(userId1);
            UserNode user2 = SearchByUserId(userId2);

            if (user1 == null || user2 == null)
            {
                Console.WriteLine("ONE OR BOTH USERS NOT FOUND");
                return;
            }

            Console.WriteLine("\nMUTUAL FRIENDS BETWEEN " + user1.name + " AND " + user2.name + ":");
            bool found = false;

            //loop through friends
            for (int i = 0; i < user1.friendCount; i++)
            {
                for (int j = 0; j < user2.friendCount; j++)
                {
                    if (user1.friendIds[i] == user2.friendIds[j])
                    {
                        UserNode friend = SearchByUserId(user1.friendIds[i]);
                        Console.WriteLine(friend.name + " (ID: " + friend.userId + ")");
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("NO MUTUAL FRIENDS FOUND");
            }
        }

        //method to count number of friends for each user
        public void CountFriends()
        {
            UserNode temp = head;

            Console.WriteLine("\nNUMBER OF FRIENDS FOR EACH USER:");
            //loop through list
            while (temp != null)
            {
                Console.WriteLine(temp.name + " (ID: " + temp.userId + ") HAS " + temp.friendCount + " FRIEND(S)");
                temp = temp.next;
            }
        }

        //main method
        public static void Main(string[] args)
        {
            //create object of social media network
            SocialMediaNetwork network = new SocialMediaNetwork();

            //create users
            UserNode u1 = new UserNode(1, "Alice", 25);

            UserNode u2 = new UserNode(2, "Bob", 28);

            UserNode u3 = new UserNode(3, "Charlie", 22);

            UserNode u4 = new UserNode(4, "Diana", 30);

            //add users to network
            network.AddUser(u1);
            network.AddUser(u2);
            network.AddUser(u3);
            network.AddUser(u4);
            Console.WriteLine("USERS ADDED TO NETWORK: Alice, Bob, Charlie, Diana");

            //add friend connections
            network.AddFriend(1, 2);
            network.AddFriend(1, 3);
            network.AddFriend(2, 3);
            network.AddFriend(3, 4);

            //display friends of a user
            network.DisplayFriends(1);

            //find mutual friends between two users
            network.FindMutualFriends(1, 3);

            //remove a friend connection
            network.RemoveFriend(1, 3);

            //display friends after removal
            network.DisplayFriends(1);

            //count friends for each user
            network.CountFriends();
        }
    }
}

