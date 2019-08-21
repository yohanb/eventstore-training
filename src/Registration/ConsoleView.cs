using System;
using System.Collections.Generic;
using Registration.Blueprint.ReadModels;

namespace AccountBalance
{
    public class ConsoleView
    {
        //hack reactive bindings 
        private List<UserDisplayName> _registerUsers;
        public List<UserDisplayName> RegisteredUsers
        { get => _registerUsers;
            set { _registerUsers = value; ListUsers(); } }

        private string _errorMsg;
        public string ErrorMsg { get => _errorMsg;
            set { _errorMsg = value; Error(); } }
        
        public void Redraw()
        {

            Console.Clear();
            Console.WriteLine("Available Commands:");
            Console.WriteLine("\t Add [user name]");
            Console.WriteLine("\t list");
            Console.WriteLine("\t exit");
            Console.WriteLine("\t clean");
            Console.WriteLine("\t undo");
            Console.Write("Command:");
        }

        private void Error()
        {
            Console.WriteLine();
            Console.WriteLine("Error: " + _errorMsg);
            Console.WriteLine("Press enter to retry");
            Console.ReadLine();
            Redraw();
        }

        private void ListUsers()
        {
            Redraw();
            foreach (var user in _registerUsers)
            {
                Console.WriteLine(user.DisplayName);
            }
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Redraw();
        }
    }
}