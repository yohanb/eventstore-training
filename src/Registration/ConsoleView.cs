using System;
using System.Collections.Generic;
using Registration.Blueprint.ReadModels;
using Registration.ExternalSharing.ReadModel;

namespace Registration
{
    public class ConsoleView
    {
        //hack reactive bindings

        private List<SharedLink> _links;
        private List<string> _history;


        public List<SharedLink> LinkSummaries
        { get => _links;
            set { _links = value; this.ListLinks(); } }

        public List<string> HistorySummaries
        { get => _history;
            set { _history = value; this.ListHistory(); } }

        private string _errorMsg;
        public string ErrorMsg { get => _errorMsg;
            set { _errorMsg = value; Error(); } }

        public void Redraw()
        {

            Console.Clear();
            Console.WriteLine("Available Commands:");
            Console.WriteLine("\t Revoke [id]");
            Console.WriteLine("\t Approve [id]");
            Console.WriteLine("\t list-links");
            Console.WriteLine("\t list-history");
            Console.WriteLine("\t exit");
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

        public void ListLinks()
        {
            Redraw();
            foreach (var link in this._links)
            {
                Console.WriteLine($"{link.DisplayName} {link.ExternalLinkId}" );
            }
        }

        public void ListHistory()
        {
            Redraw();
            foreach (var history in this._history)
            {
                Console.WriteLine(history);
            }
        }
    }
}