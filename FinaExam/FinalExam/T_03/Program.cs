using System;
using System.Collections.Generic;



namespace T_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users= new List<User>();
            int capacity = int.Parse(Console.ReadLine());
            string command;
            while ((command = Console.ReadLine())!= "Statistics")
            {
                string[] commandArg = command.Split("=", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArg[0];
                if (action == "Add")
                {
                    string userName = commandArg[1];
                    int sent = int.Parse(commandArg[2]);
                    int received = int.Parse(commandArg[3]);
                    if (!users.Exists(x=> x.UserName == userName))
                    {
                        User user = new User(userName, sent, received, capacity);
                            user.Capacity -= sent;
                            user.Capacity -= received;
                        
                        if (user.Sent + user.Received >= capacity)
                        {
                            continue;
                        }
                        users.Add(user);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (action == "Message")
                {
                    string sender = commandArg[1];
                    string receiver = commandArg[2];
                    bool senderExist = false;
                    bool receiverExist = false;
                    foreach (User user in users) 
                    {
                        if (user.UserName == sender)
                        {
                            senderExist = true;
                        }
                        if (user.UserName == receiver)
                        {
                            receiverExist = true;
                        }
                    }
                    if (receiverExist == true && senderExist == true)
                    {
                        for (int i = 0; i < users.Count; i++)
                        {
                            if (users[i].UserName == sender)
                            {
                                users[i].Capacity -= 1;
                                users[i].Sent += 1;
                                if (users[i].Capacity <= 0)
                                {
                                    Console.WriteLine($"{users[i].UserName} reached the capacity!");
                                    users.Remove(users[i]);
                                }
                            }
                            if (users[i].UserName == receiver)
                            {
                                users[i].Received += 1;
                                users[i].Capacity -= 1;
                                if (users[i].Capacity <= 0)
                                {
                                    Console.WriteLine($"{users[i].UserName} reached the capacity!");
                                    users.Remove(users[i]);
                                }
                            }
                        }
                    }
                }
                else if (action == "Empty")
                {
                    string userName = commandArg[1];
                    if (userName == "All")
                    {
                        users.Clear();
                    }
                    else
                    {
                        for (int i = 0; i < users.Count; i++)
                        {
                            if (users[i].UserName == userName)
                            {
                                users.Remove(users[i]);
                            }
                        }
                    }
                   
                }
            }
            
            if (users.Count > 0)
            {
                Console.WriteLine($"Users count: {users.Count}");
                foreach (User user in users)
                {
                    Console.WriteLine($"{user.UserName} - {user.Sent + user.Received}");
                }
            }
            else
            {
                Console.WriteLine($"Users count: 0");
            }
        }
    }
    public class User
    {
        public User(string userName,int sent,int received,int capacity)
        {
            UserName= userName;
            Sent= sent;
            Received= received;
            Capacity= capacity;
        }
        public string UserName { get; set; }
        public int Sent { get; set; }
        public int Received { get; set; }
        public int Capacity { get; set; }
        
    }
}
